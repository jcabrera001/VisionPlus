﻿Imports System.Configuration
Imports System.Data.SqlClient
Public Class frmHorasEmpleado

    ReadOnly parametros As New PropReportes
    Dim emp As Integer = 1
    Dim area As String
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
    Public Sub New(parametros As PropReportes, emp As Integer, ini As DateTime, fin As DateTime, area As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.emp = emp
        Me.ini = ini
        Me.fin = fin
        Me.area = area
    End Sub
    Private Sub frmHorasEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cnx = New SqlConnection(ConfigurationManager.ConnectionStrings("Nomina").ToString())

        f.Conexion = cnx
        Try
            f.NewTable("spEmpresaSelect", "Empresa")
            f.NewTable("spAreaParametroSelect", "Area")
            f.SetGridLookUpEdit(cmbEmpresa, f.dsDesarrollo.Tables("Empresa"), "IdEmpresa", "Nombre")
            f.SetGridLookUpEdit(cmbArea, f.dsDesarrollo.Tables("Area"), "Area", "Area")
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        cmbEmpresa.EditValue = emp
        dtpInicio.EditValue = ini
        dtpFinal.EditValue = fin
        cmbArea.EditValue = area

    End Sub
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim frm As New frmError
        Dim prmList As New List(Of SqlParameter)

        frm.ClearError()
        If IsNothing(cmbEmpresa.EditValue) Then frm.AddErr("Debe seleccionar La empresa", 0)
        If IsNothing(cmbArea.EditValue) Then frm.AddErr("Debe seleccionar el área a consultar", 0)
        If IsNothing(dtpFinal.EditValue) Then frm.AddErr("Debe seleccionar la fecha de inicio", 0)
        If IsNothing(dtpInicio.EditValue) Then frm.AddErr("Debe seleccionar el mes a consultar", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            prmList.Add(New SqlParameter("@EMPRESA", cmbEmpresa.EditValue.ToString))
            prmList.Add(New SqlParameter("@FDESDE", dtpInicio.EditValue))
            prmList.Add(New SqlParameter("@FHASTA", dtpFinal.EditValue))
            prmList.Add(New SqlParameter("@AREA", cmbArea.EditValue.ToString))


            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmHorasEmpleado(parametros, CInt(cmbEmpresa.EditValue), CDate(dtpInicio.EditValue), CDate(dtpFinal.EditValue), cmbArea.EditValue.ToString()))
            frmRpt.Show()
            Me.Close()
        End If
    End Sub
End Class