using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitOrchestrated
{
    public class Server
    {

        public string VDCName { get; set; }
        public string VMName { get; set; }
        public string TemplateVer { get; set; }
        public string WinVer { get; set; }
        public string WinEdition { get; set; }
        public string CPUNo { get; set; }
        public string RAM { get; set; }
        public string ADJoin { get; set; }
        public string OrgNetworkName { get; set; }
        public string IPAdd { get; set; }
        public string DNS1 { get; set; }
        public string DNS2 { get; set; }
        public string EndpointProtection { get; set; }

        public override string ToString()
        {
            return VMName + " - " + IPAdd;
        }
    }

}
