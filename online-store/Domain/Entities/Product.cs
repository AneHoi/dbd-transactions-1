namespace online_store.Domain.Entities;

public class Product
{
    Guid id { get; set; }
    string name { get; set; }
    int ean  { get; set; }
    string description { get; set; }
    double price { get; set; }
}