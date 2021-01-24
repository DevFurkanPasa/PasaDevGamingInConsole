using PasaDevGaming.ControlDatabase;
using PasaDevGaming.PasaDevPrograming;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace PasaDevGaming.Utilities
{
    public static class ControlToCustomers
    {
        static EdevletDatabase _edevletDatabase = new EdevletDatabase();
        static List<Customer> _customers = _edevletDatabase.ReturnOfCustomers();

        public static void StartControl()
        {
            for (int i = 0; i < 1; i--)
            {
                Console.Clear();
                Console.WriteLine("Kaydolmak için ---------------> 1'e");
                Console.WriteLine("Giriş yapmak için ------------> 2'ye");
                Console.WriteLine("Programı kapatmak için -------> 3'ye tıklayın.");
                try
                {
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result == 1)
                    {
                        Register();
                        Control();
                    }
                    else if (result == 2)
                    {
                        Control();
                    }
                    else if (result == 3)
                    {
                        i = 10;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen doğru sayıyı giriniz.");
                        Thread.Sleep(1500);
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Sistem bilinmedik bir hata ile karşılaştı!");
                    Thread.Sleep(1000);
                    Console.WriteLine("Sistem yeniden başlatılıyor!");
                    Thread.Sleep(1000);
                }
                
                
            }       
        }
        public static void Control()
        {
            bool control = false;
            Console.WriteLine("Tc kimlik numaranızı giriniz.");
            string tcNumber = Console.ReadLine().ToString();
            Console.WriteLine("İsminizi giriniz.");
            string firstName = Console.ReadLine().ToString();
            Console.WriteLine("Soyisminizi giriniz.");
            string lastName = Console.ReadLine().ToString();
            Console.WriteLine("Doğum yılınızı giriniz.");
            string birthYear = Console.ReadLine().ToString();

            foreach (Customer customer in _customers)
            {
                if (tcNumber == customer.TcNumber && firstName == customer.FirstName && lastName == customer.LastName && birthYear == customer.BirthYear)
                {
                    control = true;
                    break;
                }
            }
            if (control == true)
            {
                PasaDevProgram program = new PasaDevProgram();
                Console.Clear();
                program.Intro();
                program.StartProgram();
            }

        }
        public static void Register()
        {
            Console.Clear();
            Console.WriteLine("Tc kimlik numaranızı giriniz.");
            string tcNumber = Console.ReadLine().ToString();
            Console.WriteLine("İsminizi giriniz.");
            string firstName = Console.ReadLine().ToString();
            Console.WriteLine("Soyisminizi giriniz.");
            string lastName = Console.ReadLine().ToString();
            Console.WriteLine("Doğum yılınızı giriniz.");
            string birthYear = Console.ReadLine().ToString();

            Customer customer = new Customer();
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.TcNumber = tcNumber;
            customer.BirthYear = birthYear;

            _customers.Add(customer);

            Console.Clear();
            Console.WriteLine("Kaydınız başarıyla oluşturuldu!");
            Thread.Sleep(1500);
            Console.WriteLine("Lütfen giriş yapın!");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
}
