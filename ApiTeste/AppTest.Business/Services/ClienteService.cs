using AppTest.Business.Interfaces;
using AppTest.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTest.Business.Services
{
    public class ClienteService : BaseService, IClienteService
    {
        public ClienteService(INotificador notificador) : base(notificador)
        {
        
        }
        
        public bool Adicionar(Cliente cliente)
        {
            if (cliente.Nome == "Teste")
            {
                Notificar("Já existe um cliente com esse nome.");
                return false;
            }

            return true;
        }
    }
}
