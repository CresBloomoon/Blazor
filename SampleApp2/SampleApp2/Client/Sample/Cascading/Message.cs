﻿using System;

namespace SampleApp2.Client.Sample.Cascading
{
	public class Message
	{
		private string _name;

		public Message()
		{
			_name = "Guest";
		}

		public Message(string name)
		{
			_name = name;
		}

		public string GetText()
		{
			return $"Hello {_name}";
		}
	}
}
