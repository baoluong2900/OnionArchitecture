using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    [Table("Employees")]
    public class Employee : BaseEntity
    {

        [Column("TitleID")]
        public int TitleId { get; set; }

        [Column("DepartmentID")]
        public int DepartmentId { get; set; }

        [Column("OfficeID")]
        public int OfficeId { get; set; }

        [Column("BirhDate")]
        public DateTime BirthDate { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("Sex")]
        public string Sex { get; set; }

        [Column("Avatar")]
        public string Avatar { get; set; }

        public Department Department { get; set; }
        public Office Office { get; set; }
        public Title Title { get; set; }
        //public ICollection<Title> Titles { get; set; }
        //public ICollection<Department> Departments { get; set; }
        //public ICollection<Office> Offices { get; set; }
    }
}
