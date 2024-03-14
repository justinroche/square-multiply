class Program
{

  static void Main()
  {

    // Obtain modular exponentiation values.
    Console.WriteLine("Enter the base number: ");
    long baseNumber = long.Parse(Console.ReadLine());
    Console.WriteLine("Enter the exponent: ");
    long exponent = long.Parse(Console.ReadLine());
    Console.WriteLine("Enter the modulo: ");
    long modulo = long.Parse(Console.ReadLine());

    // Compute and print result.
    long result = RunSquareMultiply(baseNumber, exponent, modulo);
    Console.WriteLine("Result: " + result);
  }

  static long RunSquareMultiply(long baseNumber, long exponent, long modulo)
  {
    long result = 1;
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