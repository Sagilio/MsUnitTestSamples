using System.Linq;
using System.Threading.Tasks;

namespace TestApps
{
    public class AddCounter
    {
        public ValueTask<int> AddAsync(params int[] num)
        {
            return new ValueTask<int>(num.Sum());
        }

        public ValueTask<int> CountAsync(params int[] num)
        {
            return new ValueTask<int>(num.Length);
        }

        public async ValueTask<int> AddByCountAsync(int count, params int[] num)
        {
            return await AddAsync(num.Take(count).ToArray());
        }
    }
}