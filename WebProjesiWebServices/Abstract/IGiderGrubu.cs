using System;
using System.Collections.Generic;
using System.Text;
using WebProjesiDataAccess.Models;

namespace WebProjesiWebServices.Abstract
{
  public   interface IGiderGrubu
    {

        GiderGrubu GetGider(int id);

        IEnumerable<GiderGrubu> GetGiderGetir();

        void Add( GiderGrubu giderGrubu);
        void Update(GiderGrubu giderGrubu);

        void Delete(GiderGrubu giderGrubu);
    }
}
