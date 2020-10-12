using System;

namespace Lab_2
{
    class Program
    {

        static void Main(string[] args)
        {

            Bus A1 = new Bus(new DateTime(2018, 12, 1), "Krainov K.A", "11", "VN12", 2009, 13444);
            Bus A2 = new Bus(new DateTime(2019, 2, 1), "Bobrov P.A", "11", "VN12", 2000, 18912);
            Bus B18 = new Bus(new DateTime(2019, 3, 1), "Путин В.В", "19A", "VN12", 1999, 23900);
            Bus C1 = new Bus(new DateTime(2019, 3, 1), "Белодед Н.И", "77", "VN12", 1996, 34900);
            Bus trainee = new Bus();

            A1.showClassInfo();
            //output with using get
            Console.WriteLine($"Get: {A1.Fio},{A2.Mileage},{B18.NumbMarh},{C1.Marka},{trainee.Age}");

            //set
            trainee.Fio = "Alex";
            trainee.Mileage = 0;
            trainee.NumbMarh = "12";
            trainee.NumbBus = 1000;

            A1.Equals(A2);
            int hash = B18.GetHashCode();
            Console.WriteLine($"Get type:\n" +
                $"A1:{A1.GetType()}\n" +
                $"A2:{A2.GetType()}\n" +
                $"C1:{C1.GetType()}\n");


            Bus[] park = new Bus[]
                {
                    A1,
                    A2,
                    B18,
                    C1,
                    trainee
                };

            //Task № 1

            string userCheck = Console.ReadLine();

            foreach (Bus item in park)
            {
                if (string.Compare(userCheck, item.NumbMarh) == 0)
                {
                    Console.WriteLine($"{item.NumbMarh} : {item.NumbBus }, driver {item.Fio} , km : {item.Mileage}");
                }
            }
            //Task № 2

            int  userAge = Convert.ToInt32(Console.ReadLine());
            foreach (Bus item in park)
            {
                if (item.Age > userAge)
                {
                    Console.WriteLine($"{item.NumbMarh} : {item.NumbBus }, driver {item.Fio} , km : {item.Mileage}");
                }
            }



            var T12 = new { InUsingDate = new DateTime(2020, 10, 10) , Fio = "Abella", NumbMarh = "44A", Marka = "BELAZ7", NumbBus = 1223, Mileage = 512};

            var A22 = new Bus();
            Console.WriteLine($" {A22.Mileage } , {A22.NumbBus} , {A22.Fio} , {A22.NumbMarh}  ");

        }
    }

}
