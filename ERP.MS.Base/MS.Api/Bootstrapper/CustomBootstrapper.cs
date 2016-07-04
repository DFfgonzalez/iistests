using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using Nancy.Conventions;
using Nancy.Diagnostics;

namespace MS.Api.Bootstrapper
{

    // The bootstrapper enables you to reconfigure the composition of the framework,
    // by overriding the various methods and properties.
    // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper
    public class CustomBootstrapper : DefaultNancyBootstrapper
    {

        // TODO: Eliminar las sobreescrituras de métodos que no sean necesarias.

        public CustomBootstrapper() : base() {}

        //protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        //{
        //    base.ApplicationStartup(container, pipelines);
        //}

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            // Por alguna razón TinyIOC no tomó de forma automática esta implementación.
            container.Register<ERP.Defontana.Dal.Interface.IDao<ERP.Defontana.Cpl.Dto.EmpresaDto>, ERP.Defontana.Dal.Core.Dao>().AsSingleton();

        }

        //protected override void ConfigureConventions(NancyConventions nancyConventions)
        //{
        //    base.ConfigureConventions(nancyConventions);
        //}

        //protected override void ConfigureRequestContainer(TinyIoCContainer container, NancyContext context)
        //{
        //    base.ConfigureRequestContainer(container, context);
        //}

        //protected override TinyIoCContainer CreateRequestContainer(NancyContext context)
        //{
        //    return base.CreateRequestContainer(context);
        //}

        //protected override TinyIoCContainer GetApplicationContainer()
        //{
        //    return base.GetApplicationContainer();
        //}

        //protected override IEnumerable<IApplicationStartup> GetApplicationStartupTasks()
        //{
        //    return base.GetApplicationStartupTasks();
        //}

        //protected override IDiagnostics GetDiagnostics()
        //{
        //    return base.GetDiagnostics();
        //}

        //protected override IEnumerable<IRegistrations> GetRegistrationTasks()
        //{
        //    return base.GetRegistrationTasks();
        //}

        //protected override IEnumerable<IRequestStartup> RegisterAndGetRequestStartupTasks(TinyIoCContainer container, Type[] requestStartupTypes)
        //{
        //    return base.RegisterAndGetRequestStartupTasks(container, requestStartupTypes);
        //}

        //protected override void RegisterInstances(TinyIoCContainer container, IEnumerable<InstanceRegistration> instanceRegistrations)
        //{
        //    base.RegisterInstances(container, instanceRegistrations);
        //}

        //protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        //{
        //    base.RequestStartup(container, pipelines, context);
        //}

    }
}