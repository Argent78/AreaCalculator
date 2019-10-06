using System.Threading.Tasks;

namespace AreaCalculator.Data
{
    /**
     * An interface for saving & retrieving data from file.
     *
     * Note: Whilst this class has a 'ReadData' method, there is no actual requirement in the spec to read back persisted data.
     */
    public interface IDataHandler
    {
        Task SaveDataAsync(object data);

        Task<T> ReadDataAsync<T>() where T : class; 
    }
}