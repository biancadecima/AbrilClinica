using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abril_Clinica.Models
{
    public abstract class Person
    {
        private string _name;
        private string _surname;
        private long _dni;

        public Person(string name, string surname, long dni)
        {
            _name = name;
            _surname = surname;
            _dni = dni;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public long Dni { get => _dni; set => _dni = value; }

    }
}
