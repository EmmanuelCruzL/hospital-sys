using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_sys.Models
{
    class Category
    {
        private int id;
        private String name;

        public Category()
        {
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;            
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
