using NUnit.Framework;
using TheTestAssignmentTEST.Data;
using TheTestAssignmentTEST.Test.TestHelpers;

namespace TheTestAssignmentTEST.Test
{
    [TestFixture]
    class TestGoogleSearch : TestBase
    {
        [Test]
        public void ValidateEnSearchResult()
        {
            TestProjectHelper.runner.Run(new ValidateEnSearchResultClass());
        }

        [Test]
        public void ValidateRSSearchResult()
        {
            TestProjectHelper.runner.Run(new ValidateRSSearchResultClass());
        }

    }
}
