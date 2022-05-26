
//Mucho OJO aquí, como hace las importación automática llama a la clase rootobject en todos los casos por lo que puede hacer 
//confilcto si hay varias importaciones
//Este fichero lo he generado poniendo la dirección de la página en el navegador
// https://jsonplaceholder.typicode.com/users/ copiamos el contenido con Crt+c
// y luego usamos Editar/Pegado especial/Pegar JSON como clase

public class Rootobjectk
{
    public User2[] Property1 { get; set; }
}

public class User2
{
    public int id { get; set; }
    public string name { get; set; }
    public string username { get; set; }
    public string email { get; set; }
    public Address address { get; set; }
    public string phone { get; set; }
    public string website { get; set; }
    public Company company { get; set; }
}

public class Address
{
    public string street { get; set; }
    public string suite { get; set; }
    public string city { get; set; }
    public string zipcode { get; set; }
    public Geo geo { get; set; }
}

public class Geo
{
    public string lat { get; set; }
    public string lng { get; set; }
}

public class Company
{
    public string name { get; set; }
    public string catchPhrase { get; set; }
    public string bs { get; set; }
}



