Imports System.Configuration
Imports System.Data.SqlClient
Public Class frmParmAgrupacionSubCuentas
    Dim cnx As SqlConnection

    Dim parametros As New PropReportes
    Dim zaf As Integer = 1
    Dim mes, tipo As Integer
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
    Public Sub New(parametros As PropReportes, zaf As Integer, mes As Integer, tipo As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.zaf = zaf
        Me.mes = mes
        Me.tipo = tipo
    End Sub
    Private Sub frmParmAgrupacionSubCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnx = New SqlConnection(ConfigurationManager.ConnectionStrings("Finanzas").ToString())
        f.Conexion = cnx
        Try
            f.NewTable("select Codigo, PresupuestoID, Descripcion from finanzas..Presupuesto where EmpresaID = 1", "Zafra")
            f.NewTable("select CategoriaSubCuentaID, Nombre from CategoriaSubCuenta", "Tipo")
            f.NewTable("select PresupuestoID, CalendarioID, Titulo from Calendario", "calendario")
            f.SetGridLookUpEdit(cmbPresu, f.dsDesarrollo.Tables("Zafra"), "PresupuestoID", "Descripcion", "PresupuestoID")
            f.SetGridLookUpEdit(cmbTipo, f.dsDesarrollo.Tables("Tipo"), "CategoriaSubCuentaID", "Nombre", "CategoriaSubCuentaID")

        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        cmbPresu.EditValue = zaf
        cmbMes.EditValue = mes
        cmbTipo.EditValue = tipo
    End Sub

    Private Sub cmbPresu_EditValueChanged(sender As Object, e As EventArgs) Handles cmbPresu.EditValueChanged
        If Not IsNothing(cmbPresu.EditValue) Then
            If Not IsNothing(f.dsDesarrollo.Tables("calendario")) Then
                f.dsDesarrollo.Tables("calendario").Dispose()
            End If
            f.dsDesarrollo.Tables("calendario").DefaultView.RowFilter = "PresupuestoID = " & cmbPresu.EditValue.ToString
            f.SetGridLookUpEdit(cmbMes, f.dsDesarrollo.Tables("calendario"), "CalendarioID", "Titulo", "PresupuestoID,CalendarioID")

        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim frm As New frmError
        Dim prmList As New List(Of SqlParameter)

        frm.ClearError()
        If IsNothing(cmbPresu.EditValue) Then frm.AddErr("Debe seleccionar un Presupuesto", 0)
        If IsNothing(cmbMes.EditValue) Then frm.AddErr("Debe seleccionar el mes a consultar", 0)
        If IsNothing(cmbTipo.EditValue) Then frm.AddErr("Debe seleccionar el Tipo de Reporte", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            prmList.Add(New SqlParameter("@pre", cmbPresu.EditValue.ToString))
            prmList.Add(New SqlParameter("@cal", cmbMes.EditValue.ToString))
            prmList.Add(New SqlParameter("@tip", cmbTipo.EditValue.ToString))


            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmParmAgrupacionSubCuentas(parametros, CInt(cmbPresu.EditValue), CInt(cmbMes.EditValue), CInt(cmbTipo.EditValue)))
            frmRpt.Show()
            Me.Close()
        End If
    End Sub
End Class