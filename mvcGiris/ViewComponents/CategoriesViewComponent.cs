using mvcGiris.Models;
using Microsoft.AspNetCore.Mvc;
using mvcTic.business.Abstract;
// using mvcGiris.Data;

namespace mvcGiris.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {

        private ICategoryService _categoryService;

        public CategoriesViewComponent(ICategoryService categoryService)
        {
            this._categoryService  = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory=RouteData?.Values["id"];
            return View(_categoryService.GetAll());

            //Kategoriler artık CategoryRepository'de oluşturduğumuz için bu kısma gerek kalmadı
            // var categories = new List<Category>()
            // {
            //     new Category{Name="Telefon", Description="Cep Telefonları"},
            //     new Category{Name="Bilgisayar", Description="Windows İş Bilgisayarları"},
            //     new Category{Name="Elektronik", Description="Elektronik Ev Aletleri"}
            // };
            // return View(categories);
            
            //Burada seçili kategorinin hangisini aldık daha sonra default.cshtml dosyasında class'a aşağıdaki eklemeyi yaparak
            // @(ViewBag.SelectedCategory==@Categories.CategoryId.ToString()?"active":"")">@Categories.Name
            //seçili kategorinin mavi görünmesini sağladık

            // ViewBag.SelectedCategory = RouteData?.Values["id"];
            // return View(CategoryRepository.Categories);
            // return View();
            //CategoryRepository yazınca altı kırmızı çizili, ctrl+nokta yap yolu seç
        }
    }
}