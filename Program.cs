void loopzao()
{
Console.Clear();

int numero;

Console.WriteLine("SINAIS LOL");

Console.WriteLine("Diga quantos petiscos você quer, cachorrão");

numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você é mesmo um Cachorrão");
    Console.ResetColor();
}

else if (numero < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Que tipo de cachorro você é, Cachorrão?");
    Console.ResetColor();
}

else if (numero == 0)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine ("Então vamos pegar um ratão, Cachorrão...");
    Console.ResetColor();
}
string lockloopzao;

Console.WriteLine ("Quer recomeçar, Cachorrão?");
Console.WriteLine ("S ou N \n");    
lockloopzao = Console.ReadLine ().ToUpper();

if (lockloopzao == "S")
{
    loopzao();
}
else if (lockloopzao == "N")
{
    Console.Clear();
}
}
loopzao();