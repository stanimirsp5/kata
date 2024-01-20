
namespace KataCSharp.Sandbox
{
    public class CreateFile
    {
        public void Start()
        {
            string[] lines = { "First line", "Second line", "Third line" };
            string docPath = "/Users/stanimirpetrov/Documents/Projects/DtcLogsReader/AzureIoTHubMacExplorer/WriteLines.txt";
            //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(docPath))
            {
                outputFile.WriteLine(lines);
            }
        }
    }
}