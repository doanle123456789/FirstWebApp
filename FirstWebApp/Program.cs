using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// CAU TRUC DU AN ASP.NET CORE
/// 1. Connected Services: se lam viec khi add service o ben ngoai vao 
/// 2. Properties: thu muc chua file launchSettings.json: file nay chứa những profile để thực thi ứng dụng
/// 3. Folder wwwroot: tự hiểu là một thư mục của ứng dụng chứa file html, css, file ảnh, file tĩnh.
/// 4. Dependencies: chứa NuGet package, có thể cài bằng cách:
///    - C1: Add PackageReference trong file Project.csproj
///    - C2: nhấp chuột phải vào project chọn Manage Nuget Package
///    - C3: cài bằng lệnh thông qua Tools > NuGet Package Manager > Package Manager Console
/// 5. Manage Client-Side Libraries: 
///    - Có phần libraries: mỗi phần tử là một object:
///         + Tên là tên library
///         + destination: muốn để đâu trong project khi tải về
/// 6. appsettings.json: chứa file cấu hình
/// 7. Program.cs và Startup.cs là 2 file để chạy ứng dụng
///    
/// </summary>

namespace FirstWebApp
{
    public class Program
    {
        public static void Main(string[] args)//nhan cac tham so tu dong lenh
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /*
         * sau khi tao xong se tra ve 1 doi tuong la IHostBuilder. Dung 1 helper class.CreateDefaultBuilder: lam nhiem vu tao 1 server Kestrel.
         * Kestrel la mot web server cua ASP.Net Core mac dinh. Sau khi tao xong thi no se tra ve mot IHostBuilder va no dung class Startup de 
         * lam nhung cau hinh khi no khoi chay ban dau se tro den file Startup nay. Khi tr ve xong thi no se dung pthuc Build() de build mot cai 
         * hostApplication va cuoi cung Run() de run no.
         */

        /*
         * Day la mot ham rat don gian(Body expression): than ham chi co 1 dong
         */
        
        //public static IHostBuilder CreateHostBuilder(string[] args)  
        //=>
        //Host.CreateDefaultBuilder(args)
        //    .ConfigureWebHostDefaults(webBuilder =>
        //    {
        //        webBuilder.UseStartup<Startup>();
        //    });

        //Cach viet 2, tuong minh khi trong than ham co nhieu dong
        //public static IHostBuilder CreateHostBuilder(string[] args)
        //{
        //    return Host.CreateDefaultBuilder(args)
        //                .ConfigureWebHostDefaults(webBuilder =>
        //                {
        //                    webBuilder.UseStartup<Startup>();
        //                });
        //}
       
        /*
         * var mot dtuong builder bang cach new WebHostBuilder 
         */
        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var builder = new WebHostBuilder();
        }


























        //{
        //    var builder = new WebHostBuilder()
        //        .UseKestrel()   //chi tuong minh ra server dang su dung cho webhost la Kestrel
        //        .UseStartup<Startup>()
        //        .UseContentRoot(System.IO.Directory.GetCurrentDirectory()) //thu muc hien tai cua UD, thu muc goc cua UD (FirstWebApp)
        //        .ConfigureAppConfiguration((hostingContext,config) => //configure app;
        //        {
        //            var env = hostingContext.HostingEnvironment; //lay ra duoc mtruong htai
        //            config.AddJsonFile("appsetting.json",optional:true,reloadOnChange:true)//(file config, co tim thay khong cung khong bao loi, tu dong nhan cau hinh moi khi co thay doi khong can restart lai UD
        //                .AddJsonFile($"appsettings.{env.EnvironmentName}.json",optional:true,reloadOnChange:true)
        //            if(env.IsDevelopment())
        //            {
        //                var appAssembly = Assembly.Load(new AssemblyName(env.ApplicationName));
        //                if(appAssembly != null)
        //                {
        //                    config.AddUserSecrets(appAssembly, optional: true);
        //                }
        //            } //neu mtruong la Development thi se load o Assembly hien tai (FirstWebApp.dll), su dung Secrets khi debug

        //            config.AddEnvironmentVariables(); //lay ra tham so he thong

        //            if (args != null)
        //            {
        //                config.AddCommandLine(args);
        //            } //khi CommandLine khac null thi no cung lay tu CommandLine
        //        })
        //        .ConfigureLogging((hostingContext,logging)=> 
        //        {
        //            logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
        //            logging.AddConsole();
        //            logging.AddDebug();
        //        })
        //        .UseIISIntegration()
        //        .UseDefaultServiceProvider((context, options) =>
        //        {
        //            options.ValidateScopes = context.HostingEnvironment.IsDevelopment();
        //        });
        //    return builder;
        //}
    }
}
