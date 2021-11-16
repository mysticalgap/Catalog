using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public abstract class AuthorForManipulationDto
    {
        [Required(ErrorMessage = "Фамилия автора является обязательным полем.")]
        public string Surname { get; set; }
    }
}
