using System;
using System.ComponentModel.DataAnnotations;

namespace UserLibrary
{
    public class Funcionalidades
    {
        [Key]
        public int IdFuncionalidade { get; set; }

        [Required(ErrorMessage = "Favor informar: Nome. Este campo é obrigatório.")]
        [Range(3, 100, ErrorMessage = "Campo Nome deve ter entre 3 e 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor informar: Descrição. Este campo é obrigatório.")]
        [Range(0, 300, ErrorMessage = "O campo Descrição suporta no máximo 300 caracteres")]
        public string Descricao { get; set; }

        [Display(Name = "Perfil")]
        [Required(ErrorMessage = "Favor informar: Perfil. Este campo é obrigatório.")]
        public int IdPerfil { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public virtual Perfil Perfil { get; set; }

    }
}
