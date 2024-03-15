using Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Entities;
using Entities.Entities.DTO;

namespace DAL
{
    public class PublisherRepository
    {
        GameStoreContext gameStoreContext = new GameStoreContext();

        public List<Publisher> GetAllPublishersRepository()
        {
            return gameStoreContext.Publishers.ToList();
        }
        public Publisher? GetPublisherByIdRepository(int PublisherId)
        {
            return gameStoreContext.Publishers.Where(x => x.PublisherId == PublisherId).FirstOrDefault();
        }
        public GameStoreResponse CreatePublisherRepository(Publisher p)
        {

            using (var transaction = gameStoreContext.Database.BeginTransaction())
            {
                //pme.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Product ON");
                gameStoreContext.Publishers.Add(p);
                gameStoreContext.SaveChanges();
                //pme.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Product OFF");

                transaction.Commit();
            }
            return new GameStoreResponse();
        }
        public GameStoreResponse EditPublisherRepository(Publisher p)
        {
            using (var transaction = gameStoreContext.Database.BeginTransaction())
            {
                Publisher? p2 = gameStoreContext.Publishers.Where(x => x.PublisherId == p.PublisherId).FirstOrDefault();
                if (p2 != null)
                {
                    p2.PublisherName = p.PublisherName;
                    p2.PublisherEmail = p.PublisherEmail;
                    p2.PublisherDescription = p.PublisherDescription;
                    gameStoreContext.SaveChanges();

                    transaction.Commit();
                    return new GameStoreResponse();
                }
            }
            return new GameStoreResponse("Edit failed: Cannot find Publisher with id "+p.PublisherId);
        }
        public GameStoreResponse DeletePublisherRepository(int PublisherId)
        {
            Publisher? p = gameStoreContext.Publishers.Where(x => x.PublisherId == PublisherId).FirstOrDefault();
            if (p != null)
            {
                gameStoreContext.Publishers.Remove(p);
                gameStoreContext.SaveChanges();
                return new GameStoreResponse();
            }
            return new GameStoreResponse("Delete failed: Cannot find Publisher with id "+PublisherId);
        }
    }
}
