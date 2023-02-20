namespace BicAuto.Models;

public class DbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        BicAutoDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BicAutoDbContext>();

        if (!context.Categories.Any())
        {
            context.Categories.AddRange(Categories.Select(c => c.Value));
        }

        if (!context.Autos.Any())
        {
            context.AddRange
            (
                new Auto { Name = "Dacia", Price = 22.95M, Model = "Logan", Features = "Full, fara piele, test pt id nr 1.", Category = Categories["Autoturism"], ImageUrl = "https://cdn.motor1.com/images/mgl/EYzZR/s2/2012-333748-2013-dacia-logan-leaked-photo-low-res-17-9-20121.jpg", InStock = true, IsAutoOfTheYear = true, ImageThumbnailUrl = "https://cdn.motor1.com/images/mgl/EYzZR/s2/2012-333748-2013-dacia-logan-leaked-photo-low-res-17-9-20121.jpg", FabricationDate = "2018" },
                new Auto { Name = "Bmw", Price = 19.95M, Model = "Seria 3", Features = "Leather, Blue color, Xdrive, black interior", Category = Categories["Autoturism"], ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/8d/BMW_G20_IMG_0167.jpg", InStock = true, IsAutoOfTheYear = false, ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/8/8d/BMW_G20_IMG_0167.jpg", FabricationDate = "2020" },
                new Auto { Name = "Renault", Price = 21.95M, Model = "Laguna", Features = "Full transformed to racing", Category = Categories["Autoturism"], ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/Renault_Laguna_Coup%C3%A9_Monaco_GP_dCi_150_%28III%29_%E2%80%93_Frontansicht%2C_7._Mai_2011%2C_D%C3%BCsseldorf.jpg/1920px-Renault_Laguna_Coup%C3%A9_Monaco_GP_dCi_150_%28III%29_%E2%80%93_Frontansicht%2C_7._Mai_2011%2C_D%C3%BCsseldorf.jpg", InStock = true, IsAutoOfTheYear = false, ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/Renault_Laguna_Coup%C3%A9_Monaco_GP_dCi_150_%28III%29_%E2%80%93_Frontansicht%2C_7._Mai_2011%2C_D%C3%BCsseldorf.jpg/1920px-Renault_Laguna_Coup%C3%A9_Monaco_GP_dCi_150_%28III%29_%E2%80%93_Frontansicht%2C_7._Mai_2011%2C_D%C3%BCsseldorf.jpg", FabricationDate = "2018" },
                new Auto { Name = "Volvo", Price = 21.95M, Model = "XC90", Features = "7 seats, familly car, leather, worm steeringweel", Category = Categories["Autoturism"], ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/2018_Volvo_XC90_2.0.jpg/1920px-2018_Volvo_XC90_2.0.jpg", InStock = true, IsAutoOfTheYear = false, ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/2018_Volvo_XC90_2.0.jpg/1920px-2018_Volvo_XC90_2.0.jpg", FabricationDate = "2015" },
                new Auto { Name = "Mercedes", Price = 29.95M, Model = "C220", Features = "White leather, full option", Category = Categories["Autoturism"], ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/52/Mercedes-Benz_C_200_Avantgarde_%28W_205%29_%E2%80%93_Frontansicht%2C_26._April_2014%2C_D%C3%BCsseldorf.jpg", InStock = true, IsAutoOfTheYear = false, ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/5/52/Mercedes-Benz_C_200_Avantgarde_%28W_205%29_%E2%80%93_Frontansicht%2C_26._April_2014%2C_D%C3%BCsseldorf.jpg", FabricationDate = "2016" }
                );
        }

        context.SaveChanges();
    }

    private static Dictionary<string, Category>? categories;

    public static Dictionary<string, Category> Categories
    {
        get
        {
            if (categories == null)
            {
                var genresList = new Category[]
                {
                    new Category { CategoryName = "Autoturism" },
                    new Category { CategoryName = "Transport Marfa"},
                    new Category { CategoryName = "Transport Persoane"},
                };

                categories = new Dictionary<string, Category>();

                foreach (Category genre in genresList)
                {
                    categories.Add(genre.CategoryName, genre);
                }
            }

            return categories;
        }
    }
}

