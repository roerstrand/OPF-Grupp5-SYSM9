using Cyberquiz.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.BLL.Services
{
    // Reglerar åtkomst
    // Använder ResultsService för att hämta information om användarens resultat
    public class ProgressService : IProgressService // Serviceklass implementerar Interface
    {
        // Fält
        private readonly AppDbContext _appContext;

        // Konstruktor
        public ProgressService(AppDbContext appContext) 
        {
            _appContext = appContext;
        }

        // Metod för att avgöra om en subkategori är upplåst - tar ID för användaren och underkategorin som argument
        public async Task<bool> IsSubCategoryUnlockedAsync(string userId, SubCategory subCat)
        {
            // Säkerställ att första underkategorin är upplåst
            if (subCat.Order == 1) {
                return true;
            }
            // Hämta den senaste underkategorin
            // Metod ska läggas till i ISubCatService och SubCatService
            // Hämta föregående underkategori och användarens resultat för den
            var score = await _iMyResultService.GetScoreForSubCategoryAsync(userId, subCatId - 1);
            // Kontrollera >= 0.8
            if (score >= 0.8) {
                return true;
            }
            return false;
        }

    }
}
