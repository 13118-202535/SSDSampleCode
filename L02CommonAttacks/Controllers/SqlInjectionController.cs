using L02CommonAttacks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace L02CommonAttacks.Controllers
{
    public class SqlInjectionController : Controller
    {
        //https://localhost:7006/SqlInjection/VulnerableGetCarById?id=1
        //https://localhost:7006/SqlInjection/VulnerableGetCarById?id=0;DELETE%20FROM%20Car%20%20WHERE%20Id%20=%201%20OR%201%20=%201

        public IActionResult VulnerableGetCarById()
        {
            string connString = "Server=(localdb)\\mssqllocaldb;Database=SSD-L02CommonAttacks;Trusted_Connection=True;MultipleActiveResultSets=true";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM Car WHERE Id = {Request.Query["Id"]}", connection);

                using (var reader = command.ExecuteReader())
                {
                    Car foundCar = null;
                    if (reader.Read())
                    {
                        foundCar = new Car
                        {
                            Id = (int)reader["Id"],
                            Make = reader["Make"].ToString(),
                            Model = reader["Model"].ToString(),
                            Color = reader["Color"].ToString(),
                            Year = (int)reader["Year"]
                        };
                    }
                    else
                    {
                        return NotFound();
                    }
                    return View("VulnerableGetCarById", foundCar);
                }
            }
        }
    }
}
