using DesignPatternsDefinitions.CreationalPatterns.Builder;
using Xunit;

namespace DesignPatternTests.CreationalPatterns
{
    [Collection("CreationalPatternsTests")]
    public class BuilderTests
    {
        [Fact]
        public void BuildDocument_buildPDF()
        {
            PDFDocument document = new();
            document.Title = "pdf title";
            document.Content = "pdf content";
            DocumentBuilder.BuildDocument(document);
            Assert.Equal(ExtensionType.PDF, document.Extension);
        }

        [Fact]
        public void BuildDocument_buildXcel()
        {
            XcelDocument document = new();
            document.Title = "Xcel title";
            document.Content = "Xcel content";
            DocumentBuilder.BuildDocument(document);
            Assert.Equal(ExtensionType.Xcel, document.Extension);
        }
    }
}
