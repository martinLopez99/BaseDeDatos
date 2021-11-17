using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTP4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AgendaContext())
            {
                //Alta
                Persona mPersona = new Persona
                {
                    PersonaId = 1,
                    Nombre = "Juan",
                    Apellido = "Sánchez",
                    Telefonos = new List<Telefono>
                    {
                        new Telefono
                        {
                            TelefonoId = 1,
                            Numero = "555 - 123456",
                            Tipo = "Celular"
                          }
                    }
                };

                db
            }



        }
    }
}
