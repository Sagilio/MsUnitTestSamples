using System.Linq;
using System.Threading.Tasks;

namespace TestApps
{
    public class Counter
    {
        public ValueTask<int> Add(params int[] num)
        {
            return new ValueTask<int>(num.Sum());
        }

        public ValueTask<int> Count(params int[] num)
        {
            return new ValueTask<int>(num.Length);
        }

        public ValueTask<int> AddByCount(int count, params int[] num)
        {
            return new ValueTask<int>(num.Take(count).Sum());
        }
    }
}