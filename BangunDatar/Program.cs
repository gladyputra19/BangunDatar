using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BangunDatar
{
    

        class Program
        {

            static void Main(string[] args)
            {
            Menu:
            Console.WriteLine("Menu");
            Console.WriteLine("=================");
            Console.WriteLine("Choose Figure :");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Circle");
            Console.WriteLine("5. Trapezoid");

            int pilihan = Convert.ToInt16(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("Input Square Side : ");
                    Square a = new Square();
                    a.setSide(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("The Square Area Is : " + a.area());
                    Console.WriteLine("The Square Perimeter Is : " + a.Perimeter());
                    break;

                case 2:
                    Console.WriteLine("Input Rectangle Width : ");
                    Rectangle b = new Rectangle();
                    b.setWidth(Convert.ToInt16(Console.ReadLine()));
                    Console.WriteLine("Input Rectangle Height : ");
                    b.setHeight(Convert.ToInt16(Console.ReadLine()));
                    Console.WriteLine("The Rectangle Area Is : " + b.area());
                    Console.WriteLine("The Rectangle Perimeter Is : " + b.perimeter());
                    break;
                case 3:
                    Console.WriteLine("Input Triangle Base : ");
                    Triangle c = new Triangle();
                    c.setBased(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Input Triangle Height : ");
                    c.setHeight(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Input Triangle Side A : ");
                    c.setSideA(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Input Triangle Side B : ");
                    c.setSideB(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("The Triangle Area is : "+c.area());
                    Console.WriteLine("The Triangle Perimeter is : " + c.perimeter());
                    break;
                case 4:
                    Console.WriteLine("Input circle Side : ");
                    circle d = new circle();
                    d.setRadius(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("The Circle Area Is : " + d.area());
                    Console.WriteLine("The Circle Perimeter Is : " + d.perimeter());
                    break;
                case 5:
                    Trapezoid e = new Trapezoid();
                    Console.WriteLine("Please Insert Trapezoid Base A : ");
                    e.baseA = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please Insert Trapezoid Base B : ");
                    e.baseB = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please Insert Trapezoid Height : ");
                    e.height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please Insert Trapezoid Side : ");
                    e.side = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The Area of This Trapezoid is : " + e.area());
                    Console.WriteLine("The Perimeter of this Trapezoid is : " + e.perimeter());
                    break;
                default:
                    Console.WriteLine("Please Input Within Option !");
                    goto Menu;
                    break;
            }
            }
        }
    }



