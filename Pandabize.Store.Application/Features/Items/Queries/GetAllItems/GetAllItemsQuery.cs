using MediatR;

namespace Pandabize.Store.Application.Features.Items.Queries.GetAllItems
{
    public class GetAllItemsQuery : IRequest<List<ItemListVM>>
    {
    }
}
