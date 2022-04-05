namespace DesignPatternsDefinitions.CreationalPatterns.Builder
{
    public class PDFDocument : DocumentBuilder
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
            Metadata = "Pdf metadata";
        }

        private protected override void AddTitle(string title)
        {
            Console.WriteLine(title);
        }

        private protected override void SetExtension()
        {
            Extension = ExtensionType.PDF;
        }
    }
}
