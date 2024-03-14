class Program
{

  static void Main()
  {

    // Obtain modular exponentiation values.
    Console.WriteLine("Enter the base number: ");
    int baseNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the exponent: ");
    int exponent = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the modulo: ");
    int modulo = int.Parse(Console.ReadLine());

    // Compute and print result.
    int result = RunSquareMultiply(baseNumber, exponent, modulo);
    Console.WriteLine("Result: " + result);
  }

  static int RunSquareMultiply(int baseNumber, int exponent, int modulo)
  {
    int result = 1;
    string binaryExponent = Convert.ToString(exponent, 2);

    Console.WriteLine("Exponent (" + exponent + ") in binary: " + binaryExponent);

    for (int i = 0; i < binaryExponent.Length; i++)
    {
      result = result * result % modulo;
      if (binaryExponent[i] == '1')
        result = result * baseNumber % modulo;

      Console.WriteLine("Step " + i + " (" + binaryExponent[i] + "): " + result);
    }

    return result;
  }

}