using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Description is Required")]
        public string Description { get; private set; }
        [Required(ErrorMessage = "The Price is Required")]
        public decimal Price { get; private set; }
        [Required(ErrorMessage = "The Stock is Required")]
        public int Stock { get; private set; }
        public string Image { get; private set; }
        public int CategoryId { get; private set; }
        public Category Category { get; set; }
    }
}
