using System;
using System.Collections.Generic;
namespace Prerelease_IGCSE_CS
{
    public class Order
    {
        public string CustomerName { get; }
        public DateTime Date { get; } = DateTime.Today;
        public Estimate EstimateDetails { get; }
    }
}
