using Microsoft.AspNetCore.Mvc.Rendering;

namespace HortiDot.Config
{
    public static class ExtensionMethods
    {
        public static IEnumerable<SelectListItem> GetEnumValueSelectList<TEnum>(this IHtmlHelper htmlHelper) where TEnum : struct
        {
            return new SelectList(Enum.GetValues(typeof(TEnum)).OfType<Enum>()
                .Select(x =>
                    new SelectListItem
                    {
                        Text = x.ToString(),
                        Value = x.ToString()
                    }), "Value", "Text");
        }
    }
}
