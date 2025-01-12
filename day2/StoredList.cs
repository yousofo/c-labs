using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace day2
{
    internal class StoredList : List<DataDto>
    {
        static readonly JsonSerializerOptions options = new() { PropertyNameCaseInsensitive = true };

        readonly string filePath = "data.json";

        public StoredList()
        {
            Initialize();
        }
        public new void Add(DataDto item)
        {
            base.Add(item);

            TriggerSync();

        }
        public new void Remove(DataDto item)
        {
            base.Remove(item);

            TriggerSync();
        }
        public void Display()
        {
            foreach (var item in this)
            {
                Console.Write(item.Name + " ");
            }
            Console.WriteLine("\n");
        }

        public new void Clear()
        {
            base.Clear();
            TriggerSync();
        }

        public void TriggerSync()
        {

            var jsonString = JsonSerializer.Serialize(this, options);
            File.WriteAllText(filePath, jsonString);

        }

        public void Initialize()
        {
            var jsonString = File.ReadAllText(filePath);

            var data = JsonSerializer.Deserialize<DataDto[]>(jsonString, options);

            AddRange(data);
        }

    }
    internal class DataDto
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object? dto)
        {
            return dto is DataDto dataDto &&
                   Name == dataDto.Name &&
                   Age == dataDto.Age;
        }
    }
}
