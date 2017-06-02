using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using JSON = Newtonsoft.Json.JsonConvert;
namespace EntityTest.Helpers
{
    class EntityHelper
    {
        //I am sure we will need other helpers. I just needed this now for the extension method.
    }

    public static class EntityExtensions
    {
        public static T ToType<T>(this ObjectResult results)
        {
            ObjectResult r = results;
            return JSON.DeserializeObject<T>(JSON.SerializeObject(r));
        }
    }
}
