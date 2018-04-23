using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace CustomHeaderButtonsExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            panelContainer1.CustomButtonUnchecked += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(panelContainer1_CustomButtonUnchecked);
            panelContainer1.CustomButtonChecked += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(panelContainer1_CustomButtonChecked);
            panelContainer1.CustomButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(panelContainer1_CustomButtonClick);
        }


        void panelContainer1_CustomButtonUnchecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e) {
            panelContainer1.Visibility = DockVisibility.Visible;
        }

        void panelContainer1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e) {
            panelContainer1.ActiveChild.Close();
        }

        void panelContainer1_CustomButtonChecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e) {
            if (e.Button == panelContainer1.CustomHeaderButtons[4]) (panelContainer1.ActiveChild.ControlContainer.Controls[0] as MemoEdit).Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            if (e.Button == panelContainer1.CustomHeaderButtons[3]) (panelContainer1.ActiveChild.ControlContainer.Controls[0] as MemoEdit).Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            if (e.Button == panelContainer1.CustomHeaderButtons[2]) (panelContainer1.ActiveChild.ControlContainer.Controls[0] as MemoEdit).Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            if (e.Button == panelContainer1.CustomHeaderButtons[1]) panelContainer1.Visibility = DockVisibility.AutoHide;
        }
    }
}
