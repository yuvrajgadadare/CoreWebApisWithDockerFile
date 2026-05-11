namespace CoreWebApisWithDockerFile.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Rate { get; set; }
        public float Gst { get; set; }
        public int StockQuantity { get; set; }
    }
}
