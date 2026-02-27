using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.BLL.Interfaces
{
    public interface IProgressService // Interface för kontrakt med Service
    {
        Task<bool> IsSubCategoryUnlockedAsync(string userId, int subCatId);
    }
}
