[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(CourseScheduler.Website.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(CourseScheduler.Website.App_Start.NinjectWebCommon), "Stop")]

namespace CourseScheduler.Website.App_Start
{
	using System;
	using System.Web;
	using CourseScheduler.Data;
	using CourseScheduler.Website.Services;
	using Microsoft.Web.Infrastructure.DynamicModuleHelper;
	using Ninject;
	using Ninject.Web.Common;

	public static class NinjectWebCommon
	{
		private static readonly Bootstrapper bootstrapper = new Bootstrapper();

		/// <summary>
		/// Starts the application
		/// </summary>
		public static void Start()
		{
			DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
			DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
			bootstrapper.Initialize(CreateKernel);
		}

		/// <summary>
		/// Stops the application.
		/// </summary>
		public static void Stop()
		{
			bootstrapper.ShutDown();
		}

		/// <summary>
		/// Creates the kernel that will manage your application.
		/// </summary>
		/// <returns>The created kernel.</returns>
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

		/// <summary>
		/// Load your modules or register your services here!
		/// </summary>
		/// <param name="kernel">The kernel.</param>
		private static void RegisterServices(IKernel kernel)
		{
#if DEBUG
			//Dependency Injection for mail service using Ninject
			kernel.Bind<IMailService>().To<MockMailService>().InRequestScope();
#else
			//Dependency Injection for mail service using Ninject
			kernel.Bind<IMailService>().To<MailService>().InRequestScope();
#endif
			//InRequestScope - means everyone from the website gets the same reference. not creating new instance
			kernel.Bind<CourseSchedulerContext>().To<CourseSchedulerContext>().InRequestScope();
			kernel.Bind<ICourseSchedulerRepository>().To<CourseSchedulerRepository>().InRequestScope();
		}
	}
}
