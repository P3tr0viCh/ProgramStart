using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Запуск программы")]
[assembly: AssemblyDescription("Запуск программы из папки с версией")]
[assembly: AssemblyCompany("П3тр0виЧъ")]
[assembly: AssemblyProduct("ProgramStart")]
[assembly: AssemblyCopyright("© П3тр0виЧъ")]
[assembly: AssemblyTrademark("П3тр0виЧъ™")]
[assembly: AssemblyCulture("")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: ComVisible(false)]

[assembly: Guid("3605d35f-49d1-4d33-ae72-f4ceb6214fec")]

[assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0.0")]
