using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebProjesiDataAccess.Abstract;

namespace WebProjesiDataAccess.Models
{
public class GiderGrubu:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Gideradi { get; set; }
    }
}
