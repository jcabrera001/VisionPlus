<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametrosChoCC
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
        Me.cbxSubCuenta = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbxCuenta = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbxCategoria = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbxPeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.cbxSubCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxSubCuenta
        '
        Me.cbxSubCuenta.Location = New System.Drawing.Point(84, 41)
        Me.cbxSubCuenta.Name = "cbxSubCuenta"
        Me.cbxSubCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxSubCuenta.Size = New System.Drawing.Size(254, 20)
        Me.cbxSubCuenta.TabIndex = 33
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(26, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 34
        Me.LabelControl2.Text = "SubCuenta"
        '
        'cbxCuenta
        '
        Me.cbxCuenta.Location = New System.Drawing.Point(84, 12)
        Me.cbxCuenta.Name = "cbxCuenta"
        Me.cbxCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxCuenta.Size = New System.Drawing.Size(254, 20)
        Me.cbxCuenta.TabIndex = 27
        '
        'cbxCategoria
        '
        Me.cbxCategoria.Location = New System.Drawing.Point(85, 97)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxCategoria.Size = New System.Drawing.Size(254, 20)
        Me.cbxCategoria.TabIndex = 28
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(217, 125)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(121, 30)
        Me.cmdCancelar.TabIndex = 31
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(84, 125)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(121, 30)
        Me.cmdAceptar.TabIndex = 29
        Me.cmdAceptar.Text = "Aceptar"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(32, 100)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 32
        Me.LabelControl3.Text = "Categoria"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(44, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 30
        Me.LabelControl1.Text = "Cuenta"
        '
        'cbxPeriodo
        '
        Me.cbxPeriodo.Location = New System.Drawing.Point(85, 69)
        Me.cbxPeriodo.Name = "cbxPeriodo"
        Me.cbxPeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxPeriodo.Size = New System.Drawing.Size(254, 20)
        Me.cbxPeriodo.TabIndex = 35
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(3, 72)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl4.TabIndex = 36
        Me.LabelControl4.Text = "Mes a comparar"
        '
        'frmParametrosChoCC
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(347, 161)
        Me.Controls.Add(Me.cbxPeriodo)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cbxSubCuenta)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cbxCuenta)
        Me.Controls.Add(Me.cbxCategoria)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmParametrosChoCC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parámetros"
        CType(Me.cbxSubCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxSubCuenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxCuenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbxCategoria As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxPeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
