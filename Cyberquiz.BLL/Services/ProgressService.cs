using Cyberquiz.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.BLL.Services
{
    // Reglerar åtkomst
    // Behöver få information om användarens resultat för att avgöra åtkomst
    public class ProgressService : IProgressService // Serviceklass implementerar Interface
    {
        //// Fält och egenskaper
        //private readonly ISubCategoryRepository _iSubRepo;
        //private readonly IProgressService _iProgressService;

        //// Konstruktor
        //public ProgressService(ISubCategoryRepository iSubRepo, IProgressService iProgressService)
        //{
        //    _iSubRepo = iSubRepo;
        //    _iProgressService = iProgressService;
        //}

        // Asnkron metod för att avgöra om en subkategori är upplåst
        public async Task<bool> IsSubCategoryUnlockedAsync(string userId, int subCategoryId)
        {
            var sub = await _iSubRepo.GetByIdAsync(subCategoryId);
            if (sub.Order == 1)
                return true;

            var previous = await _iSubRepo.GetPreviousAsync(sub);

            var score = await _resultService
                .GetScoreAsync(userId, previous.Id);

            return score >= 0.8;
        }
    }
}
