
/* Getter and setter are used to add security to fields by encapsulation 
                         They're accessors found within property
properties = combine aspects of both fields and methods ( Share name with a field)

get accessor = used to return the property value
set accessor = used to assign a new value
value keyword = defines the value assigned by the set (Parameter)
Parameter = Name of variable in a methods which revive a value from the caller when methods is called 
 
 
 */
using System;
namespace Getters___setters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car Car = new Car(200);
            Console.Write("Speed of car : ");
            Car.Speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Car.Speed);
            Console.ReadKey();
        }
    }
    class Car
    {
        private int speed;

        public Car(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get { return Speed; }
            set
            {
                if (Speed > 200)
                {
                    Speed = 200;
                }

                else
                {
                    Speed = value;
                }
            }




        }
    }
}