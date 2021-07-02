using System;
using System.Collections.Generic;
// Steffany Martins Soares
namespace Techbank 
{
  public class registerUser
  {
    public static void Main(string[] args)
    {
      string choice;
      string name = string.Empty;
      List<string> names = new List<string>();

    
      while (name != "fim") {
  
            Console.WriteLine("Bem-vindo ao menu. Escolha uma opção:");
			Console.WriteLine("1 - Adicione um nome: ");
			Console.WriteLine("2 - Delete um nome: ");
			Console.WriteLine("3 - Leia um nome: ");
			Console.WriteLine("Escreva 'fim' para sair (sem aspas)");
			choice = Console.ReadLine().Trim();
          switch (choice)
          {
              case "1":
                  Console.WriteLine("Nome:");
                  name = Console.ReadLine().Trim();
                  AddUser(name, names);
				  break;
              case "2":
                  Console.WriteLine("Nome para deletar:");
                  name = Console.ReadLine();
                  DeleteUser(names, name);
				  break;
              case "3":
                  Console.WriteLine("Nome para visualizar:");
                  name = Console.ReadLine();
                  ReadUser(names);
				  break;
              default:
                   break;
            }

          }
      }
      public static void AddUser (string name, List<string> names) {
		 foreach (string n in names) {
			 if(name != n) {
				 if(name == null || name == "") 
				 	Console.WriteLine("Escreva um nome válido");
				 else
					 names.Add(name);
			 }
				
			 else {
				 Console.WriteLine("Nome já existente");
			 }
			 
		 }
		 
      }
      public static void ReadUser (List<string> names) {
          foreach (string n in names) {
            Console.WriteLine(n);
          }
      }
      public static void DeleteUser (List<string> names, string offUser) {
		  foreach (string n in names) {
			 names.Remove(offUser); 
		  }
	  }
    }
}
 