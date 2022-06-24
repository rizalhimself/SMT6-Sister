using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace P81_Sister_MvcApp_1116.Controllers
{
    public class PegawaiController : ApiController
    {
        IPegawaiRepository repository = new Models.PegawaiModel();
        // GET api/values
        [HttpGet]
        public IEnumerable<pegawai> Get()
        {
            return repository.GetAll();
        }

        // GET api/values/5
        [HttpGet]
        public pegawai get(string id)
        {
            pegawai p = repository.GetById(id);
            return p;
        }

        // POST api/values
        [HttpPost]
        public void PostPegawai(pegawai p)
        {
            repository.Add(p);
        }

        // PUT api/values/5
        [HttpPut]
        public void PutPegawai(pegawai p)
        {
            if(repository.Update(p) == 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(string id)
        {
            repository.Delete(id);
        }
    }
}