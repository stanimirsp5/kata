namespace KataCSharp.ProCSharpWithDotNET.Exceptions;

using System;

public class FunWithExcpetions
{
    public void Start()
    {
        CallException();

        try
        {
            CallExceptionThrow();
        }catch(Exception ex)
        {
            throw;
        }
	}

    void CallExceptionThrow()
    {
        try
        {
            throw new Exception("This is a test exception");
        }
        catch (Exception ex) {
            throw;
            //throw new Exception("Not original exception");
        }

	}


    void CallException()
    {
        try
        {
            throw new Exception("This is a test exception")
            {
                HelpLink = "https://softuni.bg",
            };
        }
        catch (Exception ex)
        {
            System.Console.WriteLine("Method name {0}", ex.TargetSite.Name );
            System.Console.WriteLine("DeclaringType {0}", ex.TargetSite.DeclaringType);
            System.Console.WriteLine("MemberType {0}", ex.TargetSite.MemberType);
            Console.WriteLine("HelpLink: ", ex.HelpLink);



            Console.WriteLine("Caught exception: " + ex.Message);
            Console.WriteLine("Stack trace: " + ex.StackTrace);
        }
    }
}