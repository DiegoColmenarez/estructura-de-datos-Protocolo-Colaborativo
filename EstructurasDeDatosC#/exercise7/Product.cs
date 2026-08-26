namespace EstructurasDeDatos.exercise7;

public class Product(string id, string name, long priceInCent)
{
    public string Name { get; } = name;
    public string Id { get; } = id;
    public long PriceInCent { get; } = priceInCent;
}