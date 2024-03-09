using System;
using System.Linq;

namespace XafValueConverterWithServices.Module.BusinessObjects
{
    public interface IValueConverterService
    {
        object ConvertFromStorageType(object value);
        object ConvertToStorageType(object value);
    }
}
