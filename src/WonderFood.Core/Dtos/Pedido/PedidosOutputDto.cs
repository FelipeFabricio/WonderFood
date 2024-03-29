﻿using WonderFood.Core.Dtos.Produto;

namespace WonderFood.Core.Dtos.Pedido;

public class PedidosOutputDto
{
    public Guid Id { get; set; }
    public Guid ClienteId { get; set; }
    public DateTime DataPedido { get; set; }
    public string Status { get; set; }
    public decimal ValorTotal { get; set; }
    public int NumeroPedido { get; set; }
    public string Observacao { get; set; }
    public IEnumerable<ProdutosPedidoOutputDto> Produtos { get; set; }
}