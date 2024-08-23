namespace Domain
{
    public class Macaco: Mamifero
    {
        public Macaco(int id, string nome, int idade, ETipoIdade tipoIdade)
        {
            ID = id;
            Nome = nome;
            Idade = idade;
            TipoIdade = tipoIdade;
        }

        public override string Nascer() => "César acaba de chegar ao mundo! Bem vindo César";

        public override string Crescer(int idade, ETipoIdade tipoIdade)
        {

            switch (tipoIdade)
            {
                case ETipoIdade.dia:
                    return $"Meu bebê {Nome} está completando mais um dia de vida. Agora são {idade + 1} dias.";
                case ETipoIdade.mes:
                    return $"{Nome} está completando mais um mêsversário de {idade + 1}.";
                case ETipoIdade.ano:
                    return $"Feliz aniversário {Nome} está completando {idade + 1} anos";
                default:
                    break;
            }
  
            return "Tipo de idade invalido!";
        }

        public override string Morrer() => base.Morrer();
      
    }
}
