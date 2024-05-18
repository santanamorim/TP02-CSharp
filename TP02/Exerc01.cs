using System;

namespace TP02Exerc01
{
    public class Exerc01
    {
        public static void Main()
        {
            int homens = 0;
            int mulheres = 0;
            int criancas = 0;
            int idosos = 0;

            Console.WriteLine("Entre com um caractere por vez (H para homem, M para mulher, C para criança, I para idoso, F para finalizar):");

            while (true)
            {
                Console.Write("Entre com um caractere: ");
                char caractere = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (caractere == 'F')
                {
                    break;
                }
                else if (caractere == 'H')
                {
                    homens += 1;
                }
                else if (caractere == 'M')
                {
                    mulheres += 1;
                }
                else if (caractere == 'C')
                {
                    criancas += 1;
                }
                else if (caractere == 'I')
                {
                    idosos += 1;
                }
                else
                {
                    Console.WriteLine("Caractere inválido. Por favor, entre com H, M, C, I ou F.");
                }
            }

            int total = homens + mulheres + criancas + idosos;

            if (total > 0)
            {
                double percentHomens = (double)homens / total * 100;
                double percentMulheres = (double)mulheres / total * 100;
                double percentCriancas = (double)criancas / total * 100;
                double percentIdosos = (double)idosos / total * 100;

                Console.WriteLine($"Total de homens = {homens} - {percentHomens:F2}%");
                Console.WriteLine($"Total de mulheres = {mulheres} - {percentMulheres:F2}%");
                Console.WriteLine($"Total de crianças = {criancas} - {percentCriancas:F2}%");
                Console.WriteLine($"Total de idosos = {idosos} - {percentIdosos:F2}%");
            }
            else
            {
                Console.WriteLine("Nenhum caractere válido foi inserido.");
            }
        }
    }
}
