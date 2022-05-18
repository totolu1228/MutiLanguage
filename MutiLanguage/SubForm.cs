using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MutiLanguage
{
    public partial class SubForm : Form
    {
        public SubForm()
        {
            InitializeComponent();

            GlobalizationHelper.SwitchLanguage(this, $"{Assembly.GetExecutingAssembly().GetName().Name}.Globalization.{MainForm.Language}");
        }
    }
}
