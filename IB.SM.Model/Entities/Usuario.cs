using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Model.Entities
{
    [Table("Usuarios")]
    public class Usuario : EntityBase
    {
        [Required(ErrorMessage = "Nome não pode ser branco."), Column(Order = 1)]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Senhaexpira { get; set; }

        /// <summary>
        /// Verifica se o Usuario pode ou não alterar a senha
        /// </summary>
        public bool Alterasenha { get; set; }
        public DateTime Dataexpirar { get; set; }
        public DateTime Ultimoupdate { get; set; }
        public bool Ativo { get; set; }
        public int? Grupo_ID { get; set; }

        [ForeignKey("Grupo_ID")]
        public virtual Grupo Grupo { get; set; }

        public Usuario()
        {
            this.GlobalID = Guid.NewGuid();
            this.Ativo = true;
            this.Senhaexpira = false;
            this.Ultimoupdate = DateTime.Now;
            this.Dataexpirar = DateTime.Now.AddDays(90);
        }

    }
}
