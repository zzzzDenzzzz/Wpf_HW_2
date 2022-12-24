namespace Wpf_HW_2.Model
{
    public class ProductNode : INode
    {
        public ProductNode(Product product)
        {
            Product = product;
        }

        public Product Product { get; private set; }
        public string Name { get => Product.Name; }
    }
}
