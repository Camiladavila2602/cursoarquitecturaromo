using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Writers
{
	public class FileWriter : IUserActionWriter
	{
		public void Write(UserAction action)
		{
			File.AppendAllText("AooLogs.txt",
				string.Format("FileWriter: {0}, {1}, {2}",
			action.CreatedDateTime, action.User, action.Description));
		}
	}
}