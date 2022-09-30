namespace ExemploPOO.Models
{
    public class Aluno : Pessoa 
    {
        public Aluno()
        {
            
        }

        public Aluno(string nome) : base(nome)
        {
            
        }   

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, e sou um aluno de nota {Nota}");
        }
        
    }
}