using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uartTest
{
    class Protocal
    {
        public void ProtocalSend(byte addr, byte index, byte[] contents, byte len, byte msgID)
        {
			//test send 123
        }

        public void ProtocalRecv(byte[] data, int len)
        {
        }
    }
}
