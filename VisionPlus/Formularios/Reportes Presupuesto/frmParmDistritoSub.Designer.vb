<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParmDistritoSub
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
        Me.cbxDistrito = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbxCalendario = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbxZafra = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbxCuenta = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbxSubCuenta = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.cbxDistrito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCalendario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxZafra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxSubCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxDistrito
        '
        Me.cbxDistrito.Location = New System.Drawing.Point(71, 64)
        Me.cbxDistrito.Name = "cbxDistrito"
        Me.cbxDistrito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxDistrito.Size = New System.Drawing.Size(254, 20)
        Me.cbxDistrito.TabIndex = 98
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(31, 68)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl2.TabIndex = 99
        Me.LabelControl2.Text = "Distrito"
        '
        'cbxCalendario
        '
        Me.cbxCalendario.Location = New System.Drawing.Point(72, 116)
        Me.cbxCalendario.Name = "cbxCalendario"
        Me.cbxCalendario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxCalendario.Size = New System.Drawing.Size(254, 20)
        Me.cbxCalendario.TabIndex = 96
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(2, 120)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl1.TabIndex = 97
        Me.LabelControl1.Text = "Mes a buscar"
        '
        'cbxZafra
        '
        Me.cbxZafra.Location = New System.Drawing.Point(72, 12)
        Me.cbxZafra.Name = "cbxZafra"
        Me.cbxZafra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxZafra.Size = New System.Drawing.Size(254, 20)
        Me.cbxZafra.TabIndex = 95
        '
        'cbxCuenta
        '
        Me.cbxCuenta.Location = New System.Drawing.Point(72, 38)
        Me.cbxCuenta.Name = "cbxCuenta"
        Me.cbxCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxCuenta.Size = New System.Drawing.Size(254, 20)
        Me.cbxCuenta.TabIndex = 93
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(30, 42)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl4.TabIndex = 94
        Me.LabelControl4.Text = "Cuenta"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(204, 149)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(121, 30)
        Me.cmdCancelar.TabIndex = 92
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(76, 149)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(121, 30)
        Me.cmdAceptar.TabIndex = 91
        Me.cmdAceptar.Text = "Aceptar"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 16)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl3.TabIndex = 90
        Me.LabelControl3.Text = "Presupuesto"
        '
        'cbxSubCuenta
        '
        Me.cbxSubCuenta.Location = New System.Drawing.Point(71, 90)
        Me.cbxSubCuenta.Name = "cbxSubCuenta"
        Me.cbxSubCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxSubCuenta.Size = New System.Drawing.Size(254, 20)
        Me.cbxSubCuenta.TabIndex = 100
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 94)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl5.TabIndex = 101
        Me.LabelControl5.Text = "SubCuenta"
        '
        'frmParmDistritoSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 181)
        Me.Controls.Add(Me.cbxSubCuenta)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.cbxDistrito)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cbxCalendario)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cbxZafra)
        Me.Controls.Add(Me.cbxCuenta)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.LabelControl3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmParmDistritoSub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parámetros"
        CType(Me.cbxDistrito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCalendario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxZafra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxSubCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxDistrito As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxCalendario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxZafra As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbxCuenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxSubCuenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
