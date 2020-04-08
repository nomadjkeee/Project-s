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
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
   
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}