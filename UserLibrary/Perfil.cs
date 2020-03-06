using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserLibrary
{
    public class Perfil
    {
        [Key]
        public int IdPerfil { get; set; }

        [Required(ErrorMessage = "Favor informar: Nome .Este campo é obrigatório.")]
        [Range(3, 100, ErrorMessage = "Nome do Perfil deve ter entre 3 e 100 caracteres")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Favor informar: Descrição. Este campo é obrigatório.")]
        [Range(0, 300, ErrorMessage = "Descrição do Perfil deve ter no máximo 300 caracteres")]

        public string Descricao { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public virtual ICollection<Funcionalidades> Funcionalidades { get; set; }
    }
}
