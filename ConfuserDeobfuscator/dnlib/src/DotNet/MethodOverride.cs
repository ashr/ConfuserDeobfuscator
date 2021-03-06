/*
    Copyright (C) 2012-2013 de4dot@gmail.com

    Permission is hereby granted, free of charge, to any person obtaining
    a copy of this software and associated documentation files (the
    "Software"), to deal in the Software without restriction, including
    without limitation the rights to use, copy, modify, merge, publish,
    distribute, sublicense, and/or sell copies of the Software, and to
    permit persons to whom the Software is furnished to do so, subject to
    the following conditions:

    The above copyright notice and this permission notice shall be
    included in all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
    MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
    CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
    TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
    SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

﻿namespace dnlib.DotNet {
	/// <summary>
	/// Describes which method some method implements
	/// </summary>
	public struct MethodOverride {
		/// <summary>
		/// The method body. Usually a <see cref="MethodDef"/> but could be a <see cref="MemberRef"/>
		/// </summary>
		public IMethodDefOrRef MethodBody;

		/// <summary>
		/// The method <see cref="MethodBody"/> implements
		/// </summary>
		public IMethodDefOrRef MethodDeclaration;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="methodBody">Method body</param>
		/// <param name="methodDeclaration">The method <paramref name="methodBody"/> implements</param>
		public MethodOverride(IMethodDefOrRef methodBody, IMethodDefOrRef methodDeclaration) {
			this.MethodBody = methodBody;
			this.MethodDeclaration = methodDeclaration;
		}
	}
}
