using System;
using Ecommerce.Models;
namespace E_Commerce.Application
{
    public interface IClientRepository
    {
        public Client getOne(int id);
        public List<Client> getAll();

        public void Delete(int id);
        public Client Add(Client client);

    }
}

