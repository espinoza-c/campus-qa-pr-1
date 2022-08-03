using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static PerformanceReview1.Persona;


namespace PerformanceReview1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }

        List<Persona> personas = new List<Persona>()
            {
                new Persona("Carlos", "carlos@prueba.com", new DateTime(1997,03,18)),
                new Persona("Antonio", "antonio@prueba.com", new DateTime(2000,03,18)),
                new Persona("Juan","juan@prueba.com", new DateTime(2002,03,18)),
                new Persona("Arturo","arturo@prueba.com", new DateTime(2005,03,18)),
                new Persona("Nombre", "nombre@prueba.com", new DateTime(1985,03,18)),
                new Persona("Andrea", "andrea@prueba.com", new DateTime(1950,03,18))
            };

        // b. Crea una funcion que convierta la lista de personas a una lista de únicamente Emails.
        public void soloEmails(List<Persona> listaPersonas)
        {
            var listaEmails = from emails in listaPersonas
                              select emails.Email;

            foreach (var email in listaEmails)
            {
                Console.WriteLine(email);
            }
        }


        public IEnumerable<Persona> returnFirst()
        {
            DateTime mayoriaDeEdad = new DateTime(2002, 01, 01);

            var filteredByBirthday = from persona in personas
                                     where persona.Birthday >= mayoriaDeEdad
                                     select persona;
            return filteredByBirthday;
        }

        [Fact]
        public void soloEmailsFunciona()
        {

            //Arrange
            var listaPrueba = new List<Persona>()
            {
                new Persona("Carlos","email",new DateTime(18/03/1997)),
                new Persona("Juan","juan@prueba.com", new DateTime(2002,03,18)),
                new Persona("Arturo","arturo@prueba.com", new DateTime(2005,03,18))
            };

            //Add
            soloEmails(listaPrueba);


            //Assert


        }
    }
}       

       

    

