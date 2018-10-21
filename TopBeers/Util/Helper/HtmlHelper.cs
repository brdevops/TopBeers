using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using TopBeers.Dados.Negocio;

namespace TopBeers.Util.Helper
{
    public class HtmlHelper
    {

        //public static MvcHtmlString DropDownCervejarias<TModel, TProperty>()

        //public static HtmlString DropDownCervejarias<TModel, TProperty>(
        //    HtmlHelper<TModel> htmlHelper,
        //    Expression<Func<TModel, TProperty>> expression,
        //    Object htmlAttributes,
        //    bool habilitarCampo = true
        //)
        //{//
        //    var attributes = SetDisabledHtmlAttributes(htmlAttributes, habilitarCampo);

        //    var negocio = new CervejariaNegocio();
        //    var estados = negocio.ListarTodos();
        //    var ufs = estados.Select(u => new SelectListItem() { Text = u.Nome, Value = u.IdCervejaria.ToString() });
        //    return htmlHelper.DropDownListFor(expression, ufs, "Escolha um estado", htmlAttributes);
        //}

        public static IHtmlContent DropDownCervejarias<TModel, TProperty>( HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, object htmlAttributes)
        {
            //var ocorrencias = Enum.GetValues(typeof(EnumTipoOcorrencia))
            //    .Cast<EnumTipoOcorrencia>()
            //    .Select(l => new SelectListItem
            //    {
            //        Value = ((int)l).ToString(),
            //        Text = l.GetDescricao()
            //    }).ToList();

            var negocio = new CervejariaNegocio();
            var cervejariasAll = negocio.List();

            var cervejarias = cervejariasAll.Select(u => new SelectListItem() { Text = u.Nome, Value = u.IdCervejaria.ToString() });

            return htmlHelper.ListBoxFor(expression, cervejarias, htmlAttributes);
        }

    }
}
