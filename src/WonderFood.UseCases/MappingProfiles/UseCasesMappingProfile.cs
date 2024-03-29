﻿using AutoMapper;
using WonderFood.Core.Dtos.Cliente;
using WonderFood.Core.Dtos.Pedido;
using WonderFood.Core.Dtos.Produto;
using WonderFood.Core.Entities;

namespace WonderFood.UseCases.MappingProfiles;

public class UseCasesMappingProfile : Profile
{
    public UseCasesMappingProfile()
    {
        CreateMap<Cliente, ClienteOutputDto>().ReverseMap();
        CreateMap<Cliente, InserirClienteInputDto>().ReverseMap();
        CreateMap<Cliente, AtualizarClienteInputDto>().ReverseMap();
        
        CreateMap<Produto, ProdutoOutputDto>().ReverseMap();
        CreateMap<Produto, InserirProdutoInputDto>().ReverseMap();
        
        CreateMap<Pedido, StatusPedidoOutputDto>().ReverseMap();
        CreateMap<Pedido, PedidosOutputDto>().ReverseMap();
        CreateMap<Pedido, InserirPedidoInputDto>().ReverseMap();
        
        CreateMap<ProdutosPedido,InserirProdutosPedidoInputDto>().ReverseMap();
        CreateMap<ProdutosPedido, ProdutosPedidoOutputDto>()
            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Produto.Nome))
            .ForMember(dest => dest.Valor, opt => opt.MapFrom(src => src.Produto.Valor))
            .ForMember(dest => dest.Quantidade, opt => opt.MapFrom(src => src.Quantidade));
    }
}