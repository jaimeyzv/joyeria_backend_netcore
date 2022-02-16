using Joyeria.Core;
using Joyeria.Core.Services;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria.Services.Services
{
   public class ComplaintsService : IComplaintsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ComplaintsService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<Complaint> CreateAsync(Complaint createToComplaints)
         
        {
          await _unitOfWork.Complaints.CreateAsync(createToComplaints);
            await _unitOfWork.SaveChangesAsync();
            return createToComplaints;
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.Complaints.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Complaint>> GetComplaintsAsync()
        {
            return await _unitOfWork.Complaints.GetComplaintssAsync();
        }

        public async Task<Complaint> GetComplaintstByIdAsync(int id)
        {
            return await _unitOfWork.Complaints.GetComplaintstByIdAsync(id);
        }
    }
}
