using System;
using System.Collections.Generic;
using System.Text;
using static Cyberquiz.BLL.DummyFilesBLL.DummyClassCollection; // Kan tas bort senare

namespace Cyberquiz.BLL.DummyFilesBLL
{
    public interface IQRepo
    {
        Task<Question?> GetQByIdAsync(int id);
        Task<List<Question>> GetQsBySubCategoryIdAsync(int subCategoryId);
        Task GetQsBySubCatIdAsync(int subCatId);
    }
}
