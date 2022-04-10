using MongoRL.Interfaces;
using MongoRL.Repo;
using MongoRL.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddMongoDbSettings(builder.Configuration);
builder.Services.AddSingleton<IStudentDAL, StudentDAL>();
builder.Services.AddSingleton<ISchoolsDAL, SchoolsDAL>();


var app = builder.Build();



// Configure the HTTP request pipeline.
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
    pattern: "{controller=Mongo}/{action=Students}/{id?}");

app.Run();
