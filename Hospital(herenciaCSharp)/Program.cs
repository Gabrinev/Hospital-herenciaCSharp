using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_herenciaCSharp_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Medico> docs = new List<Medico>();
            List<Patient> patients = new List<Patient>();
            
            int option = menu();

            while (option != 0)
            {
                switch (option)
                {
                    case 1:
                        docs.Add(registerDoc());
                        break;
                    case 2:
                        Patient p = registerPatient(docs);
                        if (p != null)
                            patients.Add(p);
                        else Console.WriteLine("Medico no existente");

                        break;
                    case 3:
                        listDocs(docs);
                        break;
                    case 4:
                        listPatientXdoc(patients);
                        break;
                    case 5:
                        deletePatient(patients);
                        
                            break;
                    case 6:
                        listAll(docs,patients);
                        break;
                }
                option = menu();
            }
            








        }

        static int menu()
        {
            Console.Clear();
            Console.WriteLine("HOSPITAL SAN SAN DE SAN");
            Console.WriteLine("-----------------------");
            Console.WriteLine("");
            Console.WriteLine("Pulse 1 para dar de alta medico");
            Console.WriteLine("Pulse 2 para dar de alta paciente");
            Console.WriteLine("Pulse 3 para ver todos los medicos");
            Console.WriteLine("Pulse 4 para ver los pacientes de un medico");
            Console.WriteLine("Pulse 5 para dar de baja un paciente");
            Console.WriteLine("Pulse 6 para ver todas las personas presentes");
            Console.WriteLine("Cualquier otra tecla para salir...");

            int bowl; // Variable to hold number
            ConsoleKeyInfo UserInput = Console.ReadKey(); // Get user input
            if (char.IsDigit(UserInput.KeyChar))
            {
                bowl = int.Parse(UserInput.KeyChar.ToString()); // use Parse if it's a Digit
                return bowl;
            }
            else
            {
                bowl = 0;  // Else we assign a default value
                return bowl;
            }
        }

        static Medico registerDoc()
        {
            String dni, name, surname;
            int id;
            Console.WriteLine(" ");
            Console.WriteLine("Escriba el dni ");
            dni =Console.ReadLine();
            Console.WriteLine("Escriba el nombre ");
            name = Console.ReadLine();
            Console.WriteLine("Escriba el apellido ");
            surname = Console.ReadLine();
            Console.WriteLine("Escriba el id medico ");
            id = Convert.ToInt32(Console.ReadLine());

            Medico m = new Medico(dni, name, surname, id);
            
            return m;
        }

        static void listAll(List<Medico> docs, List<Patient> patients)
        {
            Console.WriteLine(" ");
            Console.WriteLine("MEDICOS: ");
            foreach (Medico m in docs)
            {
                Console.WriteLine(m.ToString());
            }

            Console.WriteLine("PACIENTES: ");
            foreach (Patient p in patients)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine(" ");
            Console.WriteLine("Pulsa cualquier tecla para salir...");
            Console.ReadKey();

        }


        static List<Patient> deletePatient(List<Patient> patients)
        {
            Console.WriteLine(" ");
            Patient temp = new Patient("dni","xxxx","xxxx",987,987);
            Console.WriteLine("ID Paciente a eliminar ");
            
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Patient p in patients)
            {
                if (p.id_patient == id)
                {
                    temp = p;
                }
            }
            if (patients.Remove(temp))
            {
                Console.WriteLine(" ");
                Console.WriteLine("Eliminado exitosamente");
                Console.WriteLine(" ");
                Console.WriteLine("Pulsa cualquier tecla para salir...");
                Console.ReadKey();
                return patients;
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("No se ha podido eliminar, compruebe que exista");
                Console.WriteLine(" ");
                Console.WriteLine("Pulsa cualquier tecla para salir...");
                Console.ReadKey();

                return null;
            }

            

        }
        static void listPatientXdoc(List<Patient> patients)
        {
            Console.WriteLine(" ");
            Console.WriteLine("ID Medico ");
            int idDoc = Convert.ToInt32(Console.ReadLine());
            foreach (Patient p in patients)
            {
                if (p.id_asigned_doc == idDoc)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Pulsa cualquier tecla para salir...");
            Console.ReadKey();

        }


        static void listDocs(List<Medico> docs)
        {

            Console.WriteLine(" ");
            Console.WriteLine("MEDICOS: ");
            foreach (Medico m in docs)
            {
                Console.WriteLine(m.ToString());
            }
            Console.WriteLine(" ");
            Console.WriteLine("Pulsa cualquier tecla para salir...");
            Console.ReadKey();

        }
        static Patient registerPatient(List<Medico> li)
        {
            String dni, nombre, apellido;
            int id, id_doc;
            Patient p;


            if (li.Count() == 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("No hay medicos disponibles");
                return null;
            }else
            {

                Console.WriteLine(" ");
                Console.WriteLine("Escriba el dni ");
                dni = Console.ReadLine();
                Console.WriteLine("Escriba el nombre ");
                nombre = Console.ReadLine();
                Console.WriteLine("Escriba el apellido ");
                apellido = Console.ReadLine();
                Console.WriteLine("Escriba el id paciente ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escriba el id de su medico ");
                id_doc = Convert.ToInt32(Console.ReadLine());
                foreach (Medico m in li)
                {
                    if (m.id_doc == id_doc)
                    {

                        return p = new Patient(dni, nombre, apellido, id, id_doc);
                    }

                }
                return null;



            }
                    
        }
    }

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

    class Medico : Persona
    {
        private int _id_doc;

        public Medico(String dni, String name, String surname, int id): base(dni, name, surname)
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
            return base.ToString() + " " + " id patient: "+ this.id_patient + " id doctor asignado: " + this.id_asigned_doc ;
        }

    }


}
