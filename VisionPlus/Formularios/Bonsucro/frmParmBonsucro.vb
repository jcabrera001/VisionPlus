Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmParmBonsucro


    ReadOnly parametros As New PropReportes
    Dim emp As Integer = 1
    Dim ubi As Integer = 0
    Private ReadOnly ini As Date = Now()
    Private fin As Date = Now()
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
    Public Sub New(parametros As PropReportes, emp As Integer, ini As DateTime, fin As DateTime, ubi As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.emp = emp
        Me.ini = ini
        Me.fin = fin
        Me.ubi = ubi
    End Sub
    Private Sub frmParmBonsucro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnx = New SqlConnection(ConfigurationManager.ConnectionStrings("Nomina").ToString())

        f.Conexion = cnx
        Try
            f.NewTable("spEmpresaSelect", "Empresa")
            f.NewTable("spUbicacionSelect", "Ubicacion")
            f.SetGridLookUpEdit(cmbEmpresa, f.dsDesarrollo.Tables("Empresa"), "IdEmpresa", "Nombre")
            f.SetGridLookUpEdit(cmbUbicacion, f.dsDesarrollo.Tables("Ubicacion"), "IdUbicacion", "Nombre")

        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        cmbEmpresa.EditValue = emp
        dtpInicio.EditValue = ini
        dtpFinal.EditValue = fin
        cmbUbicacion.EditValue = ubi

    End Sub
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim frm As New frmError
        Dim prmList As New List(Of SqlParameter)

        frm.ClearError()
        If IsNothing(cmbEmpresa.EditValue) Then frm.AddErr("Debe seleccionar La empresa", 0)
        If IsNothing(cmbUbicacion.EditValue) Then frm.AddErr("Debe seleccionar una ubicación", 0)
        If IsNothing(dtpFinal.EditValue) Then frm.AddErr("Debe seleccionar la fecha de inicio", 0)
        If IsNothing(dtpInicio.EditValue) Then frm.AddErr("Debe seleccionar el mes a consultar", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            prmList.Add(New SqlParameter("@EMPRESA", cmbEmpresa.EditValue.ToString))
            prmList.Add(New SqlParameter("@FDESDE", dtpInicio.EditValue))
            prmList.Add(New SqlParameter("@FHASTA", dtpFinal.EditValue))
            prmList.Add(New SqlParameter("@UBI", cmbUbicacion.EditValue.ToString))


            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmParmBonsucro(parametros, CInt(cmbEmpresa.EditValue), CDate(dtpInicio.EditValue), CDate(dtpFinal.EditValue), CInt(cmbUbicacion.EditValue)))
            frmRpt.Show()
            Me.Close()
        End If
    End Sub
End Class