Console.Write("Digite uma palavra da sua escolha: ");
string? input = Console.ReadLine();

char[] caracter = input.ToCharArray();

 for (int i = 0; i < caracter.Length / 2; i++)
 {
    char temp = caracter[i];
    caracter[i] = caracter[caracter.Length - 1 - i];
    caracter[caracter.Length - 1 - i] = temp;
 }
string caracterReversa = new string(caracter);

Console.WriteLine("String invertida: " + caracterReversa);
