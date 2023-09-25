

namespace empresaGuruDev
{
    internal class Adm : Funcionario
    {
        public  Adm(string nome, string cpf, double matricula, DateTime dataNascimento, string sexo, double salario) : base(nome, cpf, matricula, dataNascimento, sexo, salario)
        {
           
        }
        public  void recibimento2()
        {
            salario = (salario + 150) * 0.15;
            Console.WriteLine($"seu salario é {salario} reais");
        }
    }
}
