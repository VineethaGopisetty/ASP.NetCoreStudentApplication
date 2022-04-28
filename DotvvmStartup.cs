using System;
using DotVVM.Framework.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotvvmApp1
{
    public class DotvvmStartup : IDotvvmStartup, IDotvvmServiceConfigurator
    {
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            ConfigureRoutes(config,applicationPath);
            ConfigureResources(config, applicationPath);
            ConfigureControls(config, applicationPath);
        }

        private void ConfigureControls(DotvvmConfiguration config, string applicationPath)
        {
          
        }

        private void ConfigureResources(DotvvmConfiguration config, string applicationPath)
        {

        }

        private void ConfigureRoutes(DotvvmConfiguration config, string applicationPath)
        {
            config.RouteTable.Add("About","","Views/About.dothtml");
            config.RouteTable.Add("Students", "students", "Views/Students.dothtml");
        }

        public void ConfigureServices(IDotvvmServiceCollection options)
        {
            
        }
    }
}