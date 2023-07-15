namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            //builder.Services.AddApplication();
#warning pass connection string into a constant in common lib
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            //builder.Services.AddInfrastructure(connectionString);


            builder.Services.AddSwaggerDocument(settings =>
            {
                settings.Title = "CustomerManagementApi";
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.Run();
        }
    }
}