﻿using System.Collections.Generic;

namespace nothinbutdotnetstore.web.application
{
    public interface ICanGetDepartments
    {
         IEnumerable<Department> get_the_main_departments_in_the_store();
    }
}