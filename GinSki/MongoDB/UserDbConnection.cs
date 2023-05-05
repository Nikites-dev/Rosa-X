using GinSki.Models;
using MongoDB.Driver;

namespace GinSki.MongoDB;

public class UserDbConnection
{
    public static void AddToDatabase(Client user)
    {
        var client = new MongoClient("mongodb://localhost");
        var database = client.GetDatabase("GinSki");
        var collection = database.GetCollection<Client>("Clients");
        collection.InsertOne(user);
    }
}