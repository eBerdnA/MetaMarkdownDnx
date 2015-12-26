using System.Linq;
using Xunit;

namespace BeAnSys.MetaMarkdownDnx.UnitTests
{
    public class UnitTests
    {
        [Fact]
        public void TransformNull()
        {
            // arrange
            var markdown = new Markdown();
            var metadataMarkdown = new MetadataMarkdown();

            // act
            var markdownResult = markdown.Transform(TestData.Null);
            var metadataMarkdownResult = metadataMarkdown.Transform(TestData.Null);

            // assert
            Assert.Equal(markdownResult, metadataMarkdownResult);
        }

        [Fact]
        public void TransformEmptyString()
        {
            // arrange
            var markdown = new Markdown();
            var metadataMarkdown = new MetadataMarkdown();

            // act
            var markdownResult = markdown.Transform(TestData.EmptyString);
            var metadataMarkdownResult = markdown.Transform(TestData.EmptyString);

            // assert
            Assert.Equal(markdownResult, metadataMarkdownResult);
        }

        [Fact]
        public void TransformNotMarkdown()
        {
            // arrange
            var markdown = new Markdown();
            var metadataMarkdown = new MetadataMarkdown();

            // act
            var markdownResult = markdown.Transform(TestData.NotMarkdown);
            var metadataMarkdownResult = markdown.Transform(TestData.NotMarkdown);

            // assert
            Assert.Equal(markdownResult, metadataMarkdownResult);
        }

        [Fact]
        public void TransformMarkdown()
        {
            // arrange
            var markdown = new Markdown();
            var metadataMarkdown = new MetadataMarkdown();

            // act
            var markdownResult = markdown.Transform(TestData.Markdown);
            var metadataMarkdownResult = markdown.Transform(TestData.Markdown);

            // assert
            Assert.Equal(markdownResult, metadataMarkdownResult);
        }

        [Fact]
        public void TransformMetadataMarkdown()
        {
            // arrange
            var markdown = new Markdown();
            var metadataMarkdown = new MetadataMarkdown();

            // act
            var markdownResult = markdown.Transform(TestData.MetadataMarkdown);
            var metadataMarkdownResult = metadataMarkdown.Transform(TestData.MetadataMarkdown);

            // assert
            Assert.NotEqual(markdownResult, metadataMarkdownResult);
            Assert.True(markdownResult.Length > metadataMarkdownResult.Length);
        }

        [Fact]
        public void MetadataNull()
        {
            // arrange
            var metadataMarkdown = new MetadataMarkdown();

            // act
            var metadataMarkdownResult = metadataMarkdown.Metadata(TestData.Null);

            // assert
            Assert.True(!metadataMarkdownResult.Any());
        }

        [Fact]
        public void MetadataEmptyString()
        {
            // arrange
            var metadataMarkdown = new MetadataMarkdown();

            // act
            var metadataMarkdownResult = metadataMarkdown.Metadata(TestData.EmptyString);

            // assert
            Assert.True(!metadataMarkdownResult.Any());
        }

        [Fact]
        public void MetadataNotMarkdown()
        {
            // arrange
            var metadataMarkdown = new MetadataMarkdown();

            // act
            var metadataMarkdownResult = metadataMarkdown.Metadata(TestData.NotMarkdown);

            // assert
            Assert.True(!metadataMarkdownResult.Any());
        }

        [Fact]
        public void MetadataMarkdown()
        {
            // arrange
            var metadataMarkdown = new MetadataMarkdown();

            // act
            var metadataMarkdownResult = metadataMarkdown.Metadata(TestData.Markdown);

            // assert
            Assert.True(!metadataMarkdownResult.Any());
        }

        [Fact]
        public void MetadataMetadataMarkdown()
        {
            // arrange
            var metadataMarkdown = new MetadataMarkdown();

            // act
            var metadataMarkdownResult = metadataMarkdown.Metadata(TestData.MetadataMarkdown);

            // assert
            Assert.True(metadataMarkdownResult.Any());
        }
    }
}
