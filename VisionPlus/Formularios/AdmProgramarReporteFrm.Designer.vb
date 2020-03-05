<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmProgramarReporteFrm
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
        Me.components = New System.ComponentModel.Container()
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.SchedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.xtraTab = New DevExpress.XtraTab.XtraTabControl()
        Me.xtraTabPagParametros = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.dgvCampos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.cmdMostrarParametro = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbSalir = New System.Windows.Forms.ToolStripButton()
        Me.xtraTabPagCalendarizar = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtraTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtraTab.SuspendLayout()
        Me.xtraTabPagParametros.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        Me.xtraTabPagCalendarizar.SuspendLayout()
        Me.SuspendLayout()
        '
        'SchedulerControl1
        '
        Me.SchedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchedulerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SchedulerControl1.Name = "SchedulerControl1"
        Me.SchedulerControl1.Size = New System.Drawing.Size(766, 372)
        Me.SchedulerControl1.Start = New Date(2014, 10, 3, 0, 0, 0, 0)
        Me.SchedulerControl1.Storage = Me.SchedulerStorage1
        Me.SchedulerControl1.TabIndex = 2
        Me.SchedulerControl1.Text = "SchedulerControl1"
        Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.SchedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
        '
        'SchedulerStorage1
        '
        Me.SchedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
        Me.SchedulerStorage1.Appointments.Mappings.Description = "Description"
        Me.SchedulerStorage1.Appointments.Mappings.End = "EndDate"
        Me.SchedulerStorage1.Appointments.Mappings.Label = "Label"
        Me.SchedulerStorage1.Appointments.Mappings.Location = "Location"
        Me.SchedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
        Me.SchedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
        Me.SchedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID"
        Me.SchedulerStorage1.Appointments.Mappings.Start = "StartDate"
        Me.SchedulerStorage1.Appointments.Mappings.Status = "Status"
        Me.SchedulerStorage1.Appointments.Mappings.Subject = "Subject"
        Me.SchedulerStorage1.Appointments.Mappings.Type = "Type"
        Me.SchedulerStorage1.Resources.Mappings.Caption = "ResourceName"
        Me.SchedulerStorage1.Resources.Mappings.Color = "Color"
        Me.SchedulerStorage1.Resources.Mappings.Id = "ResourceID"
        Me.SchedulerStorage1.Resources.Mappings.Image = "Image"
        Me.SchedulerStorage1.Resources.Mappings.ParentId = "UniqueID"
        '
        'xtraTab
        '
        Me.xtraTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtraTab.Location = New System.Drawing.Point(0, 0)
        Me.xtraTab.Name = "xtraTab"
        Me.xtraTab.SelectedTabPage = Me.xtraTabPagParametros
        Me.xtraTab.Size = New System.Drawing.Size(772, 400)
        Me.xtraTab.TabIndex = 3
        Me.xtraTab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPagCalendarizar, Me.xtraTabPagParametros})
        '
        'xtraTabPagParametros
        '
        Me.xtraTabPagParametros.Controls.Add(Me.GridControl1)
        Me.xtraTabPagParametros.Controls.Add(Me.tsMenu)
        Me.xtraTabPagParametros.Name = "xtraTabPagParametros"
        Me.xtraTabPagParametros.Size = New System.Drawing.Size(766, 372)
        Me.xtraTabPagParametros.Text = "Configurar Parametros"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridControl1.Location = New System.Drawing.Point(3, 55)
        Me.GridControl1.MainView = Me.dgvCampos
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(756, 310)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvCampos})
        '
        'dgvCampos
        '
        Me.dgvCampos.GridControl = Me.GridControl1
        Me.dgvCampos.Name = "dgvCampos"
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdMostrarParametro, Me.ToolStripSeparator2, Me.cmbGuardar, Me.ToolStripSeparator1, Me.cmbSalir})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(766, 52)
        Me.tsMenu.TabIndex = 7
        Me.tsMenu.Text = "ToolStrip1"
        '
        'cmdMostrarParametro
        '
        Me.cmdMostrarParametro.Image = Global.VisionPlus.My.Resources.Resources.table
        Me.cmdMostrarParametro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdMostrarParametro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMostrarParametro.Name = "cmdMostrarParametro"
        Me.cmdMostrarParametro.Size = New System.Drawing.Size(92, 49)
        Me.cmdMostrarParametro.Text = "Obtener Campos"
        Me.cmdMostrarParametro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
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
        'xtraTabPagCalendarizar
        '
        Me.xtraTabPagCalendarizar.Controls.Add(Me.SchedulerControl1)
        Me.xtraTabPagCalendarizar.Name = "xtraTabPagCalendarizar"
        Me.xtraTabPagCalendarizar.Size = New System.Drawing.Size(766, 372)
        Me.xtraTabPagCalendarizar.Text = "Calendarizar Reporte"
        '
        'AdmProgramarReporteFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 400)
        Me.Controls.Add(Me.xtraTab)
        Me.Name = "AdmProgramarReporteFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtraTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtraTab.ResumeLayout(False)
        Me.xtraTabPagParametros.ResumeLayout(False)
        Me.xtraTabPagParametros.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.xtraTabPagCalendarizar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents xtraTab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtraTabPagParametros As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtraTabPagCalendarizar As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdMostrarParametro As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvCampos As DevExpress.XtraGrid.Views.Grid.GridView
End Class
