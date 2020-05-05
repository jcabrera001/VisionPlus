Imports System.Configuration
Imports System.Data.SqlClient
Public Class frmParmreportesGerencia

    ReadOnly parametros As New PropReportes
    Dim emp As String
    Dim mes As Integer
    Private cnx As SqlConnection
    Dim f As New Funciones

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
    Public Sub New(parametros As PropReportes, emp As String, mes As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.emp = emp
        Me.mes = mes
    End Sub
    Private Sub frmParmreportesGerencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnx = New SqlConnection(ConfigurationManager.ConnectionStrings("Finanzas").ToString())

        f.Conexion = cnx
        Try
            f.NewTable("select Codigo, Nombre from Empresa", "Empresa")
            f.NewTable("select ID, Titulo from MesesReportes", "Mes")
            f.SetGridLookUpEdit(cmbEmpresa, f.dsDesarrollo.Tables("Empresa"), "Codigo", "Nombre")
            f.SetGridLookUpEdit(cmbMes, f.dsDesarrollo.Tables("Mes"), "ID", "Titulo")
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        cmbEmpresa.EditValue = emp
        cmbMes.EditValue = mes
    End Sub
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim frm As New frmError
        Dim prmList As New List(Of SqlParameter)

        frm.ClearError()
        If IsNothing(cmbEmpresa.EditValue) Then frm.AddErr("Debe seleccionar La empresa", 0)
        If IsNothing(cmbMes.EditValue) Then frm.AddErr("Debe seleccionar el mes a consultar", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            prmList.Add(New SqlParameter("@emp", cmbEmpresa.EditValue.ToString))
            prmList.Add(New SqlParameter("@mes", cmbMes.EditValue.ToString))


            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmParmreportesGerencia(parametros, cmbEmpresa.EditValue.ToString, CInt(cmbMes.EditValue)))
            frmRpt.Show()
            Me.Close()
        End If
    End Sub
End Class