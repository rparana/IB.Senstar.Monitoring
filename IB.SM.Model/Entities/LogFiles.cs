using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Model.Entities
{
    [Table("LogFiles")]
    public class LogFile : EntityBase
    {
        [Required(ErrorMessage = "Nome não pode ser branco.")]
        public string nome { get; set; }
        public DateTime dataLeitura { get; set; }
        public long tamanho { get; set; }

        public LogFile()
        {
            this.dataLeitura = DateTime.Now;
        }
    }
}
