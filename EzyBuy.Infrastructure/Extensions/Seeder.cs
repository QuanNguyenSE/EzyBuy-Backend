using EzyBuy.Domain.Models;
using EzyBuy.Infrastructure.Data;

namespace EzyBuy.Infrastructure.Extensions;

internal class Seeder(ApplicationDbContext db) : ISeeder
{
	public async Task SeedAsync()
	{
		if (!db.Products.Any())
		{
			var categories = GetCategories();
			var brands = GetBrands();
			var products = GetProducts();
			db.Categories.AddRange(categories);
			await db.SaveChangesAsync();
			db.Brands.AddRange(brands);
			await db.SaveChangesAsync();
			db.Products.AddRange(products);
			await db.SaveChangesAsync();
		}
	}

	private IEnumerable<Product> GetProducts()
	{
		var products = new List<Product>
		{
			new Product
			{
				Name = "Wanderer Black Hiking Boots",
				Description = "Daybird's Wanderer Hiking Boots in sleek black...",
				Price = 109.99m,
				PictureFile = "1",
				CategoryId = 1, // Footwear
				BrandId = 1     // Daybird
			},
			new Product
			{
				Name = "Summit Pro Harness",
				Description = "Conquer new heights with the Summit Pro Harness...",
				Price = 89.99m,
				PictureFile = "2",
				CategoryId = 2, // Climbing
				BrandId = 2     // Gravitator
			},
			new Product
			{
				Name = "Alpine Fusion Goggles",
				Description = "Enhance your skiing experience with the Alpine Fusion Goggles...",
				Price = 79.99m,
				PictureFile = "3",
				CategoryId = 3, // Ski/boarding
				BrandId = 3     // WildRunner
			},
			new Product
			{
				Name = "Expedition Backpack",
				Description = "The Expedition Backpack by Quester is a must-have...",
				Price = 129.99m,
				PictureFile = "4",
				CategoryId = 4, // Bags
				BrandId = 4     // Quester
			},
			new Product
			{
				Name = "Blizzard Rider Snowboard",
				Description = "Get ready to ride the slopes with the Blizzard Rider Snowboard...",
				Price = 299.99m,
				PictureFile = "5",
				CategoryId = 3, // Ski/boarding
				BrandId = 5     // B&R
			},
			new Product
			{
				Name = "Carbon Fiber Trekking Poles",
				Description = "The Carbon Fiber Trekking Poles by Raptor Elite...",
				Price = 69.99m,
				PictureFile = "6",
				CategoryId = 5, // Trekking
				BrandId = 6     // Raptor Elite
			},
			new Product
			{
				Name = "Explorer 45L Backpack",
				Description = "The Explorer 45L Backpack by Solstix...",
				Price = 149.99m,
				PictureFile = "7",
				CategoryId = 4, // Bags
				BrandId = 7     // Solstix
			},
			new Product
			{
				Name = "Frostbite Insulated Jacket",
				Description = "Stay warm and stylish with the Frostbite Insulated Jacket...",
				Price = 179.99m,
				PictureFile = "8",
				CategoryId = 6, // Jackets
				BrandId = 8     // Grolltex
			},
			new Product
			{
				Name = "VenturePro GPS Watch",
				Description = "Navigate with confidence using the VenturePro GPS Watch...",
				Price = 199.99m,
				PictureFile = "9",
				CategoryId = 7, // Navigation
				BrandId = 9     // AirStrider
			},
			new Product
			{
				Name = "Trailblazer Bike Helmet",
				Description = "Stay safe on your cycling adventures with the Trailblazer Bike Helmet...",
				Price = 59.99m,
				PictureFile = "10",
				CategoryId = 8, // Cycling
				BrandId = 10    // Green Equipment
			}
		};
		return products;
	}

	private IEnumerable<Brand> GetBrands()
	{
		var brands = new List<Brand>
		{
			new Brand { Name = "Daybird" },
			new Brand { Name = "Gravitator" },
			new Brand { Name = "WildRunner" },
			new Brand { Name = "Quester" },
			new Brand { Name = "B&R" },
			new Brand { Name = "Raptor Elite" },
			new Brand { Name = "Solstix" },
			new Brand { Name = "Grolltex" },
			new Brand { Name = "AirStrider" },
			new Brand { Name = "Green Equipment" },
			new Brand { Name = "Legend" },
			new Brand { Name = "Zephyr" },
			new Brand { Name = "XE" },
			new Brand { Name = "Raptor Elite" },
			new Brand { Name = "Solstix" },
			new Brand { Name = "Gravitator" }
		};

		return brands;
	}

	private IEnumerable<Category> GetCategories()
	{
		var categories = new List<Category>
		{
			new Category { Name = "Footwear" },
			new Category { Name = "Climbing" },
			new Category { Name = "Ski/boarding" },
			new Category { Name = "Bags" },
			new Category { Name = "Trekking" },
			new Category { Name = "Jackets" },
			new Category { Name = "Navigation" },
			new Category { Name = "Cycling" },
			new Category { Name = "Camping" },
			new Category { Name = "Headlamps" }
		};

		return categories;
	}

}
