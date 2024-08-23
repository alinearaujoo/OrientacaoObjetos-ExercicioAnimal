namespace Domain
{
    public abstract class Mamifero : IAnimal
    {
        public int ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public ETipoIdade TipoIdade { get; set; }

        public Mamifero()
        {

        }

        public Mamifero(int id, string nome, int idade, ETipoIdade tipoIdade)
        {
            ID = id;
            Nome = nome;
            Idade = idade;
            TipoIdade = tipoIdade;
        }
        public virtual string Nascer() => $"Silvio Santos acabou de reencarnar em: {Nome}";

        public virtual string Crescer(int idade, ETipoIdade tipoIdade) =>
           $" {Nome} Está crescendo e fazendo! {idade} {tipoIdade}!";

        public virtual string Morrer() => $"Bem vindo ao Timão, {Nome}!";
    }
}
