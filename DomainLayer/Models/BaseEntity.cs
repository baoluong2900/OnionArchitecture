using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class BaseEntity
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }
        [Column("CreateDate")]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Column("Active")]
        public Boolean Active { get; set; }
    }
}
