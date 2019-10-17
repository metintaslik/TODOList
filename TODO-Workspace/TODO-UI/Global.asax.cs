using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TODO_BL;
using TODO_DAL;

namespace TODO_UI
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<ToDoRepo>().As<IToDo>();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
