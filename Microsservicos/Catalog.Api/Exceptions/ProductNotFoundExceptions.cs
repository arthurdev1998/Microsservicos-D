using BuildingBlocks.Exceptions;

namespace Catalog.Api.Exceptions;

public class ProductNotFoundExceptions : NotFoundException
{
    public ProductNotFoundExceptions(Guid id) : base("Product", id)
    {
    }
}
