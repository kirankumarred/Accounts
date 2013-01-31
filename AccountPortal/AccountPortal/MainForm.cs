using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Infragistics.Win.UltraWinToolbars;

namespace Kiran.Accountportal.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadform();
        }
        private void loadform()
        {
            RibbonTab hometab = new RibbonTab("Home");
            this.ultToolsbarmgr.Ribbon.Tabs.Add(hometab);

            RibbonGroup newgroup = new RibbonGroup("New");
            this.ultToolsbarmgr.Ribbon.Tabs["Home"].Groups.Add(newgroup);

            //RibbonGroupCollection collection= new RibbonGroupCollection();
            //collection.Add("Customer");


            //FontListTool fontFaceTool = new FontListTool("Fontface");
            //this.ultToolsbarmgr.Tools.Add(fontFaceTool);
            //fontgrop.Tools.AddTool(fontFaceTool.Key, false);
        }
    }
}
