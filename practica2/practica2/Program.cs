using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            Cliente cliente = new Cliente();
            Inmueble inmueble = new Inmueble();

            empleado.nombre = "Miguel";
            empleado.apellido = "Castro";

            cliente.nombre = "Arturo";
            cliente.apellido = "Mancia";

            inmueble.tipo = "Edificio";
            inmueble.altura = 16;
            inmueble.area = 35;

        }

        class Inmueble
        {
            public string tipo;
            public double altura;
            public double area;
        }

        abstract class Persona
        {
            private string _nombre;
            private string _apellido;
            
            public string nombre
            {
                get { return _nombre; }
                set { _nombre = nombre; }
            }
            public string apellido
            {
                get { return _apellido; }
                set { _apellido = apellido; }
            }

            abstract public string Saludar();
            abstract public string DecirNombre(string nombre, string apellido);
            public void Vender()
            {
                Console.WriteLine("Gracias por su compra");
            }
        }

        class Empleado : Persona
        {
            public override string Saludar()
            {
                return ("Bienvenido ¿En qué puedo ayudarle? ");
            }
            public override string DecirNombre(string nombre, string apellido)
            {
                return (nombre + apellido);
            }
        }

        class Cliente : Persona
        {
            private string _email;
            private int _tel;
            private string _contrato;
            public string contrato
            {
                get { return _contrato; }
                set { _contrato = contrato; }
            }
            public int tel
            {
                get { return _tel; }
                set { _tel = tel; }
            }
            public string email
            {
                get { return _email; }
                set { _email = email; }
            }

            public override string DecirNombre(string nombre, string apellido)
            {
                return (nombre + apellido);
            }
            public override string Saludar()
            {
                return ("Hola, necesita un inmueble");
            }
            public void Comprar()
            {
                Console.WriteLine("Gracias");
            }
        }

       
    }
}
