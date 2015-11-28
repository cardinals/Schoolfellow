using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibs;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(GetFellowInfo)))
            {
                host.Open();
                Console.WriteLine("host open");
                Console.ReadKey();
                host.Close();
            }
        }
    }
}
