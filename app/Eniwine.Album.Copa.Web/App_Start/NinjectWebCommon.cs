using Eniwine.Album.Copa.Aplicacao.Aplicacao;
using Eniwine.Album.Copa.Dominio.Interfaces.Aplicacao;
using Eniwine.Album.Copa.Dominio.Interfaces.Repositorio;
using Eniwine.Album.Copa.Repositorio.Repositorio;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using System;
using System.Web;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Eniwine.Album.Copa.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Eniwine.Album.Copa.Web.App_Start.NinjectWebCommon), "Stop")]

namespace Eniwine.Album.Copa.Web.App_Start
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAplicacaoBase<>)).To(typeof(AplicacaoBase<>));
            kernel.Bind(typeof(IRepositorioBase<>)).To(typeof(RepositorioBase<>));

            kernel.Bind<IFigurinhaAplicacao>().To<FigurinhaAplicacao>();
            kernel.Bind<IFigurinhaRepositorio>().To<FigurinhaRepositorio>();

            kernel.Bind<ITrocaAplicacao>().To<TrocaAplicacao>();
            kernel.Bind<ITrocaRepositorio>().To<TrocaRepositorio>();

            kernel.Bind<IUsuarioAplicacao>().To<UsuarioAplicacao>();
            kernel.Bind<IUsuarioRepositorio>().To<UsuarioRepositorio>();

        }
    }
}