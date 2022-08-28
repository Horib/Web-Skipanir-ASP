using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#pragma warning disable CS8618

namespace Chap5ELF.Models
{
    public class Person
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }

        public string Fullname {
            //get { return Firstname + " " + Lastname; }
            get { return $"{Firstname} {Lastname}"; }
        }
    }
}
