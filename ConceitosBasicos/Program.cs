// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string nome = "seu nome";
Console.WriteLine("Seja bemvindo(a) " + nome);
string cidade = "Pinheiral";
Console.WriteLine($"Eu gosto de {cidade}");
string sobrenome = "de tal", apelido;
int idade = 16;
Console.WriteLine($"A idade informada foi {idade}");

byte valor = 255;
valor += 1; //valor = valor + 1;
Console.WriteLine($"valor: {valor}");

decimal salario = 5000.20m;
//como seria a declaração mais adequada para variáveis que armazenam altura, peso e altura em nanometros;
float altura = 1.60f, peso = 43.2f;
double alturaEmNano = altura * 0.000000001;
Console.WriteLine($"A sua altura é {altura}m");
Console.WriteLine($"se você pudesse ser o homem formiga, teria a altura {alturaEmNano}nm");
Console.WriteLine($"O peso informado foi: {peso}kg");
