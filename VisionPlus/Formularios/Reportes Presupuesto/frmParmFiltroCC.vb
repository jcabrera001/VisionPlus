Imports System.Data
Imports System.Data.SqlClient
Public Class frmParmFiltroCC
    Dim cnx As New SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=ProteanERP;Server=AMIGODB\AMIGODB")
    Dim adp As New SqlDataAdapter()
    Dim ds As New DataSet
    'Dim user As String
    Dim parametros As New PropReportes
    Dim zaf, cue, cc, cal As Integer
    Dim use As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(parametros As PropReportes, use As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.use = use

    End Sub
    Public Sub New(parametros As PropReportes, zaf As Integer, cue As Integer, cc As Integer, cal As Integer, use As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.zaf = zaf
        Me.cue = cue
        Me.cal = cal
        Me.cc = cc
        Me.use = use
    End Sub
 

    Private Sub frmParmFiltroCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Tables("select Codigo, PresupuestoID, Descripcion from finanzas..Presupuesto where EmpresaID = 1", "Zafra", cbxZafra, "Descripcion", "PresupuestoID", "PresupuestoID")
            Tables("Finanzas..spPresupuestoSelect " & use, "Zafra", cbxZafra, "Descripcion", "PresupuestoID", "PresupuestoID")
            Tables("select distinct MayorID, codCuenta, nomCuenta from finanzas..vusuario where usuario = '" & use & "' order by codCuenta", "cuenta", cbxCuenta, "nomCuenta", "MayorID", "MayorID")

        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        cbxZafra.EditValue = zaf
        cbxCuenta.EditValue = cue
        cbxCC.EditValue = cc
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
        Dim cmd As SqlCommand

        frm.ClearError()
        If IsNothing(cbxZafra.EditValue) Then frm.AddErr("Debe seleccionar la zafra a visualizar", 0)
        If IsNothing(cbxCuenta.EditValue) Then frm.AddErr("Debe seleccionar la cuenta a consultar", 0)
        If IsNothing(cbxCC.EditValue) Then frm.AddErr("Debe seleccionar un Centro de Costo", 0)
        If IsNothing(cbxCalendario.EditValue) Then frm.AddErr("Debe seleccionar el mes a consultar", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            prmList.Add(New SqlParameter("@pre", cbxZafra.EditValue.ToString))
            prmList.Add(New SqlParameter("@cue", cbxCuenta.EditValue.ToString))
            prmList.Add(New SqlParameter("@cco", cbxCC.EditValue.ToString))
            prmList.Add(New SqlParameter("@cal", cbxCalendario.EditValue.ToString))
            prmList.Add(New SqlParameter("@use", use))

            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmParmFiltroCC(parametros, CInt(cbxZafra.EditValue), CInt(cbxCuenta.EditValue), CInt(cbxCC.EditValue), CInt(cbxCalendario.EditValue), use))

            'Bítacora de Choluteca
            cnx.Open()
            cmd = New SqlCommand("spBitacoraPresupuestoInsert", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@cue", cbxCuenta.EditValue)
            cmd.Parameters.AddWithValue("@cen", cbxCC.EditValue)
            cmd.Parameters.AddWithValue("@cal", cbxCalendario.EditValue)
            cmd.Parameters.AddWithValue("@usu", use)
            cmd.Parameters.AddWithValue("@rep", 355)
            cmd.ExecuteNonQuery()
            cnx.Close()
            'Bítacora de Choluteca

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

    Private Sub cbxCuenta_EditValueChanged(sender As Object, e As EventArgs) Handles cbxCuenta.EditValueChanged
        If Not IsNothing(cbxCuenta.EditValue) Then
            If Not IsNothing(ds.Tables("CentoCosto")) Then
                ds.Tables("CentoCosto").Clear()
            End If
            Tables("spCentroCostoXCuenta '" & use & "', " & cbxCuenta.EditValue.ToString, "CentoCosto", cbxCC, "nomCentroCosto", "CentroCostoCabID", "CentroCostoCabID")
        End If
    End Sub
End Class