using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_aula_backend.Models
{   
    [Table("Usuarios")]
    public class Usuario
    {   
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Obrigatório informar nome.")]
        public string Nome { get; set; }
       
        [Required(ErrorMessage ="obrigatório informar senha.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
       
        [Required(ErrorMessage ="Obrigatório informar o perfil.")]
        public Perfil Perfil { get; set; }
    }
    public enum Perfil
    {
        Administrador,
        Usuario
    }
}
