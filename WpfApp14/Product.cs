namespace WpfApp14
{
    public enum ProdCathegorys
    {
        Lena,
        Gena
    }
    public class Product
    {
        public string ProdName { get; set; }
        public decimal ProdPrice { get; set; }
        public string ProdImage { get; set; }
        public ProdCathegorys ProdCathegory { get; set; }
    }
}