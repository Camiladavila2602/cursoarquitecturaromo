using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.ConsoleApp.Services
{
	internal class AppLogger(IEnumerable<IUserActionWriter> writers)
	{
        private IUserActionWriter writer;

        public AppLogger(IUserActionWriter writer)
        {
            this.writer = writer;
        }

        public void WriteLog(string message)
		{
			UserAction Log = new UserAction("System", message);
			foreach (IUserActionWriter writer in writers)
			{
				writer.Write(Log);
			}

		}
	}
}
