using Northwind.ConsoleApp.Services;
using Northwind.Writers;
using NorthWind.Entities.Interfaces;

IUserActionWriter Writer = new DebugWriter();
AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application started.");
ProductService Service = new ProductService(Writer);
Service.Add("Demo", "Azucar refinada");