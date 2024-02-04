using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Game.Mongodb
{
    public class CRUD
    {
        public static void CreateCharacter(Character character)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Characters");
            var collection = database.GetCollection<Character>("CharacterCollection");
            collection.InsertOne(character);
        }

    }
}
