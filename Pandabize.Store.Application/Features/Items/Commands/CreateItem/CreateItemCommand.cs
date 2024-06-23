using MediatR;

namespace Pandabize.Store.Application.Features.Items.Commands.CreateItem
{
    public class CreateItemCommand : IRequest<Guid>
    {
        public string Name { get; set; } = string.Empty;
    }
}
