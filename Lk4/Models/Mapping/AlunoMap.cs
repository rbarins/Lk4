using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Lk4.Models.Mapping
{
    public class AlunoMap : EntityTypeConfiguration<Aluno>
    {
        public AlunoMap()
        {
            // Primary Key
            this.HasKey(t => t.AlunoId);



            // Properties
            // Table & Column Mappings
            this.ToTable("Aluno");
            this.Property(t => t.AlunoId).HasColumnName("AlunoId");
            this.Property(t => t.AlunoSenha).HasColumnName("AlunoSenha");
            this.Property(t => t.AlunoUsuario).HasColumnName("AlunoUsuario");
            this.Property(t => t.AlunoToken).HasColumnName("AlunoToken");
            this.Property(t => t.AlunoNome).HasColumnName("AlunoNome");
            this.Property(t => t.AlunoDataCadastro).HasColumnName("AlunoDataCadastro");
            this.Property(t => t.AlunoStatus).HasColumnName("AlunoStatus");
            this.Property(t => t.AlunoSexo).HasColumnName("AlunoSexo");
            this.Property(t => t.AlunoCpf).HasColumnName("AlunoCpf");
            this.Property(t => t.AlunoRg).HasColumnName("AlunoRg");
            this.Property(t => t.AlunoTurma).HasColumnName("AlunoTurma");
            this.Property(t => t.AlunoDataNascimento).HasColumnName("AlunoDataNascimento");
            this.Property(t => t.AlunoDataAtivacao).HasColumnName("AlunoDataAtivacao");
            this.Property(t => t.AlunoEmail).HasColumnName("AlunoEmail");
            this.Property(t => t.AlunoConfirmaSenha).HasColumnName("AlunoConfirmaSenha");
        }
    }
}
