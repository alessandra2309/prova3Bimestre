using empresaGuruDev;

while (true)
{
    Console.WriteLine("digite seu nome:");
    string nome = Console.ReadLine();
    DateTime data = DateTime.Now;


    Console.WriteLine("selecione qual usuario você é: ");
    Console.WriteLine("1- adm");
    Console.WriteLine("2- Medico");
    int opcao = Convert.ToInt32(Console.ReadLine());
   

    if(opcao == 1)
    {
        List<Adm> Funcio = new List<Adm>();
        Adm a = new Adm( nome,"0000",200, data, "Feminino", 5000);
        Funcio.Add(a);
        a.recibimento2();
    }
    else if(opcao == 2)
    {
        List<Medico> Fun = new List<Medico>();
        Medico m = new Medico(nome, "0001", 201, data, "Masculino", 20000, "registro no conselho", 1000, "clino geral");
        Fun.Add(m);  
        m.recebimento();
      
        
    }
}