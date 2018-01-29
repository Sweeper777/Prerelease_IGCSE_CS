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

        public Estimate(List<Choice> choices)
        {
            Choices = new List<Choice>(choices);
            ID = nextID;
            nextID++;
            Price = Choices.Sum(x => x.Price) * 1.2m;
        }

        public override string ToString()
        {
            var builder = new StringBuilder($"ID: {ID}\nComponents:\n");
            foreach (var choice in Choices) {
                builder.AppendLine(choice.ToString());
            }
            builder.AppendLine($"Price: ${Price}");
            return builder.ToString();
        }
    }
}
