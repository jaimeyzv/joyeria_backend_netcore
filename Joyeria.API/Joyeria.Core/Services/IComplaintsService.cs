﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria.Core.Services
{
    public interface IComplaintsService
    {
        Task<IEnumerable<Complaint>> GetComplaintsAsync();
        Task<Complaint> GetComplaintstByIdAsync(int id);
        Task<Complaint> CreateAsync(Complaint createToComplaints);

        Task DeleteAsync(int id);
    }
}