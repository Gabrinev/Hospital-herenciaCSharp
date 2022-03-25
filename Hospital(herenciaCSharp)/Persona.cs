using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_herenciaCSharp_
{
    class Persona
    {
        private String _dni;
        private String _name;
        private String _surname;

        public String dni
        {
            get
            {
                return _dni;
            }
            set
            {
                _dni = value;
            }
        }
        public String name
        {
            get
            {
                return _name;
            }
        }
        public String surname
        {
            get
            {
                return _surname;
            }
        }
        public Persona(String dni, String name, String surname)
        {
            _dni = dni;
            _name = name;
            _surname = surname;
        }
        public override string ToString()
        {
            return "dni: " + this.dni + " nombre: " + this.name + " apellido: " + this.surname;
        }
    }
}
