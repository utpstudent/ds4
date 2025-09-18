using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client();
            client.FirstName = "Miguel";
            client.LastName = "Martinez";
            client.Age = 25;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());
        }
    }

        public class Client
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string GetFullName()
            {
                return FirstName + " " + LastName;
            }
        }

    }


