using Joyeria.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joyeria.Data.Repositories
{
    public class ComplaintRepository : IComplaintRepository
    {
        private readonly JoyeriaDbContext _dbContext;

        public ComplaintRepository(JoyeriaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Complaint> CreateAsync(Complaint createToComplaints)

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

        public async Task<IEnumerable<Complaint>> GetComplaintssAsync()
        {
            return await this._dbContext.Complaints.ToListAsync();
        }

        public async Task<Complaint> GetComplaintstByIdAsync(int id)
        {
             var complaints= await this._dbContext.Complaints.FindAsync(id);
            return complaints;
        }
    }
}
