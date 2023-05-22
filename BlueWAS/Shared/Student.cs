using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueWAS.Shared
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(5, ErrorMessage = "name limit exceeds ", MinimumLength = 5)]
        public string Name { get; set; }

        public string RollNumber { get; set; }

        public DateTime DOB { get; set; }



    }
}
