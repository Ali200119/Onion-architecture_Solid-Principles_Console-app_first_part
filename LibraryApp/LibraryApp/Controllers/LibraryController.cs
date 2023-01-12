using System;
using Domain.Models;
using Service.Helpers;
using Service.Services;
using Service.Services.Interfaces;

namespace LibraryApp.Controllers
{
	public class LibraryController
	{
		private readonly ILibraryService _service;

		public LibraryController()
		{
			_service = new LibraryService();
		}

		public void Create()
		{
			ConsoleColor.DarkCyan.WriteConsole("Please enter library name");

			string libraryName = Console.ReadLine();

            ConsoleColor.DarkCyan.WriteConsole("Please enter seat count");

			SeatCount: string seatCountStr = Console.ReadLine();

			int seatCount;

			bool isCorrectSeatCount = int.TryParse(seatCountStr, out seatCount);

			if (isCorrectSeatCount)
			{
				Library library = new Library
				{
					Name = libraryName,
					SeatCount = seatCount
				};

				var response = _service.Create(library);
				ConsoleColor.Green.WriteConsole($"{response.Id}  {response.Name}  {response.SeatCount}");
			}

			else
			{
                ConsoleColor.DarkCyan.WriteConsole("Please enter correct format seat count");
				goto SeatCount;
            }
        }
	}
}