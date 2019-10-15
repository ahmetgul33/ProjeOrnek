using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProjesiDataAccess.Models;
using WebProjesiWebServices.Abstract;

namespace ProjeRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiderGrubuController : ControllerBase
    {
        private readonly IGiderGrubu _giderGrubu;

            public GiderGrubuController(IGiderGrubu giderGrubu)

        {
            _giderGrubu = giderGrubu;

        }
        [HttpGet]

        public List<GiderGrubu> Get()
        {
            var List = _giderGrubu.GetGiderGetir().ToList();
            return List;
        }
        [HttpGet("{id}")]
        public GiderGrubu Get(int id)
        {
            return _giderGrubu.GetGider(id);
        }
        [HttpPost]
        public void Post([FromForm] GiderGrubu giderGrubu )
        {
            _giderGrubu.Add(giderGrubu);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}