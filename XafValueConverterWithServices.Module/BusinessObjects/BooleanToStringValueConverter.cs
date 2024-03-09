using DevExpress.Data.Utils;
using DevExpress.Xpo.Metadata;
using System;
using System.Linq;

namespace XafValueConverterWithServices.Module.BusinessObjects
{
    public class BooleanToStringValueConverter : ValueConverter
    { 

        public static IServiceProvider ServiceProvider { get; set; }
        public override object ConvertFromStorageType(object value)
        {

            var ConverterInstance=   ServiceProvider.GetService<IValueConverterService>();

            return ConverterInstance.ConvertFromStorageType(value); ;
        }
        public override object ConvertToStorageType(object value)
        {
            var ConverterInstance = ServiceProvider.GetService<IValueConverterService>();

            return ConverterInstance.ConvertToStorageType(value);
        }
        public override Type StorageType
        {
            get { return typeof(string); }
        }
    }
}