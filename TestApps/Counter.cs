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
            return new ValueTask<int>(num.Length - 1);
        }
    }
}