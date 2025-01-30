using Sistema_Pizzaria.Models;

namespace Sistema_Pizzaria.Services
{
    public class PedidoService
    {
        private readonly List<Pizza> _pizzasDisponiveis;

        public PedidoService()
        {
            // Lista fixa de pizzas para evitar dependência do banco de dados
            _pizzasDisponiveis = new List<Pizza>
        {
            new Pizza { Sabor = "Calabresa", TempoPreparo = 15 },
            new Pizza { Sabor = "Mussarela", TempoPreparo = 12 },
            new Pizza { Sabor = "Portuguesa", TempoPreparo = 18 }
        };
        }

        public int CalcularTempoPedido(List<string> sabores)
        {
            int tempoTotal = 0;

            foreach (var sabor in sabores)
            {
                var pizza = _pizzasDisponiveis.FirstOrDefault(p => p.Sabor == sabor);

                if (pizza == null)
                    throw new ArgumentException("Um ou mais sabores do pedido estão em falta.");

                tempoTotal += pizza.TempoPreparo;
            }

            return tempoTotal;
        }
    }
}
