namespace Tz_HTT.Model.Entity;

/// <summary>
/// Категория товара
/// </summary>
public class Category
{
    /// <summary>
    /// Id категории
    /// </summary>
    public int Id { get; set; } 

    /// <summary>
    /// Название категории
    /// </summary>
    public string NameCategory { get; set; } = string.Empty;

    /// <summary>
    /// Ключ
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Навигационное свойство
    /// </summary>
    public IEnumerable<Product> Product { get; set; }
}
