using Football_Stats.Library.Client;
using Football_Stats.Library.Interfaces;
using Football_Stats.Library.Leagues;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Football_Stats
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ILeague, LeagueBase>();
            container.RegisterType<ApiClient>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}