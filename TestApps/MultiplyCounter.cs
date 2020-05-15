using System.Linq;
using System.Threading.Tasks;

namespace TestApps
{
    public class MultiplyCounter
    {
        public ValueTask<int> MultiplyAsync(params int[] num)
        {
            return new ValueTask<int>(num.Aggregate( 
                (a, b) => a * b));
        }

        public ValueTask<int> CountAsync(params int[] num)
        {
            return new ValueTask<int>(num.Length);
        }

        public async ValueTask<int> MultiplyByCountAsync(int count, params int[] num)
        {
            return await MultiplyAsync(num.Take(count).ToArray());
        }
    }
}