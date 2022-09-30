namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {

        }

        public Professor(string nome) : base(nome)
        {
            
        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, Sou um professor, e ganho um salário de R$ {Salario}");
        }
    }
}