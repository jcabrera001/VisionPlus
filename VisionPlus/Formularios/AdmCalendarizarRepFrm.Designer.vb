<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmCalendarizarRepFrm
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
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.cmbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbxProgramar = New DevExpress.XtraEditors.GroupControl()
        Me.SchedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xtabUnaVez = New DevExpress.XtraTab.XtraTabPage()
        Me.weekDayLista = New DevExpress.XtraScheduler.UI.WeekDaysCheckEdit()
        Me.lblDiasSemana = New DevExpress.XtraEditors.LabelControl()
        Me.txtRepeticion = New DevExpress.XtraEditors.SpinEdit()
        Me.lblRepetir = New DevExpress.XtraEditors.LabelControl()
        Me.txtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtHora = New DevExpress.XtraEditors.TimeEdit()
        Me.lblCambio = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.xtabParametros = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.dgvParametros = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colParametro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblFrecuencia = New DevExpress.XtraEditors.LabelControl()
        Me.rgbFrecuencia = New DevExpress.XtraEditors.RadioGroup()
        Me.tsMenu.SuspendLayout()
        CType(Me.gbxProgramar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxProgramar.SuspendLayout()
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtabUnaVez.SuspendLayout()
        CType(Me.weekDayLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRepeticion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtabParametros.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgbFrecuencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbGuardar, Me.ToolStripSeparator1, Me.cmbSalir})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(680, 52)
        Me.tsMenu.TabIndex = 6
        Me.tsMenu.Text = "ToolStrip1"
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
        'gbxProgramar
        '
        Me.gbxProgramar.Controls.Add(Me.SchedulerControl1)
        Me.gbxProgramar.Controls.Add(Me.XtraTabControl1)
        Me.gbxProgramar.Controls.Add(Me.lblFrecuencia)
        Me.gbxProgramar.Controls.Add(Me.rgbFrecuencia)
        Me.gbxProgramar.Location = New System.Drawing.Point(6, 55)
        Me.gbxProgramar.Name = "gbxProgramar"
        Me.gbxProgramar.Size = New System.Drawing.Size(671, 415)
        Me.gbxProgramar.TabIndex = 7
        Me.gbxProgramar.Text = "Programador de Tareas"
        '
        'SchedulerControl1
        '
        Me.SchedulerControl1.Location = New System.Drawing.Point(115, 236)
        Me.SchedulerControl1.Name = "SchedulerControl1"
        Me.SchedulerControl1.Size = New System.Drawing.Size(546, 169)
        Me.SchedulerControl1.Start = New Date(2014, 10, 3, 0, 0, 0, 0)
        Me.SchedulerControl1.TabIndex = 3
        Me.SchedulerControl1.Text = "SchedulerControl1"
        Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.SchedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(114, 24)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xtabUnaVez
        Me.XtraTabControl1.Size = New System.Drawing.Size(552, 206)
        Me.XtraTabControl1.TabIndex = 7
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.xtabParametros, Me.xtabUnaVez})
        '
        'xtabUnaVez
        '
        Me.xtabUnaVez.Controls.Add(Me.weekDayLista)
        Me.xtabUnaVez.Controls.Add(Me.lblDiasSemana)
        Me.xtabUnaVez.Controls.Add(Me.txtRepeticion)
        Me.xtabUnaVez.Controls.Add(Me.lblRepetir)
        Me.xtabUnaVez.Controls.Add(Me.txtFecha)
        Me.xtabUnaVez.Controls.Add(Me.txtHora)
        Me.xtabUnaVez.Controls.Add(Me.lblCambio)
        Me.xtabUnaVez.Name = "xtabUnaVez"
        Me.xtabUnaVez.Size = New System.Drawing.Size(546, 178)
        Me.xtabUnaVez.Text = "Frecuencia"
        '
        'weekDayLista
        '
        Me.weekDayLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.weekDayLista.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.weekDayLista.Appearance.Options.UseBackColor = True
        Me.weekDayLista.Location = New System.Drawing.Point(203, 68)
        Me.weekDayLista.Name = "weekDayLista"
        Me.weekDayLista.Size = New System.Drawing.Size(234, 83)
        Me.weekDayLista.TabIndex = 15
        '
        'lblDiasSemana
        '
        Me.lblDiasSemana.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDiasSemana.Location = New System.Drawing.Point(146, 77)
        Me.lblDiasSemana.Name = "lblDiasSemana"
        Me.lblDiasSemana.Size = New System.Drawing.Size(19, 13)
        Me.lblDiasSemana.TabIndex = 14
        Me.lblDiasSemana.Text = "dias"
        '
        'txtRepeticion
        '
        Me.txtRepeticion.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRepeticion.Location = New System.Drawing.Point(91, 74)
        Me.txtRepeticion.Name = "txtRepeticion"
        Me.txtRepeticion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRepeticion.Properties.MaxLength = 2
        Me.txtRepeticion.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
        Me.txtRepeticion.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtRepeticion.Properties.ShowNullValuePromptWhenFocused = True
        Me.txtRepeticion.Size = New System.Drawing.Size(49, 20)
        Me.txtRepeticion.TabIndex = 13
        '
        'lblRepetir
        '
        Me.lblRepetir.Location = New System.Drawing.Point(20, 77)
        Me.lblRepetir.Name = "lblRepetir"
        Me.lblRepetir.Size = New System.Drawing.Size(65, 13)
        Me.lblRepetir.TabIndex = 12
        Me.lblRepetir.Text = "Repetir cada:"
        '
        'txtFecha
        '
        Me.txtFecha.EditValue = Nothing
        Me.txtFecha.Location = New System.Drawing.Point(66, 33)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Properties.Mask.EditMask = "D"
        Me.txtFecha.Size = New System.Drawing.Size(227, 20)
        Me.txtFecha.TabIndex = 6
        '
        'txtHora
        '
        Me.txtHora.EditValue = New Date(2014, 9, 9, 0, 0, 0, 0)
        Me.txtHora.Location = New System.Drawing.Point(337, 33)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHora.Properties.Mask.EditMask = "t"
        Me.txtHora.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.txtHora.Size = New System.Drawing.Size(100, 20)
        Me.txtHora.TabIndex = 5
        '
        'lblCambio
        '
        Me.lblCambio.Location = New System.Drawing.Point(20, 36)
        Me.lblCambio.Name = "lblCambio"
        Me.lblCambio.Size = New System.Drawing.Size(23, 13)
        Me.lblCambio.TabIndex = 4
        Me.lblCambio.Text = "A las"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(546, 178)
        Me.XtraTabPage1.Text = "Programacion"
        '
        'xtabParametros
        '
        Me.xtabParametros.Controls.Add(Me.GridControl1)
        Me.xtabParametros.Name = "xtabParametros"
        Me.xtabParametros.Size = New System.Drawing.Size(546, 178)
        Me.xtabParametros.Text = "Configurar Parametros"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.dgvParametros
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(546, 175)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvParametros})
        '
        'dgvParametros
        '
        Me.dgvParametros.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colParametro, Me.colValor})
        Me.dgvParametros.GridControl = Me.GridControl1
        Me.dgvParametros.Name = "dgvParametros"
        Me.dgvParametros.OptionsView.ShowGroupPanel = False
        '
        'colParametro
        '
        Me.colParametro.Caption = "Parametro"
        Me.colParametro.Name = "colParametro"
        Me.colParametro.Visible = True
        Me.colParametro.VisibleIndex = 0
        '
        'colValor
        '
        Me.colValor.Caption = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 1
        '
        'lblFrecuencia
        '
        Me.lblFrecuencia.Location = New System.Drawing.Point(10, 32)
        Me.lblFrecuencia.Name = "lblFrecuencia"
        Me.lblFrecuencia.Size = New System.Drawing.Size(56, 13)
        Me.lblFrecuencia.TabIndex = 4
        Me.lblFrecuencia.Text = "Frecuencia:"
        '
        'rgbFrecuencia
        '
        Me.rgbFrecuencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rgbFrecuencia.Location = New System.Drawing.Point(10, 51)
        Me.rgbFrecuencia.Name = "rgbFrecuencia"
        Me.rgbFrecuencia.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Ninguno"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Una vez"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Diariamente"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Semanal")})
        Me.rgbFrecuencia.Size = New System.Drawing.Size(98, 354)
        Me.rgbFrecuencia.TabIndex = 5
        '
        'AdmCalendarizarRepFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 473)
        Me.Controls.Add(Me.gbxProgramar)
        Me.Controls.Add(Me.tsMenu)
        Me.Name = "AdmCalendarizarRepFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendarizar Reporte"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        CType(Me.gbxProgramar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxProgramar.ResumeLayout(False)
        Me.gbxProgramar.PerformLayout()
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtabUnaVez.ResumeLayout(False)
        Me.xtabUnaVez.PerformLayout()
        CType(Me.weekDayLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRepeticion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtabParametros.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgbFrecuencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbxProgramar As DevExpress.XtraEditors.GroupControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtabUnaVez As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents weekDayLista As DevExpress.XtraScheduler.UI.WeekDaysCheckEdit
    Friend WithEvents lblDiasSemana As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRepeticion As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblRepetir As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtHora As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents lblCambio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents xtabParametros As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvParametros As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colParametro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblFrecuencia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgbFrecuencia As DevExpress.XtraEditors.RadioGroup
End Class
