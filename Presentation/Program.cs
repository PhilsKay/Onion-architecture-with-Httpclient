using Onion_architecture.Infrastructure.FinanceAPI;
using Onion_architecture.Infrastructure.RecipesAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient("Finance-news",option =>
{
    option.BaseAddress = new Uri("https://api.apilayer.com/");
    option.DefaultRequestHeaders.Add("apikey", builder.Configuration["FinanceApiKey"]);
});

builder.Services.AddTransient<IFinanceNews, FinanceNewsService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
