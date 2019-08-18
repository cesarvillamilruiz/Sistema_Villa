﻿using Microsoft.AspNetCore.Mvc;
using Sis.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sis.Web.Controllers.API
{
    [Route("api/[Controller]")]
    public class ProductsController:Controller
    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(this.productRepository.GetAllWithUsers());
        }
    }
}
