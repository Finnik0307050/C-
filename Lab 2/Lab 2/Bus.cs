using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{

    public partial class Bus
    {
      
        static public DateTime dateCreationOfPark;
        //static
        private static ushort kolvo = 0;

        private string fio;
        public string Fio
        {
            get
            {
                return fio;
            }
            set
            {
                fio = value;
            }
        }
        private int numb;
        public int NumbBus
        {
            get
            {

                return numb;
            }
            set
            {
                if (value > numb)
                    Console.WriteLine("Incorrect value!");
                else
                    numb = value;
            }
        }
        private string numbmar;
        public string NumbMarh
        {
            get
            {
                return numbmar;
            }
            set
            {

                numbmar = value;
            }
        }
        private string marka;
        public string Marka
        {
            get
            {
                return marka;

            }
            set
            {
                marka = value;
            }
        }

        private uint mileage;
        public uint Mileage
        {
            get
            {
                return mileage;
            }
            set
            {
                if (mileage < 0)
                    Console.WriteLine("Incorrect value!");
                else
                    mileage = value;
            }
        }
        private int age;

        public int Age
        {
            get
            {
                return (DateTime.Now.Year - startInUsing.Year);
            }
        }
        private DateTime startInUsing;

        public DateTime StartInUsing
        {
            get
            {
                return startInUsing;
            }
            set
            {
                startInUsing = value; 
            }


        }
        private readonly double ID;
        private void countHash(uint mileage, DateTime startInUsing, string fio, out double ID)
        {
            ID = (Math.Pow(mileage, startInUsing.Year) / fio.Length);
        }

        public void changeYouName(string fullname)
        {
            Console.ReadLine();
        }



        public Bus()
        {
            this.fio = " AUTOBUS";
            this.numb = 6699;
            this.marka = "MAZ";
            this.numbmar = "12";
            this.mileage = 0;
            this.startInUsing = new DateTime(2008, 10, 6);



            countHash(mileage, startInUsing,fio, out ID);

            kolvo++;
        }

        public Bus(DateTime inUsingYear, string fio, string numbmar, string marka,int numb, uint mileage):this()
        {
            if (DateTime.Now.Year - inUsingYear.Year > 100)
            {
                Console.WriteLine("NO NO NO");
                this.startInUsing = DateTime.Now;
            }
            else
            {
                this.startInUsing = inUsingYear;
                this.fio = fio;
                this.numb = numb;
                this.marka = marka;
                this.numbmar = numbmar;
                this.mileage = mileage;


            }
        }
        static Bus()
        {
            dateCreationOfPark = DateTime.Now;
            Console.WriteLine("You will see this message only one time.\n Park was created!");
        }

        public void showClassInfo()
            {
                Console.WriteLine($"Quantity of objects:{kolvo}");
            }

        public override bool Equals(Object obj) //модификатор перефопределения метода 
        {
            Bus forOverride = obj as Bus;
            return (
                fio == forOverride.fio &&
                numbmar == forOverride.numbmar &&
                marka == forOverride.marka &&
               numb == forOverride.numb &&
                mileage == forOverride.mileage &&
                startInUsing == forOverride.startInUsing
                );
        }
        public override int GetHashCode()
        {
            return (int)ID;
        }

        public override string ToString()
        {
            return $"Bus {marka} number {numb}, route {numbmar}, meliage {mileage}\n" +
                $", used since {startInUsing} by {fio}";
        }

        public void ShowAge()
        {
            Console.WriteLine($" Age of Bus : {this.Age } year");

        }

    }


 

}
