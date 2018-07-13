using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPractice.Data
{
    public class PersonInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PersonContext>
    {
    }
}