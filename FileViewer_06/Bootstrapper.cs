using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Unity;
using System.Windows;
using Microsoft.Practices.Unity;

namespace FileViewer_06
{
    public class Bootstrapper : UnityBootstrapper
    {
        public override void Run(bool runWithDefaultConfiguration)
        {
            base.Run(runWithDefaultConfiguration);
        }

        //create the shell
        //show the window

        protected override DependencyObject CreateShell()
        {
            // make new shell ~ new shell();
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            //Set main window for Prism
            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            Type moduleAType = typeof(Module_A.Module);
            ModuleCatalog.AddModule(new Prism.Modularity.ModuleInfo { ModuleName = moduleAType.Name, ModuleType = moduleAType.AssemblyQualifiedName });
        }

    }
}