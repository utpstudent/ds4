using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal_Aplicacion_To_Do
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
