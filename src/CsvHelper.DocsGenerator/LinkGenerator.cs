﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelper.DocsGenerator
{
    public class LinkGenerator
    {
        public string GenerateLink(Type type)
		{
			if (type.Namespace.StartsWith("CsvHelper"))
			{
				return $"[{type.GetTitle()}](/api/{type.Namespace}/{type.Name})";
			}

			var fullName = $"{type.Namespace}.{type.Name}";

			return $"[{type.GetTitle()}](https://docs.microsoft.com/en-us/dotnet/api/{fullName.ToLower()})";
		}
	}
}