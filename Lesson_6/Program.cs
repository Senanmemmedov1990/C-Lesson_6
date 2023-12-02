using System;

namespace Lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomCollection<Employee> employees = new CustomCollection<Employee>();

            bool continueProgram = true;
            while (continueProgram)
            {
                Console.Clear();
                Console.WriteLine("Employee Idareetme Sistemi");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Employee elave et");
                Console.WriteLine("2. Employee tap");
                Console.WriteLine("3. Butun Employee goster");
                Console.WriteLine();
                Console.Write("Secimleri daxil et: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee(employees);
                        break;
                    case "2":
                        FindEmployee(employees);
                        break;
                    case "3":
                        ShowAllEmployees(employees);
                        break;
                    default:
                        Console.WriteLine("Xahis edirem bu reqemleri yazin (1, 2, or 3).");
                        break;
                }

                Console.WriteLine();
                Console.Write("Davam etmek isteyirsinizmi? (beli/xeyr): ");
                string continueInput = Console.ReadLine();
                continueProgram = continueInput.ToLower() == "beli";
            }

            Console.WriteLine("Employee sisteminden istifade etdiyiniz ucun tesekkur edirik!");
            Console.ReadKey();
        }



        static void AddEmployee(CustomCollection<Employee> employees)
        {
            Console.Write("Adinizi daxil edin: ");
            string firstName = Console.ReadLine();

            Console.Write("Soyadinizi daxil edin: ");
            string lastName = Console.ReadLine();

            Console.Write("Yasinizi daxil edin: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Emek haqqinizi daxil edin: ");
            double salary = double.Parse(Console.ReadLine());

            Employee employee = new Employee
            {
                Name = firstName,
                Surname = lastName,
                Age = age,
                Salary = salary
            };

            employees.Add(employee);
            Console.WriteLine("Employee ugurla elave olundu.");
        }




        static void FindEmployee(CustomCollection<Employee> employees)
        {
            Console.Write("Employee ID daxil edin: ");
            int id = int.Parse(Console.ReadLine());

            Employee employee = employees.FindById(id);

            if (employee != null)
            {
                Console.WriteLine("Employee found:");
                Console.WriteLine($"   ID: {employee.Id}");
                Console.WriteLine($"   Ad: {employee.Name}");
                Console.WriteLine($"   Soyad: {employee.Surname}");
                Console.WriteLine($"   Yas: {employee.Age}");
                Console.WriteLine($"   Emek haqqi: {employee.Salary}");
            }
            else
            {
                Console.WriteLine("Employee tapilmadi.");
            }
        }



        static void ShowAllEmployees(CustomCollection<Employee> employees)
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("Employee tapilmadi.");
            }
            else
            {
                Console.WriteLine("Employee listi:");
                Console.WriteLine("------------------------");

                foreach (var employee in employees)
                {
                    Console.WriteLine($"  ID: {employee.Id}");
                    Console.WriteLine($"  Ad: {employee.Name}");
                    Console.WriteLine($"  Soyad: {employee.Surname}");
                    Console.WriteLine($"  Yas: {employee.Age}");
                    Console.WriteLine($"  Emek haqqi: {employee.Salary}");
                    Console.WriteLine("------------------------");
                }
            }
        }



    }

    }

