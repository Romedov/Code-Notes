using System;
using System.Collections.Generic;
using System.Windows.Controls;
using TTPRO2.Interfaces;

namespace TTPRO2.Other
{
    public class PageController : IPageController
    {
        private Dictionary<string, string> PagesUri = new Dictionary<string, string>
        {
            ["ToSales"] = "Page2.xaml",
            ["ToReturns"] = "",
            ["ToShifts"] = "",
            ["ToSuppliers"] = "",
            ["ToSupplies"] = "",
            ["ToUser"] = "Page1.xaml"
        };
        public Uri GetPageUri(object control)
        {
            Button btn = control as Button;
            Uri pg = btn != null ? new Uri(PagesUri[btn.Name], UriKind.Relative) : new Uri(PagesUri["ToUser"], UriKind.Relative);
            return pg;
        }
    }
}
