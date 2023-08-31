// Repository/ItineraryMasterRepository.cs

using System;
using System.Collections.Generic;
using System.Linq;
using ETourProject1.Models;
using Microsoft.EntityFrameworkCore;

namespace ETourProject1.Repository
{
    public class ItineraryRepository : Itinerary_Master
    {
        private readonly Appdbcontext _dbContext;

        public ItineraryRepository(Appdbcontext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Itinerary_Master> GetAll()
        {
            return _dbContext.Itinerary_Master.ToList();
        }

        public Itinerary_Master GetById(int id)
        {
            return _dbContext.Itinerary_Master.Find(id);
        }

        public void Add(Itinerary_Master itinerary)
        {
            _dbContext.Itinerary_Master.Add(itinerary);
            _dbContext.SaveChanges();
        }

      
    }
}
