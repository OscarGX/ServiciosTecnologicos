using Caamtroh.Domain;
using Caamtroh.ViewModels;

namespace Caamtroh.Infraestructure
{
    public class AutomaperWebProfile: AutoMapper.Profile
    {
        public AutomaperWebProfile()
        {
            //entidad AspNetRoles
            CreateMap<AspNetRolesDomainModel,AspNetRolesVM>();
            CreateMap<AspNetRolesVM, AspNetRolesDomainModel>();

            //entidad AspNetUsers
            CreateMap<AspNetUsersDomainModel, AspNetUsersVM>();
            CreateMap<AspNetUsersVM, AspNetUsersDomainModel>();
        }
    }
}