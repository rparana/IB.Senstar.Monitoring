using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IB.SM.Model.Entities
{
    [Table("Zonas")]
    public class Zone : EntityBase
    {
        [Required(ErrorMessage = "Nome não pode ser branco."), Column(Order = 1)]
        public string Nome { get; set; }
        public int NumeroZona { get; set; }
        public int NumeroZonaCentral { get; set; }
        public string Lado { get; set; }
        public int Inicio { get; set; }
        public int Fim { get; set; }
        public DateTime Ultimoupdate { get; set; }
        public int? Central_ID { get; set; }
        public float x1 { get; set; }
        public float y1 { get; set; }
        public float x2 { get; set; }
        public float y2 { get; set; }

        [ForeignKey("Central_ID")]
        public virtual Central Central { get; set; }

        public Zone()
        {
            this.GlobalID = Guid.NewGuid();
            this.Inicio = 0;
            this.Fim = 0;
            this.NumeroZona = 0;
            this.NumeroZonaCentral = 0;
            this.Ultimoupdate = DateTime.Now;
        }
    }
}