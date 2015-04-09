using System.Runtime.InteropServices;
﻿using System.Reflection;

#if DEBUG
[assembly: AssemblyProduct("Kouch (Debug)")]
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyProduct("Kouch (Release)")]
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyDescription("Kouch - Client for CouchDb")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyCopyright("All Rights Reversed")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: AssemblyVersion("3.1.0.*")]
[assembly: AssemblyFileVersion("3.1.0")]