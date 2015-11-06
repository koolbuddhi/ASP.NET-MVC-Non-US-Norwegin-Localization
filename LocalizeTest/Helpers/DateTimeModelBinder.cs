using System;
using System.Globalization;
using System.Web.Mvc;

namespace LocalizeTest.Helpers
{
    class DateTimeModelBinder : DefaultModelBinder
    {
        #region IModelBinder Members 

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            DateTime date;

            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            //unfortunately this fails
            //var date = value.ConvertTo(typeof(DateTime), CultureInfo.CurrentCulture);

            var dateString = value.AttemptedValue;
            
            if (DateTime.TryParseExact(dateString, CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern,
                CultureInfo.CurrentCulture, DateTimeStyles.None, out date))
            {
                return date;
            }
            return base.BindModel(controllerContext, bindingContext);
        }

        #endregion
    }
}