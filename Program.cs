using dotnet_intermediario.Models;
using System.Globalization; // Alterar regionalizaçāo da applicaçāo
using Newtonsoft.Json;

// Método extensivo
int numero = 21;
bool ehPar = false;

ehPar = numero.EhPar(); // método diretamente na variável

Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));






























// Classe genérica - recebe vários tipos de dados, na mesma classe
// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);






























// Variável com tipo de dado automático (dinâmico)
// dynamic variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = 4;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");




























// Tipo anônimo em coleçāo
// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }























// Tipo Anonimo - parecido com a tupla
// var tipoAnonimo = new { Nome = "Matheus", Sobrenome = "Henrique", Altura = 1.75 };

// Console.WriteLine($"Nome: {tipoAnonimo.Nome}, Sobrenome: {tipoAnonimo.Sobrenome}, Altura: {tipoAnonimo.Altura}");




































// Nulos
// bool? desejaReceberEmail = true;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber e-mail");
// }
// else
// {
//     Console.WriteLine("O usuário nāo respondeu ou optou por nāo receber e-mail");
// }


































// Leitura Json
// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, " +
//                     $"Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}, " +
//                     $"Desconto: {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }






































// DateTime dataAtual = DateTime.Now;

// Json
// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 15.50M, dataAtual);
// Venda v2 = new Venda(2, "Licença Windows", 750.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado); // Escrever arquivos

// Console.WriteLine(serializado);

































// IF Ternário
// int numero = 20;
// bool ehPar = false;

// ehPar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }

































// Deconstruir objeto
// Pessoa p = new Pessoa("Matheus", "Henrique");

// (string nome, string sobrenome) = p; // Deconstrutor

// Console.WriteLine($"{nome} {sobrenome}");



























// Tuplas - Variável com mais de um item, com diferentes tipos de dados
// (int Id, string Nome, string Sobrenome) tupla = (12, "Matheus", "Henrique"); // Permite colocar Alias nos itens (mais recomendada)

// // ValueTuple<int, string, string> outroExemploTupla = (12, "Cesar", "Gustavo");

// // var outroExemploTuplaCreate = Tuple.Create(12, "Henrique", "Silva");

// Console.WriteLine($"Id: {tupla.Id}, Nome: {tupla.Nome}, Sobrenome: {tupla.Sobrenome}");

// LeituraArquivo arquivo = new LeituraArquivo();

// var /*Para nāo passar o tipo de variável*/ (sucesso, linhasArquivo, _/*quantidadeLinhas*/) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     // Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Nāo foi possível ler o arquivo");
// }
































// Fila - First In / First Out
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(5);
// fila.Enqueue(4);
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); // Sempre remove o primeiro elemento da fila

// Pilha - Last In / First Out

// Stack<int> pilha = new Stack<int>();

// pilha.Push(3);
// pilha.Push(5);
// pilha.Push(1);
// pilha.Push(7);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");

// Dicionario

// Dictionary<string/*Elemento único*/, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "Sāo Paulo");
// estados.Add("MG", "Minas Gerais");
// estados.Add("BA", "Bahia");

// Console.WriteLine(estados["BA"]);

// foreach (KeyValuePair<string, string> item in estados) // ou (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("-----------------");
// estados.Remove("MG");
// estados["SP"] = "Campinas"; // Altera valor informando a chave

// foreach (KeyValuePair<string, string> item in estados) // ou (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Procurando itens dentro do dicionário

// string chave = "RJ"; //"BA"
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor nāo existe. É seguro adicionar a chave: {chave}");
// }

















// new Excecao().Metodo1();







// try // Para tratar uma exceçāo
// {
//     // Leitura de arquivos
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }


// } // Tipos de tratamentos de exceçōes
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo nāo encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta nāo encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceçāo genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Código prosseguiu");
// }












// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); // Alterar regionalizaçāo da applicaçāo

// Conversāo para valores monetário
// decimal valorMonetario = 15.86M;

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // Altera regionalizaçāo de item específico

// Representaçāo porcentagem
// double porcentagem = .5462;

// Console.WriteLine(porcentagem.ToString("P"));

// Representaçāo personalizada
// int numero = 22122022;

// Console.WriteLine(numero.ToString("##x######"));

// Datetime

// Console.WriteLine(data.ToString("yyyy/MM/dd hh:mm:ss:ms"));

// Console.WriteLine(data.ToShortDateString());

// Console.WriteLine(data.ToShortTimeString());


// string dataString = "2022-12-12 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data); // Evitar exception

// if (sucesso)
// {
//     Console.WriteLine($"Data convertida: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} nāo é uma data válida");
// }













// Pessoa p = new Pessoa(nome: "Matheus", sobrenome: "Henrique"); /*Variável de construtores podem ser informadas*/
// Pessoa p1 = new Pessoa("Sérgio", "Santos");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p);
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.ListarAlunos();