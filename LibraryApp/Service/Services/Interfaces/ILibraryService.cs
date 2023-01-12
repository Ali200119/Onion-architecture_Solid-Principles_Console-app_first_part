using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface ILibraryService
	{
		Library Create(Library library);
		Library Delete(int id);
		Library GetById(int id);
		List<Library> Search(string searchText);
		List<Library> GetAll();
	}
}