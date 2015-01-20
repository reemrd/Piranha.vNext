﻿/*
 * Copyright (c) 2014-2015 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * http://github.com/piranhacms/piranha.vnext
 * 
 */

using System;

namespace Piranha.Extend.Extensions
{
	/// <summary>
	/// Boolean extension.
	/// </summary>
	[Extension(Name="Boolean", Type=ExtensionType.Property)]
	public class BooleanExtension : SimpleExtension<bool>, IExtension
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public BooleanExtension() : base(v => v) { }
	}
}
