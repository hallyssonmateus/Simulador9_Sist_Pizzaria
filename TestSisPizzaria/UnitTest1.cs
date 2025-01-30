using Sistema_Pizzaria.controller;
using Moq;
using Sistema_Pizzaria.Infra;
using Sistema_Pizzaria.Models;
using Microsoft.AspNetCore.Mvc;
using Sistema_Pizzaria.Services;

namespace TestSisPizzaria
{
    [TestFixture]
    public class Tests
    {
        private PedidoService _pedidoService;

        [SetUp]
        public void Setup()
        {
            _pedidoService = new PedidoService(); // Criamos uma nova instância antes de cada teste
        }
    

        [Test]
        public void CalcularTempoPedido_DeveRetornarTempoCorreto_QuandoTodosSaboresExistem()
        {
            // Arrange
            var sabores = new List<string> { "Calabresa", "Portuguesa" };

            // Act
            int tempoTotal = _pedidoService.CalcularTempoPedido(sabores);

            // Assert
            Assert.AreEqual(33, tempoTotal); // 15 + 18
        }

        [Test]
        public void CalcularTempoPedido_DeveLancarExcecao_QuandoSaborNaoExiste()
        {
            // Arrange
            var sabores = new List<string> { "Calabresa", "Frango com Catupiry" };

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => _pedidoService.CalcularTempoPedido(sabores));
            Assert.AreEqual("Um ou mais sabores do pedido estão em falta.", ex.Message);
        }
    }
}