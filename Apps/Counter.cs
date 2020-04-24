using System.Linq;
using System.Threading.Tasks;

namespace MsUnitTestSample.Apps
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