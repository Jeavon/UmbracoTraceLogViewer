﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplo.TraceLogViewer.Models
{
	/// <summary>
	/// Represents a single row in a log file
	/// </summary>
	public class LogDataItem
	{
		public DateTime Date { get; set; }

		public string ThreadNo { get; set; }

		public string Level { get; set; }

		public string Logger { get; set; }

		public string ThreadId { get; set; }

		public string Message { get; set; }
	}
}
