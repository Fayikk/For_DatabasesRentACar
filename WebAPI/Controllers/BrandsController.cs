﻿using Business.Abstract;
using DataAcces.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
           var result = _brandService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("Add")]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.add(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }

        [HttpPost("Update")]
        
        public IActionResult Update(Brand brand)
        {
            var result = _brandService.Update(brand);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }



    }
}
