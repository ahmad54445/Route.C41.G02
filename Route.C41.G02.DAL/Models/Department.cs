using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.C41.G02.DAL.Models
{
    //Model  For 
    public class Department
    {
        public int Id { get; set; }//for beck end
        [Required]
        public string Code { get; set; }// We dont use nullable dont suuport in Net 5
        [Required]
        public string Name { get; set; }
        [Display(Name = "Date Of Creation")]
        public DateTime DateOfCreation { get; set; }
    }
}
