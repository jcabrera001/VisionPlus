<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GridControlPrm = New DevExpress.XtraGrid.GridControl()
        Me.dgvParametros = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSecuencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParametro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoDato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaximo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControlPrm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControlPrm
        '
        Me.GridControlPrm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControlPrm.Location = New System.Drawing.Point(0, 0)
        Me.GridControlPrm.MainView = Me.dgvParametros
        Me.GridControlPrm.Name = "GridControlPrm"
        Me.GridControlPrm.Size = New System.Drawing.Size(555, 273)
        Me.GridControlPrm.TabIndex = 2
        Me.GridControlPrm.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvParametros})
        Me.GridControlPrm.Visible = False
        '
        'dgvParametros
        '
        Me.dgvParametros.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSecuencia, Me.colParametro, Me.colTipoDato, Me.colMaximo, Me.colValor})
        Me.dgvParametros.GridControl = Me.GridControlPrm
        Me.dgvParametros.GroupPanelText = "Ingrese los datos respectivo para cada filtro del reporte..."
        Me.dgvParametros.Name = "dgvParametros"
        Me.dgvParametros.OptionsCustomization.AllowGroup = False
        '
        'colSecuencia
        '
        Me.colSecuencia.Caption = "Secuencia"
        Me.colSecuencia.FieldName = "Secuencia"
        Me.colSecuencia.Name = "colSecuencia"
        Me.colSecuencia.OptionsColumn.AllowEdit = False
        Me.colSecuencia.OptionsColumn.AllowMove = False
        Me.colSecuencia.OptionsColumn.FixedWidth = True
        Me.colSecuencia.OptionsColumn.ReadOnly = True
        Me.colSecuencia.OptionsFilter.AllowAutoFilter = False
        Me.colSecuencia.OptionsFilter.AllowFilter = False
        Me.colSecuencia.Visible = True
        Me.colSecuencia.VisibleIndex = 0
        '
        'colParametro
        '
        Me.colParametro.Caption = "Parametro"
        Me.colParametro.FieldName = "Parametro"
        Me.colParametro.Name = "colParametro"
        Me.colParametro.OptionsColumn.AllowEdit = False
        Me.colParametro.OptionsColumn.AllowMove = False
        Me.colParametro.OptionsColumn.FixedWidth = True
        Me.colParametro.OptionsColumn.ReadOnly = True
        Me.colParametro.OptionsFilter.AllowAutoFilter = False
        Me.colParametro.OptionsFilter.AllowFilter = False
        Me.colParametro.Visible = True
        Me.colParametro.VisibleIndex = 1
        '
        'colTipoDato
        '
        Me.colTipoDato.Caption = "Tipo Dato"
        Me.colTipoDato.FieldName = "TipoDato"
        Me.colTipoDato.Name = "colTipoDato"
        Me.colTipoDato.OptionsColumn.AllowEdit = False
        Me.colTipoDato.OptionsColumn.AllowMove = False
        Me.colTipoDato.OptionsColumn.FixedWidth = True
        Me.colTipoDato.OptionsColumn.ReadOnly = True
        Me.colTipoDato.OptionsFilter.AllowAutoFilter = False
        Me.colTipoDato.OptionsFilter.AllowFilter = False
        Me.colTipoDato.Visible = True
        Me.colTipoDato.VisibleIndex = 2
        '
        'colMaximo
        '
        Me.colMaximo.Caption = "Maximo"
        Me.colMaximo.FieldName = "Maximo"
        Me.colMaximo.Name = "colMaximo"
        Me.colMaximo.OptionsColumn.AllowEdit = False
        Me.colMaximo.OptionsColumn.AllowMove = False
        Me.colMaximo.OptionsColumn.FixedWidth = True
        Me.colMaximo.OptionsColumn.ReadOnly = True
        Me.colMaximo.OptionsFilter.AllowAutoFilter = False
        Me.colMaximo.OptionsFilter.AllowFilter = False
        Me.colMaximo.Visible = True
        Me.colMaximo.VisibleIndex = 3
        '
        'colValor
        '
        Me.colValor.Caption = "Valor"
        Me.colValor.FieldName = "colValor"
        Me.colValor.MaxWidth = 200
        Me.colValor.MinWidth = 10
        Me.colValor.Name = "colValor"
        Me.colValor.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 273)
        Me.Controls.Add(Me.GridControlPrm)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GridControlPrm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvParametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControlPrm As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvParametros As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSecuencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParametro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoDato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaximo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
End Class
