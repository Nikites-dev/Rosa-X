using System;
using System.Collections.Generic;
using GinSki.Models;
using MongoDB.Driver;

namespace GinSki.MongoDB
{
    public class UserDbConnection
    {
        public static void AddToDatabase(Client user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("GinSki");
            var collection = database.GetCollection<Client>("Client");
            collection.InsertOne(user);
        }
        
        public static Client GetClientByEmail(String email)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("GinSki");
            var collection = database.GetCollection<Client>("Client");
            Client user = collection.Find(x => x.Email == email).FirstOrDefault();

            if (user == null)
            {
                return null;
            }
            
            return user;
        }
        
        public static void UpdateClient(Client user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("GinSki");
            var collection = database.GetCollection<Client>("Client");
            var b = collection.ReplaceOne(x => x.Email == user.Email, user).ModifiedCount > 0;
        }
        
        public static List<Client> GetListClient()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("GinSki");
            var collection = database.GetCollection<Client>("Client");

            List<Client> listClients = new List<Client>();

            try
            {
                listClients = collection.Find(x => x.Email != "").ToList();
            }
            catch (Exception e)
            {
                return null;
            }

            if (listClients.Count == 0)
            {
                return null;
            }

            return listClients;
        }
    }
}