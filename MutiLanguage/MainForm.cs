using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace MutiLanguage
{
    public partial class MainForm : Form
    {
        public static string Language = "zh-cn";

        public MainForm()
        {
            InitializeComponent();

            cbxLanguage.Items.Add("zh-cn");
            cbxLanguage.Items.Add("en-us");
            cbxLanguage.SelectedIndex = 0;
        }

        private void cbxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLanguage.SelectedItem == null)
                return;
            Language = cbxLanguage.SelectedItem.ToString();
            GlobalizationHelper.SwitchLanguage(this, $"{Assembly.GetExecutingAssembly().GetName().Name}.Globalization.{Language}");
        }

        private void button_Click(object sender, EventArgs e)
        {
            SubForm subForm = new SubForm();
            subForm.ShowDialog();
        }
    }
}
