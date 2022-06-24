﻿using P72_Sister_WcfDbase_1116.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace P72_Sister_WcfDbase_1116
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmployee
    {
        [OperationContract]
        List<Pegawai> getPegawaiList();

        [OperationContract]
        List<Pegawai> getPegawaiByName(string name);
    }
}
