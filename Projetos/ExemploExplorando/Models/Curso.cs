namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome  { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }


        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int qantidade = Alunos.Count;
            return qantidade;
        }
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: Numero: {Nome}");

            for(int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                string texto = $"Nº {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
            
        }
    }
}