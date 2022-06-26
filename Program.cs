var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");
// app.MapControllerRoute(
//     name: "auth",
//     pattern: "auth/{action=Login}",
//     defaults: new { controller = "Auth", action = "Login" });
// app.MapControllerRoute(
//     name: "auth",
//     pattern: "auth/{action=Register}",
//     defaults: new { controller = "Auth", action = "Register" });
// app.MapControllerRoute(
//     name: "user",
//     pattern: "user/{id?}",
//     defaults: new { controller = "User", action = "Index" });
app.MapControllerRoute(
    name: "post",
    pattern: "post/{id?}",
    defaults: new { controller = "Post", action = "Index" });
app.MapControllerRoute(
    name: "create",
    pattern: "create",
    defaults: new { controller = "Create", action = "Index" }
);
// pattern: "{controller=User}/{action=Index}/{id?}");

app.Run();
