// using mvcGiris.Models;

// namespace mvcGiris.Data
// {
//     public static class CategoryRepository
//     {
//         private static List<Category>? _categories = null;

//         static CategoryRepository()
//         {
//             _categories = new List<Category>
//             {
//                 new Category{CategoryId=1, Name="Telefon",Description="Tüm telefonlar", imgLink="~/img/cSharp.png"},
//                 new Category{CategoryId=2, Name="Bilgisayar",Description="Tüm bilgisayarlar", imgLink="~/img/cSharp.png"},
//                 new Category{CategoryId=3, Name="Elektronik",Description="Elektronik Ekipmanları", imgLink="~/img/cSharp.png"},
//                 new Category{CategoryId=4, Name="Beyaz Eşya",Description="Ev Araçları", imgLink="~/img/cSharp.png"}
//             };
//         }

//         public static List<Category>? Categories
//         {
//             get
//             {
//                 return _categories;
//             }
//         }

//         public static void AddProduct(Category category)
//         {
//             _categories.Add(category);
//         }

//         public static Category GetCategoryById(int id)
//         {
//             return _categories.FirstOrDefault(p=>p.CategoryId==id);
//         }
//     }
// }
