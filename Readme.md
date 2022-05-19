Este fichero es un ejemplo de como importar JSON desde una página web.
JSON  es un formato de texto sencillo para intercambio de datos que surgió en javascript y que posteriormente se ha reutilizado.
Un ejemplo de datos en JSON puede ser:
{
  "departamento":8,
  "nombredepto":"Ventas",
  "director": "Juan Rodríguez",
  "empleados":[
    {
      "nombre":"Pedro",
      "apellido":"Fernández"
    },{
      "nombre":"Jacinto",
      "apellido":"Benavente"
    } 
  ]
}
Hay dos operaciones con ficheros JSON serializar que es convertir una clase de C# en datos JSON y deserializar que es convertir datos en formato JSON 
a variable de C#

Para hacer la importación en primer lugar tendríamos que saber el formato, si no lo sabemos tenemos que importarlo de la propia fuente de datos.
Si tiene JSON en el que desea deserializar y no tiene la clase en la que deserializarlo, tiene opciones que no son crear manualmente la clase que necesita:
Deserialice en un DOM JSON (modelo de objetos de documento) y extraiga lo que necesita del DOM.
Dom permite navegar a una subsección de una carga JSON y deserializar un valor único, un tipo personalizado o una matriz. Para obtener información sobre JsonNode DOM en .NET 6, consulte JsonNode. Para obtener información sobre JsonDocument DOM, consulte JsonDocument.
Use Utf8JsonReader directamente.
Use Visual Studio 2022 para generar automáticamente la clase que necesita:
Copie el JSON que necesita para deserializar.
Cree un archivo de clase y elimine el código de plantilla.
Elija EditarPasteSpecialPasteJSON como Clases. El resultado es una clase que puede usar para el destino de deserialización.
    