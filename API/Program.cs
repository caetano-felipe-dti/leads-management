using Application.Handlers.GetLeads;
using Infra;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetLeadsHandler).Assembly));


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); 

app.UseRouting();
app.UseCors("AllowAll");
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();


app.Run();