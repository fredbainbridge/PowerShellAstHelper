using System;
using System.Management.Automation.Language;
using System.Management.Automation;

namespace astHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            string psFile = System.IO.File.ReadAllText("test.ps1");
            Token[] tokens;
            ParseError[] errors;
            var ast = Parser.ParseInput(psFile,out tokens,out errors);
            var asts = ast.FindAll(p => p != null, true);
        }
    }
}
