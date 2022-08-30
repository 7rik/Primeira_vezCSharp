const string textoolamundo = "Ola mundo, meu primeiro programa em c#, feito por ";
string nomecompleto;
int idade;

Console.WriteLine("Qual o seu nome completo?");
nomecompleto = Console.ReadLine().ToString();

Console.WriteLine("Qual sua idade?");
idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(textoolamundo + nomecompleto + " que tem " + idade +" anos");