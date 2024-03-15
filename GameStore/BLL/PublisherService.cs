using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Entities.Context;
using Entities.Entities;
using Entities.Entities.DTO;

namespace BLL
{
    public class PublisherService
    {
        PublisherRepository publisherRepository = new PublisherRepository();
        public List<Publisher> GetAllPublishersService()
        {
            return publisherRepository.GetAllPublishersRepository();
        }
        public Publisher? GetPublisherByIdService(int PublisherId)
        {
            return publisherRepository.GetPublisherByIdRepository(PublisherId);
        }
        public GameStoreResponse CreatePublisherService(Publisher p)
        {
            //if (validation)
            //{
                return publisherRepository.CreatePublisherRepository(p);
            //}
            return new GameStoreResponse("Create failed: Validation error");
        }
        public GameStoreResponse EditPublisherService(Publisher p)
        {
            //if (validation)
            //{
                return publisherRepository.EditPublisherRepository(p);
            //}
            return new GameStoreResponse("Edit failed: Validation error");
        }
        public GameStoreResponse DeletePublisherService(int PublisherId)
        {
            return publisherRepository.DeletePublisherRepository(PublisherId);
        }
    }
}
