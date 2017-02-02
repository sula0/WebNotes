﻿using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Common
{
    public interface INoteService
    {
        Task<INote> GetNoteByIdAsync(int id);
        Task<ICategory> GetCategoryByIdAsync(int id);
        Task<List<INote>> GetNotesAsync();
        Task<List<ICategory>> GetCategoriesAsync();
        void UpdateNote(INote entity);
        void UpdateCategory(ICategory entity);
        Task DeleteNote(int id);
        Task DeleteCategory(int id);
        Task SaveChangesAsync();
    }
}
