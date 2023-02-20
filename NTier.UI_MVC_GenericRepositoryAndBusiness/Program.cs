var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
// *IoC container for ConnectionStrings
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConStr"));
});
// * Access\Repositories Injection
builder.Services.AddTransient<IPersonRepository, PersonRepository>();
builder.Services.AddTransient<ITweetRepository, TweetRepository>();
// * Business\Services Injection
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<ITweetService, TweetService>();
// Configure the HTTP request pipeline.
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Person}/{action=Index}/{id?}");
app.Run();
