﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddReporteXUsuario
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gcUsuarios = New DevExpress.XtraGrid.GridControl()
        Me.gvUsuarios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.idusuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colusuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gcUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcUsuarios
        '
        Me.gcUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gcUsuarios.Location = New System.Drawing.Point(6, 5)
        Me.gcUsuarios.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcUsuarios.LookAndFeel.UseWindowsXPTheme = True
        Me.gcUsuarios.MainView = Me.gvUsuarios
        Me.gcUsuarios.Name = "gcUsuarios"
        Me.gcUsuarios.Size = New System.Drawing.Size(498, 470)
        Me.gcUsuarios.TabIndex = 1
        Me.gcUsuarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUsuarios})
        '
        'gvUsuarios
        '
        Me.gvUsuarios.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvUsuarios.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvUsuarios.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gvUsuarios.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvUsuarios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idusuario, Me.Nombre, Me.colusuario})
        Me.gvUsuarios.GridControl = Me.gcUsuarios
        Me.gvUsuarios.GroupPanelText = "Usuarios Actuales"
        Me.gvUsuarios.Name = "gvUsuarios"
        Me.gvUsuarios.OptionsCustomization.AllowGroup = False
        Me.gvUsuarios.OptionsDetail.EnableMasterViewMode = False
        Me.gvUsuarios.OptionsView.ShowAutoFilterRow = True
        '
        'idusuario
        '
        Me.idusuario.Caption = "IDReporte"
        Me.idusuario.FieldName = "idusuario"
        Me.idusuario.Name = "idusuario"
        '
        'colusuario
        '
        Me.colusuario.Caption = "Usuario"
        Me.colusuario.FieldName = "Usuario"
        Me.colusuario.Name = "colusuario"
        Me.colusuario.OptionsColumn.AllowEdit = False
        Me.colusuario.OptionsColumn.ReadOnly = True
        Me.colusuario.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colusuario.Visible = True
        Me.colusuario.VisibleIndex = 0
        Me.colusuario.Width = 183
        '
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.FieldName = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.OptionsColumn.AllowEdit = False
        Me.Nombre.OptionsColumn.ReadOnly = True
        Me.Nombre.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Nombre.Visible = True
        Me.Nombre.VisibleIndex = 1
        Me.Nombre.Width = 240
        '
        'frmAddReporteXUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 494)
        Me.Controls.Add(Me.gcUsuarios)
        Me.Name = "frmAddReporteXUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.gcUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcUsuarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUsuarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents idusuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colusuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
End Class
