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
    //Esta clase que es la que va a servir para leer los datos nos la dan en el ejemplo
    //Si no tenemos la clase tenemos que obtenerlas (ver ficheros EstrucutraJSON)
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

            User? user = await client.GetFromJsonAsync<User>("users/1/");
                Console.WriteLine($"Id: {user?.Id}");
                Console.WriteLine($"Name: {user?.Name}");
                Console.WriteLine($"Username: {user?.Username}");
                Console.WriteLine($"Email: {user?.Email}");
                Console.WriteLine();

            Console.WriteLine("Ahora vamos a ver el mismo ejemplo con más datos");
            Console.Read();
            // Utilizamos la estructura que hemos importado
            List<User2>? usuarios = await client.GetFromJsonAsync<List<User2>>("users/");
            foreach (User2 usuario in usuarios)
            {
                Console.WriteLine($"Id: {usuario?.id}");
                Console.WriteLine($"Name: {usuario?.name}");
                Console.WriteLine($"Username: {usuario?.username}");
                Console.WriteLine($"Email: {usuario?.email}");
                Console.WriteLine($"Adress: {usuario?.address.street}, {usuario.address.suite}");
                Console.WriteLine($" {usuario?.address.city}, {usuario.address.zipcode}");
                Console.WriteLine();
            }

            //Otro ejemplo
            Console.WriteLine("Pulsa para ver otro ejemplo");
            Console.Read();

            HttpClient client2 = new()
            {
                BaseAddress = new Uri("https://www.floatrates.com")
                
            };
        
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