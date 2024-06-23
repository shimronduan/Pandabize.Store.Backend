using AutoMapper;
using MediatR;
using Pandabize.Store.Application.Contracts.Persistance;
using Pandabize.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandabize.Store.Application.Features.Items.Queries.GetItemDetails
{
    internal class GetItemDetailQueryHandler : IRequestHandler<GetItemDetailQuery, ItemDetailVm>
    {
        private readonly IAsyncRepository<Item> _itemRepository;
        private readonly IMapper _mapper;

        public GetItemDetailQueryHandler(
            IMapper mapper,
            IAsyncRepository<Item> itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public async Task<ItemDetailVm> Handle(GetItemDetailQuery request, CancellationToken cancellationToken)
        {
            var @event = await _itemRepository.GetByIdAsync(request.Id);
            var itemDetailDto = _mapper.Map<ItemDetailVm>(@event);

            //var category = await _categoryRepository.GetByIdAsync(@event.CategoryId);

            //eventDetailDto.Category = _mapper.Map<CategoryDto>(category);

            return itemDetailDto;
        }
    }
}
