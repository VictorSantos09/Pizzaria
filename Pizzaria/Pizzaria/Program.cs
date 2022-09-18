using Pizzaria;

Ingredientes ingredientes = new Ingredientes();
Clientes clientes = new Clientes();
Estabelecimento estabelecimento = new Estabelecimento();
IsnullOrEmpty isNull = new IsnullOrEmpty();

estabelecimento.PreçoPizza = 70;
estabelecimento.PizzasPedidas = 0;
estabelecimento.Time = 45;

string[] complementos = new string[10];
complementos[0] = "Tomate";
complementos[1] = "Azeitona";
complementos[2] = "Cheddar";
complementos[3] = "Calabresa";
complementos[4] = "Frango Grelhado";
complementos[5] = "Carne";
complementos[6] = "Milho";
complementos[7] = "Bacon";
complementos[8] = "Ovo";
complementos[9] = "Cebola";

Console.WriteLine($"Bem - Vindo á Tipizza Pizzaria\nQualquer pedido por R${estabelecimento.PreçoPizza}!\n");

bool open = true;
while (open)
{
    if (estabelecimento.PayLeave() == true)
    {
        break;
    }
    else
    {
        clientes.Cadastro(isNull);
        Console.Clear();
    } 
    if (ingredientes.UserChoicePizza() == false)
    {
        break;
    }
    else
    {
        estabelecimento.PizzasPedidas++;
        ingredientes.ItensValor(complementos);
        estabelecimento.PrepareTime(ingredientes);
    }
    Console.WriteLine("Clique 1 para ver Estoque e Caixa, ou ENTER para continuar comprando");
    string userinputChoice = Console.ReadLine();
    if (userinputChoice == "1")
    {
        estabelecimento.MoneyStatus();
        ingredientes.Inventory(complementos);
    }
}