using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace телефонный_справочник
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new NumberBook();

            List<NumberBook> mylistContact = new List<NumberBook>();



            Console.WriteLine("Выберите действие");

            Console.WriteLine("Добавление контакта: 0");

            Console.WriteLine("Удаление контакта: 1");

            Console.WriteLine("Поиск контакта: 2");


        }
    }
    public class WorkBook
    {
        static void UserMode ()
        {
            switch ((ActivPhone) int.Parse(Console.ReadLine()))
            {
                case ActivPhone.AddToContact :
                    {
                        Person per = new Person();
                        Console.WriteLine("Создание нового элемента справочника");
                        Console.WriteLine("Введите номер абонента");
                        per.Number = Console.ReadLine();
                        Console.WriteLine("Введите имя абонента");
                        per.Name = Console.ReadLine();
                        
                    }
            }
        }
    }
        
    enum ActivPhone
    {
        AddToContact = 0,

        DelToContact = 1,

        LoockToContact = 2,

    }
    public class Person
    {
        public string Name { get; set; }

        public string  Number /*Number*/ { get; set; }

        //public override string ToString()
        //{
        //    return string.Format("Name {0} Number {1} ", Name, Number);
        //}
    }
    public class Number
    {
        public string Numbers { get; set; }
    }
    public class NumberBook : DbContext
    {
        public NumberBook() : base("NomberBook")
        {

        }

        static NumberBook()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<NumberBook>());
        }
        public DbSet<Person> people { get; set; }

        public DbSet<Number> numbers { get; set; }
    }
    public class AddNomber
    {

    }
}
