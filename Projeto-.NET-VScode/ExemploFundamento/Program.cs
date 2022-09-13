using ExemploFundamento.Models;


bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}











// bool presencaMinima = false;
// double media = 7;

// if (presencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     {
//         Console.WriteLine("Reprovado!");
//     }
// }







// bool eMaiorDeIdade = false;
// bool possuiAutorizacaoDosPais = false;

// if (eMaiorDeIdade || possuiAutorizacaoDosPais)
// {
//     Console.WriteLine("Entrada Liberada!");
// }
// else
// {
//    Console.WriteLine("Entrada não liberada."); 
// }







// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
    
//     default:
//         Console.WriteLine("Não é Vogal");
//         break;
// }





// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// if (letra == "a")
// {
//     Console.WriteLine("Vogal")
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal")
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal")
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal")
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal")
// }
// else 
// {
//     Console.WriteLine("Não é uma Vogal")
// }






// int quantidadeEstoque = 3;
// int quantidadeCompra = 1;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

// Console.WriteLine($"quantidade em estoque: {quantidadeEstoque}");
// Console.WriteLine($"quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"{possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda Invalida");
// }
// else if(possivelVenda)
// {
//     Console.WriteLine("Venda Realizada");
// }
// else 
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade em estoque");
// }












// string a = "15-";
// int b = 0;

// int.TryParse(a, out b);
// Console.WriteLine(b)




// double a = 4/2+2

// Console.WriteLine(a);




// int a = 5;
// double b = a;

// Console.WriteLine(b);



// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);





// //Cast - Casting
// //int a = Convert.ToInt32(null);
// int a = int.Parse(null); 

// Console.WriteLine(a);








// int a = 10;
// int b = 20;

// int c = a + b;

// c = c + 5;
//c += 5;

 // c = c - 5;
 //c -= 5;
//Console.WriteLine(c);


// DateTime dataAtual = DateTime.Now.add;
// Console.WriteLine(dataAtual);


// string apresentacao ="Olá seja bem vindo";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine(quantidade);
// Console.WriteLine(altura.ToString("0.00"));
// Console.WriteLine(preco);
// Console.WriteLine(condicao);

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Diogo";
// pessoa1.Idade = 18;
// pessoa1.Apresentar();