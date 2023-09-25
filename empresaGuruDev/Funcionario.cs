

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace empresaGuruDev
{
    internal class Funcionario
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public double matricula { get; set; }
        public DateTime dataNascimento { get; set; }
        public string sexo { get; set; }
        public double salario { get; set; }

        public Funcionario()
        {

        }
        public Funcionario(string nome, string cpf, double matricula, DateTime dataNascimento, string sexo, double salario)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.matricula = matricula;
            this.dataNascimento = dataNascimento;
            this.sexo = sexo;
            this.salario = salario;
           
        }
    }
}
