using System.Text.Json;
using System.Text.Json.Serialization;

namespace _2024_PracLesson
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                List<Fruit> fruits = new List<Fruit>
                {
                    new Citrus("Orange", "Orange", 53.2),
                    new Citrus("Lemon", "Yellow", 29.1),
                    new Citrus("Grapefruit", "Pink", 31.5),
                    new Fruit("Apple", "Red"),
                    new Fruit("Banana", "Yellow")
                };

                foreach (Fruit fruit in fruits)
                {
                    if (fruit.Color == "Yellow")
                        fruit.Print(fruit.ToString());
                }

                fruits = fruits.OrderBy(f => f.Name).ToList();

                string[] lines = fruits.Select(f => f.ToString()).ToArray();

                try
                {
                    File.WriteAllLines("fruits.txt", lines);
                }
                catch (IOException ioEx)
                {
                    Console.WriteLine($"Error writing to file: {ioEx.Message}");
                }

                try
                {
                    string jsonString = JsonSerializer.Serialize(fruits,
                        new JsonSerializerOptions { WriteIndented = true });

                    File.WriteAllText("fruits.json", jsonString);
                }
                catch (JsonException jsonEx)
                {
                    Console.WriteLine($"Serialization error in JSON: {jsonEx.Message}");
                }
                catch (IOException ioEx)
                {
                    Console.WriteLine($"Error writing JSON to a file: {ioEx.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred: {ex.Message}");
            }
        }
    }
}
