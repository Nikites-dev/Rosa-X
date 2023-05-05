using GinSki.Models;
using MongoDB.Driver;

namespace GinSki.MongoDB;

public class InventoryDbConnection
{
    public static void AddToDatabase(Inventory inventory)
    {
        var client = new MongoClient("mongodb://localhost");
        var database = client.GetDatabase("GinSki");
        var collection = database.GetCollection<Inventory>("Inventory");
        collection.InsertOne(inventory);
    }
    
    public static Inventory GetInventoryByName(String name)
    {
        var client = new MongoClient("mongodb://localhost");
        var database = client.GetDatabase("GinSki");
        var collection = database.GetCollection<Inventory>("Inventory");
        Inventory inventory = collection.Find(x => x.Name == name).FirstOrDefault();
            
        if (inventory == null)
        {
            return null;
        }
        return inventory;
    }
    
    
    public static Inventory GetInventoryByIdType(int idTypeInventory)
    {
        var client = new MongoClient("mongodb://localhost");
        var database = client.GetDatabase("GinSki");
        var collection = database.GetCollection<Inventory>("Inventory");
        Inventory inventory = collection.Find(x => x.IdTypeInverory == idTypeInventory).FirstOrDefault();
            
        if (inventory == null)
        {
            return null;
        }
        return inventory;
    }
    
    public static void UpdateInventory(Inventory inventory)
    {
        var client = new MongoClient("mongodb://localhost");
        var database = client.GetDatabase("GinSki");
        var collection = database.GetCollection<Inventory>("Inventory");
        var b = collection.ReplaceOne(x => x.Name == inventory.Name, inventory).ModifiedCount > 0;
    }
    
    public static List<Inventory> GetListInventory()
    {
        var client = new MongoClient("mongodb://localhost");
        var database = client.GetDatabase("GinSki");
        var collection = database.GetCollection<Inventory>("Inventory");

        List<Inventory> inventories = new List<Inventory>();
            
        try
        {
            inventories = collection.Find(x => x.Name  != "").ToList();
        }
        catch (Exception e)
        {
            inventories = null;
        }
            
        if (inventories == null)
        {
            return null;
        }
        return inventories;
    }
}