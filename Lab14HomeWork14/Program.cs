using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14HomeWork14
{
    class Program
    {
        static void Main(string[] args)
        {//Ввод данных
            Console.Write("Введите имя кошки:");
            string catName = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите имя собаки:");
            string dogName = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
         //Вывод ответа
            Cat cat = new Cat(catName);
            cat.ShowInfo();
            Console.WriteLine();
            Dog dog = new Dog(dogName);
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal //Абстрактный класс
    {
        public abstract string Name { get; set; } //Абстракное свойство имя
        public Animal(string name) //Конструктор
        { Name = name; }
        public abstract string Say(); // Абстрактный метод
        public void ShowInfo() // Не абстрактный метод
        {
            Console.WriteLine("Имя животного - {0}", Name);
            Console.WriteLine("Издаваемый звук - {0}", Say());
        }
    }
    class Cat : Animal      //Дочерний класс
    {
        private string name; // Поле имя
        public override string Name // Свойство имя
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    name = "Кошка";
                }
                else
                {
                    name = value;
                }

            }
        }
        //Конструктор переопределяем
        public Cat(string name)
            : base(name)
        {
        }
        public override string Say()// Переопределение имени
        { return "Мяу "; }
    }
    class Dog : Animal
    {
        private string name; // Поле имя
        public override string Name // Свойство имя
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    name = "Собака"; // Имя по умолчанию
                }
                else
                {
                    name = value;
                }

            }
        }
        //Конструктор переопределяем
        public Dog(string name)
            : base(name)
        {
        }
        public override string Say()// Переопределение имени
        { return "Гав "; }
    }
}
