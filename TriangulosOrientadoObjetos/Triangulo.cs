using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangulosOrientadoObjetos
{
    internal class Triangulo
    {
        public double lado1, lado2, lado3;
        
        public void VerificarTriangulo()
        {
            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
            {
                MensagemColorida("Os lados do triângulo devem ser maiores que zero!", ConsoleColor.Red);
            }
            else if (lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2 || lado2 + lado3 <= lado1)
            {
                MensagemColorida("Triângulo Inválido.", ConsoleColor.Red);
            }
            else
            {
                // Verifica a classificação do triângulo inserido
                if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
                {
                    MensagemColorida("Triângulo Equilátero.", ConsoleColor.Cyan);
                }
                else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                {
                    MensagemColorida("Triângulo Escaleno.", ConsoleColor.Cyan);
                }
                else
                {
                    MensagemColorida("Triângulo Isósceles.", ConsoleColor.Cyan);
                }
            }
        }

        public void MensagemColorida(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(mensagem);
            Console.ResetColor();
        }
    }
}
