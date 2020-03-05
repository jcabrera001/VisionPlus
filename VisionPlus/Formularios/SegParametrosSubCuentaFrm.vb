Imports System.Data.SqlClient

Public Class SegParametrosSubCuentaFrm
    Public UsuarioID As String
    Dim adp As SqlDataAdapter
    Dim ds As New DataSet
    Dim cnn As String
    Dim cnx As SqlConnection

    'Añadidos
    Public reporte As String
    Public dataBase As String
    Public user, usuarioSesion As String
    Public pass As String
    Public server As String
    Public parametro As String = ""
    Public info, asunto, cuerpo As String
    Public passwordSesion As String
    Public idMensaje As Integer
    Public UserLogin As String
    Dim primera As Boolean = False

    Dim emp As String = ""
    Dim cue As String = ""
    Dim sc As String = ""
    Dim per As Integer
    Dim usu As String = ""
    Dim cat As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(Empresa As String, Cuenta As String, SubCuenta As String, Categoria As Integer, Periodo As Integer, Usuario As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        emp = Empresa
        cue = Cuenta
        sc = SubCuenta
        cat = Categoria
        per = Periodo
        usuarioSesion = Usuario
    End Sub
    Private Sub SegParametrosSubCuentaFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Tables("select * from Finanzas..IDF_Empresas where TP = '01'", "Empresa", cbxEmpresa, "Description", "TP", "TP")
            Tables("spCuentaUsuarios " & UsuarioID, "Cuenta", cbxCuenta, "CtaDetalle", "CtaDetalle")
            Tables("spMesAComparar", "Periodo", cbxPeriodo, "EncabezadoCompleto", "PerEmpXCalendarioID", "PerEmpXCalendarioID")
            Tables("spSubCuentasUsuario", "SubCuenta", cbxSubCuenta, "Nombre", "ID")
            Tables("spCategoriaReportes", "Categoria", cbxCategoria, "Categoria", "ID", "ID")

            'cbxEmpresa.SelectionStart = 1
            cbxEmpresa.EditValue = "01"
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        If emp.ToString.Count > 0 Then
            Refrescar()
        End If
    End Sub
    Private Sub Tables(sql As String, name As String, cbx As DevExpress.XtraEditors.LookUpEdit, Display As String, Value As String)
        cnn = "Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=ProteanERP;Server=AMIGODB\AMIGODB"
        cnx = New SqlConnection(cnn)

        adp = New SqlDataAdapter(sql, cnx)
        adp.Fill(ds, name)

        cbx.Properties.DataSource = ds.Tables(name)
        cbx.Properties.ValueMember = Value
        cbx.Properties.DisplayMember = Display
    End Sub
    Private Sub Tables(sql As String, name As String, cbx As DevExpress.XtraEditors.LookUpEdit, Display As String, Value As String, Hide As String)
        cnn = "Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=ProteanERP;Server=AMIGODB\AMIGODB"
        cnx = New SqlConnection(cnn)

        adp = New SqlDataAdapter(sql, cnx)
        adp.Fill(ds, name)

        cbx.Properties.DataSource = ds.Tables(name)
        cbx.Properties.ValueMember = Value
        cbx.Properties.DisplayMember = Display
        cbx.Properties.PopulateColumns()
        cbx.Properties.Columns(Hide).Visible = False
    End Sub
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
    Public Sub Refrescar()
        cbxEmpresa.EditValue = emp
        cbxCuenta.EditValue = cue
        cbxSubCuenta.EditValue = sc
        cbxPeriodo.EditValue = per
        cbxCategoria.EditValue = cat
    End Sub
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click

        Dim frm As New frmError
        If IsNothing(cbxEmpresa.EditValue) Then frm.AddErr("Debe Seleccionar una empresa", 0)
        If IsNothing(cbxCuenta.EditValue) Then frm.AddErr("Debe Seleccionar una Cuenta", 0)
        If IsNothing(cbxSubCuenta.EditValue) Then frm.AddErr("Debe Seleccionar  una SubCuenta", 1)
        If IsNothing(cbxPeriodo.EditValue) Then frm.AddErr("Debe Seleccionar un Periodo", 0)
        If IsNothing(cbxCategoria.EditValue) Then frm.AddErr("Debe Seleccionar una categoria", 1)

        If frm.isErr Then
            frm.ShowDialog()
            Exit Sub
        Else
            Dim frmRpt As New RptVisorCRFrm(cbxEmpresa.EditValue.ToString, cbxCuenta.EditValue.ToString, cbxSubCuenta.EditValue.ToString, CInt(cbxPeriodo.EditValue.ToString), CInt(cbxCategoria.EditValue.ToString), UsuarioID)
            frmRpt.usuarioSesion = UsuarioID
            frmRpt.info = info
            frmRpt.reporte = reporte
            frmRpt.dataBase = dataBase
            frmRpt.user = user
            frmRpt.pass = pass
            frmRpt.server = server
            frmRpt.parametro = parametro
            frmRpt.CrystalReportViewer1.ShowRefreshButton = False
            Me.Close()
            frmRpt.Show()
            'frmRpt.ShowDialog()

        End If
    End Sub
End Class