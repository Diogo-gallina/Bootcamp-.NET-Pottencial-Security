using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;


int a = 10;
int b = a;

Console.WriteLine($"Valor de A: {a}");
Console.WriteLine($"Valor de B: {b}");










// Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");

// Pessoa p2 = p1;
// p2.Nome = "Vinicius";

// Console.WriteLine($"Nome da pessoa p1: {p1.NomeCompleto}");
// Console.WriteLine($"Nome da pessoa p2: {p2.NomeCompleto}");






























// int numero = 20;
// bool par = false;

// par = numero.EhPar();
// string mensagem = "O número: " + numero + (par ? " é par" : " é impar");

// Console.WriteLine(mensagem);



























// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);


// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("Teste");

// Console.WriteLine(arrayString[0]);


// List<int> lista = new List<int>();


















// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";

// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;

// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");





















// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new {x.Produto, x.Preco});

// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }

















// var tipoAnonimo = new {Nome = "Leonardo", Sobrenome = "Buta", Altura = 1.80M};

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);

















// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach(Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, " +
//     $"Data: {venda.DataVenda.ToString("dd-MM-yyyy HH:mm")}" + $"{(venda.Desconto.HasValue ? $" Desconto de: {venda.Desconto}" : "")}");
// }

























// bool? desejaReceberEmail = null;

// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber email");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber email");
// }

























// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach(Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd-MM-yyyy HH:mm")}");
// }
















// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escriótio", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);





























// int numero = 15;
// bool ehPar = false;

//IF TERNARIO

// ehPar = numero %2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));



// if(numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }






























// Pessoa p1 = new Pessoa("Leonardo", "Buta");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");



















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if(sucesso)
// {
//     //Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);

//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }




























// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Diogo", "Gallina", 10.5M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Diogo", "Gallina", 10.5M);

// Console.WriteLine($"id: {tupla.Item1}");
// Console.WriteLine($"id: {tupla.Item2}");
// Console.WriteLine($"id: {tupla.Item3}");
// Console.WriteLine($"id: {tupla.Item4}");
























//DICTIONARY


//  Dictionary<string,string> estados = new Dictionary<string, string>();

//  estados.Add("SP", "São Paulo");
//  estados.Add("BA", "Bahia");
//  estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["MG"]);

// foreach(KeyValuePair<string,string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("---------------------------------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - Valor alterado";

// foreach(KeyValuePair<string,string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }


// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else{
//     Console.WriteLine($"Valor não existe. É seguroadicionar a chave: {chave}");
// }



























//STACK - Pilha



// Stack<int>  pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }













//QUEUE / FILA



// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);
// fila.Enqueue(5);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }












// new ExemploExcecao().Metodo1();

















//TRY CATCH


//string[] linhasExemplo = File.ReadAllLines("Arquivos/arquivo-Leitura.txt");



// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo-Leitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }catch(FileNotFoundException ex){
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex){
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch(Exception ex){
//     Console.WriteLine($"Ocorreu uma excessão Generica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }























//MANIPULANDO DATETIME E VALIDANDO

// string dataString = "2022-13-17 18:00";

// bool sucesso = DateTime.TryParseExact(
//     dataString, 
//     "yyyy-MM-dd HH:mm", 
//     CultureInfo.InvariantCulture, 
//     DateTimeStyles.None, 
//     out DateTime data);

// if(sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }else{
//     Console.WriteLine($"{dataString} não é uma data válida");
// }

// Console.WriteLine(data);














//MANIPULANDO VALORES



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

//  decimal valorMonetário = 82.40M;

//  Console.WriteLine(valorMonetário.ToString("C9"));

// double porcentagem = .3421;

//  Console.WriteLine(porcentagem.ToString("P"));

//  int numero =123456;

//  Console.WriteLine(numero.ToString("##-##-##"));
















// Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();












// Pessoa p1 = new Pessoa();
// p1.Nome = "Leonardo";
// p1.Sobrenome = "Buta";
// p1.Idade = 18;
// p1.Apresentar();
