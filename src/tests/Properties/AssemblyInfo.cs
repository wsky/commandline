#region License
//
// Command Line Library: AssemblyInfo.cs
//
// Author:
//   Giacomo Stelluti Scala (gsscoder@gmail.com)
//
// Copyright (C) 2005 - 2012 Giacomo Stelluti Scala
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion
#region Using Directives
using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
#endregion

[assembly: AssemblyTitle(_ThisAssembly.Title)]
[assembly: AssemblyProduct("Command Line Parsing Library")]
[assembly: AssemblyDescription(_ThisAssembly.Title)]
[assembly: AssemblyCopyright(_ThisAssembly.Copyright)]
[assembly: AssemblyVersion(_ThisAssembly.Version)]
[assembly: AssemblyInformationalVersion(_ThisAssembly.InformationalVersion)]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: AssemblyCulture("")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
//[assembly: AssemblyCompany("")]
//[assembly: AssemblyTrademark("")]