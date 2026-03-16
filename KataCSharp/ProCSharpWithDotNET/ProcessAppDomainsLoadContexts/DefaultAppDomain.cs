using System.Reflection;

namespace KataCSharp.ProCSharpWithDotNET.ProcessAppDomainsLoadContexts;
public class DefaultAppDomain
{
	public void Start()
	{
		DisplayDefaultAppDomainStats();
		ListAllAssembliesInAppDomain();
	}

	void DisplayDefaultAppDomainStats()
	{
		//Get access to the default AppDomain for the current thread
		AppDomain defaultAD = AppDomain.CurrentDomain;
        //Print various stats about this domain
        Console.WriteLine("Name of this domain: {0}", defaultAD.FriendlyName);
        Console.WriteLine("ID of domain in this process: {0}", defaultAD.Id);
        Console.WriteLine("Is this the default domain? {0}", defaultAD.IsDefaultAppDomain());
        Console.WriteLine("Base directory of this domain: {0}", defaultAD.BaseDirectory);
        Console.WriteLine("Setup information for this domain:");
        Console.WriteLine("\t Application Base: {0}", defaultAD.SetupInformation.ApplicationBase);
        Console.WriteLine("\t Target framework: {0}", defaultAD.SetupInformation.TargetFrameworkName);
	}

	void ListAllAssembliesInAppDomain()
	{
		AppDomain appDomain = AppDomain.CurrentDomain;

		Assembly[] loadedAssemplies = appDomain.GetAssemblies();
        Console.WriteLine("***** Here are the assemblies loaded in {0} *****\n", appDomain.FriendlyName);
		foreach (Assembly a in loadedAssemplies)
		{
            Console.WriteLine($"-> Name, Version: {a.GetName().Name}:{a.GetName().Version}");
		}
	}

}
