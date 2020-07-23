using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Asp.netCoreMVCCRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column("FullName")]
        [Required(ErrorMessage ="This field is required.")]
        [DisplayName("Full Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""']*$"), StringLength(30, MinimumLength = 3)]
        public string FullName { get; set; }
        [Column("EmpCode")]
        [DisplayName("Emp. Code")]
        [RegularExpression(@"[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        public string EmpCode { get; set; }
        [Column("Position")] 
        [RegularExpression(@"^[A-Z]+[a-z""]*$"), Required(ErrorMessage ="This field is required."), StringLength(30)]
        public string Position { get; set; }
        [Column("OfficeLocation")]
        [DisplayName("Office Location")]
        [RegularExpression(@"^[A-Z]+[a-z]*$"), StringLength(40)]
        public string OfficeLocation { get; set; }
        [Column("Salary", TypeName = "decimal(9, 2)")]
        [DisplayFormat(DataFormatString ="{0:C}")]
        public decimal Salary { get; set; }

        [Column("RecruitmentDate"), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RecruitmentDate { get; set; }
    }
}
