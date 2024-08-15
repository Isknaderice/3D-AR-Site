var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddRazorPages(); // Закомментируйте или удалите эту строку

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseDefaultFiles();  // Добавлено для использования index.html по умолчанию
app.UseStaticFiles();

app.UseRouting();

// app.UseAuthorization(); // Уберите эту строку, если не используете авторизацию

// app.MapRazorPages(); // Закомментируйте или удалите эту строку

app.MapFallbackToFile("index.html");  // Эта строка указывает на использование вашего index.html по умолчанию

app.Run();
