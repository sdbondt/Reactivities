using AutoMapper;
using Domain;

namespace API.Core;

public class MappingProfiles: Profile
{
    public MappingProfiles()
    {
        CreateMap<Activity, Activity>();
    }
}
