using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using TopBeers.Dados.Negocio;

namespace TopBeers.Util.Helper
{
    public static class HtmlHelper
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

        //public static IHtmlContent DropDownCervejarias<TModel>( 
        //    HtmlHelper<TModel> htmlHelper, 
        //    Expression<Func<TModel>> expression, 
        //    object htmlAttributes)
        //{

        //    var negocio = new CervejariaNegocio();
        //    var cervejariasAll = negocio.List();

        //    var cervejarias = cervejariasAll.Select(u => new SelectListItem() { Text = u.Nome, Value = u.IdCervejaria.ToString() });

        //    return htmlHelper.DropDownListFor(expression, cervejarias, "Teste", htmlAttributes);
        //}

        //public static IHtmlContent CheckboxListFor<TModel>(
        //    this IHtmlHelper<TModel> html,
        //    Expression<Func<TModel>> expression)
        //{

        //    return  html.DropDownListFor()
        //}


        //public static IHtmlContent HelloWorldHTMLString(this IHtmlHelper htmlHelper)
        //    => new HtmlString("<strong>Hello World</strong>");

    }
}
