
namespace empresaGuruDev
{
    internal class Medico :Funcionario
    {
        public string CRM { get; set; }
        public double VHextra { get; set; }
        public string especialidade { get; set; }

        public Medico(string nome, string cpf, double matricula, DateTime dataNascimento, string sexo, double salario, string cRM, double vHextra, string especialidade) : base(nome, cpf, matricula, dataNascimento, sexo, salario)
        {
            CRM = cRM;
            VHextra = vHextra;
            this.especialidade = especialidade;
        }
        public void recebimento()
        {
            salario = salario * 0.20;
            Console.WriteLine($"seu salario é {salario} reais");

        }
    }
}
