using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof(ViewTheMainDepartmentsInTheStore))]
    public class ViewTheMainDepartmentsInTheStoreSpecs
    {
        public abstract class concern : Observes<IPerformApplicationBehaviour,
                                            ViewTheMainDepartmentsInTheStore>
        {
        }

        public class when_processing_a_request : concern
        {
            Establish c = () =>
            {
                list_of_dept = Enumerable.Range(1, 100).Select(x => fake.an<IContainRequestInformation>()).ToList();
                request = fake.an<IContainRequestInformation>();
                depends.on<IEnumerable<IContainRequestInformation>>(list_of_dept);
            };

            Because b = () =>
               sut.process(request);


            It should_get_a_list_of_the_main_departments_in_the_store = () =>
            request.ShouldNotBeNull(); 


            static IContainRequestInformation request;
            static IList<IContainRequestInformation> list_of_dept;
        }
    }
}