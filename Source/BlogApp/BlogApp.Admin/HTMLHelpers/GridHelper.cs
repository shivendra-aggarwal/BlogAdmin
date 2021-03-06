﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Admin
{
    public static class GridHelper
    {
        public static MvcHtmlString GetSimpleGrid<TEntity>(this HtmlHelper htmlHelper, IEnumerable<TEntity> list)
        {
            Type entity = typeof(TEntity);

            TagBuilder tableTag = new TagBuilder("table");
            tableTag.AddCssClass("table table-bordered table-hover table-striped table-responsive");

            TagBuilder trHeaderTag = new TagBuilder("tr");

            CustomAttributeData attributeData = null;
            entity.GetProperties().ToList().ForEach(propInfo =>
            {
                if (propInfo.CustomAttributes != null &&
                propInfo.CustomAttributes.Count() > 0 &&
                (attributeData = propInfo.CustomAttributes.FirstOrDefault(customAttr => customAttr.AttributeType != null && customAttr.AttributeType.Name == "DisplayNameAttribute")) != null)
                {
                    TagBuilder thHeaderTag = new TagBuilder("th");
                    thHeaderTag.InnerHtml = attributeData.ConstructorArguments.FirstOrDefault().Value.ToString();
                    trHeaderTag.InnerHtml += thHeaderTag.ToString();
                }
            });

            tableTag.InnerHtml = trHeaderTag.ToString();

            if (list != null && list.Count() > 0)
            {
                list.ToList().ForEach(item =>
                {
                    TagBuilder trRowTag = new TagBuilder("tr");
                    item.GetType().GetProperties().ToList().ForEach(property =>
                    {
                        TagBuilder tdColumn = new TagBuilder("td");
                        tdColumn.InnerHtml = Convert.ToString(property.GetValue(item, null));
                        trRowTag.InnerHtml += tdColumn.ToString();
                    });
                    tableTag.InnerHtml += trRowTag.ToString();
                });

            }

            return new MvcHtmlString(tableTag.ToString());
        }
    }
}