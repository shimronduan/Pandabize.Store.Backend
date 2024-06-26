using AutoMapper;
using Pandabize.Store.Application.Features.Items.Commands.CreateItem;
using Pandabize.Store.Application.Features.Items.Commands.UpdateItem;
using Pandabize.Store.Application.Features.Items.Queries.GetAllItems;
using Pandabize.Store.Domain.Entities;

namespace Pandabize.Store.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Item, CreateItemCommand>().ReverseMap();
            CreateMap<Item, UpdateItemCommand>().ReverseMap();

            CreateMap<Item, ItemListVM>().ReverseMap();
        }
    }
}
