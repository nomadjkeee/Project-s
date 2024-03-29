﻿namespace VidlyAuth.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataBaseContext : DbContext
    {
        // Контекст настроен для использования строки подключения "DataBaseContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "VidlyAuth.Model.DataBaseContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DataBaseContext" 
        // в файле конфигурации приложения.

        static DataBaseContext()
        {
            Database.SetInitializer(new DataBaseInitialize());
        }
        public DataBaseContext()
            : base("name=DataBaseContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rental> Rentals { get; set; } 
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}