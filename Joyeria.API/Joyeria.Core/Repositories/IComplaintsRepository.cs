using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria.Core.Repositories
{
    public interface IComplaintsRepository
    {
        Task<IEnumerable<Complaints>> GetComplaintssAsync();
        Task<Complaints> GetComplaintstByIdAsync(int id);
        Task<Complaints> CreateAsync(Complaints createToComplaints);
        Task DeleteAsync(int id);
    }
}
