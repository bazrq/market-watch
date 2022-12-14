using DataService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc(); //Adds basic MVC functionality
builder.Services.AddControllers(); //Adds support for MVC controllers (views and routing would need to be added separately)
builder.Services.AddLogging(); //Adds default logging support
builder.Services.AddSignalR(); //Adds support for SignalR

builder.Services.AddAntiforgery(options =>
{
    options.FormFieldName = "AntiforgeryFieldname";
    options.HeaderName = "X-CSRF-TOKEN-HEADERNAME";
});
builder.Services.AddSwaggerGen(c =>
{
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});


builder.Services.AddTransient<MainService, MainService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
