namespace Pizzaria
{
    public class Clientes
    {
        public string Nome { get; set; }
        public string Endereço { get; set; }
        public string FormaPagamento { get; set; }
        public string Telefone { get; set; }
        public void Cadastro(IsnullOrEmpty isNull)
        {
            Console.WriteLine("CADASTRO CLIENTE\n");
            Console.WriteLine("Digite o nome:");
            Nome = isNull.EmptyST(Console.ReadLine());
            Console.WriteLine("Digite o endereço de entrega:");
            Endereço = isNull.EmptyST(Console.ReadLine());
            Console.WriteLine("Digite a forma de pagamento");
            FormaPagamento = isNull.EmptyST(Console.ReadLine());
            Console.WriteLine("Digite o telefone:");
            Telefone = isNull.EmptyST(Console.ReadLine());
            Console.WriteLine($"Cliente {Nome} cadastrado com sucesso!");
            Console.WriteLine("Clique ENTER");
            Console.ReadKey();
        }
    }
}
