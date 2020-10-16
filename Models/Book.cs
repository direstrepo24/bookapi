
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
act 

namespace BooksApi.Models
{
    //dominio de model, es una clase especial plana
    //Representa la base de datos en forma de objeto - Clase
    //enlase binding con el documento - collectiones (tablas en SQL) de mongo
    //NoSQL 
    public class Book
    {
        //propidades del objeto 
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        public string Id {get;set;} 

        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string BookName{get;set;}
        public decimal Price{get;set;}
        public string Category {get;set;}
        public string Author{get;set;}
    


        
    }
}