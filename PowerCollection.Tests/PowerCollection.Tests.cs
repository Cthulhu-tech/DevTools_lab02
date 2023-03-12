namespace PowerCollections.Tests
{
    public class ThrowError
    {
        [Fact]
        public void CreateError()
        {
            throw new ArgumentException("Parameter cannot be null"); 
        }
    }
}