﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Entities.Entities;

namespace BLL
{
    public class PublisherService
    {
        PublisherRepository publisherRepository = new PublisherRepository();
        public List<Publisher> GetAllPublishersService()
        {
            return publisherRepository.GetAllPublishersRepository();
        }

    }
}