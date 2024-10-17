using CodeFirstWPF.DataModel;
using System;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstWPF
{
    public class ContextDB : DbContext
    {
        // Контекст настроен для использования строки подключения "ContextDB" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "CodeFirstWPF.ContextDB" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ContextDB" 
        // в файле конфигурации приложения.
        public ContextDB()
            : base("name=ContextDB")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Employees> Employees { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}