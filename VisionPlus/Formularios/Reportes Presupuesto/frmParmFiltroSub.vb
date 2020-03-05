Imports System.Data
Imports System.Data.SqlClient
Public Class frmParmFiltroSub
    Dim cnx As New SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=ProteanERP;Server=AMIGODB\AMIGODB")
    Dim adp As New SqlDataAdapter()
    Dim ds As New DataSet
    'Dim user As String
    Dim parametros As New PropReportes
    Dim zaf, cue, sbc, cat, cal As Integer
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
    Public Sub New(parametros As PropReportes, zaf As Integer, cue As Integer, sbc As Integer, cat As Integer, cal As Integer, use As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.zaf = zaf
        Me.cue = cue
        Me.cal = cal
        Me.sbc = sbc
        Me.cat = cat
        Me.use = use
    End Sub
    Private Sub frmParmFiltroSub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Tables("select Codigo, PresupuestoID, Descripcion from finanzas..Presupuesto where EmpresaID = 1", "Zafra", cbxZafra, "Descripcion", "PresupuestoID", "PresupuestoID")
            Tables("Finanzas..spPresupuestoSelect " & use, "Zafra", cbxZafra, "Descripcion", "PresupuestoID", "PresupuestoID")
            Tables("select distinct MayorID, codCuenta, nomCuenta from finanzas..vusuario where usuario = '" & use & "' order by codCuenta", "cuenta", cbxCuenta, "nomCuenta", "MayorID", "MayorID")
            Tables("spSubCuentaSelect", "SubCuenta", cbxSubCuenta, "Nombre", "SubCuentaID", "SubCuentaID")
            Tables("select CategoriaID, Nombre from finanzas..categoria", "categoria", cbxCategoria, "Nombre", "CategoriaID", "CategoriaID")
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        cbxZafra.EditValue = zaf
        cbxCuenta.EditValue = cue
        cbxSubCuenta.EditValue = sbc
        cbxCategoria.EditValue = cat
        cbxCalendario.EditValue = cal
   
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
        Dim cmd As SqlCommand

        frm.ClearError()
        If IsNothing(cbxZafra.EditValue) Then frm.AddErr("Debe seleccionar la zafra a visualizar", 0)
        If IsNothing(cbxCuenta.EditValue) Then frm.AddErr("Debe seleccionar la cuenta a consultar", 0)
        If IsNothing(cbxSubCuenta.EditValue) Then frm.AddErr("Debe seleccionar una sub Cuenta", 0)
        If IsNothing(cbxCategoria.EditValue) Then frm.AddErr("Debe seleccionar una categoria", 0)
        If IsNothing(cbxCalendario.EditValue) Then frm.AddErr("Debe seleccionar el mes a consultar", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            prmList.Add(New SqlParameter("@pre", cbxZafra.EditValue.ToString))
            prmList.Add(New SqlParameter("@cue", cbxCuenta.EditValue.ToString))
            prmList.Add(New SqlParameter("@sub", cbxSubCuenta.EditValue.ToString))
            prmList.Add(New SqlParameter("@cat", cbxCategoria.EditValue.ToString))
            prmList.Add(New SqlParameter("@cal", cbxCalendario.EditValue.ToString))
            prmList.Add(New SqlParameter("@use", use))

            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmParmFiltroSub(parametros, CInt(cbxZafra.EditValue), CInt(cbxCuenta.EditValue), CInt(cbxSubCuenta.EditValue), CInt(cbxCategoria.EditValue), CInt(cbxCalendario.EditValue), use))
            frmRpt.Show()


            'Bítacora de Choluteca
            Try
                cnx.Open()
                cmd = New SqlCommand("spBitacoraPresupuestoInsert", cnx)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cue", cbxCuenta.EditValue)
                cmd.Parameters.AddWithValue("@sub", cbxSubCuenta.EditValue)
                cmd.Parameters.AddWithValue("@cal", cbxCalendario.EditValue)
                cmd.Parameters.AddWithValue("@usu", use)
                cmd.Parameters.AddWithValue("@rep", 356)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnx.Close()
            End Try
            'Bítacora de Choluteca

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