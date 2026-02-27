using Cyberquiz.BLL.DummyFilesBLL;
using Cyberquiz.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static Cyberquiz.BLL.DummyFilesBLL.DummyClassCollection;

namespace Cyberquiz.BLL.Services
{
    // Skapa subkategoriöversikt (för UI)
    // Hämta subkategori
    // Räkna antal frågor
    // Kontrollera upplåsning
    // Returnera SubCategoryDto
    public class SubCatService : ISubCatService // Serviceklass implementerar Interface
    {
        // Använder ISubCategoryRepository för att hämta kategorier
        private readonly ISubCatRepo _subCategoryRepo;

        public SubCatService(ISubCatRepo subCategoryRepo)
        {
            _subCategoryRepo = subCategoryRepo;
        }

        // Metod för att hämta underkategorier
        public async Task<List<SubCategory>> GetAllAsync()
        {
            return await _subCategoryRepo.GetAllAsync();
        }
        // Mappa till CategoryOverviewDto - SENARE 
    }
}
