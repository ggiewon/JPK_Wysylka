using System.Reflection;
using System.Runtime.InteropServices;

#region This global assembly info file will be linked to all projects for JPK Wysylka

[assembly: AssemblyProduct("JPK WysyłkaXML")]
[assembly: AssemblyCompany("UnitSoftware Grzegorz Giewon")]
[assembly: AssemblyCopyright("Copyright © UnitSoftware 2011-2019")]
[assembly: AssemblyTrademark("UnitSoftware")]

//******************************************************************************************
// Please only change this version for major and minor release (f1st and 2nd number only)
//******************************************************************************************

[assembly: AssemblyVersion("1.1.11.0")]

//******************************************************************************************
// Please update this version with every patch, service release and major + minor release!
// Enter version as followed: 
// Major.Minor.Revision.BuildNumber
// i.e. 1.2.4.123 => version 1.2.4 build #123 on TeamCity
//******************************************************************************************
[assembly: AssemblyFileVersion("1.1.11")]
//******************************************************************************************


//******************************************************************************************
// Please update this version with every patch, service release and major + minor release!
// Enter version as followed: 
// Major.Minor.Revision.BuildNumber
// i.e. 1.2.4.123 14.11.2017 11:16 => version 1.2.4 build #123 on TeamCity and datetime of build // 
//******************************************************************************************
[assembly: AssemblyInformationalVersion("1.1.11.0")]
//******************************************************************************************

[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

#if DEBUG

[assembly: AssemblyConfiguration("Debug")]
#else

[assembly: AssemblyConfiguration("Release")]
#endif

#endregion