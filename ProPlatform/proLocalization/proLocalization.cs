//using Google.Apis.Admin.Directory.directory_v1.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
//using Microsoft.Web.Mvc.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.ProPlatform.proLocalization
{
    public class proLocalization
    {
		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<RequestLocalizationOptions>(options =>
			{
				options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en-US");
				options.SupportedCultures = new List<CultureInfo> { new CultureInfo("en-US") };	
			});
			services.AddMvc();
		}
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			app.UseRequestLocalization();

			app.UseMvc();
		}

	}

}
