Namespace CustomHeaderButtonsExample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim serializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomHeaderButtonsExample.Form1))
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel4 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel4_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.memoEdit2 = New DevExpress.XtraEditors.MemoEdit()
            Me.memoEdit3 = New DevExpress.XtraEditors.MemoEdit()
            Me.memoEdit4 = New DevExpress.XtraEditors.MemoEdit()
            Me.dockPanel5 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel5_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelContainer1.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.dockPanel3.SuspendLayout()
            Me.dockPanel3_Container.SuspendLayout()
            Me.dockPanel4.SuspendLayout()
            Me.dockPanel4_Container.SuspendLayout()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.memoEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.memoEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.memoEdit4.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel5.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.Form = Me
            Me.dockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel5})
            Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.panelContainer1})
            Me.dockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.ActiveChild = Me.dockPanel1
            Me.panelContainer1.Controls.Add(Me.dockPanel1)
            Me.panelContainer1.Controls.Add(Me.dockPanel2)
            Me.panelContainer1.Controls.Add(Me.dockPanel3)
            Me.panelContainer1.Controls.Add(Me.dockPanel4)
            Me.panelContainer1.CustomHeaderButtons.AddRange(New DevExpress.XtraBars.Docking2010.IButton() {New DevExpress.XtraBars.Docking.CustomHeaderButton("Close", Global.CustomHeaderButtonsExample.Properties.Resources.delete_pressed, -1, DevExpress.XtraBars.Docking2010.HorizontalImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Close Active Panel", False, 103, True, Nothing, True, False, True, serializableAppearanceObject1, Nothing, Nothing, -1), New DevExpress.XtraBars.Docking.CustomHeaderButton("Auto Hide", Global.CustomHeaderButtonsExample.Properties.Resources.Pinned, -1, DevExpress.XtraBars.Docking2010.HorizontalImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Auto Hide Container", False, -1, True, Nothing, True, False, True, serializableAppearanceObject2, Nothing, Nothing, -1), New DevExpress.XtraBars.Docking.CustomHeaderButton("Tab 5", Global.CustomHeaderButtonsExample.Properties.Resources.right_align_16x16, -1, DevExpress.XtraBars.Docking2010.HorizontalImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Align Right", False, -1, True, Nothing, True, False, True, serializableAppearanceObject3, Nothing, Nothing, 1), New DevExpress.XtraBars.Docking.CustomHeaderButton("Tab 4", Global.CustomHeaderButtonsExample.Properties.Resources.center_align_16x16, -1, DevExpress.XtraBars.Docking2010.HorizontalImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Align Center", False, -1, True, Nothing, True, False, True, serializableAppearanceObject4, Nothing, Nothing, 1), New DevExpress.XtraBars.Docking.CustomHeaderButton("Tab 3", Global.CustomHeaderButtonsExample.Properties.Resources.left_align_16x16, -1, DevExpress.XtraBars.Docking2010.HorizontalImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Align Left", False, -1, True, Nothing, True, True, True, serializableAppearanceObject5, Nothing, Nothing, 1)})
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.panelContainer1.FloatVertical = True
            Me.panelContainer1.Footer = Nothing
            Me.panelContainer1.Header = Nothing
            Me.panelContainer1.ID = New System.Guid("a4c868dc-1a5a-4704-a97c-db1fd1e97ab1")
            Me.panelContainer1.Location = New System.Drawing.Point(0, 0)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.Options.ShowAutoHideButton = False
            Me.panelContainer1.Options.ShowCloseButton = False
            Me.panelContainer1.Options.ShowMaximizeButton = False
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(349, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(349, 291)
            Me.panelContainer1.Tabbed = True
            Me.panelContainer1.TabText = "Panel Container"
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' dockPanel2
            ' 
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel2.Footer = Nothing
            Me.dockPanel2.Header = Nothing
            Me.dockPanel2.ID = New System.Guid("0d22b9a6-fa37-49ef-b35c-e210156e1cb1")
            Me.dockPanel2.Location = New System.Drawing.Point(4, 28)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.Options.ShowCloseButton = False
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(387, 152)
            Me.dockPanel2.Size = New System.Drawing.Size(341, 232)
            Me.dockPanel2.TabText = "Tab 2"
            Me.dockPanel2.Text = "Tab 2 - DockPanel"
            ' 
            ' dockPanel2_Container
            ' 
            Me.dockPanel2_Container.Controls.Add(Me.memoEdit2)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(341, 232)
            Me.dockPanel2_Container.TabIndex = 0
            ' 
            ' dockPanel1
            ' 
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel1.FloatVertical = True
            Me.dockPanel1.Footer = Nothing
            Me.dockPanel1.Header = Nothing
            Me.dockPanel1.ID = New System.Guid("3bce220e-099b-47f3-b0d8-c7d141be2a94")
            Me.dockPanel1.Location = New System.Drawing.Point(4, 28)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.Options.ShowCloseButton = False
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(387, 152)
            Me.dockPanel1.Size = New System.Drawing.Size(341, 232)
            Me.dockPanel1.TabText = "Tab 1"
            Me.dockPanel1.Text = "Tab 1 - DockPanel"
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Controls.Add(Me.memoEdit1)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(341, 232)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' dockPanel3
            ' 
            Me.dockPanel3.Controls.Add(Me.dockPanel3_Container)
            Me.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel3.Footer = Nothing
            Me.dockPanel3.Header = Nothing
            Me.dockPanel3.ID = New System.Guid("def976c9-0f60-4b7d-8e5f-bb314951ba06")
            Me.dockPanel3.Location = New System.Drawing.Point(4, 28)
            Me.dockPanel3.Name = "dockPanel3"
            Me.dockPanel3.Options.ShowCloseButton = False
            Me.dockPanel3.OriginalSize = New System.Drawing.Size(387, 152)
            Me.dockPanel3.Size = New System.Drawing.Size(341, 232)
            Me.dockPanel3.TabText = "Tab 3"
            Me.dockPanel3.Text = "Tab 3 - DockPanel"
            ' 
            ' dockPanel3_Container
            ' 
            Me.dockPanel3_Container.Controls.Add(Me.memoEdit3)
            Me.dockPanel3_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel3_Container.Name = "dockPanel3_Container"
            Me.dockPanel3_Container.Size = New System.Drawing.Size(341, 232)
            Me.dockPanel3_Container.TabIndex = 0
            ' 
            ' dockPanel4
            ' 
            Me.dockPanel4.Controls.Add(Me.dockPanel4_Container)
            Me.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel4.Footer = Nothing
            Me.dockPanel4.Header = Nothing
            Me.dockPanel4.ID = New System.Guid("009386c2-b521-468f-8a20-744dfc97e4e4")
            Me.dockPanel4.Location = New System.Drawing.Point(4, 28)
            Me.dockPanel4.Name = "dockPanel4"
            Me.dockPanel4.Options.ShowCloseButton = False
            Me.dockPanel4.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel4.Size = New System.Drawing.Size(341, 232)
            Me.dockPanel4.TabText = "Tab 4"
            Me.dockPanel4.Text = "Tab 3 - DockPanel"
            ' 
            ' dockPanel4_Container
            ' 
            Me.dockPanel4_Container.Controls.Add(Me.memoEdit4)
            Me.dockPanel4_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel4_Container.Name = "dockPanel4_Container"
            Me.dockPanel4_Container.Size = New System.Drawing.Size(341, 232)
            Me.dockPanel4_Container.TabIndex = 0
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue")
            Me.memoEdit1.Location = New System.Drawing.Point(-4, 0)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New System.Drawing.Size(349, 232)
            Me.memoEdit1.TabIndex = 0
            ' 
            ' memoEdit2
            ' 
            Me.memoEdit2.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.memoEdit2.EditValue = resources.GetString("memoEdit2.EditValue")
            Me.memoEdit2.Location = New System.Drawing.Point(-4, 0)
            Me.memoEdit2.Name = "memoEdit2"
            Me.memoEdit2.Size = New System.Drawing.Size(349, 232)
            Me.memoEdit2.TabIndex = 0
            ' 
            ' memoEdit3
            ' 
            Me.memoEdit3.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.memoEdit3.EditValue = resources.GetString("memoEdit3.EditValue")
            Me.memoEdit3.Location = New System.Drawing.Point(-4, 0)
            Me.memoEdit3.Name = "memoEdit3"
            Me.memoEdit3.Size = New System.Drawing.Size(349, 232)
            Me.memoEdit3.TabIndex = 0
            ' 
            ' memoEdit4
            ' 
            Me.memoEdit4.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.memoEdit4.EditValue = resources.GetString("memoEdit4.EditValue")
            Me.memoEdit4.Location = New System.Drawing.Point(-4, 0)
            Me.memoEdit4.Name = "memoEdit4"
            Me.memoEdit4.Size = New System.Drawing.Size(349, 232)
            Me.memoEdit4.TabIndex = 0
            ' 
            ' dockPanel5
            ' 
            Me.dockPanel5.Controls.Add(Me.dockPanel5_Container)
            Me.dockPanel5.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanel5.FloatLocation = New System.Drawing.Point(610, 408)
            Me.dockPanel5.Footer = Nothing
            Me.dockPanel5.Header = Nothing
            Me.dockPanel5.ID = New System.Guid("72a56992-1ff6-469a-9aee-699cefa18f7b")
            Me.dockPanel5.Location = New System.Drawing.Point(-32768, -32768)
            Me.dockPanel5.Name = "dockPanel5"
            Me.dockPanel5.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel5.SavedIndex = 1
            Me.dockPanel5.Size = New System.Drawing.Size(200, 200)
            Me.dockPanel5.Text = "dockPanel5"
            Me.dockPanel5.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            ' 
            ' dockPanel5_Container
            ' 
            Me.dockPanel5_Container.Location = New System.Drawing.Point(3, 22)
            Me.dockPanel5_Container.Name = "dockPanel5_Container"
            Me.dockPanel5_Container.Size = New System.Drawing.Size(194, 175)
            Me.dockPanel5_Container.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(430, 291)
            Me.Controls.Add(Me.panelContainer1)
            Me.Name = "Form1"
            Me.Text = "Custom Buttons Example"
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelContainer1.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.dockPanel3.ResumeLayout(False)
            Me.dockPanel3_Container.ResumeLayout(False)
            Me.dockPanel4.ResumeLayout(False)
            Me.dockPanel4_Container.ResumeLayout(False)
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.memoEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.memoEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.memoEdit4.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel5.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private dockManager1 As DevExpress.XtraBars.Docking.DockManager

        Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanel3 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit

        Private dockPanel4 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel4_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private memoEdit2 As DevExpress.XtraEditors.MemoEdit

        Private memoEdit3 As DevExpress.XtraEditors.MemoEdit

        Private memoEdit4 As DevExpress.XtraEditors.MemoEdit

        Private dockPanel5 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel5_Container As DevExpress.XtraBars.Docking.ControlContainer
    End Class
End Namespace
