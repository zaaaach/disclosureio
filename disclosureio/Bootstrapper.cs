using Nancy;
using Nancy.Conventions;
using Nancy.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disclosureio
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(Nancy.Conventions.NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);

            Conventions.StaticContentsConventions.Add(
                    StaticContentConventionBuilder.AddDirectory("static", "Content")
                );
        }

        protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            if (!Properties.Settings.Default.DiagnosticsEnabled)
            {
                DiagnosticsHook.Disable(pipelines);
            }
        }

        protected override DiagnosticsConfiguration DiagnosticsConfiguration
        {
            get
            {
                return new DiagnosticsConfiguration
                {
                    Password = Properties.Settings.Default.DiagnosticsPassword,
                    Path = "/admin/diagnostics",
                    SlidingTimeout = 30
                };
            }
        }
    }
}
