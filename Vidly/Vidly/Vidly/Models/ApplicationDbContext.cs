namespace Vidly.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationDbContext : DbContext
    {
        // Контекст настроен для использования строки подключения "ApplicationDbContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Vidly.Models.ApplicationDbContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ApplicationDbContext" 
        // в файле конфигурации приложения.

        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; } 
        public DbSet<Genre> Genres { get; set; }
        
    }
   public class MyContextInitialize:DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            Genre g1 = new Genre {  GenreType="Comedy" };
            Genre g2 = new Genre { GenreType = "Action" };
            Genre g3 = new Genre { GenreType = "Thriller" };
            Genre g4 = new Genre { GenreType = "Cartoon" };
            Genre g5 = new Genre { GenreType = "TV Series" };

            MemberShip ms1 = new MemberShip { MemberShipType = "Month", PercentCount = 5 };
            MemberShip ms2 = new MemberShip { MemberShipType = "Half Year", PercentCount = 10 };
            MemberShip ms3 = new MemberShip { MemberShipType = "Year", PercentCount = 15 };

            Movies m1 = new Movies { Name = "Shrek", GenreId = g4.Id, Detail = "Very interesting movies.Recommend for children." };
            


            base.Seed(context);
        }
    }

}