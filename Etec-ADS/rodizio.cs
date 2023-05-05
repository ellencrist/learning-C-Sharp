namespace Rodizio
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
For (int i=1;i<4;i++){
            
Console.WriteLine("Digite o final da placa: ");
            N = int.Parse(Console.ReadLine());
            
            if (N == 1 || N == 2)
            {
                Console.WriteLine("Segunda feira não pode circular");
            }
        
            
            else if(N==3 || N==4)
            {
            Console.WriteLine("Terça-feira não pode circular");
            }
        
            else if(N==6 || N==7)
            {
            Console.WriteLine("Quarta-feira não pode circular");
            }

            else if (N == 7 || N == 8)
            {
            Console.WriteLine("Quinta-feira não pode circular");
            }

            else if(N==9 || N==10)
            {
            Console.WriteLine("Sexta-feira não pode circular");
            }

            else
            {
            Console.WriteLine("NÚMERO INVÁLIDO");
            }
}
            Console.ReadLine();



        }
    }
}