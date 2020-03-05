Imports System.Data
Imports System.Data.SqlClient
Public Class frmParametrosCho
    Dim cnx As New SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=ProteanERP;Server=AMIGODB\AMIGODB")
    Dim adp As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim user As String
    Dim parametros As New PropReportes
    Dim cue As String, mes As Integer, cc As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(parametros As PropReportes, user As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.user = user
    End Sub
    Public Sub New(parametros As PropReportes, user As String, cue As String, mes As Integer, cc As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.user = user
        Me.cue = cue
        Me.mes = mes
        Me.cc = cc
    End Sub
    Private Sub frmParametrosCho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Tables("spCuentasUsuario '" & user & "'", "Cuenta", cbxCuenta, "Nombre", "Cuenta")
            'Tables("select * from Finanzas.dbo.getCentroCosto('" & user & "','" & IIf(IsNothing(cbxCuenta.EditValue), "*", cbxCuenta.EditValue.ToString).ToString & "')", "cc", cbxCC, "Nombre", "CentroCosto", "Cuenta")
            Tables("spMesAComparar '30201901'", "Periodo", cbxPeriodo, "EncabezadoCompleto", "PerEmpXCalendarioID", "PerEmpXCalendarioID")

        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        cbxCuenta.EditValue = cue
        cbxPeriodo.EditValue = mes
        cbxCC.EditValue = cc
    End Sub
    Private Sub Tables(sql As String, name As String, cbx As DevExpress.XtraEditors.LookUpEdit, Display As String, Value As String, hide As String)
        adp = New SqlDataAdapter(sql, cnx)
        adp.Fill(ds, name)

        cbx.Properties.DataSource = ds.Tables(name)
        cbx.Properties.ValueMember = Value
        cbx.Properties.DisplayMember = Display
        cbx.Properties.PopulateColumns()
        cbx.Properties.Columns(hide).Visible = False

    End Sub
    Private Sub Tables(sql As String, name As String, cbx As DevExpress.XtraEditors.LookUpEdit, Display As String, Value As String)
        adp = New SqlDataAdapter(sql, cnx)
        adp.Fill(ds, name)

        cbx.Properties.DataSource = ds.Tables(name)
        cbx.Properties.ValueMember = Value
        cbx.Properties.DisplayMember = Display
        cbx.Properties.PopulateColumns()

    End Sub
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cbxCuenta_EditValueChanged(sender As Object, e As EventArgs) Handles cbxCuenta.EditValueChanged
        'ds.Tables("cc").DefaultView.RowFilter = "Cuenta = '" & cbxCuenta.EditValue.ToString & "'"
        If Not IsNothing(cbxCuenta.EditValue) Then
            If Not IsNothing(ds.Tables("cc")) Then
                ds.Tables("cc").Clear()
            End If
            Tables("select * from Finanzas.dbo.getCentroCosto('" & user & "','" & IIf(IsNothing(cbxCuenta.EditValue), "*", cbxCuenta.EditValue.ToString).ToString & "')", "cc", cbxCC, "Nombre", "CentroCosto", "Cuenta")
        End If
    End Sub
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim frm As New frmError
        Dim prmList As New List(Of SqlParameter)
        Dim cmd As SqlCommand

      
        frm.ClearError()
        If IsNothing(cbxCuenta.EditValue) Then frm.AddErr("Debe seleccionar la cuenta", 0)
        If IsNothing(cbxCC.EditValue) Then frm.AddErr("Debe seleccionar el Centro Costo", 0)
        If IsNothing(cbxPeriodo.EditValue) Then frm.AddErr("Debe seleccionar el mes a consultar", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            prmList.Add(New SqlParameter("@Cuenta", cbxCuenta.EditValue.ToString))
            prmList.Add(New SqlParameter("@MesID", cbxPeriodo.EditValue.ToString))
            prmList.Add(New SqlParameter("@CC", IIf(cbxCC.EditValue.ToString = "--TODOS--", "%", cbxCC.EditValue.ToString)))

            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmParametrosCho(parametros, user, cbxCuenta.EditValue.ToString, CInt(cbxPeriodo.EditValue), cbxCC.EditValue.ToString))

            cnx.Open()
            cmd = New SqlCommand("BitacoraPresupuestoInsert '" & cbxCuenta.EditValue.ToString & "', '" & cbxCC.EditValue.ToString & "', '0', '" & cbxPeriodo.Text & "' , '" & user & "', 355", cnx)
            cmd.ExecuteNonQuery()
            cnx.Close()

            frmRpt.Show()
            Me.Close()
        End If

    End Sub
End Class