using AppTest.Business.Interfaces;
using AppTest.Business.Models;
using AppTest.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AppTest.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/fornecedores")]
    public class ClienteController : MainController
    {
        private readonly IMapper _mapper;
        private readonly IClienteService _clienteService;

        public ClienteController(INotificador notificador, IMapper mapper, IClienteService clienteService) : base(notificador)
        {
            _mapper = mapper;
            _clienteService = clienteService;
        }

        [HttpPost]
        public ActionResult<ClienteDto> Adicionar(ClienteDto clienteDto)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            _clienteService.Adicionar(_mapper.Map<Cliente>(clienteDto));

            return CustomResponse(clienteDto);
        }
    }
}
