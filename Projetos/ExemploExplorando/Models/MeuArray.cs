namespace ExemploExplorando.Models
{
    public class MeuArray<T>
    {
        private static int capacidadade = 10;
        private int contador = 0;
        private T[] array = new T[10];

        public void AdicionarElementoArray(T elemento)
        {
            if(contador + 1 < 11)
            {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get{ return array[index];}
            set{ array[index] = value;}
        }
    }
}