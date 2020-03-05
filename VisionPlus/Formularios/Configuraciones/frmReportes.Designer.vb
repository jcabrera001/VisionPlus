<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Me.gcReporte = New DevExpress.XtraGrid.GridControl()
        Me.gvReporte = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtReporte = New DevExpress.XtraEditors.TextEdit()
        Me.txtObjeto = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.btnSalvar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbBase = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gcReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReporte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObjeto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcReporte
        '
        Me.gcReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcReporte.Location = New System.Drawing.Point(12, 2)
        Me.gcReporte.MainView = Me.gvReporte
        Me.gcReporte.Name = "gcReporte"
        Me.gcReporte.Size = New System.Drawing.Size(603, 342)
        Me.gcReporte.TabIndex = 13
        Me.gcReporte.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvReporte})
        '
        'gvReporte
        '
        Me.gvReporte.GridControl = Me.gcReporte
        Me.gvReporte.Name = "gvReporte"
        Me.gvReporte.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.gvReporte.OptionsFilter.UseNewCustomFilterDialog = True
        Me.gvReporte.OptionsView.ShowAutoFilterRow = True
        Me.gvReporte.OptionsView.ShowGroupPanel = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 445)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-1, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Base de datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 392)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Reporte"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(287, 420)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Objeto"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(74, 360)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(460, 20)
        Me.txtNombre.TabIndex = 21
        Me.txtNombre.Tag = "0"
        '
        'txtReporte
        '
        Me.txtReporte.Location = New System.Drawing.Point(74, 388)
        Me.txtReporte.Name = "txtReporte"
        Me.txtReporte.Size = New System.Drawing.Size(460, 20)
        Me.txtReporte.TabIndex = 22
        '
        'txtObjeto
        '
        Me.txtObjeto.Location = New System.Drawing.Point(333, 416)
        Me.txtObjeto.Name = "txtObjeto"
        Me.txtObjeto.Size = New System.Drawing.Size(201, 20)
        Me.txtObjeto.TabIndex = 24
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(74, 444)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(460, 56)
        Me.txtDescripcion.TabIndex = 25
        Me.txtDescripcion.Text = ""
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(540, 363)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 41)
        Me.btnSalvar.TabIndex = 26
        Me.btnSalvar.Text = "Salvar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(540, 411)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 41)
        Me.btnCancelar.TabIndex = 27
        Me.btnCancelar.Text = "Cancelar"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(540, 459)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 41)
        Me.SimpleButton3.TabIndex = 28
        Me.SimpleButton3.Text = "SimpleButton3"
        Me.SimpleButton3.Visible = False
        '
        'cmbBase
        '
        Me.cmbBase.Location = New System.Drawing.Point(74, 416)
        Me.cmbBase.Name = "cmbBase"
        Me.cmbBase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbBase.Properties.NullText = ""
        Me.cmbBase.Properties.PopupSizeable = False
        Me.cmbBase.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbBase.Properties.View = Me.GridLookUpEdit1View
        Me.cmbBase.Size = New System.Drawing.Size(201, 20)
        Me.cmbBase.TabIndex = 23
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Nombre})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridLookUpEdit1View.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.FieldName = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.OptionsColumn.AllowEdit = False
        Me.Nombre.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Nombre.Visible = True
        Me.Nombre.VisibleIndex = 0
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 512)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtObjeto)
        Me.Controls.Add(Me.txtReporte)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gcReporte)
        Me.Controls.Add(Me.cmbBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        CType(Me.gcReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReporte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObjeto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gcReporte As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvReporte As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtReporte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtObjeto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSalvar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbBase As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
End Class
