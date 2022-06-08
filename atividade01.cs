string nomeDoUsuario;
int idadeDoUsuario;
int anoAtual = 2022;

Console.WriteLine("Digite o seu nome: ");
nomeDoUsuario = Console.ReadLine();

Console.WriteLine("Digite a sua idade: ");
idadeDoUsuario = int.Parse(Console.ReadLine());

var anoNascimento = (anoAtual) - (idadeDoUsuario);
Console.WriteLine("Olá " + nomeDoUsuario + ", você nasceu em " + anoNascimento);
