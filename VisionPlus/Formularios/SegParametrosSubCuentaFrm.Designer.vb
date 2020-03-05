<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SegParametrosSubCuentaFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cbxEmpresa = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbxCuenta = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbxSubCuenta = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbxCategoria = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbxPeriodo = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.cbxEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxSubCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(215, 167)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(121, 30)
        Me.cmdCancelar.TabIndex = 19
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(82, 167)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(121, 30)
        Me.cmdAceptar.TabIndex = 18
        Me.cmdAceptar.Text = "Aceptar"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(13, 49)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Cuenta"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(4, 140)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "Mes a comparar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(13, 81)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "Sub Cuenta"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 14
        Me.LabelControl1.Text = "EmpresaID"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(13, 109)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "Categoria"
        '
        'cbxEmpresa
        '
        Me.cbxEmpresa.Location = New System.Drawing.Point(82, 13)
        Me.cbxEmpresa.Name = "cbxEmpresa"
        Me.cbxEmpresa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxEmpresa.Size = New System.Drawing.Size(254, 20)
        Me.cbxEmpresa.TabIndex = 22
        '
        'cbxCuenta
        '
        Me.cbxCuenta.Location = New System.Drawing.Point(82, 45)
        Me.cbxCuenta.Name = "cbxCuenta"
        Me.cbxCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxCuenta.Size = New System.Drawing.Size(254, 20)
        Me.cbxCuenta.TabIndex = 23
        '
        'cbxSubCuenta
        '
        Me.cbxSubCuenta.Location = New System.Drawing.Point(82, 77)
        Me.cbxSubCuenta.Name = "cbxSubCuenta"
        Me.cbxSubCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxSubCuenta.Size = New System.Drawing.Size(254, 20)
        Me.cbxSubCuenta.TabIndex = 24
        '
        'cbxCategoria
        '
        Me.cbxCategoria.Location = New System.Drawing.Point(82, 105)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxCategoria.Size = New System.Drawing.Size(254, 20)
        Me.cbxCategoria.TabIndex = 25
        '
        'cbxPeriodo
        '
        Me.cbxPeriodo.Location = New System.Drawing.Point(82, 136)
        Me.cbxPeriodo.Name = "cbxPeriodo"
        Me.cbxPeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxPeriodo.Size = New System.Drawing.Size(254, 20)
        Me.cbxPeriodo.TabIndex = 26
        '
        'SegParametrosSubCuentaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 200)
        Me.Controls.Add(Me.cbxPeriodo)
        Me.Controls.Add(Me.cbxCategoria)
        Me.Controls.Add(Me.cbxSubCuenta)
        Me.Controls.Add(Me.cbxCuenta)
        Me.Controls.Add(Me.cbxEmpresa)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SegParametrosSubCuentaFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametros"
        CType(Me.cbxEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxSubCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxEmpresa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbxCuenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbxSubCuenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbxCategoria As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbxPeriodo As DevExpress.XtraEditors.LookUpEdit
End Class
