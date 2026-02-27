using System;
using System.Collections.Generic;
using System.Text;
using static Cyberquiz.BLL.DummyFilesBLL.DummyClassCollection; // Kan tas bort senare

namespace Cyberquiz.BLL.DummyFilesBLL
{
    public interface ICatRepo
    {
        Task<List<Category>> GetAllAsync();
        Task<Category?> GetByIdAsync(int id);
    }
}
