using System;
using System.Collections;

namespace IComparible_Interface
{
    public class Car : IComparable, IComparable<Car>
    {
        protected double weight;

        public Car(double weight)
        {
            this.weight = weight;
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        //Non-Generic IComparable
        public int CompareTo(object obj)
        {
            if(!(obj is Car))
            {
                throw new InvalidOperationException("CompareTo: Not a Car");
            }
            return CompareTo(obj as Car); //Calls the Generic CompareTo method
        }

        //Generic IComparable<Car>
        public int CompareTo(Car other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return this.weight.CompareTo(other.weight);
            }
        }
    }

    public class Honda : Car
    {
        public Honda(double weight) : base(weight)
        {

        }
    }

    class CompareCars
    {
        static void Main(string[] args)
        {
            ArrayList cars = new ArrayList();

            Car c1 = new Car(3420.32);
            Car c2 = new Car(2832.9);
            Car c3 = new Car(2568.93);
            Car c4 = new Car(4521.20);
            Car c5 = new Car(2493.11);
            Car c6 = new Car(3274.82);
            Honda c7 = new Honda(2993.28);

            cars.Add(c1);
            cars.Add(c2);
            cars.Add(c3);
            cars.Add(c4);
            cars.Add(c5);
            cars.Add(c6);
            cars.Add(c7);

            Console.WriteLine("Before sorting array list of cars");

            foreach (Car temp in cars)
            {
                Console.WriteLine(temp.Weight);
            }

            //Sort our list of cars. This only works for our Car type because we implemented the IComparable interfaces
            cars.Sort();

            Console.WriteLine("\nAfter sorting array list of cars");

            foreach (Car temp in cars)
            {
                Console.WriteLine(temp.Weight);
            }
        }
    }
}
