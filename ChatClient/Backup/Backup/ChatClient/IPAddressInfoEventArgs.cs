using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClient
{
    class IPAddressInfoEventArgs : EventArgs
    {
        private string _ipAddress;
        public IPAddressInfoEventArgs(string ipAddress)
        {
            this._ipAddress = ipAddress;
        }

        public string IPAddress
        {
            get { return this._ipAddress; }
        }
    }
}
