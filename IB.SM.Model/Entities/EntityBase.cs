using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IB.SM.Model.Entities
{
    public class EntityBase
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }
        public Guid GlobalID { get; set; }
    }
}
