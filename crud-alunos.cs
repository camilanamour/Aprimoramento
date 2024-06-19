using System;
using System.Collections.Generic;

public class Principal{
    public static void Main(string[] args){
        List<Aluno> alunos = new List<Aluno>();
        Principal p = new Principal(); // instaciar a classe para usar os métodos 
        
        // menu 
        while (true){
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
                    for (int i = 0; i<vezes; i++){
                        Console.WriteLine($"\nCadastro do Aluno {i + 1}");
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Curso: ");
                        string curso = Console.ReadLine();

                        alunos.Add(new Aluno() { Nome = nome, Idade = idade, Curso = curso });
                    }
                    break;
                case 2:     
                    consultarAlunos();
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
    
    public int qtdcadastrar(){
        int qtdAlunos = 0;
        Console.WriteLine("Quantos alunos deseja cadastrar?");
        qtdAlunos = int.Parse(Console.ReadLine());
        return qtdAlunos;
    }
    
    public static void consultarAlunos(){
        Console.WriteLine("Funcionou...");
    }
    
   class Aluno {
        public string Nome{ get; set;}
        public int Idade{get; set;}
        public string Curso{get; set;}
    }
}