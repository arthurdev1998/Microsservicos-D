using BuildingBlocks.CQRS;
using Marten;

namespace Catalog.Api.Products.UpdateProduct;

public record UpdateProductCommand(Guid Id, string Name, List<string> Category, string Description, string ImageFile, decimal Price)
    : ICommand<UpdateProductResult>;

public record UpdateProductResult(bool IsSuccess);

public class EndpointProductHandler
 (IDocumentSession session, ILogger<EndpointProductHandler> logger)
    : ICommandHandler<UpdateProductCommand, UpdateProductResult>
{
    public Task<UpdateProductResult> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
    {
        logger.LogInformation("UpdateProductHandler.Handle called with {@Command}", command);
        return null;
    }
}