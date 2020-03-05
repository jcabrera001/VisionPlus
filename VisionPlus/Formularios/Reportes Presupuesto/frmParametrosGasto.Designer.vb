<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametrosGasto
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
        Me.cbxCuenta = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbxCalendario = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbxEstado = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.cbxZafra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCalendario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxZafra
        '
        Me.cbxZafra.Location = New System.Drawing.Point(83, 12)
        Me.cbxZafra.Name = "cbxZafra"
        Me.cbxZafra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxZafra.Size = New System.Drawing.Size(254, 20)
        Me.cbxZafra.TabIndex = 49
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(17, 16)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl3.TabIndex = 50
        Me.LabelControl3.Text = "Zafra"
        '
        'cbxCuenta
        '
        Me.cbxCuenta.Location = New System.Drawing.Point(83, 42)
        Me.cbxCuenta.Name = "cbxCuenta"
        Me.cbxCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxCuenta.Size = New System.Drawing.Size(254, 20)
        Me.cbxCuenta.TabIndex = 47
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(14, 46)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl4.TabIndex = 48
        Me.LabelControl4.Text = "Cuenta"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(215, 123)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(121, 30)
        Me.cmdCancelar.TabIndex = 46
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(82, 123)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(121, 30)
        Me.cmdAceptar.TabIndex = 45
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cbxCalendario
        '
        Me.cbxCalendario.Location = New System.Drawing.Point(83, 97)
        Me.cbxCalendario.Name = "cbxCalendario"
        Me.cbxCalendario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxCalendario.Size = New System.Drawing.Size(254, 20)
        Me.cbxCalendario.TabIndex = 51
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 101)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl1.TabIndex = 52
        Me.LabelControl1.Text = "Mes a buscar"
        '
        'cbxEstado
        '
        Me.cbxEstado.Location = New System.Drawing.Point(82, 70)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxEstado.Size = New System.Drawing.Size(254, 20)
        Me.cbxEstado.TabIndex = 53
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(13, 74)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 54
        Me.LabelControl2.Text = "Estado"
        '
        'frmParametrosGasto
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(348, 165)
        Me.Controls.Add(Me.cbxEstado)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cbxCalendario)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cbxZafra)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cbxCuenta)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmParametrosGasto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parámetros"
        CType(Me.cbxZafra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCalendario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxZafra As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxCuenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbxCalendario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxEstado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
