using Xunit;
using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using GildedRose.Logic;

namespace GildedRose.Test
{
    [UseReporter(typeof(DiffReporter))]
    public class ApprovalTest
    {
        [Fact(Skip = "Should run after all changes completed")]
        public void ThirtyDays()
        {
            var programOutput = new StringBuilder();
            Console.SetOut(new StringWriter(programOutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = programOutput.ToString();

            Approvals.Verify(output);
        }
    }
}
