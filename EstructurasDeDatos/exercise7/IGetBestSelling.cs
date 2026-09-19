namespace EstructurasDeDatos.exercise7;

public interface IGetBestSelling
{
    List<Product> GetBestSelling(List<SalesLine> salesLineList);
}