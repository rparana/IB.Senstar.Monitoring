using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IB.SM.Model.Entities
{
    [Table("Permissoes")]
    public class Permissao : EntityBase
    {
        public bool SystemADMAccess { get; set; }
        public bool AlarmViewAccess { get; set; }
        public bool SystemConfig { get; set; }

        //Usuários
        public bool CreateUser { get; set; }
        public bool UpdateUser { get; set; }
        public bool FindUser { get; set; }
        public bool DeleteUser { get; set; }

        //Grupos
        public bool CreateGroup { get; set; }
        public bool UpdateGroup { get; set; }
        public bool FindGroup { get; set; }
        public bool DeleteGroup { get; set; }

        //Centrais
        public bool CreateCentral { get; set; }
        public bool UpdateCentral { get; set; }
        public bool FindCentral { get; set; }
        public bool DeleteCentral { get; set; }

        //Zonas
        public bool CreateZone { get; set; }
        public bool UpdateZone { get; set; }
        public bool FindZone { get; set; }
        public bool DeleteZone { get; set; }

        //Mapas
        public bool CreateMaps { get; set; }
        public bool UpdateMaps { get; set; }
        public bool FindMaps { get; set; }
        public bool DeleteMaps { get; set; }

        //Events
        public bool ClearEvents { get; set; }
        public bool ImportEvents { get; set; }
        public bool AcknowledgeEvents { get; set; }
        public bool SilenceEvents { get; set; }

        public Permissao()
        {
            this.GlobalID = Guid.NewGuid();
        }
    }
}