using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.C41.G02.DAL.Models
{
    //Model  For 
    internal class Department
    {
        public int Id { get; set; }//for beck end
        public string Code { get; set; }// We dont use nullable dont suuport in Net 5
        public string Name { get; set; }
        public DateTime DateOfCreateion { get; set; }
    }
}
