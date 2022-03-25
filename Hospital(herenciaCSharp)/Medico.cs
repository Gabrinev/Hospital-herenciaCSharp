using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_herenciaCSharp_
{
    class Medico : Persona
    {
        private int _id_doc;

        public Medico(String dni, String name, String surname, int id) : base(dni, name, surname)
        {
            _id_doc = id;
        }
        public int id_doc
        {
            get
            {
                return _id_doc;
            }
        }
        public override string ToString()
        {
            return base.ToString() + " " + " id medico: " + this.id_doc;
        }

    }
}
