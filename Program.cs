string? Digitei = Console.ReadLine();
string[] partes = Digitei.Split(' ');

int a = int.Parse(partes[0]);
string operador = partes[1];
int b = int.Parse(partes[2]);
Console.WriteLine(Calculos(a, b, operador));

static int Calculos(int a, int b, string operador)
{
    if (operador == "+")
        return a + b;
    else if (operador == "-")
        return a - b;
    else if (operador == "*")
        return a * b;
    else if (operador == "/")
        return a / b;
    else
        throw new Exception("Operador inválido");
}