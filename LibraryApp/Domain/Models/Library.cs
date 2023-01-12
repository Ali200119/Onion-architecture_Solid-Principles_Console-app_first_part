using System;
using Domain.Common;

namespace Domain.Models
{
	public class Library: BaseEntity
	{
		public string Name { get; set; }
		public int SeatCount { get; set; }
		public List<Book> Books { get; set; }
	}
}