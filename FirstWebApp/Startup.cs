using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// File nay gom 2 pthuc Configure() va ConfigureServices()
///    + ConfigureServices(): co the nhan vao 1 tham so la IServiceCollection de register mot so thu va su dung cac instance cua cac
/// ServiceCollection da duoc dang ky.
///    + Configure(): nhan vao 2 tham so la: 
///        * IApplicationBuilder: chinh la the hien cua Application de cau hinh RequestPipeline.
///        * IWebHostEnvironment: de chi ra moi truong chung ta dang hoat dong la moi truong nao.
/// </summary>

namespace FirstWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //DUNG SERVICE NAO ADD VAO DAY
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); //add framework MVC vào ứng dụng
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        
        //DUNG MIDDLEWARE NAO ADD VAO DAY
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //neu mtruong dang hdong la Development thi se cau hinh middleware la DeveloperExceptionPage(), nghia la neu
            //mtruong Development thi se hien thi loi khong than thien, tuc la loi chi tiet ve code, con doi voi khong phai
            //mtruong Development thi chung ta se khong bat cai nay.
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //day la 1 middleware da duoc xd san, middleware dung extension method viet ra ngoai
            }

            app.UseRouting();

            //day cung la 1 middleware goi la inline middleware, no se viet thang trong nay. Middleware nay can thiep 
            //vao response tra ve va write ra dong chu "Hello World!"

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
