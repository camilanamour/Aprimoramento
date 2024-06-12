using System;

public class main{
    public static void Main(string[] args){
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
                case 1:     // cadastrar
                    break;
                case 2:     // consulta
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
}