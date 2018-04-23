namespace CustomHeaderButtonsExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel4 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit3 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit4 = new DevExpress.XtraEditors.MemoEdit();
            this.dockPanel5 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel5_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.dockPanel3.SuspendLayout();
            this.dockPanel3_Container.SuspendLayout();
            this.dockPanel4.SuspendLayout();
            this.dockPanel4_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit4.Properties)).BeginInit();
            this.dockPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel5});
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.ActiveChild = this.dockPanel1;
            this.panelContainer1.Controls.Add(this.dockPanel1);
            this.panelContainer1.Controls.Add(this.dockPanel2);
            this.panelContainer1.Controls.Add(this.dockPanel3);
            this.panelContainer1.Controls.Add(this.dockPanel4);
            this.panelContainer1.CustomHeaderButtons.AddRange(new DevExpress.XtraBars.Docking2010.IButton[] {
            new DevExpress.XtraBars.Docking.CustomHeaderButton("Close", global::CustomHeaderButtonsExample.Properties.Resources.delete_pressed, -1, DevExpress.XtraBars.Docking2010.HorizontalImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Close Active Panel", false, 103, true, null, true, false, true, serializableAppearanceObject1, null, null, -1),
            new DevExpress.XtraBars.Docking.CustomHeaderButton("Auto Hide", global::CustomHeaderButtonsExample.Properties.Resources.Pinned, -1, DevExpress.XtraBars.Docking2010.HorizontalImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Auto Hide Container", false, -1, true, null, true, false, true, serializableAppearanceObject2, null, null, -1),
            new DevExpress.XtraBars.Docking.CustomHeaderButton("Tab 5", global::CustomHeaderButtonsExample.Properties.Resources.right_align_16x16, -1, DevExpress.XtraBars.Docking2010.HorizontalImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Align Right", false, -1, true, null, true, false, true, serializableAppearanceObject3, null, null, 1),
            new DevExpress.XtraBars.Docking.CustomHeaderButton("Tab 4", global::CustomHeaderButtonsExample.Properties.Resources.center_align_16x16, -1, DevExpress.XtraBars.Docking2010.HorizontalImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Align Center", false, -1, true, null, true, false, true, serializableAppearanceObject4, null, null, 1),
            new DevExpress.XtraBars.Docking.CustomHeaderButton("Tab 3", global::CustomHeaderButtonsExample.Properties.Resources.left_align_16x16, -1, DevExpress.XtraBars.Docking2010.HorizontalImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Align Left", false, -1, true, null, true, true, true, serializableAppearanceObject5, null, null, 1)});
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.panelContainer1.FloatVertical = true;
            this.panelContainer1.Footer = null;
            this.panelContainer1.Header = null;
            this.panelContainer1.ID = new System.Guid("a4c868dc-1a5a-4704-a97c-db1fd1e97ab1");
            this.panelContainer1.Location = new System.Drawing.Point(0, 0);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.Options.ShowAutoHideButton = false;
            this.panelContainer1.Options.ShowCloseButton = false;
            this.panelContainer1.Options.ShowMaximizeButton = false;
            this.panelContainer1.OriginalSize = new System.Drawing.Size(349, 200);
            this.panelContainer1.Size = new System.Drawing.Size(349, 291);
            this.panelContainer1.Tabbed = true;
            this.panelContainer1.TabText = "Panel Container";
            this.panelContainer1.Text = "panelContainer1";
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel2.Footer = null;
            this.dockPanel2.Header = null;
            this.dockPanel2.ID = new System.Guid("0d22b9a6-fa37-49ef-b35c-e210156e1cb1");
            this.dockPanel2.Location = new System.Drawing.Point(4, 28);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.Options.ShowCloseButton = false;
            this.dockPanel2.OriginalSize = new System.Drawing.Size(387, 152);
            this.dockPanel2.Size = new System.Drawing.Size(341, 232);
            this.dockPanel2.TabText = "Tab 2";
            this.dockPanel2.Text = "Tab 2 - DockPanel";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.memoEdit2);
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(341, 232);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel1.FloatVertical = true;
            this.dockPanel1.Footer = null;
            this.dockPanel1.Header = null;
            this.dockPanel1.ID = new System.Guid("3bce220e-099b-47f3-b0d8-c7d141be2a94");
            this.dockPanel1.Location = new System.Drawing.Point(4, 28);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(387, 152);
            this.dockPanel1.Size = new System.Drawing.Size(341, 232);
            this.dockPanel1.TabText = "Tab 1";
            this.dockPanel1.Text = "Tab 1 - DockPanel";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.memoEdit1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(341, 232);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dockPanel3
            // 
            this.dockPanel3.Controls.Add(this.dockPanel3_Container);
            this.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel3.Footer = null;
            this.dockPanel3.Header = null;
            this.dockPanel3.ID = new System.Guid("def976c9-0f60-4b7d-8e5f-bb314951ba06");
            this.dockPanel3.Location = new System.Drawing.Point(4, 28);
            this.dockPanel3.Name = "dockPanel3";
            this.dockPanel3.Options.ShowCloseButton = false;
            this.dockPanel3.OriginalSize = new System.Drawing.Size(387, 152);
            this.dockPanel3.Size = new System.Drawing.Size(341, 232);
            this.dockPanel3.TabText = "Tab 3";
            this.dockPanel3.Text = "Tab 3 - DockPanel";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Controls.Add(this.memoEdit3);
            this.dockPanel3_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(341, 232);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // dockPanel4
            // 
            this.dockPanel4.Controls.Add(this.dockPanel4_Container);
            this.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel4.Footer = null;
            this.dockPanel4.Header = null;
            this.dockPanel4.ID = new System.Guid("009386c2-b521-468f-8a20-744dfc97e4e4");
            this.dockPanel4.Location = new System.Drawing.Point(4, 28);
            this.dockPanel4.Name = "dockPanel4";
            this.dockPanel4.Options.ShowCloseButton = false;
            this.dockPanel4.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel4.Size = new System.Drawing.Size(341, 232);
            this.dockPanel4.TabText = "Tab 4";
            this.dockPanel4.Text = "Tab 3 - DockPanel";
            // 
            // dockPanel4_Container
            // 
            this.dockPanel4_Container.Controls.Add(this.memoEdit4);
            this.dockPanel4_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel4_Container.Name = "dockPanel4_Container";
            this.dockPanel4_Container.Size = new System.Drawing.Size(341, 232);
            this.dockPanel4_Container.TabIndex = 0;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue");
            this.memoEdit1.Location = new System.Drawing.Point(-4, 0);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(349, 232);
            this.memoEdit1.TabIndex = 0;
            // 
            // memoEdit2
            // 
            this.memoEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit2.EditValue = resources.GetString("memoEdit2.EditValue");
            this.memoEdit2.Location = new System.Drawing.Point(-4, 0);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Size = new System.Drawing.Size(349, 232);
            this.memoEdit2.TabIndex = 0;
            // 
            // memoEdit3
            // 
            this.memoEdit3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit3.EditValue = resources.GetString("memoEdit3.EditValue");
            this.memoEdit3.Location = new System.Drawing.Point(-4, 0);
            this.memoEdit3.Name = "memoEdit3";
            this.memoEdit3.Size = new System.Drawing.Size(349, 232);
            this.memoEdit3.TabIndex = 0;
            // 
            // memoEdit4
            // 
            this.memoEdit4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit4.EditValue = resources.GetString("memoEdit4.EditValue");
            this.memoEdit4.Location = new System.Drawing.Point(-4, 0);
            this.memoEdit4.Name = "memoEdit4";
            this.memoEdit4.Size = new System.Drawing.Size(349, 232);
            this.memoEdit4.TabIndex = 0;
            // 
            // dockPanel5
            // 
            this.dockPanel5.Controls.Add(this.dockPanel5_Container);
            this.dockPanel5.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel5.FloatLocation = new System.Drawing.Point(610, 408);
            this.dockPanel5.Footer = null;
            this.dockPanel5.Header = null;
            this.dockPanel5.ID = new System.Guid("72a56992-1ff6-469a-9aee-699cefa18f7b");
            this.dockPanel5.Location = new System.Drawing.Point(-32768, -32768);
            this.dockPanel5.Name = "dockPanel5";
            this.dockPanel5.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel5.SavedIndex = 1;
            this.dockPanel5.Size = new System.Drawing.Size(200, 200);
            this.dockPanel5.Text = "dockPanel5";
            this.dockPanel5.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel5_Container
            // 
            this.dockPanel5_Container.Location = new System.Drawing.Point(3, 22);
            this.dockPanel5_Container.Name = "dockPanel5_Container";
            this.dockPanel5_Container.Size = new System.Drawing.Size(194, 175);
            this.dockPanel5_Container.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 291);
            this.Controls.Add(this.panelContainer1);
            this.Name = "Form1";
            this.Text = "Custom Buttons Example";
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel3.ResumeLayout(false);
            this.dockPanel3_Container.ResumeLayout(false);
            this.dockPanel4.ResumeLayout(false);
            this.dockPanel4_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit4.Properties)).EndInit();
            this.dockPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel3;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel4;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel4_Container;
        private DevExpress.XtraEditors.MemoEdit memoEdit2;
        private DevExpress.XtraEditors.MemoEdit memoEdit3;
        private DevExpress.XtraEditors.MemoEdit memoEdit4;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel5;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel5_Container;
    }
}

