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
            return _dbContext.ItineraryMasters.ToList();
        }

        public Itinerary_Master GetById(int id)
        {
            return _dbContext.ItineraryMasters.Find(id);
        }

        public void Add(Itinerary_Master itinerary)
        {
            _dbContext.ItineraryMasters.Add(itinerary);
            _dbContext.SaveChanges();
        }

        public void Update(Itinerary_Master itinerary)
        {
            _dbContext.Entry(itinerary).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var itinerary = _dbContext.ItineraryMasters.Find(id);
            if (itinerary != null)
            {
                _dbContext.ItineraryMasters.Remove(itinerary);
                _dbContext.SaveChanges();
            }
        }
    }
}


