namespace KataCSharp.AdventOfCode
{
	internal static class AdventHelper
	{
		internal static string[] ReadFromFile(string path)
		{
			var lineRes = new List<string>();
			try
			{
				//Pass the file path and file name to the StreamReader constructor
				StreamReader sr = new StreamReader(path);
				//Read the first line of text
				string line = string.Empty;
				line = sr.ReadLine();
				//Continue to read until you reach end of file
				while (line != null)
				{
					//write the line to console window
					Console.WriteLine(line);
					lineRes.Add(line);
					//Read the next line
					line = sr.ReadLine();
				}
				//close the file
				sr.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
			finally
			{
				Console.WriteLine("Executing finally block.");
			}
			return lineRes.ToArray();
		}
	}
}
