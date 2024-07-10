﻿using WatchMNS.Models;
using WatchMNS.Repository;
using WatchMNS.Services.Interfaces;

namespace WatchMNS.Services
{
    public class LateMissStatusService : ILateMissStatusService
    {
        private readonly LateMissStatusRepository _lateMissStatusRepository;

        public LateMissStatusService(LateMissStatusRepository lateMissStatusRepository)
        {
            _lateMissStatusRepository = lateMissStatusRepository;
        }
        public async Task AddAsync(LateMissStatus entity)
        {
            await _lateMissStatusRepository.AddAsync(entity);
        }

        public async Task DeleteAsync(object id)
        {
            await _lateMissStatusRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<LateMissStatus>> GetAllAsync()
        {
            return await _lateMissStatusRepository.GetAllAsync();
        }

        public async Task<LateMissStatus> GetByIdAsync(object id)
        {
            return await _lateMissStatusRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(LateMissStatus entity)
        {
            await _lateMissStatusRepository.UpdateAsync(entity);
        }
    }
}