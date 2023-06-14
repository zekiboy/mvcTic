// using mvcGiris.Models;

// namespace mvcGiris.Data
// {
//     public static class ProductRepository
//     {
//         private static List<Product>? _products = null;

//         static ProductRepository()
//         {
//             _products = new List<Product>
//             {
//                 new Product{ProductId=1, Name="Iphone 5",Price=6000, Description="Telefon", imgLink="cSharp.png",CategoryId=1},
//                 new Product{ProductId=2, Name="Iphone 5s",Price=8000,Description="Telefon", imgLink="js.png",CategoryId=1},
//                 new Product{ProductId=3, Name="Huwai M16 Matebook",Price=19000,Description="Bilgisayar", imgLink="cSharp.png",CategoryId=2},
//                 new Product{ProductId=4, Name="Apple Macbook Pro",Price=26000,Description="Bilgisayar", imgLink="cSharp.png",CategoryId=2},
//             };
//         }

//         public static List<Product>? Products
//         {
//             get
//             {
//                 return _products;
//             }
//         }

//         public static void AddProduct(Product product)
//         {
//             _products.Add(product);
//         }

//         public static Product GetProductById(int id)
//         {
//             return _products.FirstOrDefault(p=>p.ProductId==id);
//         }

//         public static void EditProduct(Product product)
//         {
//             foreach (var p in _products)
//             {
//                 if(p.ProductId == product.ProductId)
//                 {
//                     p.Name=product.Name;
//                     p.Price=product.Price;
//                     p.Description=product.Description;
//                     p.imgLink=product.imgLink;
                
//                 }
//             }
//         }

//         public static void DeleteProduct(Product product)
//         {
//             foreach (var p in _products)
//             {
//                 if(p.ProductId == product.ProductId)
//                 {
//                     var db =ProductRepository.Products;
//                     db.Remove(p);
//                     break;
                    
//                 }
//             }
//         }

//     }
// }
