using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P81_Sister_MvcApp_1116.Models
{
    public class PegawaiModel : IPegawaiRepository
    {
        dbAppPegawaiEntities context = new dbAppPegawaiEntities();

        public pegawai Add(pegawai emp)
        {
            var addedPegawai = context.pegawai.Add(emp);
            context.SaveChanges();

            return addedPegawai;
        }

        public void Delete(string nip)
        {
            pegawai d = context.pegawai.FirstOrDefault(a => a.nip == nip);
            context.pegawai.Remove(d);

            context.SaveChanges();
        }

        public IEnumerable<pegawai> GetAll()
        {
            return context.pegawai;
        }

        public pegawai GetById(string nip)
        {
            IQueryable<pegawai> emp = context.pegawai.Where(a => a.nip == nip);
            return emp.FirstOrDefault();
        }

        public int Update(pegawai emp)
        {
            pegawai updatePegawai = context.pegawai.FirstOrDefault(a => a.nip == emp.nip);
            updatePegawai.nama = emp.nama.Trim();
            updatePegawai.jenis_kelamin = emp.jenis_kelamin.Trim();
            updatePegawai.alamat = emp.alamat.Trim();
            updatePegawai.kodeJabatan = emp.kodeJabatan;

            return context.SaveChanges();
        }
    }
}