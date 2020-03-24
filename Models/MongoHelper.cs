using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace HopZone.Models
{
    public class MongoHelper
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://NIT:12345nit@cluster0-vd97p.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatebase = "hopzone";

        public static IMongoCollection<Models.User> user_collection { get; set; }

        internal static void ConnectToMongoService()
        {
            try
            {
                client = new MongoClient(MongoConnection);
                database = client.GetDatabase(MongoDatebase);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

    }
}
