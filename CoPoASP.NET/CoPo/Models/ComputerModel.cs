using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoPo.Models
{
    public class ComputerModel 
    {
        public string PCName { get; set; }
        public string OSName { get; set; }
        public string OSVersion { get; set; }
        public string CPUInfo { get; set; }
        public string InputLocale { get; set; }
        public string SystemLocale { get; set; }

        public int DiskCapacity { get; set; }
        public string TotalPhysicalMemory { get; set; }

        public ComputerModel(string pCName, string oSName, string oSVersion, string cPUInfo, string inputLocale, string systemLocale, int diskCapacity, string totalPhysicalMemory)
        {
            this.PCName = pCName;
            this.OSName = oSName;
            this.OSVersion = oSVersion;
            this.CPUInfo = cPUInfo;
            this.InputLocale = inputLocale;
            this.SystemLocale = systemLocale;
            this.DiskCapacity = diskCapacity;
            this.TotalPhysicalMemory = totalPhysicalMemory;
        }
    }
}
