﻿Imports System.Data.SqlClient
Public Class frmParmDistritoSub
    Dim cnx As New SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=ProteanERP;Server=AMIGODB\AMIGODB")
    Dim adp As New SqlDataAdapter()
    Dim ds As New DataSet

    Dim parametros As New PropReportes
    Dim zaf, cue, dis, cal, sbc As Integer
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
    Public Sub New(parametros As PropReportes, zaf As Integer, cue As Integer, dis As Integer, sbc As Integer, cal As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.zaf = zaf
        Me.cue = cue
        Me.dis = dis
        Me.sbc = sbc
        Me.cal = cal
    End Sub
    Private Sub frmParmDistritoSub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Tables("select Codigo, PresupuestoID, Descripcion from finanzas..Presupuesto where EmpresaID = 1", "Zafra", cbxZafra, "Descripcion", "PresupuestoID", "PresupuestoID")
            Tables("spCuentasAgricolasSelect", "cuenta", cbxCuenta, "Nombre", "MayorID", "MayorID")
            Tables("spSubCuentaSelect", "SubCuenta", cbxSubCuenta, "Nombre", "SubCuentaID", "SubCuentaID")
            Tables("spDistritoSelect 1", "Distrito", cbxDistrito, "Nombre", "DistritoID", "DistritoID")

        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        cbxZafra.EditValue = zaf
        cbxCuenta.EditValue = cue
        cbxDistrito.EditValue = dis
        cbxCalendario.EditValue = cal
        cbxSubCuenta.EditValue = sbc
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
        If IsNothing(cbxCuenta.EditValue) Then frm.AddErr("Debe seleccionar la cuenta a consultar", 0)
        If IsNothing(cbxDistrito.EditValue) Then frm.AddErr("Debe seleccionar una distrito", 0)
        If IsNothing(cbxSubCuenta.EditValue) Then frm.AddErr("Debe seleccionar una subCuenta", 0)
        If IsNothing(cbxCalendario.EditValue) Then frm.AddErr("Debe seleccionar el mes a consultar", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            prmList.Add(New SqlParameter("@pre", cbxZafra.EditValue.ToString))
            prmList.Add(New SqlParameter("@cue", cbxCuenta.EditValue.ToString))
            prmList.Add(New SqlParameter("@dis", cbxDistrito.EditValue.ToString))
            prmList.Add(New SqlParameter("@sub", cbxSubCuenta.EditValue.ToString))
            prmList.Add(New SqlParameter("@cal", cbxCalendario.EditValue.ToString))

            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmParmDistritoSub(parametros, CInt(cbxZafra.EditValue), CInt(cbxCuenta.EditValue), CInt(cbxDistrito.EditValue), CInt(cbxSubCuenta.EditValue), CInt(cbxCalendario.EditValue)))
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