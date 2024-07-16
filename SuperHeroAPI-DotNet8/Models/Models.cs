namespace SuperHeroAPI_DotNet8.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public float Price { get; set; }
    }

    public class Recipe
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
        public List<RecipeIngredient> Ingredients { get; set; }
    }

    public class RecipeIngredient
    {
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int Quantity { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> Items { get; set; }
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int? IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int? RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int Quantity { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

}
