using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanteTcpDemo
{
    internal class DeciveResponse
    {
        public string Result_code { get; set; }
        public string Return_code { get; set; }

        public string Return_msg { get; set; }


        public DeciveInfo Data { get; set; }
    }


    internal class DeciveInfo
    {
        public string ConnectUrl { get; set; }
        public string UserNo { get; set; }

    }
}
