using System;
using System.Collections.Generic;

namespace Lk4.Models
{
    public partial class Aluno
    {
        public int AlunoId { get; set; }
        public string AlunoSenha { get; set; }
        public string AlunoUsuario { get; set; }
        public string AlunoToken { get; set; }
        public string AlunoNome { get; set; }
        public System.DateTime AlunoDataCadastro { get; set; }
        public string AlunoStatus { get; set; }
        public string AlunoSexo { get; set; }
        public string AlunoCpf { get; set; }
        public string AlunoRg { get; set; }
        public string AlunoTurma { get; set; }
        public System.DateTime AlunoDataNascimento { get; set; }
        public System.DateTime AlunoDataAtivacao { get; set; }
        public string AlunoEmail { get; set; }
        public string AlunoConfirmaSenha { get; set; }
    }
}
