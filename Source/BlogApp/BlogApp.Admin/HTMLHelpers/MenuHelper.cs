using BlogApp.Model.MenuManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Admin
{
    public static class MenuHelper
    {
        public static MvcHtmlString GetMenuBar(this HtmlHelper htmlHelper,
            IEnumerable<Menu> menus,
            string currentActionName)
        {
            TagBuilder tagDivNavTop = new TagBuilder("div");
            tagDivNavTop.AddCssClass("navbar navbar-static-top");

            TagBuilder tagDivContainer = new TagBuilder("div");
            tagDivContainer.AddCssClass("container");

            TagBuilder tagUlNav = new TagBuilder("ul");
            tagUlNav.AddCssClass("nav nav-tabs");

            TagBuilder tagSpanCaret = new TagBuilder("span");
            tagSpanCaret.AddCssClass("caret");
            
            foreach (Menu menu in menus)
            {
                if (menu.ChildMenus != null && menu.ChildMenus.Count > 0)
                {
                    //Creating dropdown root element for nested menu
                    TagBuilder tagLiNav = new TagBuilder("li");
                    tagLiNav.AddCssClass("dropdown");
                    tagLiNav.MergeAttribute("role", "presentation");

                    //Creating anchor for dropdown menu
                    TagBuilder tagAnchorDropDown = new TagBuilder("a");
                    tagAnchorDropDown.AddCssClass("dropdown-toggle");
                    tagAnchorDropDown.MergeAttribute("data-toggle", "dropdown");
                    tagAnchorDropDown.MergeAttribute("href", "#");
                    tagAnchorDropDown.MergeAttribute("role", "button");
                    tagAnchorDropDown.MergeAttribute("aria-haspopup", "true");
                    tagAnchorDropDown.MergeAttribute("aria-expanded", "false");

                    tagAnchorDropDown.InnerHtml = menu.MenuTitle;
                    tagAnchorDropDown.InnerHtml += tagSpanCaret.ToString();

                    TagBuilder tagUlDropDownMenu = new TagBuilder("ul");
                    tagUlDropDownMenu.AddCssClass("dropdown-menu");

                    foreach (Menu child in menu.ChildMenus)
                    {
                        TagBuilder tagLiChildMenu = new TagBuilder("li");
                        if (!string.IsNullOrEmpty(child.ControllerName) && string.Equals(currentActionName.ToLower(), child.ControllerName.ToLower()))
                        {
                            tagLiChildMenu.AddCssClass("active");
                        }
                        TagBuilder tagAnchorChildMenu = new TagBuilder("a");
                        
                        tagAnchorChildMenu.MergeAttribute("href", string.IsNullOrEmpty(child.ControllerName) ? "#" : string.Format("/{0}/{1}", child.ControllerName, child.ActionName));
                        tagAnchorChildMenu.InnerHtml = child.MenuTitle;
                        tagLiChildMenu.InnerHtml = tagAnchorChildMenu.ToString();

                        tagUlDropDownMenu.InnerHtml += tagLiChildMenu.ToString();
                    }
                    tagLiNav.InnerHtml = tagAnchorDropDown.ToString();
                    tagLiNav.InnerHtml += tagUlDropDownMenu.ToString();
                    tagUlNav.InnerHtml += tagLiNav.ToString();
                }
                else
                {
                    TagBuilder tagLiMenu = new TagBuilder("li");
                    if (!string.IsNullOrEmpty(menu.ControllerName) && string.Equals(currentActionName.ToLower(), menu.ControllerName.ToLower()))
                    {
                        tagLiMenu.AddCssClass("active");
                    }
                    TagBuilder tagAnchorMenu = new TagBuilder("a");
                    tagAnchorMenu.MergeAttribute("href", string.IsNullOrEmpty(menu.ControllerName) ? "#" : string.Format("/{0}/{1}", menu.ControllerName, menu.ActionName));
                    tagAnchorMenu.InnerHtml = menu.MenuTitle;
                    tagLiMenu.InnerHtml = tagAnchorMenu.ToString();

                    tagUlNav.InnerHtml += tagLiMenu.ToString();
                }

            }

            tagDivContainer.InnerHtml = tagUlNav.ToString();
            tagDivNavTop.InnerHtml = tagDivContainer.ToString();
            
            return MvcHtmlString.Create(tagDivNavTop.ToString());

        }
    }
}