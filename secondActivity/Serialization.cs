using System.Text.Json;
using EpisodeListFunction;

namespace SerializationFunction
{
    public class Serialization
    {
        private static string _filepath = "./Database/UserEpisodes.json";
        public static void EpisodeSerialize(Dictionary<int,string> userList)
        {
            string jsonString = JsonSerializer.Serialize(userList, new JsonSerializerOptions {WriteIndented = true});
            Console.WriteLine(jsonString);
            Console.ReadLine();

            File.WriteAllText(_filepath, jsonString);
            
        }

    }
}