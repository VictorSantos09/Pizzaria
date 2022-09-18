namespace Pizzaria
{
    public class Estabelecimento
    {
        public string Worker1 { get; set; }
        public string Worker2 { get; set; }
        public int Time { get; set; }
        public int PizzasPedidas { get; set; }
        public int PreçoPizza { get; set; }
        public int PreçoExtraComplementos { get; set; }
        public int MargemLucro { get; set; }
        public int DinheiroCaixa { get; set; }
        public int DinheiroPagar { get; set; }
        public int DinheiroReceber { get; set; }

        public void WorkesAtribution()
        {
            IsnullOrEmpty isNull = new IsnullOrEmpty();
            Console.WriteLine("Digite a função do primeiro funcionário");
            Worker1 = isNull.EmptyST(Console.ReadLine());
            Console.WriteLine("Digite a função do segundo funcionário");
            Worker2 = isNull.EmptyST(Console.ReadLine());
            Time = Time - 30;
            Console.WriteLine($"A pizza ficará pronta e será enviada em {Time} minutos");
        }
        public void PrepareTime(Ingredientes ingredientes)
        {
            IsnullOrEmpty isNull = new IsnullOrEmpty();
            Console.WriteLine($"A pizza ficará pronta em {Time} minutos");
            Console.WriteLine("Deseja direcionar funcionarios para agilizar? | 1 - Sim  2 - Não");
            string userInputWorkers = isNull.EmptyST(Console.ReadLine());
            if (userInputWorkers == "1")
            {
                WorkesAtribution();
            }
        }
    public int MoneyStatus()
        {
            Console.Clear();
            Console.WriteLine("CAIXA\n");
            DinheiroCaixa = 1500;
            Console.WriteLine($"Quantia em caixa: {DinheiroCaixa}");
            DinheiroReceber = PizzasPedidas * PreçoPizza;
            DinheiroPagar = DinheiroPagar + DinheiroReceber;
            Console.WriteLine($"Quantia a receber: {DinheiroReceber} | Pizzas Pedidas: {PizzasPedidas}");
            return DinheiroReceber;
        }
        public bool PayLeave()
        {
            Console.WriteLine("Pressione 3 para SAIR ou ENTER para continuar");
            string userLeave = Console.ReadLine();
            if (userLeave == "3")
            {
                if (PizzasPedidas > 0)
                {
                    Console.WriteLine($"Clique ENTER para pagar os {PizzasPedidas} pedidos no valor de {DinheiroPagar} antes de sair");
                    Console.ReadKey();
                    Console.WriteLine("Pagamento efetuado\nVolte Sempre!");
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
