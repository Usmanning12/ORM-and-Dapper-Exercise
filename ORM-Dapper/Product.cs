namespace ORM_Dapper;

public class Product
{
    public Product()
    {
        
    }
    
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int CategoryId { get; set; }
    public int OnSale { get; set; }
    public string StockLevel { get; set; }
    
}