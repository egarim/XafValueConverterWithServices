using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XafValueConverterWithServices.Module.BusinessObjects
{
    public class ValueConverterService : IValueConverterService
    {
        public object ConvertFromStorageType(object value)
        {
            return Convert.ToString(value) == "T";
        }
        public object ConvertToStorageType(object value)
        {
            return Convert.ToBoolean(value) ? "T" : "F";
        }
    }
}
