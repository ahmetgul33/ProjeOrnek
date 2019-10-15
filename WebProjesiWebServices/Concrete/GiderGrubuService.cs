using System;
using System.Collections.Generic;
using System.Text;
using WebProjesiDataAccess.Models;
using WebProjesiPosData.Abstract;
using WebProjesiPosData.Concrate.EntityFramework;
using WebProjesiWebServices.Abstract;

namespace WebProjesiWebServices.Concrete
{
    public class GiderGrubuService : IGiderGrubu
    {
        private readonly IGiderGrubuRepository _giderGrubu;
            public GiderGrubuService (IGiderGrubuRepository giderGrubu)
        {
            _giderGrubu = giderGrubu;
        }
        public void Add(GiderGrubu giderGrubu)
        {
            _giderGrubu.Add(giderGrubu);

        }

        public void Delete(GiderGrubu giderGrubu)
        {
            _giderGrubu.Delete(giderGrubu);
        }

        public GiderGrubu GetGider(int id)
        {
            return _giderGrubu.Get(x => x.Id == id);
        }

        public IEnumerable<GiderGrubu> GetGiderGetir()
        {
            return _giderGrubu.GetAll();

        }

        public void Update(GiderGrubu giderGrubu)
        {
            throw new NotImplementedException();
        }
    }
}
