using MediatR;

namespace Pandabize.Store.Application.Features.Items.Commands.DeleteItem
{
    public class DeleteItemCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
