namespace Pizzaria
{
    public class Ingredientes
    {
        public bool UserChoicePizza()
        {
            IsnullOrEmpty isNull = new IsnullOrEmpty();
            string[] sabores = new string[5];
            sabores[0] = "Quatro Queijos\nMolho de tomate, mussarela, parmesão, provolone e catupiry";
            sabores[1] = "Strogonoff De Frango\nMolho de tomate, mussarela, strogonoff de frango";
            sabores[2] = "Portuguesa\nmussarela, presunto, ovo, cebola e azeitona verde";
            sabores[3] = "Coração\nMolho de tomate, mussarela, coração";
            sabores[4] = "Bacon\nMolho de tomate, mussarela, bacon";

            Console.WriteLine("SABORES DISPONÍVEIS\n");
            Console.WriteLine($"1 - {sabores[0]}\n2 - {sabores[1]}\n3 - {sabores[2]}\n4 - {sabores[3]}\n5 - {sabores[4]}\n");
            Console.WriteLine("Digite sua escolha:");
            string userInputSabor = isNull.EmptyST(Console.ReadLine());
            Console.Clear();
            if (userInputSabor == "1")
            {
                Console.WriteLine($"{sabores[0]} será preparada!");
                return true;
            }
            else if (userInputSabor == "2")
            {
                Console.WriteLine($"{sabores[1]} será preparada!");
                return true;
            }
            else if (userInputSabor == "3")
            {
                Console.WriteLine($"{sabores[2]} será preparada!");
                return true;
            }
            else if (userInputSabor == "4")
            {
                Console.WriteLine($"{sabores[3]} será preparada!");
                return true;
            }
            else if (userInputSabor == "5")
            {
                Console.WriteLine($"{sabores[4]} será preparada!");
                return true;
            }
            else
            {
                Console.WriteLine("Tente novamente");
                return false;
            }
        }
        public void Inventory(string[] complementos)
        {
            Console.WriteLine();
            Console.WriteLine("ESTOQUE\n");
            Random random = new Random();
            int contador = 1;
            for (int i = 0; i < complementos.Length; i++)
            {
                Console.WriteLine($"{contador} - {complementos[i]} | Em Estoque: {random.Next(150,500)}");
                contador++;
            }
        }
        public void ItensValor(string[] complementos)
        {
            int[] complementosQtd = new int[10];


            IsnullOrEmpty isNull = new IsnullOrEmpty();
            Console.WriteLine("Deseja adicionar complementos? 1 - Sim | 2 - Não");
            string userInputAdd = isNull.EmptyST(Console.ReadLine());
            if (userInputAdd == "1")
            {
                Console.Clear();
                int contador = 1;
                Console.WriteLine("OPÇÕES DISPONÍVEIS");
                for (int i = 0; i < complementos.Length; i++)
                {
                    Console.WriteLine($"{contador} - {complementos[i]}");
                    contador++;
                }
                Console.WriteLine("Digite qual deseja");
                string userInputCpt = isNull.EmptyST(Console.ReadLine());
                if (userInputCpt == "1")
                {
                    ItemPattern(complementosQtd[0], complementos[0]);
                }
                else if (userInputCpt == "2")
                {
                    ItemPattern(complementosQtd[1], complementos[1]);
                }
                else if (userInputCpt == "3")
                {
                    ItemPattern(complementosQtd[2], complementos[2]);
                }
                else if (userInputCpt == "4")
                {
                    ItemPattern(complementosQtd[3], complementos[3]);
                }
                else if (userInputCpt == "5")
                {
                    ItemPattern(complementosQtd[4], complementos[4]);
                }
                else if (userInputCpt == "6")
                {
                    ItemPattern(complementosQtd[5], complementos[5]);
                }
                else if (userInputCpt == "7")
                {
                    ItemPattern(complementosQtd[6], complementos[6]);
                }
                else if (userInputCpt == "8")
                {
                    ItemPattern(complementosQtd[7], complementos[7]);
                }
                else if (userInputCpt == "9")
                {
                    ItemPattern(complementosQtd[8], complementos[8]);
                }
                else if (userInputCpt == "10")
                {
                    ItemPattern(complementosQtd[9], complementos[9]);
                }
                Console.WriteLine($"Em preparo!");
            }
            else
            {
                Console.WriteLine($"Nenhum complemento extra adicionado\nEm preparo!");
            }
            Console.WriteLine("Clique ENTER");
            Console.ReadKey();
        }
        public int ItemPattern(int complementosQtd, string complementos)
        {
            IsnullOrEmpty isNull = new IsnullOrEmpty();
            Console.WriteLine("Quantos deseja adicionar?");
            complementosQtd = isNull.EmptyINT(complementosQtd);
            Console.WriteLine($"Foram adicionados {complementosQtd} de {complementos}");
            return complementosQtd;
            // Transferir retorno do IF nao sei fazer ( necessario pegar o return  do ItemPattern
            // e jogar no estabelecimento.TempoPreparo() para fazer o calculo sem re chamar o metodo)

            // {acontece do user nao querer
            // complemento e mesmo assim é obrigado a chamar ou mesmo ele querendo tem que selecionar novamente}
        }
    }
}