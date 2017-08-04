using System;
using System.Collections.Generic;
using System.Text;
using ViewLiveUpdate.Entities;
using ViewLiveUpdate.Interfaces;
using ViewLiveUpdate.ViewDatas;
using ViewLiveUpdate.ViewDatas.Core;

namespace ViewLiveUpdate.Services
{
    public class HomeService
    {
        ViewDataBuilderService _viewDataBuilderService;

        public HomeService(ViewDataBuilderService viewDataBuilderService)
        {
            _viewDataBuilderService = viewDataBuilderService;
        }
        
        public PersonViewData<Person> GetPerson()
        {
            Person p = new Person()
            {
                Id = 11,
                Name = "Rene"
            };

            var vd = new PersonViewData<Person>();

            var result = (PersonViewData<Person>)_viewDataBuilderService.Build(vd, p);

            return result;
        }
    }
}
