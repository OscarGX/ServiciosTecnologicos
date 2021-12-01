﻿using Incubadora.Domain;
using Incubadora.ViewModels;

namespace Incubadora.Infraestructure
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