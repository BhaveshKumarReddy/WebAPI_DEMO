using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_DEMO.Models
{
    public class Car
    {
        public int Cid { get; set; }
        public string Cname { get; set; }
        public float Price { get; set; }

        public Car() { }
        public Car(int cid,string name,float price)
        {
            Cid = cid;
            Cname = name;
            Price = price;
        }
        public static List<Car> cars = new();
        public static List<Car> getCars()
        {
            cars.Add(new Car(1,"Ford",340000));
            cars.Add(new Car(2, "Kia", 120000));
            cars.Add(new Car(3, "Toyota", 230000));
            cars.Add(new Car(4, "Maruti", 560000));
            return cars;
        }
    }
}
