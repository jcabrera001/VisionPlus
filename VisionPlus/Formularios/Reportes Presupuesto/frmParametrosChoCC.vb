Imports System.Data
Imports System.Data.SqlClient
Public Class frmParametrosChoCC
    Dim cnx As New SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=ProteanERP;Server=AMIGODB\AMIGODB")
    Dim adp As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim user As String
    Dim parametros As New PropReportes
    Dim cue As String, SubC As String, cat As String
    Dim Mes As Integer

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
    Public Sub New(parametros As PropReportes, user As String, cue As String, Mes As Integer, SubC As String, cat As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        Me.parametros = parametros
        Me.user = user
        Me.cue = cue
        Me.SubC = SubC
        Me.Mes = Mes
        Me.cat = cat
    End Sub
    Private Sub frmParametrosChoCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        cbxCuenta.EditValue = cue
        cbxSubCuenta.EditValue = SubC
        cbxPeriodo.EditValue = Mes
        cbxCategoria.EditValue = cat
    End Sub
    Public Sub LoadData()
        Try
            Tables("spCuentasUsuario '" & user & "'", "Cuenta", cbxCuenta, "Nombre", "Cuenta")
            Tables("spSubCuentasUsuario", "SubCuenta", cbxSubCuenta, "Nombre", "ID")
            Tables("spMesAComparar '30201901'", "Periodo", cbxPeriodo, "EncabezadoCompleto", "PerEmpXCalendarioID", "PerEmpXCalendarioID")
            Tables("select Codigo, Nombre from Finanzas.dbo.Categoria", "Categoria", cbxCategoria, "Nombre", "Codigo", "Codigo")
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
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
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim frm As New frmError
        Dim prmList As New List(Of SqlParameter)
        Dim cmd As SqlCommand

        frm.ClearError()
        If IsNothing(cbxCuenta.EditValue) Then frm.AddErr("Debe seleccionar la cuenta", 0)
        If IsNothing(cbxSubCuenta.EditValue) Then frm.AddErr("Debe seleccionar la SubCuenta", 0)
        If IsNothing(cbxPeriodo.EditValue) Then frm.AddErr("Debe seleccionar el mes a consultar", 0)
        If IsNothing(cbxCategoria.EditValue) Then frm.AddErr("Debe seleccionar la categoria", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            prmList.Add(New SqlParameter("@Cuenta", cbxCuenta.EditValue.ToString))
            prmList.Add(New SqlParameter("@MesID", cbxPeriodo.EditValue.ToString))
            prmList.Add(New SqlParameter("@subC", IIf(cbxSubCuenta.EditValue.ToString = "--TODOS--", "%", cbxSubCuenta.EditValue.ToString)))
            prmList.Add(New SqlParameter("@Cat", cbxCategoria.EditValue.ToString))

            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmParametrosChoCC(parametros, user, cbxCuenta.EditValue.ToString(), CInt(cbxPeriodo.EditValue), cbxSubCuenta.EditValue.ToString(), cbxCategoria.EditValue.ToString()))

            cnx.Open()
            cmd = New SqlCommand("BitacoraPresupuestoInsert '" & cbxCuenta.EditValue.ToString & "', '0', '" & cbxSubCuenta.EditValue.ToString & "', '" & cbxPeriodo.Text & "' , '" & user & "', 356", cnx)
            cmd.ExecuteNonQuery()
            cnx.Close()

            frmRpt.Show()
            Me.Close()
        End If

    End Sub
End Class