using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc;

namespace CalculationsProject.HelperMethod
{
    public static class Cortar
    {
        public static string Cortarlo(this HtmlHelper helper, string nombre)
        {
            nombre = "RR";

            return helper.Cortarlo(nombre);
        }
    }
}
