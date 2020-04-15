using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WCFLib2
{
    public class Computer
    {
        private string PCName { get; set; }
        private string OSName { get; set; }
        private string OSVersion { get; set; }
        private string TotalPhysicalMemory { get; set; }
        private string CPUInfo { get; set; }
        private string InputLocale { get; set; }
        private string SystemLocale { get; set; }
        private List<string> Services;

        //public Computer()
        //{
        //    PCName = Environment.MachineName;
        //    OSName = computerInfo.OSFullName;
        //    OSVersion = computerInfo.OSVersion;
        //    TotalPhysicalMemory = computerInfo.TotalPhysicalMemory.ToString();
        //    CPUInfo = Environment.ProcessorCount + " cpu";
        //    InputLocale = computerInfo.InstalledUICulture.ToString();
        //    SystemLocale = CultureInfo.InstalledUICulture.ToString();
        //}

        public Computer(string pCName, string oSName, string oSVersion, string totalPhysicalMemory, string cPUInfo, string inputLocale, string systemLocale)
        {
            PCName = pCName;
            OSName = oSName;
            OSVersion = oSVersion;
            TotalPhysicalMemory = totalPhysicalMemory;
            CPUInfo = cPUInfo;
            InputLocale = inputLocale;
            SystemLocale = systemLocale;
            Services = GetServices();
        }
        public List<string> GetServices()
        {
            foreach (var service in ServiceController.GetServices())
            {
                Services.Add(service.ServiceName);
            }
            return this.Services;
        }

    }
}
