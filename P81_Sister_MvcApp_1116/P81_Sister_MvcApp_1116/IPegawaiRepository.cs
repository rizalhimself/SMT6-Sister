using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P81_Sister_MvcApp_1116
{
    interface IPegawaiRepository
    {
        IEnumerable<pegawai> GetAll();
        pegawai GetById(string nip);
        int Update(pegawai emp);
        pegawai Add(pegawai emp);
        void Delete(string nip);
    }
}
