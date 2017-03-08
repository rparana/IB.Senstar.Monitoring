using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Model.Entities
{
    [Table("Centrais")]
    public class Central : EntityBase
    {
        [Required(ErrorMessage = "Numero não pode ser branco."), Column(Order = 1)]
        public int Endereco { get; set; }
        [Required(ErrorMessage = "Nome não pode ser branco."), Column(Order = 2)]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Ultimoupdate { get; set; }

        public virtual ICollection<Zone> Zonas { get; set; }

        public Central()
        {
            this.GlobalID = Guid.NewGuid();
            this.Ultimoupdate = DateTime.Now;
            this.Zonas = new List<Zone>();

        }
    }
}
