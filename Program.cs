/*Uma loja tem tem uma política de descontos de acordo com o valor da alrvalor 
do cliente. Os descontos começam acima dos R$500. A cada 100 reais 
acima dos R$500,00 o cliente ganha 1% de desconto cumulativo até 25%. */

using System;

class Program{
    static void Main(string[]args){
        int tam = 0;
        string nome;
        string resultado;
        int opcao = 0;

        inicio:

        Console.Clear();
        Console.WriteLine("CALCULO DE MÉDIA");
        Console.Write("Qual o nome do aluno: ");
        nome = Console.ReadLine();
        Console.Write("Quantas notas você vai inserir: ");
        tam = int.Parse(Console.ReadLine());

        double []notas = new double [tam];

        for (int i=0; i<tam;i++){
            Console.Write($"Digite a {i+1}° nota: ");
            notas[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Aluno: {nome}");
        for (int i=0; i<notas.Length; i++){
            Console.WriteLine($"Nota {i+1}: {notas[i]}");
        }
        double media = notas.Average();
        Console.WriteLine($"Media: {media}");

        if (media>=7 && media<=10 && media>=0){
            resultado="APROVADO!";
        }else if(media>=4 && media<=10 && media>=0){
            resultado="RECUPERAÇÃO!";
        }else if(media<4 && media<=10 && media>=0){
            resultado="REPROVADO!";
        }else{
            resultado="MÉDIA INVÁLIDA!";
        }
        Console.WriteLine($"Resultado: {resultado}");
        

        while(opcao!=1 || opcao!=2){
            Console.WriteLine("1 - Calcular outra media\n2 - Sair");
            opcao = int.Parse(Console.ReadLine());

            if(opcao==1){
                goto inicio;
            }else if(opcao==2){
                Console.WriteLine("Fim do Programa");
                break;
            }else{
                Console.WriteLine("Opção Invalida");
            }
        }


        

    }
}