//22/02/2017
//  Adicionado a propriedade PoM

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Model.Entities
{
    public class ViewEvents
    {
        public int ID { get; set; }
        public int IDZona { get; set; }
        [Display(Name = "Data/Hora")]
        public DateTime Data_Hora { get; set; }
        [Display(Name = "Central")]
        public string Central { get; set; }
        [Display(Name = "Lado")]
        public string Lado { get; set; }
        [Display(Name = "Zona")]
        public string Zona { get; set; }
        [Display(Name = "Distância da Central")]
        public string Distancia { get; set; }
        public bool PoM { get; set; }

        public ViewEvents()
        {
            this.IDZona = 0;
            PoM = false;
        }

    }
}
