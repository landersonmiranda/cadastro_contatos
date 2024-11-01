﻿using PrimeiraCrudMVC.Enums;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace PrimeiraCrudMVC.Models
{
    public class UsuarioSemSenhaModel
    {
       public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o login do usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o email do usuário")]
        [EmailAddress(ErrorMessage = "O email informado não é válido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Escolha o perfil do usuário")]
        public PerfilEnum? Perfil { get; set; }
   
     

    }
}
