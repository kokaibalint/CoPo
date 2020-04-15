using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;

namespace WCFLib2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        ComputerInfo computerInfo = new ComputerInfo();

        public Computer computer()
        {
            return new Computer(Environment.MachineName, computerInfo.OSFullName, computerInfo.OSVersion, computerInfo.TotalPhysicalMemory.ToString(), Environment.ProcessorCount + "cpu", computerInfo.InstalledUICulture.ToString(), computerInfo.InstalledUICulture.ToString());
        }

        //public List<string> GetServices()
        //{
        //    List<string> services = new List<string>();
        //    foreach (var service in ServiceController.GetServices())
        //    {
        //        services.Add(service.ServiceName);
        //    }
        //    return services;
        //}
        //public string CPUInfo()
        //{
        //    return Environment.ProcessorCount + " cpu";
        //}

        //public int DiskCapacity()
        //{
        //    foreach (DriveInfo drive in DriveInfo.GetDrives())
        //    {
        //        return (int)drive.TotalSize;
        //    }

        //    return -1;

        //}

        //public string InputLocale()
        //{
        //    return computerInfo.InstalledUICulture.ToString();
        //}

        ////public DateTime InstallDate()
        ////{
        ////    return null;
        ////}

        //public string OSName()
        //{
        //    return computerInfo.OSFullName;
        //}

        //public string OSVersion()
        //{
        //    return computerInfo.OSVersion;
        //}

        //public string PCName()
        //{
        //    return Environment.MachineName;
        //}

        //public List<string> Services()
        //{
        //    List<string> services = new List<string>();
        //    foreach (var service in ServiceController.GetServices())
        //    {
        //        services.Add(service.ToString());
        //    }
        //    return services;
        //}

        //public string SystemLocale()
        //{
        //    return CultureInfo.InstalledUICulture.ToString();
        //}

        //public string TotalPhysicalMemory()
        //{
        //    return computerInfo.TotalPhysicalMemory + " MB";
        //}
    }
}
