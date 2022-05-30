var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

//*Startup
//.NET 6`da Startup.cs fayli yoxdur.Servis ve middleware konfigurasiyalarinin mesulliyeti Program.cs faylina buraxilib.

//*Top Level Statements
//Asp.Net 6`da Main metodu ozelligi var yeni sanki main icinde is gorur.Namespace falan yoxdur.Koda odaklidi.

//*WebApplicationBuilder--> .Net5 deki IHostBuilderin evezinedir.
//*WebApplication: Builder nesnesini yaratmak ucun .Net 6 da var..Net 5 deki Host sinifinin qarsiligidir.

//*Port
//.Net 6dan once appler 5001 de ayaga qalxirdi indi ferqli portlarda ayaga qalxacaq