<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmMtoGrupos
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
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.cmbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.cmbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.cmbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.cmbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbxDatos = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.lblNombre = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.dgvDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdArea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tsMenu.SuspendLayout()
        CType(Me.gbxDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatos.SuspendLayout()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbGuardar, Me.cmbEliminar, Me.cmbCancelar, Me.cmbSalir})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(507, 52)
        Me.tsMenu.TabIndex = 6
        '
        'cmbGuardar
        '
        Me.cmbGuardar.Image = Global.VisionPlus.My.Resources.Resources.disk
        Me.cmbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbGuardar.Name = "cmbGuardar"
        Me.cmbGuardar.Size = New System.Drawing.Size(50, 49)
        Me.cmbGuardar.Text = "Guardar"
        Me.cmbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmbEliminar
        '
        Me.cmbEliminar.Image = Global.VisionPlus.My.Resources.Resources.delete
        Me.cmbEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbEliminar.Name = "cmbEliminar"
        Me.cmbEliminar.Size = New System.Drawing.Size(47, 49)
        Me.cmbEliminar.Text = "Eliminar"
        Me.cmbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Image = Global.VisionPlus.My.Resources.Resources.cancel
        Me.cmbCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(44, 49)
        Me.cmbCancelar.Text = "Limpiar"
        Me.cmbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmbSalir
        '
        Me.cmbSalir.Image = Global.VisionPlus.My.Resources.Resources.door_in
        Me.cmbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbSalir.Name = "cmbSalir"
        Me.cmbSalir.Size = New System.Drawing.Size(36, 49)
        Me.cmbSalir.Text = "Salir"
        Me.cmbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'gbxDatos
        '
        Me.gbxDatos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gbxDatos.Controls.Add(Me.LabelControl1)
        Me.gbxDatos.Controls.Add(Me.txtDescripcion)
        Me.gbxDatos.Controls.Add(Me.lblNombre)
        Me.gbxDatos.Controls.Add(Me.txtNombre)
        Me.gbxDatos.Location = New System.Drawing.Point(3, 298)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(494, 129)
        Me.gbxDatos.TabIndex = 12
        Me.gbxDatos.Text = "Informacion del Grupo de Trabajo"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 92)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Descripcion:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.Location = New System.Drawing.Point(76, 89)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(408, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(12, 37)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(41, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(76, 34)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(408, 20)
        Me.txtNombre.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(3, 55)
        Me.GridControl1.MainView = Me.dgvDatos
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(502, 240)
        Me.GridControl1.TabIndex = 11
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvDatos})
        '
        'dgvDatos
        '
        Me.dgvDatos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdArea, Me.colNombre, Me.colDescripcion})
        Me.dgvDatos.GridControl = Me.GridControl1
        Me.dgvDatos.GroupPanelText = "Lista de Areas de Trabajo"
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.OptionsView.ShowAutoFilterRow = True
        '
        'colIdArea
        '
        Me.colIdArea.Caption = "ID. Area"
        Me.colIdArea.FieldName = "idarea"
        Me.colIdArea.MinWidth = 10
        Me.colIdArea.Name = "colIdArea"
        Me.colIdArea.OptionsColumn.AllowEdit = False
        Me.colIdArea.OptionsColumn.ReadOnly = True
        Me.colIdArea.Visible = True
        Me.colIdArea.VisibleIndex = 0
        Me.colIdArea.Width = 92
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowEdit = False
        Me.colNombre.OptionsColumn.ReadOnly = True
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 228
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 2
        Me.colDescripcion.Width = 231
        '
        'AdmMtoGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 461)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.tsMenu)
        Me.Name = "AdmMtoGrupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario Grupos de Trabajo"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        CType(Me.gbxDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbxDatos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNombre As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdArea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
End Class
