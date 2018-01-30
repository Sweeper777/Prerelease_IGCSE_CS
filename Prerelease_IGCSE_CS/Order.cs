using System;
using System.Collections.Generic;
namespace Prerelease_IGCSE_CS
{
    public class Order
    {
        public string CustomerName { get; }
        public DateTime Date { get; } = DateTime.Today;
        public Estimate EstimateDetails { get; }

        public Order(string customerName, Estimate estimateDetails)
        {
            CustomerName = customerName;
            EstimateDetails = estimateDetails;
            AllOrders.Add(this);
        }

        public override string ToString()
        {
            return $"{EstimateDetails}Customer Name: {CustomerName}\nDate: {Date.ToShortDateString()}";
        }

    }
}
