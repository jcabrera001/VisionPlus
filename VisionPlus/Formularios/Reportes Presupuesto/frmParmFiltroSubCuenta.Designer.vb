<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParmFiltroSubCuenta
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
        Me.cbxZafra = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbxCalendario = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbxSubCuenta = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.cbxZafra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCalendario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxSubCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxZafra
        '
        Me.cbxZafra.Location = New System.Drawing.Point(88, 12)
        Me.cbxZafra.Name = "cbxZafra"
        Me.cbxZafra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxZafra.Size = New System.Drawing.Size(254, 20)
        Me.cbxZafra.TabIndex = 55
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(56, 15)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl3.TabIndex = 56
        Me.LabelControl3.Text = "Zafra"
        '
        'cbxCalendario
        '
        Me.cbxCalendario.Location = New System.Drawing.Point(88, 41)
        Me.cbxCalendario.Name = "cbxCalendario"
        Me.cbxCalendario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxCalendario.Size = New System.Drawing.Size(254, 20)
        Me.cbxCalendario.TabIndex = 53
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(6, 45)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl4.TabIndex = 54
        Me.LabelControl4.Text = "Mes a comparar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(220, 103)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(121, 30)
        Me.cmdCancelar.TabIndex = 52
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(87, 103)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(121, 30)
        Me.cmdAceptar.TabIndex = 51
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cbxSubCuenta
        '
        Me.cbxSubCuenta.Location = New System.Drawing.Point(87, 70)
        Me.cbxSubCuenta.Name = "cbxSubCuenta"
        Me.cbxSubCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxSubCuenta.Size = New System.Drawing.Size(254, 20)
        Me.cbxSubCuenta.TabIndex = 73
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(26, 74)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 74
        Me.LabelControl2.Text = "Sub Cuenta"
        '
        'frmParmFiltroSubCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 140)
        Me.Controls.Add(Me.cbxSubCuenta)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cbxZafra)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cbxCalendario)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmParmFiltroSubCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Párametros"
        CType(Me.cbxZafra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCalendario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxSubCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxZafra As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxCalendario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbxSubCuenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
