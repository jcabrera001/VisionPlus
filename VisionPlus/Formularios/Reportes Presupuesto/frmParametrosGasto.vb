Imports System.Data
Imports System.Data.SqlClient
Public Class frmParametrosGasto
    Dim cnx As New SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=Finanzas;Server=AMIGODB\AMIGODB")
    Dim adp As New SqlDataAdapter()
    Dim ds As New DataSet
    'Dim user As String
    Dim parametros As New PropReportes
    Dim zaf, cue, cal, est As Integer
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
    Public Sub New(parametros As PropReportes, zaf As Integer, cue As Integer, cal As Integer, use As String, est As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.zaf = zaf
        Me.cue = cue
        Me.cal = cal
        Me.use = use
        Me.est = est
    End Sub
    Private Sub frmParametrosGasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Tables("spPresupuestoSelect " & use, "Zafra", cbxZafra, "Descripcion", "PresupuestoID", "PresupuestoID")
            Tables("spCuentaSelect", "cuenta", cbxCuenta, "Nombre", "MayorID", "MayorID")
            Tables("select cast(Codigo as int) Codigo, Valor from produccion..iValores('j_reportes', 'Estado')", "Estado", cbxEstado, "Valor", "Codigo", "Codigo")
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        cbxZafra.EditValue = zaf
        cbxCuenta.EditValue = cue
        cbxCalendario.EditValue = cal
        cbxEstado.EditValue = est
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
        If IsNothing(cbxCalendario.EditValue) Then frm.AddErr("Debe seleccionar el mes a consultar", 0)
        If IsNothing(cbxEstado.EditValue) Then frm.AddErr("Debe seleccionar un estado", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            prmList.Add(New SqlParameter("@may", cbxCuenta.EditValue.ToString))
            prmList.Add(New SqlParameter("@cal", cbxCalendario.EditValue.ToString))
            prmList.Add(New SqlParameter("@est", cbxEstado.EditValue.ToString))

            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmParametrosGasto(parametros, CInt(cbxZafra.EditValue), CInt(cbxCuenta.EditValue), CInt(cbxCalendario.EditValue), use, CInt(cbxEstado.EditValue)))
            frmRpt.Show()
            Me.Close()
        End If
    End Sub

    Private Sub cbxZafra_EditValueChanged(sender As Object, e As EventArgs) Handles cbxZafra.EditValueChanged
        If Not IsNothing(cbxZafra.EditValue) Then
            If Not IsNothing(ds.Tables("cc")) Then
                ds.Tables("cc").Clear()
            End If
            Tables("select CalendarioID, Titulo from Finanzas..Calendario where PresupuestoID  = " & cbxZafra.EditValue.ToString, "cc", cbxCalendario, "Titulo", "CalendarioID", "CalendarioID")
        End If
    End Sub
End Class