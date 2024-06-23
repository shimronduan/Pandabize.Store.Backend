using AutoMapper;
using MediatR;
using Pandabize.Store.Application.Contracts.Persistance;
using Pandabize.Store.Domain.Entities;

namespace Pandabize.Store.Application.Features.Items.Commands.DeleteItem
{
    public class DeleteItemCommandHandler : IRequestHandler<DeleteItemCommand>
    {
        private readonly IAsyncRepository<Item> _itemRepository;
        private readonly IMapper _mapper;

        public DeleteItemCommandHandler(IMapper mapper, IAsyncRepository<Item> itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public async Task Handle(DeleteItemCommand request, CancellationToken cancellationToken)
        {
            var itemToDelete = await _itemRepository.GetByIdAsync(request.Id);

            await _itemRepository.DeleteAsync(itemToDelete);
        }
    }
}
