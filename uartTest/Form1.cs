using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uartTest
{
    public partial class Form1 : Form
    {
        private Protocal proto;
        public Form1()
        {
            InitializeComponent();
            proto = new Protocal();
        }

        private bool uartIsOpened = false;
        private byte sendIndex = 0;

        private void broadcastButton_Click(object sender, EventArgs e)
        {
            if(uartIsOpened)
            {
                proto.ProtocalSend(0xff, sendIndex++, null, 0, 0x00);
            }
        }

        private void selfcheckButton_Click(object sender, EventArgs e)
        {
            byte addr = Convert.ToByte(addrTextBox.Text);

            if(uartIsOpened)
            {
                proto.ProtocalSend(addr, sendIndex++, null, 0, 0x01);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {

        }

        private void openUartButton_Click(object sender, EventArgs e)
        {
            if(uartIsOpened)
            {
                uartIsOpened = !uartIsOpened;
            }
            else
            {
                uartIsOpened = !uartIsOpened;
            }
        }
    }
}
