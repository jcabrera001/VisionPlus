<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmVisorRepFrm
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
        Me.gcReportes = New DevExpress.XtraGrid.GridControl()
        Me.dgvReportes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBDUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBDPasswd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colServidor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPerfil = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSolicitar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdReporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.cmbVerRep = New System.Windows.Forms.ToolStripButton()
        Me.cmbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbProgramarRep = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbxUsuarios = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lblSitios = New DevExpress.XtraEditors.LabelControl()
        Me.cbxSitios = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbxUsuarios = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblID = New DevExpress.XtraEditors.LabelControl()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.VisionPlus.WaitForm1), True, True)
        CType(Me.gcReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        CType(Me.gbxUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxUsuarios.SuspendLayout()
        CType(Me.cbxSitios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxUsuarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcReportes
        '
        Me.gcReportes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gcReportes.Location = New System.Drawing.Point(0, 116)
        Me.gcReportes.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcReportes.LookAndFeel.UseWindowsXPTheme = True
        Me.gcReportes.MainView = Me.dgvReportes
        Me.gcReportes.Name = "gcReportes"
        Me.gcReportes.Size = New System.Drawing.Size(672, 361)
        Me.gcReportes.TabIndex = 0
        Me.gcReportes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvReportes})
        '
        'dgvReportes
        '
        Me.dgvReportes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.dgvReportes.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.dgvReportes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.dgvReportes.Appearance.GroupPanel.Options.UseForeColor = True
        Me.dgvReportes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombre, Me.colDescripcion, Me.colReporte, Me.colBD, Me.colBDUsuario, Me.colBDPasswd, Me.colServidor, Me.colPerfil, Me.colNombre1, Me.colNombre2, Me.colSolicitar, Me.colIdReporte})
        Me.dgvReportes.GridControl = Me.gcReportes
        Me.dgvReportes.GroupPanelText = "Reportes Disponibles"
        Me.dgvReportes.Name = "dgvReportes"
        Me.dgvReportes.OptionsCustomization.AllowGroup = False
        Me.dgvReportes.OptionsDetail.EnableMasterViewMode = False
        Me.dgvReportes.OptionsView.ShowAutoFilterRow = True
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowEdit = False
        Me.colNombre.OptionsColumn.ReadOnly = True
        Me.colNombre.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        Me.colNombre.Width = 183
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 235
        '
        'colReporte
        '
        Me.colReporte.Caption = "Reporte"
        Me.colReporte.FieldName = "Reporte"
        Me.colReporte.Name = "colReporte"
        Me.colReporte.OptionsColumn.AllowEdit = False
        Me.colReporte.OptionsColumn.ReadOnly = True
        Me.colReporte.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colReporte.Visible = True
        Me.colReporte.VisibleIndex = 2
        Me.colReporte.Width = 236
        '
        'colBD
        '
        Me.colBD.Caption = "Base Datos"
        Me.colBD.FieldName = "basedatos"
        Me.colBD.Name = "colBD"
        '
        'colBDUsuario
        '
        Me.colBDUsuario.Caption = "Usuario"
        Me.colBDUsuario.FieldName = "usuario"
        Me.colBDUsuario.Name = "colBDUsuario"
        '
        'colBDPasswd
        '
        Me.colBDPasswd.Caption = "Password"
        Me.colBDPasswd.FieldName = "passwd"
        Me.colBDPasswd.Name = "colBDPasswd"
        '
        'colServidor
        '
        Me.colServidor.Caption = "Servidor"
        Me.colServidor.FieldName = "servidor"
        Me.colServidor.Name = "colServidor"
        '
        'colPerfil
        '
        Me.colPerfil.Caption = "Perfil"
        Me.colPerfil.FieldName = "perfil"
        Me.colPerfil.Name = "colPerfil"
        '
        'colNombre1
        '
        Me.colNombre1.Caption = "Nombre1"
        Me.colNombre1.FieldName = "nombre1"
        Me.colNombre1.Name = "colNombre1"
        '
        'colNombre2
        '
        Me.colNombre2.Caption = "Nombre2"
        Me.colNombre2.FieldName = "nombre2"
        Me.colNombre2.Name = "colNombre2"
        '
        'colSolicitar
        '
        Me.colSolicitar.Caption = "Solicitar"
        Me.colSolicitar.FieldName = "solicitar"
        Me.colSolicitar.Name = "colSolicitar"
        '
        'colIdReporte
        '
        Me.colIdReporte.Caption = "IDReporte"
        Me.colIdReporte.FieldName = "idreporte"
        Me.colIdReporte.Name = "colIdReporte"
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbVerRep, Me.cmbRefrescar, Me.ToolStripSeparator2, Me.cmbProgramarRep, Me.ToolStripSeparator1, Me.cmbSalir})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(672, 54)
        Me.tsMenu.TabIndex = 1
        Me.tsMenu.Text = "ToolStrip1"
        '
        'cmbVerRep
        '
        Me.cmbVerRep.Image = Global.VisionPlus.My.Resources.Resources.table_gear
        Me.cmbVerRep.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbVerRep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbVerRep.Name = "cmbVerRep"
        Me.cmbVerRep.Size = New System.Drawing.Size(96, 51)
        Me.cmbVerRep.Text = "Generar Reporte"
        Me.cmbVerRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmbRefrescar
        '
        Me.cmbRefrescar.Image = Global.VisionPlus.My.Resources.Resources.arrow_refresh_small
        Me.cmbRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbRefrescar.Name = "cmbRefrescar"
        Me.cmbRefrescar.Size = New System.Drawing.Size(59, 51)
        Me.cmbRefrescar.Text = "Refrescar"
        Me.cmbRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 54)
        Me.ToolStripSeparator2.Visible = False
        '
        'cmbProgramarRep
        '
        Me.cmbProgramarRep.Enabled = False
        Me.cmbProgramarRep.Image = Global.VisionPlus.My.Resources.Resources.calendar
        Me.cmbProgramarRep.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbProgramarRep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbProgramarRep.Name = "cmbProgramarRep"
        Me.cmbProgramarRep.Size = New System.Drawing.Size(120, 51)
        Me.cmbProgramarRep.Text = "Calendarizar Reporte"
        Me.cmbProgramarRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmbProgramarRep.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'cmbSalir
        '
        Me.cmbSalir.Image = Global.VisionPlus.My.Resources.Resources.door_in
        Me.cmbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbSalir.Name = "cmbSalir"
        Me.cmbSalir.Size = New System.Drawing.Size(36, 51)
        Me.cmbSalir.Text = "Salir"
        Me.cmbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'gbxUsuarios
        '
        Me.gbxUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxUsuarios.Controls.Add(Me.SimpleButton1)
        Me.gbxUsuarios.Controls.Add(Me.lblSitios)
        Me.gbxUsuarios.Controls.Add(Me.cbxSitios)
        Me.gbxUsuarios.Controls.Add(Me.cbxUsuarios)
        Me.gbxUsuarios.Controls.Add(Me.lblID)
        Me.gbxUsuarios.Location = New System.Drawing.Point(0, 52)
        Me.gbxUsuarios.Name = "gbxUsuarios"
        Me.gbxUsuarios.Size = New System.Drawing.Size(672, 59)
        Me.gbxUsuarios.TabIndex = 2
        Me.gbxUsuarios.Text = "Lista de Usuarios"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton1.Location = New System.Drawing.Point(590, 25)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "Cargar"
        '
        'lblSitios
        '
        Me.lblSitios.Location = New System.Drawing.Point(357, 30)
        Me.lblSitios.Name = "lblSitios"
        Me.lblSitios.Size = New System.Drawing.Size(29, 13)
        Me.lblSitios.TabIndex = 3
        Me.lblSitios.Text = "Sitios:"
        '
        'cbxSitios
        '
        Me.cbxSitios.Enabled = False
        Me.cbxSitios.Location = New System.Drawing.Point(392, 27)
        Me.cbxSitios.Name = "cbxSitios"
        Me.cbxSitios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxSitios.Properties.NullText = "Seleccione un sitio..."
        Me.cbxSitios.Size = New System.Drawing.Size(172, 20)
        Me.cbxSitios.TabIndex = 2
        '
        'cbxUsuarios
        '
        Me.cbxUsuarios.Enabled = False
        Me.cbxUsuarios.Location = New System.Drawing.Point(50, 28)
        Me.cbxUsuarios.Name = "cbxUsuarios"
        Me.cbxUsuarios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxUsuarios.Properties.NullText = "Seleccione un perfil..."
        Me.cbxUsuarios.Size = New System.Drawing.Size(172, 20)
        Me.cbxUsuarios.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.Location = New System.Drawing.Point(13, 30)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(28, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Perfil:"
        '
        'AdmVisorRepFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 485)
        Me.Controls.Add(Me.gbxUsuarios)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.gcReportes)
        Me.Name = "AdmVisorRepFrm"
        Me.Text = "Visor de Reportes"
        CType(Me.gcReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        CType(Me.gbxUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxUsuarios.ResumeLayout(False)
        Me.gbxUsuarios.PerformLayout()
        CType(Me.cbxSitios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxUsuarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gcReportes As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvReportes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbVerRep As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbxUsuarios As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxUsuarios As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colBD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBDUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBDPasswd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServidor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPerfil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSolicitar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblSitios As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxSitios As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colIdReporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbProgramarRep As System.Windows.Forms.ToolStripButton
    Private WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
