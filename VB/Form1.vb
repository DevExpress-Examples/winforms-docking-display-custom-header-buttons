Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace CustomHeaderButtonsExample
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			AddHandler panelContainer1.CustomButtonUnchecked, AddressOf panelContainer1_CustomButtonUnchecked
			AddHandler panelContainer1.CustomButtonChecked, AddressOf panelContainer1_CustomButtonChecked
			AddHandler panelContainer1.CustomButtonClick, AddressOf panelContainer1_CustomButtonClick
		End Sub


		Private Sub panelContainer1_CustomButtonUnchecked(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs)
			panelContainer1.Visibility = DockVisibility.Visible
		End Sub

		Private Sub panelContainer1_CustomButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs)
			panelContainer1.ActiveChild.Close()
		End Sub

		Private Sub panelContainer1_CustomButtonChecked(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs)
            If (e.Button Is panelContainer1.CustomHeaderButtons(4)) Then
                TryCast(panelContainer1.ActiveChild.ControlContainer.Controls(0), MemoEdit).Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near
            End If
            If e.Button Is panelContainer1.CustomHeaderButtons(3) Then
                TryCast(panelContainer1.ActiveChild.ControlContainer.Controls(0), MemoEdit).Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center
            End If
            If e.Button Is panelContainer1.CustomHeaderButtons(2) Then
                TryCast(panelContainer1.ActiveChild.ControlContainer.Controls(0), MemoEdit).Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far
            End If
            If e.Button Is panelContainer1.CustomHeaderButtons(1) Then
                panelContainer1.Visibility = DockVisibility.AutoHide
            End If
		End Sub
	End Class
End Namespace