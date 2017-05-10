using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Model;

namespace LadaSedan
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Создаём машину
            Car car1 = new Car("Лада", Categories.D);
            car1.CarColor = Color.Purple;

            //Первый раз пытаемся вывести водителя у машины
            try
            {
                Console.WriteLine("Попытка вывести водителя машины...");
                Console.WriteLine(car1.CarPassport.Owner.Name);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("У машины ещё нет водителя!");
            }
            
            //Создаём водителя
            Driver driver1 = new Driver("Вольдемар", Convert.ToDateTime("01.01.2000"));
            driver1.CategoriesDr = new List<Categories> { Categories.B, Categories.C };

            //Первый раз пытаемся присвоить водителя
            try
            {
                Console.WriteLine("\nПопытка присвоить водителя машине...");
                car1.ChangeOwner("M666MM", driver1);
                Console.WriteLine("Водитель присвоен машине.");
            }
            //Можно но в данный момент не нужно)
            //catch(NullReferenceException)
            //{
            //    Console.WriteLine("Возможно, вы не ввели категорию водителю");
            //}
            //catch(ArgumentOutOfRangeException)
            //{
            //    Console.WriteLine("Возможно, вы не создали водителя");
            //}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Добовляем Вольдемару категорию D и пробуем сменить водителя лады ещё раз
            driver1.CategoriesDr.Add(Categories.D);
            try
            {
                Console.WriteLine("\nПопытка присвоить водителя машине...");
                car1.ChangeOwner("M666MM", driver1);
                Console.WriteLine("Водитель присвоен машине.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Выводим номер машины Вольдемара
            try
            {
                Console.WriteLine("\nПопытка вывести номер машины Вольдемара...");
                Console.WriteLine("Номер машины Вольдемара: " + driver1.Car.CarNumber);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("У Вольдемара нет машины");
            }

            //Выводим имя владельца Лады
            try
            {
                Console.WriteLine("\nПопытка вывести имя владельца Лады...");
                Console.WriteLine("Имя владельца Лады: " + car1.CarPassport.Owner.Name);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("У Лады нет владельца");
            }

            Console.ReadLine();
        }         
    }
}
