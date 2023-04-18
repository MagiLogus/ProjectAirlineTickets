//1-Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.
//Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
//O sistema deve exibir um menu com as seguintes opções:
//1- Cadastrar passagem
//2- Listar Passagens
//0- Sair
//Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

String usuario;
String senha;
String resposta;
int opcao;
string [] nomes = new string[5];
string [] origem = new string[5];
string [] destino = new string[5];
string [] data = new string[5];

//Metodo
static bool ValidarSenha(string senha)
{
if (senha == "123456")
{
Console.WriteLine("Senha correta, login efetuado !");
return true;
}

else
{
Console.WriteLine("Senha incorreta, login negado, tente novamente !");
return false;
}
}

//Login
Console.WriteLine($"Bem-Vindo a IANES TURISMO !");
Console.Write($"Por favor, informe o seu usuário: ");
usuario = Console.ReadLine();

while (true)
{
Console.Write($"Por favor, informe a sua senha:");
senha = Console.ReadLine();
if (ValidarSenha(senha))
{
break;
}
}

//Menu 
while (true)
{
Console.WriteLine(@$"
Bem-vindo {usuario} !
=======================================
| Selecione uma das seguintes opções: |
| 1 - Cadastrar passagem              |
| 2 - Listar passagens                |
| 0 - Sair                            |
=======================================
");

opcao = int.Parse(Console.ReadLine());

while (opcao < 0 || opcao > 2)
{
Console.WriteLine("Opção inválida. Tente novamente.");   
opcao = int.Parse(Console.ReadLine());
}

//Ações do menu 
switch (opcao)
{
case 1:
for (int i = 0; i < 5; i++)
{
Console.WriteLine($"");
Console.WriteLine($"{i + 1}º Passageiro ");
Console.WriteLine("Informe o nome:");
nomes[i] = Console.ReadLine();

Console.WriteLine("Informe a origem:");
origem[i] = Console.ReadLine();

Console.WriteLine("Informe o destino:");
destino[i] = Console.ReadLine();

Console.WriteLine("Informe a data do voo em dd/mm/aaaa:");
data[i] = Console.ReadLine();

Console.WriteLine("A passagem foi cadastrada com sucesso!");
            
Console.WriteLine("Desejaria cadastrar uma nova passagem? (S/N)");
resposta = Console.ReadLine().ToUpper();
if (resposta != "S")
{
break;
}
}
break;

case 2: 
if (string.IsNullOrEmpty(nomes[0]))
{
Console.WriteLine("Nenhuma passagem foi cadastrada ainda.");
}
else
{
Console.WriteLine("Passagens cadastradas:");
for (var i = 0; i < 5; i++)
{
if (!string.IsNullOrEmpty(nomes[i]))
{
Console.WriteLine(@$"
===============================================
                 {i+1}º Ticket                
  Passageiro: {nomes[i]}                      
  Origem: {origem[i]}                         
  Destino: {destino[i]}                       
  Data do voo: {data[i]}                      
===============================================
");
}
}
}
break;

case 0:
Console.WriteLine("Efetuando logout.....");
return;

default:
Console.WriteLine("A opção é inválida. Tente novamente.");
break;
}
}