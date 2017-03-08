using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IB.SM.Model.Entities
{
    [Table("Grupos")]
    public class Grupo : EntityBase
    {
        [Required(ErrorMessage = "Nome não pode ser branco."), Column(Order = 1)]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        //public long Permissao_ID { get; set; }
        public DateTime Ultimoupdate { get; set; }

        public int Permisssao_ID { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }

        [ForeignKey("Permisssao_ID")]
        public virtual Permissao Permissao { get; set; }

        public Grupo()
        {
            this.GlobalID = Guid.NewGuid();
            this.Ultimoupdate = DateTime.Now;
            this.Usuarios = new List<Usuario>();
        }
    }

}