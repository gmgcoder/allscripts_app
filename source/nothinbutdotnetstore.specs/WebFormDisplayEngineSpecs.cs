using System.Collections.Generic;
using Machine.Specifications;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.aspnet;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof(WebFormDisplayEngine))]
    public class WebFormDisplayEngineSpecs
    {
        public abstract class concern : Observes<IDisplayReports,
                                            WebFormDisplayEngine>
        {
        }

        public class when_displaying_a_report : concern
        {
           Establish c = () =>
            {
                all_main_departments = new List<Department>{new Department()};
                get_information_from_the_store_catalog_repository = depends.on<ICanGetInformationFromTheStoreCatalog>();
                display_engine = depends.on<IDisplayReports>();
  
                get_information_from_the_store_catalog_repository.setup(x => x.get_the_main_departments_in_the_store())
                    .Return(all_main_departments);

            };

            Because b = () =>
                sut.display(display_engine);

            It should_display_the_report = () =>
                get_information_from_the_store_catalog_repository.received(x => x.get_the_main_departments_in_the_store());

                  

            static ICanGetInformationFromTheStoreCatalog get_information_from_the_store_catalog_repository;
            static IEnumerable<Department> all_main_departments;
            static IDisplayReports display_engine;

           
        }
    }
}