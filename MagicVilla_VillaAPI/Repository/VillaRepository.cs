﻿using SigmaVilla_VillaAPI.Data;
using SigmaVilla_VillaAPI.Models;
using SigmaVilla_VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SigmaVilla_VillaAPI.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.DateCreated = DateTime.Now;
            _db.Villas.Update(entity);
            //dbSet.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
