namespace online_store.Domain.Entities;

public class Order
{
    int id { get; set; }
    Payment payment { get; set; }
    List<ProductAmount> products { get; set; }
}

public class ProductAmount
{
    float amount { get; set; }
    Product product { get; set; }
}