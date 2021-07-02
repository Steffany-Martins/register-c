// using System;

// namespace Tech_bank
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Informe seu nome:");

//             string nome = Console.ReadLine();

//             Console.WriteLine("Informe a sua idade");

//             if(!int.TryParse(Console.ReadLine(), out int idadeConvertida))// Try parse é para o conteúdo escrito se é inteiro e se for é atribuído a idade convertida
//                 Console.WriteLine("Idade inválida");
//             else {
//                 int idade = idadeConvertida;

//                 string eMaior = idade >= 18? "maior" : "menor";

//                 Console.WriteLine($"{nome}, você  é {eMaior} de idade");

//                 Console.WriteLine($"Parte 2 - {nome}, você é {(idade>= 18 ? "maior" : "menor")} de idade");

//             }



//         }
//     }
// }
