using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3_08_01_2021.Models.Domain
{
    public class Major
    {
        private int id;
        private string name;


        public Major()
        {
        }

        public Major(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}


