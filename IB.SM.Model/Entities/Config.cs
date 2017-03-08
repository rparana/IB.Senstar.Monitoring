using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Model.Entities
{
    [Table("Configuracoes")]
    public class ConfigSys : EntityBase
    {
        public int Tempoleitura { get; set; }
        public string CaminhoLogs { get; set; }
        public string CaminhoLogsSalvos { get; set; }
        public bool SalvarDepoisdeLer { get; set; }
        public DateTime Ultimoupdate { get; set; }


        public ConfigSys()
        {
            this.GlobalID = Guid.NewGuid();
            this.Ultimoupdate = DateTime.Now;
        }
    }
}
