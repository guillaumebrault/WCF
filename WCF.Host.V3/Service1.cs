using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Host.V3
{
    public partial class Service1 : ServiceBase
    {
        ServiceHost host1 = null;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host1 = new ServiceHost(typeof(Service1));
            host1.Open();
        }

        protected override void OnStop()
        {
            host1.Close();
        }
    }
}
