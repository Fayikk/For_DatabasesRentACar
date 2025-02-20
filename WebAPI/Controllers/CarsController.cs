﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //Katmanımız için gerekli referanslandırmayı yapalım.
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        //Şimdi öncellikler bağımlılığı ortadan kaldırmak için
        //kaldırmak değilde bağımlılığı en aza indirgeme için 
        //yapımızı oluşturalım.
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
            //Bu yapı sayesinde bağımlılık seviyemzizi en aza indirgemiş olduk.
        }

        [HttpPost("Added")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return  Ok(result);
            }
            return BadRequest(result);  

        }



        [HttpGet("getAll")]//Bu komut swagger arayüzünde sadece get etme işlemi yapacağımızı tanımlamamıza yarar.
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result );
            }
            
            return BadRequest(result);

            
        }


        [HttpGet("GetByColorId")]
        public IActionResult GetbyId(int id)
        {
            var result = _carService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("CarDetail")]
        public IActionResult GetCarDetail(int carId)
        {
            var result = _carService.GetCarDetail(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("Details")]
        public IActionResult GetDetails()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }

        //[HttpPost("Add")]
        //public IActionResult Add(Car car)
        //{
        //    var result = _carService.Add(car);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

    }
}
