using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace Prerelease_IGCSE_CS
{
    public class Estimate
    {
        public List<Choice> Choices { get; }
        public ulong ID { get; }
        static ulong nextID = 1;
        public decimal Price { get; set; }

    }
}
