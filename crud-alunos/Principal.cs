using System;
using System.Collections.Generic;

public class Principal{

    List<Aluno> alunos = new List<Aluno>();
    public static void Main(string[] args) {
        
        Principal p = new Principal(); // instaciar a classe para usar os métodos 

        // menu 
        while (true) {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Cadastrar Alunos");
            Console.WriteLine("2. Consultar Alunos");
            Console.WriteLine("3. Alterar Alunos");
            Console.WriteLine("4. Excluir Alunos");
            Console.WriteLine("5. Sair");

            Console.Write("\nDigite o que deseja: ");
            int op = int.Parse(Console.ReadLine());
            switch (op){
                case 1:
                    int vezes = p.qtdcadastrar();
                    for (int i = 0; i < vezes; i++){
                        Console.WriteLine($"\nCadastro do Aluno {i + 1}");
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Curso: ");
                        string curso = Console.ReadLine();

                        p.alunos.Add(new Aluno() { Nome = nome, Idade = idade, Curso = curso });
                    }
                    break;
                case 2:
                    ConsultarAlunos(p.alunos);
                    break;
                case 3:     // altera
                    break;
                case 4:     // exclui
                    break;
                case 5:
                    Console.WriteLine("Saindo do programa...");
                    Environment.Exit(0); // Encerra o programa
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    private static void ConsultarAlunos(List<Aluno> alunos) {
        Console.Write("\nQual é o nome do aluno para consulta: ");
        string nmBusca = Console.ReadLine();

        // pesquisa para aprimoramento
        Aluno encontrado = alunos.Find(a => a.Nome.ToLower() == nmBusca.ToLower(System.Globalization.CultureInfo.CurrentCulture));

        if (encontrado != null) {
            Console.WriteLine($"\nAluno encontrado:");
            Console.WriteLine($"Nome: {encontrado.Nome}");
            Console.WriteLine($"Idade: {encontrado.Idade}");
            Console.WriteLine($"Curso: {encontrado.Curso}");
        } else {
            Console.WriteLine($"Aluno com o nome '{nmBusca}' não encontrado.");
        }
    }


    public int qtdcadastrar()
    {
        int qtdAlunos = 0;
        Console.WriteLine("\nQuantos alunos deseja cadastrar?");
        qtdAlunos = int.Parse(Console.ReadLine());
        return qtdAlunos;
    }

    
}