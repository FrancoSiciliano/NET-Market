using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities;

public class Product : BaseClass
{
    
    public string Description { get; set; }

    public int Stock { get; set; }
    
    public int TrademarkId { get; set; }

    public Trademark Trademark { get; set; }
    
    public int CategoryId { get; set; }
    
    public Category Category { get; set; }
    
    public decimal Price { get; set; }
    
    public string Image { get; set; }
    
}