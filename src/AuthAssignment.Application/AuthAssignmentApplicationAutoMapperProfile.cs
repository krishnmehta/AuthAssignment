using AutoMapper;

namespace AuthAssignment;

public class AuthAssignmentApplicationAutoMapperProfile : Profile
{
    public AuthAssignmentApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<User,UserDto>();
    }
}
