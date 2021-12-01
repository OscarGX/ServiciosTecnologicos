using Incubadora.Business;
using Incubadora.Business.Interface;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Incubadora
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IAspNetRolesBusiness, AspNetRolesBusiness>();
            container.RegisterType<IAspNetUsersBusiness, AspNetUsersBusiness>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}