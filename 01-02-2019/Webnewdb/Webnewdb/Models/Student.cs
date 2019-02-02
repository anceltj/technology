using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webnewdb.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int UserdemoId { get; set; }
        public virtual Userdemo Userdemo { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail{ get; set; }
        public Gender Genderlist { get; set; }



    }
    public enum Gender
    {
        Male,
        Female
    }
}