namespace TriangulosOrientadoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Triangulo triangulo = new Triangulo();

                triangulo.MensagemColorida("Digite os valores dos lados do triângulo:", ConsoleColor.DarkCyan);
                Console.WriteLine();

                triangulo.MensagemColorida("\nLado 1: ", ConsoleColor.DarkCyan);
                triangulo.lado1 = double.Parse(Console.ReadLine());

                triangulo.MensagemColorida("\nLado 2: ", ConsoleColor.DarkCyan);
                triangulo.lado2 = double.Parse(Console.ReadLine());

                triangulo.MensagemColorida("\nLado 3: ", ConsoleColor.DarkCyan);
                triangulo.lado3 = double.Parse(Console.ReadLine());

                Console.WriteLine();
                triangulo.VerificarTriangulo();
                Console.ReadLine();
            }
        }
    }
}