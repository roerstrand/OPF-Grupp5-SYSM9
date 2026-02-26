using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.BLL.Interfaces
{
    internal interface IProgressService // Interface för kontrakt med Service
    {
        // Operation som anropar metod i ProgressServiceklassen
        Task<bool> IsSubCategoryUnlockedAsync(string userId, int subCategoryId);
    }
}
