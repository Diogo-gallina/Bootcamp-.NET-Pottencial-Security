namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;     
                Console.WriteLine("Saque realizado com sucesso");          
            }
            else
            {
                Console.WriteLine("Operação bloqueada. Você não tem saldo o suficiente!");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponivel é: {saldo}") ;
        }
    }
}