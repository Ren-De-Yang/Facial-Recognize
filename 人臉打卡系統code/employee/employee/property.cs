using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace employee
{
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    class property : ParentControlDesigner
    {
        static string[] reserveproperty = new string[] { "Location"};
        protected override void PreFilterProperties(System.Collections.IDictionary properties)
        {
            //針對UserControl每個屬性進行過濾
            foreach (var pi in typeof(System.Windows.Forms.UserControl).GetProperties())
            {
                if (!reserveproperty.Contains(pi.Name)){
                    properties.Remove(pi.Name);
                }
            }
            properties.Remove("FlowBreak");
            properties.Remove("GenerateMember");
            properties.Remove("Modifiers");
            properties.Remove("ApplicationSettings");
            base.PreFilterProperties(properties);
        }

        protected override void PreFilterEvents(System.Collections.IDictionary events)
        {
            //針對UserControl每個事件進行過濾
            foreach (var ei in typeof(System.Windows.Forms.UserControl).GetEvents())
            {
                if (events.Contains(ei.Name))
                    events.Remove(ei.Name);
            }
            base.PreFilterEvents(events);
        }

    }
}
