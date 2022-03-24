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
            List<Medico> medicos = new List<Medico>();
            List<Patient> pacientes = new List<Patient>();
            
            int option = menu();

            while (option != 0)
            {
                switch (option)
                {
                    case 1:
                        medicos.Add(registerDoc());
                        break;
                    case 2:
                        Patient p = registerPatient(medicos);
                        if (p != null)
                            pacientes.Add(p);
                        else Console.WriteLine("Medico no existente");

                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
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
            String dni, nombre, apellido;
            int id;

            Console.WriteLine("Escriba el dni ");
            dni =Console.ReadLine();
            Console.WriteLine("Escriba el nombre ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba el apellido ");
            apellido = Console.ReadLine();
            Console.WriteLine("Escriba el id medico ");
            id = Convert.ToInt32(Console.ReadLine());

            Medico m = new Medico(dni,nombre,apellido,id);
            
            return m;
        }
        static Patient registerPatient(List<Medico> li)
        {
            String dni, nombre, apellido;
            int id, id_doc;
            Boolean exists = false;
            Patient p;


            if (li.Count() == 0)
            {
                Console.WriteLine("No hay medicos disponibles");
                return null;
            }else
            {
                

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
                    if (m.id_medico == id_doc)
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
        private String _nombre;
        private String _apellido;

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
        public String nombre
        {
            get
            {
                return _nombre;
            }
        }
        public String apellido
        {
            get
            {
                return _apellido;
            }
        }
        public Persona(String dni, String nombre, String apellido)
        {
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
        }
    }

    class Medico : Persona
    {
        private int _id_medico;

        public Medico(String dni, String nombre, String apellido, int id): base(dni, nombre, apellido)
        {
            _id_medico = id;
        }
        public int id_medico
        {
            get
            {
                return _id_medico;
            }
        }

    }

    class Patient : Persona
    { 
 
        private int _id_patient;
        private int _id_asigned_doc;

        public Patient(String dni, String nombre, String apellido, int id, int id_doc) : base(dni, nombre, apellido)
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
    }


}
