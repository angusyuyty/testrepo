using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Notice
{
    public enum ViewNotifierType
    {
        Success,
        Info,
        Warning,
        Error
    }
    public interface IViewNotifier
    {
        void Show(string message, ViewNotifierType type, string title = null, string icon = null);
    }
}
