using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_DEMO.Models;

namespace WebAPI_DEMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static List<Car> cars = Car.getCars();
        [HttpGet]
        public ActionResult getCarDetails()
        {
            return Ok(cars);
        }

        [HttpPost]
        public ActionResult addcar(Car car)
        {
            cars.Add(car);
            return Ok(car);
        }
        [HttpGet]
        [Route("getbyID")]
        public ActionResult getCarById(int id)
        {
            return Ok(cars.SingleOrDefault(x => x.Cid == id));
        }
        [HttpPut]
        public ActionResult putCar(int id,Car car)
        {
            Car carToupdate = cars.SingleOrDefault(x => x.Cid == id);
            carToupdate.Cname = car.Cname;
            carToupdate.Price = car.Price;
            return Ok(carToupdate);
        }
        [HttpDelete]
        public ActionResult deleteCar(int id)
        {
            Car carToupdate = cars.SingleOrDefault(x => x.Cid == id);
            cars.Remove(carToupdate);
            return Ok();
        }
    }
}
