

namespace SfSamples.Models;

public class OrderInfo
{
    public string OrderID { get; set; }
    public string CustomerID { get; set; }
    public string Customer { get; set; }
    public string ShipCountry { get; set; }
    public string ShipCity { get; set; }

    public OrderInfo(string orderID, string customerID, string customer, string shipCountry, string shipCity)
    {
        OrderID = orderID;
        CustomerID = customerID;
        Customer = customer;
        ShipCountry = shipCountry;
        ShipCity = shipCity;
    }
}
