using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Owner, OwnerDto>();
        CreateMap<Account, AccountDto>();
        CreateMap<Owner, OwnerForCreationDto>();
        CreateMap<Owner, OwnerForUpdateDto>();
    }
}