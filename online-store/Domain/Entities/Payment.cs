namespace online_store.Domain.Entities;

public class Payment
{
    Guid id { get; set; }
    double price  { get; set; }
    int fromAccount  { get; set; }
    DateTime date { get; set; }
}