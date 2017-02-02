﻿using Model;
using Model.Common;
using Repository.Common;
using Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class NoteService : INoteService
    {
        private IUnitOfWork _unitOfWork;
        private IRepository<INote> _noteRepo;
        private IRepository<ICategory> _categoryRepo;

        public NoteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _noteRepo = _unitOfWork.NoteRepository;
            _categoryRepo = unitOfWork.CategoryRepository;
        }

        public async Task<INote> GetNoteByIdAsync(int id)
        {
            return await _noteRepo.GetByIdAsync(id);
        }

        public async Task<ICategory> GetCategoryByIdAsync(int id)
        {
            return await _categoryRepo.GetByIdAsync(id);
        }

        public async Task<List<INote>> GetNotesAsync()
        {
            return await _noteRepo.GetAllAsync();
        }

        public async Task<List<ICategory>> GetCategoriesAsync()
        {
            return await _categoryRepo.GetAllAsync();
        }

        public void UpdateNote(INote entity)
        {
            _noteRepo.Update(entity);
        }

        public void UpdateCategory(ICategory entity)
        {
            _categoryRepo.Update(entity);
        }

        public async Task DeleteNote(int id)
        {
            await _noteRepo.Delete(id);
        }

        public async Task DeleteCategory(int id)
        {
            await _categoryRepo.Delete(id);
        }

        public async Task SaveChangesAsync()
        {
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
