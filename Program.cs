string[] historico = new string[10];
int indiceHistorico = 0;

while (true) //forçar interrupção - enquanto verdadeiro 
{
    Console.Clear();
    Console.WriteLine("\n\n\n\t\t\t\t\tMENU"); // colunas e linhas da tela 
    Console.WriteLine("Pressione F1 para calcular o salário líquido");
    Console.WriteLine("Pressione F2 para calcular 13º salário");
    Console.WriteLine("Pressione F3 para exibir o histórico de cálculos");
    Console.WriteLine("Pressione DEL para sair");
    ConsoleKeyInfo tecla = Console.ReadKey(); //console key pra guardar alguma inf (tecla clicada) 

    if (tecla.Key == ConsoleKey.F1)
    {
        Console.Clear();
        Console.Write("Digite o valor da hora trabalhada: ");
        double valorHora = Convert.ToDouble(Console.ReadLine()); //Parse (conv.) // pode criar a váriavel em any time 

        Console.Clear();
        Console.Write("Digite o número de horas trabalhadas: ");
        double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

        Console.Clear();
        Console.Write("Digite o desconto total (em %): ");
        double desconto = Convert.ToDouble(Console.ReadLine());

        double salarioBruto = valorHora * horasTrabalhadas;
        double salarioLiquido = salarioBruto * (1 - desconto / 100);

        Console.WriteLine($"O salário bruto é: R$ {salarioBruto:F2}"); // F2 número de casas 
        Console.WriteLine($"O salário líquido é: R$ {salarioLiquido}");

        // Armazenando no vetor 
        if (indiceHistorico < historico.Length) // posições livres 
        {
            historico[indiceHistorico] = $"Salário Líquido: R$ {salarioLiquido:F2}";
            indiceHistorico++;
        }
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    } // Essa chave fecha o if do F1 

    else if (tecla.Key == ConsoleKey.F2) // caso contrário 
    {
        Console.Clear();
        Console.Write("Digite o salário bruto: ");
        double salarioBruto = Convert.ToDouble(Console.ReadLine());

        Console.Write("\n\nDigite a quantidade de meses trabalhados: ");
        int mesesTrabalhados = Convert.ToInt32(Console.ReadLine());

        if (mesesTrabalhados < 1 || mesesTrabalhados > 12) // || É ou // evitar enganar 
        {
            Console.WriteLine("Número de meses inválido! Deve estar entre 1 e 12");
            Console.ReadKey();
            continue;
        }

        double decimoTerceiro = (salarioBruto / 12) * mesesTrabalhados;
        Console.WriteLine($"o 13° salário proporcional é: R$ {decimoTerceiro:F2}");
        Console.ReadKey();
    }// Essa chave fecha o else if do F2 
  else if (tecla.Key == ConsoleKey.F3)
  {
    //Exibir o coneúdo do vetor na tela 
    Console.Clear();
    Console.WriteLine("Histórico de cálculos realizados");
    if(indiceHistorico == 0)
    {
        Console.WriteLine("Nenhum cálculo realizado até o momento");
    }
    else
    {
        for (int i = 0; i < indiceHistorico; i++) //laço de repetição (incrementa, testa e executa) fica nessa até for igual a zero
        {
            Console.WriteLine(i + 1 + "º Histórico:" + historico[i]);   
        }
    }
    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.ReadKey();
 } // Essa chave fecha o else if do F3 
else if(tecla.Key == ConsoleKey.Delete)
{
    //sair do programa
    Console.WriteLine("Saindo...");
    break; // força saída 
}
else // se clicou em outra tecla
{
    Console.Clear();
    Console.WriteLine("Opção inválida! Tente novamente!");
    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.ReadKey();  
}
}
