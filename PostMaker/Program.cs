using BLL.Abstract;
using BLL.Concrete;
using DAL.Abstract;
using DAL.Concrete;


var builder = WebApplication.CreateBuilder(args);

/*builder.Host.ConfigureWebHostDefaults(webBuilder =>
{
    webBuilder.UseStartup<Startup>();
});*/

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddMvcCore();
builder.Services.AddControllers();
//builder.Services.AddScoped<Startup>();
//adaugat:
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IPostRepository, PostRepository>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
//app.UseMvc();
app.MapControllers();

app.MapRazorPages();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.Run();
