using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWatch.ProPlatform.Security
{
    public class AuthoziedMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthoziedMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                if (context.Request.Path == "/Users/User/LoginView" || context.Request.Path == "/Users/User/Login")
                {
                    await _next(context);
                    return;
                }


                var userIdStr = context.Session.GetString(SessionKeys.UserId);
                int userId = Convert.ToInt32(userIdStr);
                if (userId == 0)
                {
                    //context.
                    context.Response.Redirect("/Users/User/LoginView");
                    return;
                }

                //var cultureQuery = context.Request.Query["culture"];
                //if (!string.IsNullOrWhiteSpace(cultureQuery))
                //{
                //    var culture = new CultureInfo(cultureQuery);

                //    CultureInfo.CurrentCulture = culture;
                //    CultureInfo.CurrentUICulture = culture;

                //}

                //Call the next delegate/ middleware in the pipeline


                await _next(context);
            }
            catch (Exception ex)
            {


                context.Response.Redirect("/Users/User/LoginView");
                return;
            }
        }
    }


    public static class RequestAuthoziedMiddleware
    {
        public static IApplicationBuilder UseAuthoziedMiddleware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthoziedMiddleware>();
        }
    }

}
