Imports System.Data
Imports System.Data.SqlClient
Public Class frmParmFiltroGenerales
    Dim cnx As New SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=ProteanERP;Server=AMIGODB\AMIGODB")
    Dim adp As New SqlDataAdapter()
    Dim ds As New DataSet
    'Dim user As String
    Dim parametros As New PropReportes
    Dim zaf, cal As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(parametros As PropReportes)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
    End Sub
    Public Sub New(parametros As PropReportes, zaf As Integer, cal As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.zaf = zaf
        Me.cal = cal

    End Sub
    Private Sub frmParmFiltroGenerales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Tables("select Codigo, PresupuestoID, Descripcion from finanzas..Presupuesto where EmpresaID = 1", "Zafra", cbxZafra, "Descripcion", "PresupuestoID", "PresupuestoID")

        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        cbxZafra.EditValue = zaf
        cbxCalendario.EditValue = cal
    End Sub
    Private Sub Tables(sql As String, name As String, cbx As DevExpress.XtraEditors.LookUpEdit, Display As String, Value As String, hide As String)
        adp = New SqlDataAdapter(sql, cnx)
        adp.Fill(ds, name)

        cbx.Properties.DataSource = ds.Tables(name)
        cbx.Properties.ValueMember = Value
        cbx.Properties.DisplayMember = Display
        cbx.Properties.PopulateColumns()
        cbx.Properties.Columns(hide).Visible = False
        'cbx.ItemIndex = 0

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim frm As New frmError
        Dim prmList As New List(Of SqlParameter)

        frm.ClearError()
        If IsNothing(cbxZafra.EditValue) Then frm.AddErr("Debe seleccionar la zafra a visualizar", 0)
        If IsNothing(cbxCalendario.EditValue) Then frm.AddErr("Debe seleccionar el mes a consultar", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            prmList.Add(New SqlParameter("@pre", cbxZafra.EditValue.ToString))
            prmList.Add(New SqlParameter("@cal", cbxCalendario.EditValue.ToString))


            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmParmFiltroGenerales(parametros, CInt(cbxZafra.EditValue), CInt(cbxCalendario.EditValue)))
            frmRpt.Show()
            Me.Close()
        End If
    End Sub
    Private Sub cbxZafra_EditValueChanged(sender As Object, e As EventArgs) Handles cbxZafra.EditValueChanged
        If Not IsNothing(cbxZafra.EditValue) Then
            If Not IsNothing(ds.Tables("calendario")) Then
                ds.Tables("calendario").Clear()
            End If
            Tables("select CalendarioID, Titulo from Finanzas..Calendario where PresupuestoID  = " & cbxZafra.EditValue.ToString, "calendario", cbxCalendario, "Titulo", "CalendarioID", "CalendarioID")
        End If
    End Sub
   

End Class