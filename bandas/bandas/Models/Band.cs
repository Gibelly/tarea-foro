using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bandas.Models
{
    public class Band
    {
        [Key]
        public int BandId { get; set; }

        [Display(Name = "Nombre")]
        public string BandName { get; set; }

        [Display(Name = "Genero")]
        public string BandGender { get; set; }

        [Display(Name = "No. de Miembros")]
        public int BandMemberCant { get; set; }
    }
}
