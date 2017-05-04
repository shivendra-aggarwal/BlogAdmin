using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Admin
{
    public static class PageHeaderHelper
    {
        public static MvcHtmlString GetPageHeader(this HtmlHelper htmlHelper, string title, string subText = null)
        {
            TagBuilder headerDivTag = new TagBuilder("div");
            headerDivTag.AddCssClass("page-header well");

            TagBuilder h2Tag = new TagBuilder("h2");
            h2Tag.InnerHtml = title;

            TagBuilder smallTag = new TagBuilder("small");
            smallTag.InnerHtml = subText;
            h2Tag.InnerHtml += smallTag.ToString();

            headerDivTag.InnerHtml = h2Tag.ToString();

            return new MvcHtmlString(headerDivTag.ToString());
        }
    }
}