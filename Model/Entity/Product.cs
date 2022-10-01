
/// <summary>
/// Товар
/// </summary>
public class Product
{
    /// <summary>
    /// Id товара
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Название товара
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Цена товара
    /// </summary>
    public decimal Price { get; set; } 

    /// <summary>
    /// Ключ
    /// </summary>
    public int CategoryId { get; set; }

    /// <summary>
    /// Навигационное свойство
    /// </summary>
    public Category Category { get; set; }
}
