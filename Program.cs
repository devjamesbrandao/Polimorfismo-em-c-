using polimorfismo.Models;

namespace polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de polimorfismo sem sobrecarga
            Veiculo[] veiculo = new Veiculo[2];
            Console.WriteLine("\nPolimorfismo sem sobrecarga\n");
            veiculo[0] = new Automovel("Ferrari");
            veiculo[1] = new Aeronave("Tucano");
            MovimentarVeiculo(veiculo[0]);
            MovimentarVeiculo(veiculo[1]);


            Calculadora calc = new Calculadora();
            Console.WriteLine("\nPolimorfismo com sobrecarga\n");
            Console.WriteLine("Somando 2 números...");
            Console.WriteLine(calc.Soma(45, 43));
            Console.WriteLine("Somando 3 números...");
            Console.WriteLine(calc.Soma(45, 43, 100 ));
            Console.ReadKey();
        }

        public static void MovimentarVeiculo(Veiculo veiculo)
        {
            Console.WriteLine(veiculo.Tipo);

            veiculo.Mover();
        }
    }
}