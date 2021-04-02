using AutoMapper;
using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Infrastructure.ViewModel;

namespace Conscious.Choice.OnionApi.Infrastructure.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerModel, Customer>()
                .ForMember(dest => dest.Id,
                        opt => opt.MapFrom(src => src.CustomerId))
                .ReverseMap();
        }
    }
}
