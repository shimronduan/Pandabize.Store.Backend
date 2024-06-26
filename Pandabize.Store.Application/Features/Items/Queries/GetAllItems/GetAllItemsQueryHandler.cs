using AutoMapper;
using MediatR;
using Pandabize.Store.Application.Contracts.Persistance;
using Pandabize.Store.Domain.Entities;

namespace Pandabize.Store.Application.Features.Items.Queries.GetAllItems
{
    public class GetAllItemsQueryHandler : IRequestHandler<GetAllItemsQuery, List<ItemListVM>>
    {
        private readonly IAsyncRepository<Item> itemRepository;
        private readonly IMapper mapper;

        public GetAllItemsQueryHandler(IMapper mapper, IAsyncRepository<Item> itemRepository)
        {
            this.itemRepository = itemRepository;
            this.mapper = mapper;
        }
       
        public async Task<List<ItemListVM>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            var items = (await itemRepository.ListAllAsync()).OrderByDescending(x => x.LastModifiedDate);
            return mapper.Map<List<ItemListVM>>(items);
        }
    }
}
