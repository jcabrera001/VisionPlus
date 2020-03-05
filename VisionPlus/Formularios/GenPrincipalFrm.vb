'Proyecto      : Vision+
'Descripcion   : Sistema de Consulta/Generacion de Reportes de Grupo CAHSA
'Objetivos     : Reporteria para aliviar licencias de Avantis/Protean y demas sistemas de informacion
'Version       : Este sistema es una migracion completa de su antecesor "Vision", usando Visual Basic.Net 2013 y DevExpress 14
'                con base de datos SQL Server 2008 R2

'Tecnologias de la Informacion Grupo CAHSA
'Fecha         : Agosto/2014

Imports DevExpress.Utils
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports System.Threading
Imports System.ComponentModel
Imports System.Text
Imports LibVisionPlus001

Partial Public Class GenPrincipalFrm
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    Public dtUsuarios As DataTable
    Public libx As ClsUtilidades = New ClsUtilidades()
    Public usuario, carpetaRaiz, nombreServidorRep, perfil, grupo, pw, ky, sit, emp As String 'perfil = area
    Public idusuario, idgrupo, idarea As Int32
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub GenPrincipalFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'perfil = "Admin"
        'idusuario = 1
        ky = libx.FnxProcEC000("")
        'Obtener carpeta raiz y nombre de servidor en donde se alojan todos los reportes
        carpetaRaiz = "Reporteador\Reportes"
        nombreServidorRep = "AMIGOTS2"
        'usuario = "admin"

        Thread.Sleep(4000) 'Ejecutar formulario Splash Screen
        CargarComboSkins() 'Cargar lista de bonus Skin
        Me.WindowState = FormWindowState.Maximized
        cmbLogin.PerformClick()
    End Sub

    Public Sub CargarComboSkins()
        Dim combo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Dim barManager1 As New DevExpress.XtraBars.BarManager()
        barManager1.ForceInitialize()

        combo = TryCast(barManager1.RepositoryItems.Add("ComboBoxEdit"), 
                        DevExpress.XtraEditors.Repository.RepositoryItemComboBox)

        For Each cnt As SkinContainer In SkinManager.Default.Skins
            combo.Items.Add(cnt.SkinName)
        Next cnt

        cbxSkins.Edit = combo
        'bxSkins.EditValue = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        cbxSkins.EditValue = "Blue"
    End Sub

    Private Sub cmbHerSkin2007_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbHerSkin2007.ItemClick
        ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
    End Sub

    Private Sub cmbHerSkin2010_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbHerSkin2010.ItemClick
        ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
    End Sub

    Private Sub cmbHerSkin2013_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbHerSkin2013.ItemClick
        ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
    End Sub

    Private Sub cmbHerSkinMac_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbHerSkinMac.ItemClick
        ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
    End Sub

    Private Sub cmbHerSkinTablet_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbHerSkinTablet.ItemClick
        ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice
    End Sub

    Private Sub cmbHerSkinTabletEx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbHerSkinTabletEx.ItemClick
        ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOfficeEx
    End Sub

    Private Sub cmbHerSkinDef_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbHerSkinDef.ItemClick
        ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Default
    End Sub

    Private Sub cbxSkins_EditValueChanged(sender As Object, e As EventArgs) Handles cbxSkins.EditValueChanged
        Dim skinName As String = cbxSkins.EditValue.ToString
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = skinName
    End Sub

    Private Sub cmbCalculadora_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbCalculadora.ItemClick
        'Ejecutar la Calculadora
        Shell("C:\WINDOWS\system32\calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub cmbNotePad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbNotePad.ItemClick
        'Ejecutar el BLoc de notas
        Shell("C:\WINDOWS\system32\notepad.exe", AppWinStyle.NormalFocus)
    End Sub

    Public Sub CerrarFormulariosActivos()
        'Dim ListaTitulosFrm As New DataTable()
        'Dim colTitulos As New DataColumn("titulos")
        'colTitulos.DataType = GetType(String)
        'ListaTitulosFrm.Columns.Add(colTitulos)
        'For Each frm As Form In Application.OpenForms
        '    Dim fila As DataRow = ListaTitulosFrm.NewRow()
        '    fila(0) = frm.Name
        '    ListaTitulosFrm.Rows.Add(fila)
        'Next

        ''Recorrer lista de nombres de formularios activos
        'For fila As Integer = 0 To ListaTitulosFrm.Rows.Count - 1
        '    'Verifica si formulario Visor de Reportes esta activo
        'Next
        'Dim frm0 As AdmMtoAreasFrm = CType(Me.ActiveMdiChild, AdmMtoAreasFrm)
        'If Not frm0 Is Nothing Then
        '    frm0.Close()
        'End If
        ''Dim frm1 As AdmMtoGrupos = CType(Me.ActiveMdiChild, AdmMtoGrupos)
        ''If Not frm1 Is Nothing Then
        ''    frm1.Close()
        ''End If
        'Dim frm2 As AdmVisorRepFrm = CType(Me.ActiveMdiChild, AdmVisorRepFrm)
        'If Not frm2 Is Nothing Then
        '    frm2.Close()
        'End If
        'Dim frm4 As RptVisorCRFrm = CType(Me.ActiveMdiChild, RptVisorCRFrm)
        'If Not frm4 Is Nothing Then
        '    frm4.Close()
        'End If

        Dim areas As AdmMtoAreasFrm = CType(Application.OpenForms("AdmMtoAreasFrm"), AdmMtoAreasFrm)
        If Not areas Is Nothing Then
            areas.Close()
        End If
        Dim visor As AdmVisorRepFrm = CType(Application.OpenForms("AdmVisorRepFrm"), AdmVisorRepFrm)
        If Not visor Is Nothing Then
            visor.Close()
        End If
        Dim cr As RptVisorCRFrm = CType(Application.OpenForms("RptVisorCRFrm"), RptVisorCRFrm)
        If Not cr Is Nothing Then
            cr.Close()
        End If
    End Sub

    Public Sub cmbLogin_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbLogin.ItemClick
        CerrarFormulariosActivos()
        GenLoginFrm.ShowDialog()
        If GenLoginFrm.indicador = 1 Then
            'Obtener la informacion del usuario (Grupo/Area)
            idgrupo = GenLoginFrm.idgrupo
            grupo = GenLoginFrm.grupo
            idarea = GenLoginFrm.idarea
            perfil = GenLoginFrm.area
            'usuario = GenLoginFrm.usert
            idusuario = GenLoginFrm.idUser
            dtUsuarios = GenLoginFrm.dta
            pw = GenLoginFrm.passt
            emp = GenLoginFrm.emp
            sit = GenLoginFrm.sit

            'Verifica si el usuario es Administrador, para desbloquear las opciones del menu
            fnxValidarPermisosOpcionesMenu(idgrupo)
            HabilitarEtiquetas()
        End If
    End Sub

    Public Sub HabilitarEtiquetas()
        cmbVisorReportes.Enabled = True
        lblUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        barStaticUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        barStaticUsuario.Caption = GenLoginFrm.usert

        lblPai1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        lblGrupo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        barStaticGrupo.Caption = grupo
        barStaticGrupo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        lblPai2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        lblArea.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        barStaticArea.Caption = perfil
        barStaticArea.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
    End Sub

    Public Sub fnxValidarPermisosOpcionesMenu(es_admin As Integer)
        If es_admin = 2 Then
            'Habilitar opciones
            cmbUsuarios.Enabled = True
            cmbGrupos.Enabled = True
            cmbAreas.Enabled = True
            cmbAsignarRep.Enabled = True
            'rPagConfiguracion.Visible = True
        Else
            'Bloquear opciones
            cmbUsuarios.Enabled = False
            cmbGrupos.Enabled = False
            cmbAreas.Enabled = False
            cmbAsignarRep.Enabled = False
            'rPagConfiguracion.Visible = False
        End If
    End Sub

    Private Sub cmbVisorReportes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbVisorReportes.ItemClick
        AdmVisorRepFrm.FuncionInicial(dtUsuarios, carpetaRaiz, nombreServidorRep, pw, emp, sit)
        AdmVisorRepFrm.MdiParent = Me
        AdmVisorRepFrm.Show()
    End Sub

    Private Sub cmbAreas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbAreas.ItemClick
        AdmMtoAreasFrm.FuncionInicial(dtUsuarios, carpetaRaiz, nombreServidorRep, pw)
        AdmMtoAreasFrm.MdiParent = Me
        AdmMtoAreasFrm.Show()
    End Sub

    Private Sub GenPrincipalFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'If (e.KeyValue = Keys.F2) Then
        '    cmbLogin.PerformClick()
        'End If
    End Sub

    Private Sub cmbAcercaDe_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbAcercaDe.ItemClick
        GenAcercaDeFrm.Show()
    End Sub

    Private Sub cmbAyuda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbAyuda.ItemClick
        Try
            Shell("C:\ManualesUsuario\VisionPlus\VisionPlus.chm", AppWinStyle.NormalFocus)
        Catch ex As Exception
            MsgBox("Error al ejecutar el archivo: " & ex.Message, MsgBoxStyle.Critical, "Atencion:")
        End Try

    End Sub


    Private Sub cmbUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbUsuarios.ItemClick
        If perfil = "Admin" Then
            Dim frm As New frmAddReporteXUsuario
            frm.MdiParent = Me
            frm.Show()
        End If
    End Sub


    Private Sub btnReporte_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReporte.ItemClick
        If perfil = "Admin" Then
            Dim frm As New frmReportes
            frm.MdiParent = Me
            frm.Show()
        End If
    End Sub
End Class
