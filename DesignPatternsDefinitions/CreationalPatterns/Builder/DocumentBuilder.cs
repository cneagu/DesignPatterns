namespace DesignPatternsDefinitions.CreationalPatterns.Builder
{
    public abstract class DocumentBuilder
    {
        public abstract string Title { get; set; }
        public abstract string Content { get; set; }

        private protected abstract void AddMetaData();
        private protected abstract void AddTitle(string title);
        private protected abstract void AddContent(string content);
        private protected abstract void SetExtension();

        public static void BuildDocument(DocumentBuilder builder)
        {
            builder.AddMetaData();
            builder.AddTitle(builder.Title);
            builder.AddContent(builder.Content);
            builder.SetExtension();
        }
    }
}
