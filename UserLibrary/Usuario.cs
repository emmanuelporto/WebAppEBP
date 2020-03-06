using System;
using System.ComponentModel.DataAnnotations;

namespace UserLibrary
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Favor informar: Nome. Este campo é obrigatório.")]
        [Range(0, 50, ErrorMessage = "O campo Nome suporta no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor informar: Sobrenome. Este campo é obrigatório.")]
        [Range(0, 200, ErrorMessage = "O campo Sobrenome suporta no máximo 300 caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Favor informar: Data de Nascimento. Este campo é obrigatório.")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [Display(Name = "Perfil")]
        [Required(ErrorMessage = "")]
        public int IdPerfil { get; set; }

        public virtual Perfil Perfil { get; set; }

    }
}
