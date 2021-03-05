using _4CreateObjectModel.Drivers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TheTestAssignmentTEST.Pages;

namespace TheTestAssignmentTEST.Test
{
    [TestFixture]
    class TestGoogleSearch : TestBase
    {
        [Test]
        public void ValidateEnSearchResult()
        {
            PageGoogle pg = new PageGoogle(Driver.driver);
            pg.EnterSubmitSearchText(Data.DataForTest.searchText);
            pg.IsFirstResult4Create(Data.DataForTest.searchResult4C);
        }

        [Test]
        public void ValidateRSSearchResult()
        {
            Driver.NavigateToUrl(Data.Url.urlSiteRS);
            PageGoogle pg = new PageGoogle(Driver.driver);
            pg.EnterSubmitSearchText(Data.DataForTest.searchText);
            pg.IsFirstResult4Create(Data.DataForTest.searchResult4C);
        }

    }
}
