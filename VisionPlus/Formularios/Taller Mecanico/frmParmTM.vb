Imports System.Configuration
Imports System.Data.SqlClient
Public Class frmParmTM
    Dim parametros As New PropReportes
    Dim cnx As SqlConnection

    Dim des As DateTime = Now()
    Dim has As DateTime = Now()
    Dim est, ent, emp, cen As String
    Dim f As New Funciones

    Public Sub New()

        ' This call is required by the designer. 
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(parametros As PropReportes, emp As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        Me.parametros = parametros
        Me.emp = emp
    End Sub
    Public Sub New(parametros As PropReportes, des As DateTime, has As DateTime, est As String, ent As String, emp As String, cen As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        Me.parametros = parametros
        Me.des = des
        Me.has = has
        Me.est = est
        Me.ent = ent
        Me.emp = emp
        Me.cen = cen
    End Sub
    Private Sub frmParmTM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnx = New SqlConnection(ConfigurationManager.ConnectionStrings("Produccion").ToString())
        f.Conexion = cnx
        Try
            'Tables("select Codigo, PresupuestoID, Descripcion from finanzas..Presupuesto where EmpresaID = 1", "Zafra", cbxZafra, "Descripcion", "PresupuestoID", "PresupuestoID")
            f.NewTable("spValoresSelect", "estado") ', cmbEstado, "Valor", "Codigo")
            f.NewTable("spFlaOTCabOT '" & emp & "'", "Entidad") ' cmbEntidad, "Nombre", "ID")
            f.NewTable("spFlaOTCabCentroCosto '" & emp & "'", "Centro")

            f.SetGridLookUpEdit(cmbCentro, f.dsDesarrollo.Tables("Centro"), "ID", "Nombre", "ID")
            f.SetGridLookUpEdit(cmbEntidad, f.dsDesarrollo.Tables("Entidad"), "ID", "Nombre", "ID")
            f.SetGridLookUpEdit(cmbEstado, f.dsDesarrollo.Tables("estado"), "Codigo", "Valor", "Codigo")


        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        cmbEntidad.EditValue = ent
        cmbEstado.EditValue = est
        cmbCentro.EditValue = cen
        dtpDesde.EditValue = des
        dtpHasta.EditValue = has

    End Sub
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim frm As New frmError
        Dim prmList As New List(Of SqlParameter)

        frm.ClearError()
        If IsNothing(dtpDesde.EditValue) Then frm.AddErr("Debe seleccionar la fecha inicial", 0)
        If IsNothing(dtpHasta.EditValue) Then frm.AddErr("Debe seleccionar la fecha final", 0)
        If IsNothing(cmbEntidad.EditValue) Then frm.AddErr("Debe seleccionar una entidad", 0)
        If IsNothing(cmbEstado.EditValue) Then frm.AddErr("Debe seleccionar un estado", 0)
        If IsNothing(cmbCentro.EditValue) Then frm.AddErr("Debe seleccionar un Centro de costo", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            prmList.Add(New SqlParameter("@sit", emp))
            prmList.Add(New SqlParameter("@est", cmbEstado.EditValue.ToString))
            prmList.Add(New SqlParameter("@des", dtpDesde.EditValue))
            prmList.Add(New SqlParameter("@has", dtpHasta.EditValue))
            prmList.Add(New SqlParameter("@ent", cmbEntidad.EditValue.ToString))
            prmList.Add(New SqlParameter("@cen", cmbCentro.EditValue.ToString))

            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmParmTM(parametros, CDate(dtpDesde.EditValue), CDate(dtpHasta.EditValue), cmbEstado.EditValue.ToString, cmbEntidad.EditValue.ToString, emp, cmbCentro.ToString))

            Try
                frmRpt.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.Close()
        End If
    End Sub
End Class