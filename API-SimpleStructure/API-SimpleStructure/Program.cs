using Implimentation.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddImplimentation(builder.Configuration);
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

}

var app = builder.Build();
{
  
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    //app.UseAuthorization();
    app.MapControllers();
    app.Run();
}

