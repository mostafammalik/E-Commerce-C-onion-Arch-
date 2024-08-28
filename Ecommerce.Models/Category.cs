using Ecommerce.Models;
using System;

public class Category
{
	public int Id { get; set; } 
	public string Name { get; set; }
	public ICollection<Product> Proucts = new HashSet<Product>();
}
