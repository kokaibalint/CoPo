using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFLib2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Computer computer();


        //[OperationContract]
        //string PCName();

        //[OperationContract]
        //string OSName();

        //[OperationContract]
        //string OSVersion();

        //[OperationContract]
        //string TotalPhysicalMemory();

        //[OperationContract]
        //string CPUInfo();

        ////[OperationContract]
        ////DateTime InstallDate();

        //[OperationContract]
        //string InputLocale();

        //[OperationContract]
        //string SystemLocale();

        //[OperationContract]
        //int DiskCapacity();

        //[OperationContract]
        //List<string> Services();
    }



}
