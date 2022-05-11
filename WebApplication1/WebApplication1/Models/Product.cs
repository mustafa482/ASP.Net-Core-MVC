using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.ModelMetaDataTypes;

namespace WebApplication1.Models
{
    //[ModelMetadataType(typeof(ProductMetadata))] => Validation ni basqa clasdan almaq üçündür.
    public class Product
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Email { get; set; }
    }
}
