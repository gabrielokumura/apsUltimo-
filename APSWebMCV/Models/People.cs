using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APSWebMCV.Models
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phonenumber { get; set; }
        public bool Adm { get; set; }

        public People()
        {

        }

        public People(int id, string name, string adress, string phonenumber, bool adm)
        {
            Id = id;
            Name = name;
            Adress = adress;
            Phonenumber = phonenumber;
            Adm = adm;
        }
    }
}
