using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace OfficialEkaNaweame.Models
{
    public class ListaUsuarios
    {
        public string Correo { get; set; }
        public string Tipo_usuario { get; set; }
        public bool Emailconfirmado { get; set; }
    }
}