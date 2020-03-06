using System;

namespace GerenciadorUsuarioClient.Data
{
    public class UsuarioClient
    {
        public int idUsuario { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public DateTime? dataNascimento { get; set; }
        public DateTime? dataCadastro { get; set; }
        public int idPerfil { get; set; }
    }
}
