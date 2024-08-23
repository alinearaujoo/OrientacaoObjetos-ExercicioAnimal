
using Domain;

var bebe = new Macaco(1, "César", 0, ETipoIdade.mes);
var adultoMacaco = new Macaco(2, "Nola", 18, ETipoIdade.ano);

Mamifero doguinho = new Doguinho(3, "Toby", 1, ETipoIdade.ano,"basé");

Console.WriteLine(bebe.Nascer());
Console.WriteLine(bebe.Crescer(0, ETipoIdade.mes));

Console.WriteLine(adultoMacaco.Crescer(18, ETipoIdade.ano));
Console.WriteLine(adultoMacaco.Morrer());

Console.WriteLine(doguinho.Nascer());
Console.WriteLine(doguinho.Crescer(1, ETipoIdade.ano));
Console.WriteLine(doguinho.Morrer());