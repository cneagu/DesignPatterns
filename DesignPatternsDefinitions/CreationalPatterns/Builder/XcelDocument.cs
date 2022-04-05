using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDefinitions.CreationalPatterns.Builder
{
    public class XcelDocument : DocumentBuilder
    {
        public override string Title { get; set; }
        public override string Content { get; set; }

        public string Metadata { get; private set; }
        public ExtensionType Extension { get; private set; }
        private protected override void AddContent(string content)
        {
            Console.WriteLine(content);
        }

        private protected override void AddMetaData()
        {
            Metadata = "Xcel metadata";
        }

        private protected override void AddTitle(string title)
        {
            Console.WriteLine(title);
        }

        private protected override void SetExtension()
        {
            Extension = ExtensionType.Xcel;
        }
    }
}
