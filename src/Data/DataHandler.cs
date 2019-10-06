using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AreaCalculator.Data
{
    public class DataHandler : IDataHandler
    {
        private const string SaveFile = "shapedata.txt";
        
        public async Task SaveDataAsync(object data)
        {
            var json = JsonConvert.SerializeObject(data);
            await File.WriteAllTextAsync(SaveFile, json);
        }

        public async Task<T> ReadDataAsync<T>() where T : class
        { 
            var json = await File.ReadAllTextAsync(SaveFile);
            var data = JsonConvert.DeserializeObject<T>(json);
            return data;
        }
    }
}
