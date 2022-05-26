using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Net.Http.Json;
using EstructuraJSON;



namespace HttpClientExtensionMethods
{
    //Previamente hemos visto como se estructuran los datos JSON si no lo tenemos debemos extraerlo de algun sitio
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
    }

    public class Program
    {
        public static async Task Main()
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri("https://jsonplaceholder.typicode.com")
            };

            // Get the user information.


            List<User>? m = await client.GetFromJsonAsync<List<User>>("users/");
            foreach (User user in m)
            {
                Console.WriteLine($"Id: {user?.Id}");
                Console.WriteLine($"Name: {user?.Name}");
                Console.WriteLine($"Username: {user?.Username}");
                Console.WriteLine($"Email: {user?.Email}");
                Console.WriteLine();
            }

            //Otro ejemplo
            Console.WriteLine("Pulsa para ver otro ejemplo");
            Console.Read();

            HttpClient client2 = new()
            {
                BaseAddress = new Uri("https://www.floatrates.com")
                
            };
            //using HttpClient client2 = httpClient;
        
            Rootobject? k = await client2.GetFromJsonAsync<Rootobject>("daily/eur.json");

            Console.WriteLine($"Code: {k.usd.code}");
            Console.WriteLine($"AlfaCode: {k.usd.alphaCode}");
            Console.WriteLine($"NumCode: {k.usd.numericCode}");
            Console.WriteLine($"Name: {k.usd.name}");
            Console.WriteLine($"Rate: {k.usd.rate}");
            Console.WriteLine($"Date: {k.usd.date}");
            Console.WriteLine($"InvRate: {k.usd.inverseRate}");
            Console.WriteLine();

            Console.Read();

        }

    }
}