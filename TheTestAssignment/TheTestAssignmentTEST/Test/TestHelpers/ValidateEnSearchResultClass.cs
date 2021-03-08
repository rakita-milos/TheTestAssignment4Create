using TestProject.SDK;
using TestProject.SDK.Tests;
using TestProject.SDK.Tests.Helpers;
using TheTestAssignmentTEST.Data;
using TheTestAssignmentTEST.Pages;

namespace TheTestAssignmentTEST.Test.TestHelpers
{
    public class ValidateEnSearchResultClass : IWebTest
    {
        public ExecutionResult Execute(WebTestHelper helper)
        {
            Drivers.driver = helper.Driver;
            Drivers.NavigateToUrl(Data.Url.urlSiteEn);
            PageGoogle pg = new PageGoogle(Drivers.driver);
            pg.EnterSubmitSearchText(Data.DataForTest.searchText);
            pg.IsFirstResult4Create(Data.DataForTest.searchResult4C);
            if (Data.DataForTest.searchResult4C.Equals(PageGoogle.searchResult.Text))
            {
                return ExecutionResult.Passed;
            }
            else
            {
                return ExecutionResult.Failed;
            }
            
        }
    }
}
