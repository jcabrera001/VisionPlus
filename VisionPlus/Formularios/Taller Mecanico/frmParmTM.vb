Imports System.Data.SqlClient
Public Class frmParmTM
    Dim parametros As New PropReportes
    Dim cnx As New SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=Produccion;Server=AMIGODB\AMIGODB")
    Dim adp As New SqlDataAdapter()
    Dim dt As New DataTable
    Dim ds As New DataSet
    Dim des As DateTime = Now()
    Dim has As DateTime = Now()
    Dim est, ent, emp As String
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
    Public Sub New(parametros As PropReportes, des As DateTime, has As DateTime, est As String, ent As String, emp As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        Me.parametros = parametros
        Me.des = des
        Me.has = has
        Me.est = est
        Me.ent = ent
        Me.emp = emp

    End Sub
    Private Sub frmParmTM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Tables("select Codigo, PresupuestoID, Descripcion from finanzas..Presupuesto where EmpresaID = 1", "Zafra", cbxZafra, "Descripcion", "PresupuestoID", "PresupuestoID")
            Tables("spValoresSelect", "estado", cbxEstado, "Valor", "Codigo")
            Tables("spFlaOTCabOT '" & emp & "'", "Entidad", cbxEntidad, "Nombre", "ID")

        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        cbxEntidad.EditValue = ent
        cbxEstado.EditValue = est
        dtpDesde.EditValue = des
        dtpHasta.EditValue = has
    End Sub
    Private Sub Tables(sql As String, name As String, cbx As DevExpress.XtraEditors.GridLookUpEdit, Display As String, Value As String)
        adp = New SqlDataAdapter(sql, cnx)
        adp.Fill(ds, name)

        cbx.Properties.DataSource = ds.Tables(name)
        cbx.Properties.ValueMember = Value
        cbx.Properties.DisplayMember = Display
        'cbx.Properties.PopulateColumns()
        'cbx.Properties.Columns(hide).Visible = False
        'cbx.ItemIndex = 0

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
        If IsNothing(cbxEntidad.EditValue) Then frm.AddErr("Debe seleccionar una entidad", 0)
        If IsNothing(cbxEstado.EditValue) Then frm.AddErr("Debe seleccionar un estado", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            prmList.Add(New SqlParameter("@sit", emp))
            prmList.Add(New SqlParameter("@est", cbxEstado.EditValue.ToString))
            prmList.Add(New SqlParameter("@des", dtpDesde.EditValue))
            prmList.Add(New SqlParameter("@has", dtpHasta.EditValue))
            prmList.Add(New SqlParameter("@ent", cbxEntidad.EditValue.ToString))

            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmParmTM(parametros, CDate(dtpDesde.EditValue), CDate(dtpHasta.EditValue), cbxEstado.EditValue.ToString, cbxEntidad.EditValue.ToString, emp))

            Try
                frmRpt.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.Close()
        End If
    End Sub
End Class