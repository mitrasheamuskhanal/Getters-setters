
/* Getter and setter are used to add security to fields by encapsulation 
                         They're accessors found within property
properties = combine aspects of both fields and methods ( Share name with a field)

get accessor = used to return the property value
set accessor = used to assign a new value
value keyword = defines the value assigned by the set (Parameter)
Parameter = Name of variable in a methods which revive a value from the callen when methods is called 
 
 
 */
using System;
namespace Getters___setters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car Car = new Car(200);
        }
    }
    class Car
    {
        public int speed;
        public Car(int speed) {
        
        if (speed < 200)
            {
                speed = 200;
            }
        else if (speed >200)
            {
                speed = Value;
            }
               
    }
}
