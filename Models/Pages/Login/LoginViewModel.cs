﻿using System.ComponentModel.DataAnnotations;

namespace harakiri_rpg.Models.Pages.Login
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string nm_email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string nm_senha { get; set; } = string.Empty;

        [Display(Name = "Lembrar-me")]
        public bool dv_lembrar { get; set; }
    }

}
