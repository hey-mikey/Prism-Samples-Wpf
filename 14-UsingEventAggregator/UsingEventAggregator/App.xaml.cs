using System.Windows;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using ModuleA;
using ModuleB;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using UsingEventAggregator.Views;

namespace UsingEventAggregator
{
    /// <summary>
    ///     Interaction logic for App.xaml
    ///     Class App.
    ///     Implements the <see cref="PrismApplication" />
    /// </summary>
    /// <seealso cref="PrismApplication" />
    public partial class App : PrismApplication
    {
        /// <summary>
        ///     Constructor for UsingEventAggregator App
        ///     This GUID registration is for using the App Center's SDK
        /// </summary>
        public App()
        {
            AppCenter.Start("c8563d4d-e664-4f6f-baa5-c07e283439c8", typeof(Analytics));
        }

        /// <summary>
        ///     Creates the shell or main window of the application.
        /// </summary>
        /// <returns>The shell of the application.</returns>
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        /// <summary>
        ///     Used to register types with the container that will be used by your application.
        /// </summary>
        /// <param name="containerRegistry">The container registry.</param>
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        /// <summary>
        ///     Configures the <see cref="T:Prism.Modularity.IModuleCatalog" /> used by Prism.
        /// </summary>
        /// <param name="moduleCatalog">The module catalog.</param>
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleAModule>();
            moduleCatalog.AddModule<ModuleBModule>();
        }
    }
}