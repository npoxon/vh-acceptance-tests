﻿using System.Collections.Generic;
using System.Linq;
using AcceptanceTests.PageObject.Pages;
using TechTalk.SpecFlow;

namespace AcceptanceTests.PageObject.Helpers
{
    public class PageNavigator
    {
        private List<Page> _userJourneyPages;
        public readonly ScenarioContext _scenarioContext;

        public PageNavigator(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public UserJourneyPage CurrentPage
        {
            get
            {
                return _scenarioContext.Get<UserJourneyPage>("CurrentPage");
            }
        }

        public void addPageToJourney(Page page)
        {
            if(_userJourneyPages == null)
            {
                _userJourneyPages = new List<Page>();
            }

            if (!_userJourneyPages.Exists(p => p.Path == page.Path))
            {
                _userJourneyPages.Add(page);
            }
            
        }

        public Page GetPage(string pageUri)
        {
            return _userJourneyPages.Single(page => page.Path == pageUri);
        }

        public List<Page> PageList
        {
            get
            {
                return _userJourneyPages;
            }
        }
    }
}
