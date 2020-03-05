<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SegParametrosFrm
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.ProduccionDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionDataSet = New VisionPlus.ProduccionDataSet()
        Me.JAppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.J_AppointmentsTableAdapter = New VisionPlus.ProduccionDataSetTableAdapters.J_AppointmentsTableAdapter()
        Me.cbxPeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbxEmpresa = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbxCuenta = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbxCentroCosto = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.ProduccionDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JAppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCentroCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "EmpresaID"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(13, 86)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Centro Costo"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(4, 118)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Mes a comparar"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(13, 54)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Cuenta"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(82, 145)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(121, 30)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(215, 145)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(121, 30)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Cancelar"
        '
        'ProduccionDataSetBindingSource
        '
        Me.ProduccionDataSetBindingSource.DataSource = Me.ProduccionDataSet
        Me.ProduccionDataSetBindingSource.Position = 0
        '
        'ProduccionDataSet
        '
        Me.ProduccionDataSet.DataSetName = "ProduccionDataSet"
        Me.ProduccionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JAppointmentsBindingSource
        '
        Me.JAppointmentsBindingSource.DataMember = "J_Appointments"
        Me.JAppointmentsBindingSource.DataSource = Me.ProduccionDataSetBindingSource
        '
        'J_AppointmentsTableAdapter
        '
        Me.J_AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'cbxPeriodo
        '
        Me.cbxPeriodo.Location = New System.Drawing.Point(82, 115)
        Me.cbxPeriodo.Name = "cbxPeriodo"
        Me.cbxPeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxPeriodo.Size = New System.Drawing.Size(254, 20)
        Me.cbxPeriodo.TabIndex = 3
        '
        'cbxEmpresa
        '
        Me.cbxEmpresa.Location = New System.Drawing.Point(82, 18)
        Me.cbxEmpresa.Name = "cbxEmpresa"
        Me.cbxEmpresa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxEmpresa.Size = New System.Drawing.Size(254, 20)
        Me.cbxEmpresa.TabIndex = 0
        '
        'cbxCuenta
        '
        Me.cbxCuenta.Location = New System.Drawing.Point(82, 50)
        Me.cbxCuenta.Name = "cbxCuenta"
        Me.cbxCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxCuenta.Size = New System.Drawing.Size(254, 20)
        Me.cbxCuenta.TabIndex = 1
        '
        'cbxCentroCosto
        '
        Me.cbxCentroCosto.Location = New System.Drawing.Point(82, 82)
        Me.cbxCentroCosto.Name = "cbxCentroCosto"
        Me.cbxCentroCosto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxCentroCosto.Size = New System.Drawing.Size(254, 20)
        Me.cbxCentroCosto.TabIndex = 2
        '
        'SegParametrosFrm
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(344, 180)
        Me.Controls.Add(Me.cbxCentroCosto)
        Me.Controls.Add(Me.cbxCuenta)
        Me.Controls.Add(Me.cbxEmpresa)
        Me.Controls.Add(Me.cbxPeriodo)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SegParametrosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametros"
        CType(Me.ProduccionDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JAppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCentroCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProduccionDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionDataSet As VisionPlus.ProduccionDataSet
    Friend WithEvents JAppointmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents J_AppointmentsTableAdapter As VisionPlus.ProduccionDataSetTableAdapters.J_AppointmentsTableAdapter
    Friend WithEvents cbxPeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbxEmpresa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbxCuenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbxCentroCosto As DevExpress.XtraEditors.LookUpEdit
End Class
