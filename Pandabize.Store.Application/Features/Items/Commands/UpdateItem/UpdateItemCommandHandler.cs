using AutoMapper;
using MediatR;
using Pandabize.Store.Application.Contracts.Persistance;
using Pandabize.Store.Domain.Entities;

namespace Pandabize.Store.Application.Features.Items.Commands.UpdateItem
{
    public class UpdateItemCommandHandler : IRequestHandler<UpdateItemCommand>
    {
        private readonly IAsyncRepository<Item> _itemRepository;
        private readonly IMapper _mapper;

        public UpdateItemCommandHandler(IMapper mapper, IAsyncRepository<Item> itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public async Task Handle(UpdateItemCommand request, CancellationToken cancellationToken)
        {
            var eventToUpdate = await _itemRepository.GetByIdAsync(request.Id);

            _mapper.Map(request, eventToUpdate, typeof(UpdateItemCommand), typeof(Item));

            await _itemRepository.UpdateAsync(eventToUpdate);
        }
    }
}
