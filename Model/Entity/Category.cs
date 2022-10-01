namespace Tz_HTT.Model.Entity;

public class Category
{
    public int Id { get; set; } 
    public string NameCategory { get; set; } = string.Empty;
    public int ProductId { get; set; }
    public IEnumerable<Product> Product { get; set; }
}
