using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria.Core.Services
{
    public interface IComplaintsService
    {
        Task<IEnumerable<Complaints>> GetComplaintsAsync();
        Task<Complaints> GetComplaintstByIdAsync(int id);
        Task<Complaints> CreateAsync(Complaints createToComplaints);

        Task DeleteAsync(int id);
    }
}
