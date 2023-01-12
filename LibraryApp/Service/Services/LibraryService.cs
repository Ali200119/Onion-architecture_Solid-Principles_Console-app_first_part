using System;
using Domain.Models;
using Repository.Repositories;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly LibraryRepository _repo;
        private int _count = 1;

        public LibraryService()
        {
            _repo = new LibraryRepository();
        }

        public Library Create(Library library)
        {
            library.Id = _count;
            _repo.Create(library);
            _count++;
            return library;
        }

        public Library Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetAll()
        {
            throw new NotImplementedException();
        }

        public Library GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Library> Search(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}