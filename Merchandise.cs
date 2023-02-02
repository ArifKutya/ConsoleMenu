class Merchandise
{
    public int Id { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public string Category { get; set; }

    public Merchandise(int id, int price, int quantity, string category)
    {
        Id = id;
        Price = price;
        Quantity = quantity;
        Category = category;
    }
}