using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace WorkerService1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseWindowsService()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                });

        //public static IHostBuilder CreateHostBuilder(string[] args)
        //{
        //    return Host.CreateDefaultBuilder(args) //ʹ��Ĭ������ʵ����Host����
        //        .UseWindowsService() //ָ����Ŀ���Բ���ΪWindows����
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>()
        //                .UseKestrel(options =>
        //                {
        //                    options.Listen(IPAddress.Any, 50003); //ָ���˿ںţ���Ȼ���������
        //                    options.limits.MaxRequestBodySize = null;
        //                });
        //        })
        //        .UseDefaultServiceProvider(options => options.ValidateScopes = false);
        //}
    }
}
