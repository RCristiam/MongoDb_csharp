using MongoDB.Driver;

namespace MongoDB_csharp.Logic;

public class MongoDriver
{
    public void Connect()
    {
        MongoClient dbClient = new MongoClient("");

        var dbList = dbClient.ListDatabases().ToList();

        Console.WriteLine("The list of databases on this server is: ");
        foreach (var db in dbList)
        {
            Console.WriteLine(db);
        }
    }

}