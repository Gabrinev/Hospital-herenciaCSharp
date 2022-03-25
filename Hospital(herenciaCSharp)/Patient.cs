using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_herenciaCSharp_
{
    class Patient : Persona
    {

        private int _id_patient;
        private int _id_asigned_doc;

        public Patient(String dni, String name, String surname, int id, int id_doc) : base(dni, name, surname)
        {
            _id_patient = id;
            _id_asigned_doc = id_doc;
        }

        public int id_patient
        {
            get
            {
                return _id_patient;
            }
        }
        public int id_asigned_doc
        {
            get
            {
                return _id_asigned_doc;
            }
        }
        public override string ToString()
        {
            return base.ToString() + " " + " id patient: " + this.id_patient + " id doctor asignado: " + this.id_asigned_doc;
        }

    }
}
