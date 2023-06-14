using Microsoft.EntityFrameworkCore;
using mvcGiris.entity;

namespace mvcTic.data.Concrete.EFCore
{
    public static class SeedDatabase
    {
        //projeyi canlıya aldığımızda kullanmayıp, sadece test verisi olarak kullanacağımız için static
        public static void Seed()
        {
            var context = new mvcTicContext();

            if(context.Database.GetPendingMigrations().Count()==0)
            {
                //databaseimizde bekleyen migration varsa bu işlemleri yapma

                if(context.Categories.Count()==0)
                {
                    //eğer datebaseimde kategori yoksa aşağıdaki verileri ekle
                    context.Categories.AddRange(Categories);
                }

                if(context.Products.Count()==0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                }
            }
                context.SaveChanges();           
        }

        private static Category[] Categories=
        {
            new Category(){Name ="Telefon"},
            new Category(){Name="Bilgisayar"},
            new Category(){Name="Elektronik"}
        };

        private static Product[] Products=
        {
            new Product() {Name="Iphone 5s", Price=5000, imgLink="kırmızı_iphone.jpg",Description="apple telefon", IsApproved=true},
            new Product() {Name="Iphone 6s", Price=6000, imgLink="kırmızı_iphone.jpg",Description="apple telefon",IsApproved=true},
            new Product() {Name="Iphone 4s", Price=7000, imgLink="kırmızı_iphone.jpg",Description="telefon",IsApproved=false},
            new Product() {Name="Huwai Matebook", Price=15000, imgLink="kırmızı_iphone.jpg",Description="windows pc",IsApproved=false}
        };
        //projeyi çalıştırdığmızda çalışması için startupa ekleme yapacağız

        private static ProductCategory[] ProductCategories={
            new ProductCategory(){Product=Products[0], Category=Categories[0]},
            new ProductCategory(){Product=Products[0], Category=Categories[2]},
            new ProductCategory(){Product=Products[1], Category=Categories[0]},
            new ProductCategory(){Product=Products[1], Category=Categories[2]},
            new ProductCategory(){Product=Products[2], Category=Categories[0]},
            new ProductCategory(){Product=Products[2], Category=Categories[2]},
            new ProductCategory(){Product=Products[3], Category=Categories[1]},
            new ProductCategory(){Product=Products[3], Category=Categories[2]}

        };
    }
}