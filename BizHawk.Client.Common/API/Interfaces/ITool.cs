﻿using System;
namespace BizHawk.Client.ApiHawk
{
	public interface ITool : IExternalAPI
	{
		Type GetTool(string name);
		object CreateInstance(string name);
		void OpenCheats();
		void OpenHexEditor();
		void OpenRamWatch();
		void OpenRamSearch();
		void OpenTasStudio();
		void OpenToolBox();
		void OpenTraceLogger();
	}
}
