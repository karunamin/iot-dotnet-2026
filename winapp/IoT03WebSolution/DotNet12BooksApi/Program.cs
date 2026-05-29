using Microsoft.OpenApi.Models;

namespace DotNet12BooksApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // ----------------------------------------------------
            // [수정 1] 서비스 컨테이너에 OpenAPI(Swagger) 기능 등록
            // ----------------------------------------------------
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            else
            {
                // ----------------------------------------------------
                // [수정 2] 개발(Development) 환경일 때 Swagger 미들웨어 켜기
                // ----------------------------------------------------
                app.UseSwagger();

                // [수정 3] 만약 주소창에 /openapi/v1.json 경로를 고정하고 싶다면 아래와 같이 설정합니다.
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                    // 만약 브라우저에서 'https://localhost:7002/swagger'로 접속하고 싶다면 이대로 둡니다.
                });
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
