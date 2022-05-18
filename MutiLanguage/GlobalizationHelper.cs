using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace MutiLanguage
{
    public static class GlobalizationHelper
    {
        public static void SwitchLanguage(Form form, string resxDir)
        {
            ResourceManager rm = new ResourceManager(resxDir, Assembly.GetExecutingAssembly());
            string content = rm.GetString(form.Name);
            if (!string.IsNullOrEmpty(content))
                form.Text = content;
            foreach (Control control in form.Controls)
                SwitchLanguage(control, resxDir);
        }

        public static void SwitchLanguage(Control control, string resxDir)
        {
            ResourceManager rm = new ResourceManager(resxDir, Assembly.GetExecutingAssembly());
            string content = rm.GetString(control.Name);
            if (!string.IsNullOrEmpty(content))
                control.Text = rm.GetString(control.Name);
            foreach (Control ctrl in control.Controls)
                SwitchLanguage(ctrl, resxDir);
        }
    }
}
