namespace Catalog.Api.Exceptions;

public class ProductNotFoundExceptions : Exception
{
    public ProductNotFoundExceptions() : base("Product not found!")
    {
    }
}
