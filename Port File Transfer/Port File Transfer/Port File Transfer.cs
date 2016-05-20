using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Port_File_Transfer
{
    public partial class Port_File_Transfer : Form
    {
        private int panel=0;
        private Boolean settings=false;

        private String userMsg = "";

        private SerialPort myComPort = new SerialPort();
        
        public Port_File_Transfer()
        {
            InitializeComponent();
        }

        private void lblSetting_Click(object sender, EventArgs e)
        {
            swappanel(0);
            lblSetting.BorderStyle = BorderStyle.FixedSingle;
            lblSend.BorderStyle = BorderStyle.None;
            lblReceive.BorderStyle = BorderStyle.None;
            cbdtr.Checked=true;
            cbrts.Checked = true;
        }

        private void lblSend_Click(object sender, EventArgs e)
        {
            if (settings == true)
            {
                swappanel(1);
                lblSetting.BorderStyle = BorderStyle.None;
                lblSend.BorderStyle = BorderStyle.FixedSingle;
                lblReceive.BorderStyle = BorderStyle.None;
            }
            else { MessageBox.Show("Save Port Settings To Send Message"); }

        }

        private void lblReceive_Click(object sender, EventArgs e)
        {
            swappanel(2);
            lblSetting.BorderStyle = BorderStyle.None;
            lblSend.BorderStyle = BorderStyle.None;
            lblReceive.BorderStyle = BorderStyle.FixedSingle;

        }
        
        private void swappanel(int panelId)
        {
            if(panelId==0){
                panelSetting.Visible = true;
                panelSend.Visible = false;
                panelReceive.Visible = false;
                panel = 0;
                
            }else if(panelId==1){
                panelSend.Visible=true;
                panelReceive.Visible=false;
                panelSetting.Visible = false;
                panel=1;
            }
            else{

                panelReceive.Visible = true; 
                panelSend.Visible = false;
                panelSetting.Visible = false;
                panel=2;

            }
        }
        
        /*public void getPorts()
        {
            comPorts = SerialPort.GetPortNames();
            Array.Sort( comPorts );            
        }

        public void setPort(){
            int index = -1;
            myComPortName = "COM1";
  
            getPorts();
            do
            {
                index += 1;
            }
            while (!((comPorts[index] == myComPortName) |
            (index == comPorts.GetUpperBound(0))));
            
            if (index == comPorts.GetUpperBound(0))
            {
                myComPortName = comPorts[0];
            }
        }*/

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtComports.Text == "" || txtBrate.Text == "" || txtParity.Text == "" || txtDatabits.Text == "" || txtStopbits.Text == "")
            {
                MessageBox.Show("All Port Settings Are Required.");
            }
            else
            {
                settings = true;
                
                string port = "" + txtComports;
                int brate = int.Parse(txtBrate.Text);
                string parity = "" + txtParity.Text;
                int dbits = int.Parse(txtDatabits.Text);
                byte sbits = byte.Parse(txtStopbits.Text);
                myComPort.PortName = "COM1";
                myComPort.BaudRate = 9600;
                myComPort.Parity = Parity.None;              
                myComPort.DataBits =8;
                if (sbits == 1)
                myComPort.StopBits = StopBits.One;
                else if (sbits == 2)
                    myComPort.StopBits = StopBits.Two;
                else myComPort.StopBits = StopBits.None;

                myComPort.RtsEnable = true;
                myComPort.DtrEnable = true;

                MessageBox.Show("Port Settings Saved");
                myComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ReceiveData); 
            }
        }
        
        private void btnSend_Click(object sender, EventArgs e)
        {
            string message; 
            if (!myComPort.IsOpen)
                {
                    myComPort.Open();
                }
             message = "" + txtsend.Text;
             myComPort.WriteLine(message);

             MessageBox.Show("Message Send");   
                       
        }


        private void btnReceive_Click(object sender, EventArgs e) 
        {
            if (userMsg == "")
                MessageBox.Show("System Error Try Again");
            else
            {
                txtReceive.Text = "" + userMsg;
                MessageBox.Show("Message Received.");
            }
        }

        private void ReceiveData(object sender, EventArgs e)
        {
            try
            {
                if (!myComPort.IsOpen)
                {
                    myComPort.Open();
                }
                userMsg = myComPort.ReadLine();
            }
            catch (Exception ex) {
                MessageBox.Show("Error while reading the data from port!");
            }
        }

          
                            
        
    }
}
