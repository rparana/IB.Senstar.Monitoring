using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace IB.SM.Model.Entities
{
    [Table("SenstarEvents")]
    public class SenstarEvents : EntityBase
    {
        [Required(ErrorMessage = "timestamp não pode ser branco."), Column(Order = 1)]
        public DateTime Timestamp { get; set; }

        [Required(ErrorMessage = "Central não pode ser branco.")]
        [Column(Order = 2)]
        public int Central { get; set; }

        [Column(Order = 3)]
        public int Zona { get; set; }
        [StringLength(1, ErrorMessage = "O tamanho máximo é de 1 caracteres.")]
        [Column(Order = 4)]
        public string Lado { get; set; }
        [Column(Order = 5)]
        public int Distancia { get; set; }
        public bool Tratado { get; set; }
        public string Nota { get; set; }

        public SenstarEvents()
        {
            this.GlobalID = Guid.NewGuid();
            this.Timestamp = DateTime.Now;
            this.Tratado = false;
        }
    }
}
