using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos una instancia de contacto 
            Contacto contacto1 = new Contacto();

            contacto1.Nombre = "Pedro";
            contacto1.Direccion = "Veracruz s/n";
            contacto1.CorreoElectronico = "correofeik@correo.com";
            contacto1.TelefonoCasa = "6442698451";
            contacto1.TelefonoCelular = "2658854";

            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Direccion: " + contacto1.Direccion);
            Console.WriteLine("Correo Electronico: " + contacto1.CorreoElectronico);
            Console.WriteLine("Telefono de casa: " + contacto1.TelefonoCasa);
            Console.WriteLine("Telefono celular: " + contacto1.TelefonoCelular);
            Console.ReadLine();
        }
    }
}
