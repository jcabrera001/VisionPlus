Imports System.Data.SqlClient
Public Class frmBitacoraPresupuesto
    Dim rep As Integer
    Dim parametros As New PropReportes
    Dim cnx As New SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=Finanzas;Server=AMIGODB\AMIGODB")
    Dim adp As New SqlDataAdapter()
    Dim dt As New DataTable
    Dim des As DateTime = Now()
    Dim has As DateTime = Now()
    Dim use As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(parametros As PropReportes, rep As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        Me.parametros = parametros
        Me.rep = rep
    End Sub
    Public Sub New(parametros As PropReportes, rep As Integer, des As DateTime, has As DateTime, use As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        Me.parametros = parametros
        Me.rep = rep
        Me.des = des
        Me.has = has
        Me.use = use
    End Sub

    Private Sub frmBitacoraPresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adp = New SqlDataAdapter("spUsuarioSelect", cnx)
        adp.Fill(dt)

        cbxUsuario.Properties.DataSource = dt
        cbxUsuario.Properties.ValueMember = "UsuarioID"
        cbxUsuario.Properties.DisplayMember = "Nombre"
        cbxUsuario.Properties.PopulateColumns()
        cbxUsuario.Properties.Columns("UsuarioID").Visible = False

        cbxUsuario.EditValue = use
        dtpDesde.EditValue = des
        dtpHasta.EditValue = has
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim frm As New frmError
        Dim prmList As New List(Of SqlParameter)
        'Dim cmd As SqlCommand

        frm.ClearError()
        If IsNothing(cbxUsuario.EditValue) Then frm.AddErr("Debe seleccionar un usuario", 0)
        If IsNothing(dtpDesde.EditValue) Then frm.AddErr("Debe seleccionar la fecha de inicio", 0)
        If IsNothing(dtpHasta.EditValue) Then frm.AddErr("Debe seleccionar la fecha final", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else

            prmList.Add(New SqlParameter("@des", dtpDesde.EditValue))
            prmList.Add(New SqlParameter("@has", dtpHasta.EditValue))
            prmList.Add(New SqlParameter("@rep", rep))
            prmList.Add(New SqlParameter("@use", cbxUsuario.EditValue))

            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmBitacoraPresupuesto(parametros, rep, CDate(dtpDesde.EditValue), CDate(dtpHasta.EditValue), CInt(cbxUsuario.EditValue)))

            frmRpt.Show()
            Me.Close()
        End If
    End Sub
End Class