﻿using System;
using System.ComponentModel;

using NLua;

namespace BizHawk.Client.Common
{
	[Description("A library for setting and retrieving dynamic data that will be saved and loaded with savestates")]
	public sealed class UserDataLuaLibrary : DelegatingLuaLibrary
	{
		public override string Name => "userdata";

		public UserDataLuaLibrary(Lua lua) : base(lua) {}

		public UserDataLuaLibrary(Lua lua, Action<string> logOutputCallback) : base(lua, logOutputCallback) {}

		#region Delegated to ApiHawk

		[LuaMethodExample("userdata.clear()")]
		[LuaMethod("clear", "clears all user data")] //TODO docs
		public void Clear() => ApiHawkContainer.UserData.Clear();

		[LuaMethodExample("if ( userdata.containskey( \"Unique key\" ) ) then\r\n\tconsole.log( \"returns whether or not there is an entry for the given key\" );\r\nend;")] //TODO docs
		[LuaMethod("containskey", "returns whether or not there is an entry for the given key")] //TODO docs
		public bool ContainsKey(string key) => ApiHawkContainer.UserData.ContainsKey(key);

		[LuaMethodExample("local obuseget = userdata.get( \"Unique key\" );")] //TODO docs
		[LuaMethod("get", "gets the data with the given key, if the key does not exist it will return nil")] //TODO docs
		public object Get(string key) => ApiHawkContainer.UserData.Get(key);

		[LuaMethodExample("if ( userdata.remove( \"Unique key\" ) ) then\r\n\tconsole.log( \"remove the data with the given key.Returns true if the element is successfully found and removed; otherwise, false.\" );\r\nend;")] //TODO docs
		[LuaMethod("remove", "remove the data with the given key. Returns true if the element is successfully found and removed; otherwise, false.")] //TODO docs
		public bool Remove(string key) => ApiHawkContainer.UserData.Remove(key);

		[LuaMethodExample("userdata.set(\"Unique key\", \"Current key data\");")] //TODO docs
		[LuaMethod("set", "adds or updates the data with the given key with the given value")] //TODO docs
		public void Set(string name, object value) => ApiHawkContainer.UserData.Set(name, value);

		#endregion
	}
}
