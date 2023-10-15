﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
	public class ProductDto: BaseDto
	{
		public string ProductName { get; set; }
		public int Stock { get; set; }
		public decimal Price { get; set; }


		public int CategoryID { get; set; }
	}
}
