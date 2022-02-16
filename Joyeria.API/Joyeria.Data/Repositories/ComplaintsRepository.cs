using Joyeria.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria.Data.Repositories
{
    public class ComplaintsRepository : IComplaintsRepository
    {
        private readonly JoyeriaDbContext _dbContext;

        public ComplaintsRepository(JoyeriaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<Complaints> CreateAsync(Complaints createToComplaints)

        {
            await _dbContext.Complaints.AddAsync(createToComplaints);
            await _dbContext.SaveChangesAsync();
            return createToComplaints;
        }

        public async Task DeleteAsync(int id)
        {
            var complaints = await _dbContext.Complaints.FindAsync(id);
            _dbContext.Complaints.Remove(complaints);
           
        }

    

        public async Task<IEnumerable<Complaints>> GetComplaintssAsync()
        {
            return await this._dbContext.Complaints.ToListAsync();
        }

        public async Task<Complaints> GetComplaintstByIdAsync(int id)
        {
             var complaints= await this._dbContext.Complaints.FindAsync(id);
            return complaints;
        }
    }
}
