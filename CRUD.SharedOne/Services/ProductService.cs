using CRUD.SharedOne.Models;

namespace CRUD.Services;

public class ProductService
{
    List<Game>products= new List<Game>();

    public ProductService()
    {
        
    }

    public List<Game> GetProducts() { 
        return products; 
    }

    public void AddProduct(Game product){
        products.Add(product);
    }
    public void UpdateProduct(Game product) {
      var existingProduct=  products.FirstOrDefault(p=> p.Id == product.Id);
        if (existingProduct != null)
        {
            existingProduct.Name = product.Name;
          //  existingProduct.Price= product.Price;
            
        }
    }
    public void DeleteProduct(int productId){
        products.RemoveAll(p=> p.Id == productId);
    }
}
