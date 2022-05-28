using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    [Table("Titles")]
    public class Title: BaseEntity
    {
        [Column("TitleName")]
        public string TitleName { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        public ICollection<Employee> Employees { get; set; }

    }
}
