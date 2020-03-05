Partial Public Class GenPrincipalFrm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.VisionPlus.GenSplashFrm), True, True)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenPrincipalFrm))
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.cmbLogin = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbCambiarClave = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbUsuarios = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbGrupos = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbAreas = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbAsignarRep = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbVisorReportes = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbEnvioCorrero = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbCalculadora = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbNotePad = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbAyuda = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbAcercaDe = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbEstilos = New DevExpress.XtraBars.BarSubItem()
        Me.cmbHerSkinDef = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbHerSkin2007 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbHerSkin2010 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbHerSkin2013 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbHerSkinMac = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbHerSkinTablet = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbHerSkinTabletEx = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.cbxSkins = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.lblUsuario = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.barStaticUsuario = New DevExpress.XtraBars.BarStaticItem()
        Me.lblPai1 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblGrupo = New DevExpress.XtraBars.BarStaticItem()
        Me.barStaticGrupo = New DevExpress.XtraBars.BarStaticItem()
        Me.lblPai2 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblArea = New DevExpress.XtraBars.BarStaticItem()
        Me.barStaticArea = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarMdiChildrenListItem1 = New DevExpress.XtraBars.BarMdiChildrenListItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.rPagArchivo = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rPagAdministracion = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rPagConfiguracion = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rPagHerramientas = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.btnReporte = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.LookAndFeel.SkinName = "Office 2007 Blue"
        Me.BarAndDockingController1.PaintStyleName = "Skin"
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ApplicationIcon = Global.VisionPlus.My.Resources.Resources.crashdump
        Me.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue
        Me.ribbonControl1.Controller = Me.BarAndDockingController1
        Me.ribbonControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.cmbLogin, Me.cmbCambiarClave, Me.BarButtonItem3, Me.cmbUsuarios, Me.cmbGrupos, Me.cmbAreas, Me.cmbAsignarRep, Me.cmbVisorReportes, Me.BarButtonItem7, Me.BarButtonItem8, Me.cmbEnvioCorrero, Me.cmbCalculadora, Me.cmbNotePad, Me.BarButtonItem12, Me.cmbAyuda, Me.cmbAcercaDe, Me.cmbEstilos, Me.cmbHerSkinDef, Me.cmbHerSkin2007, Me.cmbHerSkin2010, Me.cmbHerSkin2013, Me.cmbHerSkinMac, Me.cmbHerSkinTablet, Me.cmbHerSkinTabletEx, Me.BarButtonItem22, Me.BarButtonItem15, Me.BarButtonItem16, Me.cbxSkins, Me.lblUsuario, Me.BarButtonItem1, Me.BarButtonItem2, Me.barStaticUsuario, Me.lblPai1, Me.lblGrupo, Me.barStaticGrupo, Me.lblPai2, Me.lblArea, Me.barStaticArea, Me.BarButtonItem4, Me.BarMdiChildrenListItem1, Me.BarButtonItem5, Me.btnReporte})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 20
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rPagArchivo, Me.rPagAdministracion, Me.rPagConfiguracion, Me.rPagHerramientas})
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1})
        Me.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.ribbonControl1.ShowToolbarCustomizeItem = False
        Me.ribbonControl1.Size = New System.Drawing.Size(851, 144)
        Me.ribbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.ribbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'cmbLogin
        '
        Me.cmbLogin.Caption = "Login"
        Me.cmbLogin.Glyph = CType(resources.GetObject("cmbLogin.Glyph"), System.Drawing.Image)
        Me.cmbLogin.Id = 1
        Me.cmbLogin.LargeGlyph = CType(resources.GetObject("cmbLogin.LargeGlyph"), System.Drawing.Image)
        Me.cmbLogin.Name = "cmbLogin"
        '
        'cmbCambiarClave
        '
        Me.cmbCambiarClave.Caption = "Cambiar Clave"
        Me.cmbCambiarClave.Glyph = CType(resources.GetObject("cmbCambiarClave.Glyph"), System.Drawing.Image)
        Me.cmbCambiarClave.Id = 2
        Me.cmbCambiarClave.LargeGlyph = CType(resources.GetObject("cmbCambiarClave.LargeGlyph"), System.Drawing.Image)
        Me.cmbCambiarClave.Name = "cmbCambiarClave"
        Me.cmbCambiarClave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'cmbUsuarios
        '
        Me.cmbUsuarios.Caption = "Usuarios"
        Me.cmbUsuarios.Enabled = False
        Me.cmbUsuarios.Glyph = CType(resources.GetObject("cmbUsuarios.Glyph"), System.Drawing.Image)
        Me.cmbUsuarios.Id = 4
        Me.cmbUsuarios.LargeGlyph = CType(resources.GetObject("cmbUsuarios.LargeGlyph"), System.Drawing.Image)
        Me.cmbUsuarios.Name = "cmbUsuarios"
        '
        'cmbGrupos
        '
        Me.cmbGrupos.Caption = "Grupos de Trabajos"
        Me.cmbGrupos.Enabled = False
        Me.cmbGrupos.Glyph = CType(resources.GetObject("cmbGrupos.Glyph"), System.Drawing.Image)
        Me.cmbGrupos.Id = 5
        Me.cmbGrupos.LargeGlyph = CType(resources.GetObject("cmbGrupos.LargeGlyph"), System.Drawing.Image)
        Me.cmbGrupos.Name = "cmbGrupos"
        '
        'cmbAreas
        '
        Me.cmbAreas.Caption = "Areas de Trabajo"
        Me.cmbAreas.Enabled = False
        Me.cmbAreas.Glyph = CType(resources.GetObject("cmbAreas.Glyph"), System.Drawing.Image)
        Me.cmbAreas.Id = 6
        Me.cmbAreas.LargeGlyph = CType(resources.GetObject("cmbAreas.LargeGlyph"), System.Drawing.Image)
        Me.cmbAreas.Name = "cmbAreas"
        '
        'cmbAsignarRep
        '
        Me.cmbAsignarRep.Caption = " Asignar Reportes"
        Me.cmbAsignarRep.Enabled = False
        Me.cmbAsignarRep.Glyph = CType(resources.GetObject("cmbAsignarRep.Glyph"), System.Drawing.Image)
        Me.cmbAsignarRep.Id = 7
        Me.cmbAsignarRep.LargeGlyph = CType(resources.GetObject("cmbAsignarRep.LargeGlyph"), System.Drawing.Image)
        Me.cmbAsignarRep.Name = "cmbAsignarRep"
        '
        'cmbVisorReportes
        '
        Me.cmbVisorReportes.Caption = "Visor Reportes"
        Me.cmbVisorReportes.Enabled = False
        Me.cmbVisorReportes.Glyph = CType(resources.GetObject("cmbVisorReportes.Glyph"), System.Drawing.Image)
        Me.cmbVisorReportes.Id = 8
        Me.cmbVisorReportes.LargeGlyph = CType(resources.GetObject("cmbVisorReportes.LargeGlyph"), System.Drawing.Image)
        Me.cmbVisorReportes.Name = "cmbVisorReportes"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Microsoft Word"
        Me.BarButtonItem7.Glyph = CType(resources.GetObject("BarButtonItem7.Glyph"), System.Drawing.Image)
        Me.BarButtonItem7.Id = 9
        Me.BarButtonItem7.LargeGlyph = CType(resources.GetObject("BarButtonItem7.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Microsoft Excel"
        Me.BarButtonItem8.Glyph = CType(resources.GetObject("BarButtonItem8.Glyph"), System.Drawing.Image)
        Me.BarButtonItem8.Id = 10
        Me.BarButtonItem8.LargeGlyph = CType(resources.GetObject("BarButtonItem8.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'cmbEnvioCorrero
        '
        Me.cmbEnvioCorrero.Caption = "Envio de Correos"
        Me.cmbEnvioCorrero.Glyph = CType(resources.GetObject("cmbEnvioCorrero.Glyph"), System.Drawing.Image)
        Me.cmbEnvioCorrero.Id = 11
        Me.cmbEnvioCorrero.LargeGlyph = CType(resources.GetObject("cmbEnvioCorrero.LargeGlyph"), System.Drawing.Image)
        Me.cmbEnvioCorrero.Name = "cmbEnvioCorrero"
        Me.cmbEnvioCorrero.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'cmbCalculadora
        '
        Me.cmbCalculadora.Caption = "Calculadora"
        Me.cmbCalculadora.Glyph = CType(resources.GetObject("cmbCalculadora.Glyph"), System.Drawing.Image)
        Me.cmbCalculadora.Id = 12
        Me.cmbCalculadora.LargeGlyph = CType(resources.GetObject("cmbCalculadora.LargeGlyph"), System.Drawing.Image)
        Me.cmbCalculadora.Name = "cmbCalculadora"
        '
        'cmbNotePad
        '
        Me.cmbNotePad.Caption = "Notepad"
        Me.cmbNotePad.Glyph = CType(resources.GetObject("cmbNotePad.Glyph"), System.Drawing.Image)
        Me.cmbNotePad.Id = 13
        Me.cmbNotePad.LargeGlyph = CType(resources.GetObject("cmbNotePad.LargeGlyph"), System.Drawing.Image)
        Me.cmbNotePad.Name = "cmbNotePad"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Skin"
        Me.BarButtonItem12.Id = 14
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'cmbAyuda
        '
        Me.cmbAyuda.Caption = "Ayuda"
        Me.cmbAyuda.Glyph = CType(resources.GetObject("cmbAyuda.Glyph"), System.Drawing.Image)
        Me.cmbAyuda.Id = 15
        Me.cmbAyuda.LargeGlyph = CType(resources.GetObject("cmbAyuda.LargeGlyph"), System.Drawing.Image)
        Me.cmbAyuda.Name = "cmbAyuda"
        '
        'cmbAcercaDe
        '
        Me.cmbAcercaDe.Caption = "Acerca de..."
        Me.cmbAcercaDe.Glyph = CType(resources.GetObject("cmbAcercaDe.Glyph"), System.Drawing.Image)
        Me.cmbAcercaDe.Id = 16
        Me.cmbAcercaDe.LargeGlyph = CType(resources.GetObject("cmbAcercaDe.LargeGlyph"), System.Drawing.Image)
        Me.cmbAcercaDe.Name = "cmbAcercaDe"
        '
        'cmbEstilos
        '
        Me.cmbEstilos.Caption = "Estilo"
        Me.cmbEstilos.Glyph = CType(resources.GetObject("cmbEstilos.Glyph"), System.Drawing.Image)
        Me.cmbEstilos.Id = 17
        Me.cmbEstilos.LargeGlyph = CType(resources.GetObject("cmbEstilos.LargeGlyph"), System.Drawing.Image)
        Me.cmbEstilos.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmbHerSkinDef), New DevExpress.XtraBars.LinkPersistInfo(Me.cmbHerSkin2007), New DevExpress.XtraBars.LinkPersistInfo(Me.cmbHerSkin2010), New DevExpress.XtraBars.LinkPersistInfo(Me.cmbHerSkin2013), New DevExpress.XtraBars.LinkPersistInfo(Me.cmbHerSkinMac), New DevExpress.XtraBars.LinkPersistInfo(Me.cmbHerSkinTablet), New DevExpress.XtraBars.LinkPersistInfo(Me.cmbHerSkinTabletEx)})
        Me.cmbEstilos.Name = "cmbEstilos"
        '
        'cmbHerSkinDef
        '
        Me.cmbHerSkinDef.Caption = "Default"
        Me.cmbHerSkinDef.Id = 18
        Me.cmbHerSkinDef.Name = "cmbHerSkinDef"
        '
        'cmbHerSkin2007
        '
        Me.cmbHerSkin2007.Caption = "Office2007"
        Me.cmbHerSkin2007.Id = 19
        Me.cmbHerSkin2007.Name = "cmbHerSkin2007"
        '
        'cmbHerSkin2010
        '
        Me.cmbHerSkin2010.Caption = "Office2010"
        Me.cmbHerSkin2010.Id = 20
        Me.cmbHerSkin2010.Name = "cmbHerSkin2010"
        '
        'cmbHerSkin2013
        '
        Me.cmbHerSkin2013.Caption = "Office2013"
        Me.cmbHerSkin2013.Id = 21
        Me.cmbHerSkin2013.Name = "cmbHerSkin2013"
        '
        'cmbHerSkinMac
        '
        Me.cmbHerSkinMac.Caption = "MacOffice"
        Me.cmbHerSkinMac.Id = 22
        Me.cmbHerSkinMac.Name = "cmbHerSkinMac"
        '
        'cmbHerSkinTablet
        '
        Me.cmbHerSkinTablet.Caption = "TabletOffice"
        Me.cmbHerSkinTablet.Id = 23
        Me.cmbHerSkinTablet.Name = "cmbHerSkinTablet"
        '
        'cmbHerSkinTabletEx
        '
        Me.cmbHerSkinTabletEx.Caption = "TabletOfficeEx"
        Me.cmbHerSkinTabletEx.Id = 24
        Me.cmbHerSkinTabletEx.Name = "cmbHerSkinTabletEx"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "BarButtonItem22"
        Me.BarButtonItem22.Id = 25
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "ejemplo"
        Me.BarButtonItem15.Id = 1
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "BarButtonItem16"
        Me.BarButtonItem16.Id = 2
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'cbxSkins
        '
        Me.cbxSkins.AutoHideEdit = False
        Me.cbxSkins.Caption = "Skin"
        Me.cbxSkins.Edit = Me.RepositoryItemComboBox1
        Me.cbxSkins.Id = 3
        Me.cbxSkins.Name = "cbxSkins"
        Me.cbxSkins.Width = 150
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.LookAndFeel.SkinName = "Seven Classic"
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'lblUsuario
        '
        Me.lblUsuario.Caption = "Usuario:"
        Me.lblUsuario.Id = 4
        Me.lblUsuario.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblUsuario.ItemAppearance.Normal.Options.UseFont = True
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
        Me.lblUsuario.TextAlignment = System.Drawing.StringAlignment.Near
        Me.lblUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem1.Id = 5
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 6
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'barStaticUsuario
        '
        Me.barStaticUsuario.Caption = "--"
        Me.barStaticUsuario.Id = 7
        Me.barStaticUsuario.Name = "barStaticUsuario"
        Me.barStaticUsuario.TextAlignment = System.Drawing.StringAlignment.Near
        Me.barStaticUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'lblPai1
        '
        Me.lblPai1.Caption = "|"
        Me.lblPai1.Id = 8
        Me.lblPai1.Name = "lblPai1"
        Me.lblPai1.TextAlignment = System.Drawing.StringAlignment.Near
        Me.lblPai1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'lblGrupo
        '
        Me.lblGrupo.Caption = "Grupo:"
        Me.lblGrupo.Id = 9
        Me.lblGrupo.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblGrupo.ItemAppearance.Normal.Options.UseFont = True
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.TextAlignment = System.Drawing.StringAlignment.Near
        Me.lblGrupo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'barStaticGrupo
        '
        Me.barStaticGrupo.Caption = "--"
        Me.barStaticGrupo.Id = 10
        Me.barStaticGrupo.Name = "barStaticGrupo"
        Me.barStaticGrupo.TextAlignment = System.Drawing.StringAlignment.Near
        Me.barStaticGrupo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'lblPai2
        '
        Me.lblPai2.Caption = "|"
        Me.lblPai2.Id = 11
        Me.lblPai2.Name = "lblPai2"
        Me.lblPai2.TextAlignment = System.Drawing.StringAlignment.Near
        Me.lblPai2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'lblArea
        '
        Me.lblArea.Caption = "Area:"
        Me.lblArea.Id = 12
        Me.lblArea.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblArea.ItemAppearance.Normal.Options.UseFont = True
        Me.lblArea.Name = "lblArea"
        Me.lblArea.TextAlignment = System.Drawing.StringAlignment.Near
        Me.lblArea.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'barStaticArea
        '
        Me.barStaticArea.Caption = "--"
        Me.barStaticArea.Id = 13
        Me.barStaticArea.Name = "barStaticArea"
        Me.barStaticArea.TextAlignment = System.Drawing.StringAlignment.Near
        Me.barStaticArea.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem4.Caption = "BarButtonItem4"
        Me.BarButtonItem4.Id = 14
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarMdiChildrenListItem1
        '
        Me.BarMdiChildrenListItem1.Caption = "Ventanas"
        Me.BarMdiChildrenListItem1.Glyph = CType(resources.GetObject("BarMdiChildrenListItem1.Glyph"), System.Drawing.Image)
        Me.BarMdiChildrenListItem1.Id = 17
        Me.BarMdiChildrenListItem1.LargeGlyph = CType(resources.GetObject("BarMdiChildrenListItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarMdiChildrenListItem1.Name = "BarMdiChildrenListItem1"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Permisos"
        Me.BarButtonItem5.Glyph = CType(resources.GetObject("BarButtonItem5.Glyph"), System.Drawing.Image)
        Me.BarButtonItem5.Id = 18
        Me.BarButtonItem5.LargeGlyph = CType(resources.GetObject("BarButtonItem5.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'rPagArchivo
        '
        Me.rPagArchivo.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup8})
        Me.rPagArchivo.Name = "rPagArchivo"
        Me.rPagArchivo.Tag = ""
        Me.rPagArchivo.Text = "Archivo"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.cmbLogin)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.cmbCambiarClave)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.ShowCaptionButton = False
        Me.ribbonPageGroup1.Text = "Acceso"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.cmbVisorReportes)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarMdiChildrenListItem1)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.ShowCaptionButton = False
        Me.RibbonPageGroup8.Text = "Visualizacion"
        '
        'rPagAdministracion
        '
        Me.rPagAdministracion.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.rPagAdministracion.Name = "rPagAdministracion"
        Me.rPagAdministracion.Text = "Administracion"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.cmbUsuarios)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.cmbGrupos)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.cmbAreas)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Perfiles"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.cmbAsignarRep)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnReporte)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Permisos"
        '
        'rPagConfiguracion
        '
        Me.rPagConfiguracion.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup7})
        Me.rPagConfiguracion.Name = "rPagConfiguracion"
        Me.rPagConfiguracion.Text = "Configuracion"
        Me.rPagConfiguracion.Visible = False
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = False
        Me.RibbonPageGroup7.Text = "Parametrizacion"
        '
        'rPagHerramientas
        '
        Me.rPagHerramientas.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup6})
        Me.rPagHerramientas.Name = "rPagHerramientas"
        Me.rPagHerramientas.Text = "Herramientas"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.cmbEnvioCorrero)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.cmbCalculadora)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.cmbNotePad)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Utilidades"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.cbxSkins)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.cmbEstilos)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.cmbAyuda)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.cmbAcercaDe)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Sistema"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.lblUsuario)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.barStaticUsuario)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.lblPai1)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.lblGrupo)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.barStaticGrupo)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.lblPai2)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.lblArea)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.barStaticArea)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 400)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(851, 31)
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.Controller = Me.BarAndDockingController1
        Me.XtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabbedMdiManager1.FloatPageDragMode = DevExpress.XtraTabbedMdi.FloatPageDragMode.Preview
        Me.XtraTabbedMdiManager1.HeaderButtons = CType(((DevExpress.XtraTab.TabButtons.Prev Or DevExpress.XtraTab.TabButtons.[Next]) _
            Or DevExpress.XtraTab.TabButtons.[Default]), DevExpress.XtraTab.TabButtons)
        Me.XtraTabbedMdiManager1.MdiParent = Me
        Me.XtraTabbedMdiManager1.SetNextMdiChildMode = DevExpress.XtraTabbedMdi.SetNextMdiChildMode.TabControl
        Me.XtraTabbedMdiManager1.ShowToolTips = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabbedMdiManager1.UseDocumentSelector = DevExpress.Utils.DefaultBoolean.[True]
        '
        'btnReporte
        '
        Me.btnReporte.Caption = "Reportes"
        Me.btnReporte.Id = 19
        Me.btnReporte.LargeGlyph = Global.VisionPlus.My.Resources.Resources.application
        Me.btnReporte.Name = "btnReporte"
        '
        'GenPrincipalFrm
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.ClientSize = New System.Drawing.Size(851, 431)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "GenPrincipalFrm"
        Me.Ribbon = Me.ribbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Menu Principal"
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private rPagArchivo As DevExpress.XtraBars.Ribbon.RibbonPage
    Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents cmbLogin As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbCambiarClave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbUsuarios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbGrupos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbAreas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rPagAdministracion As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents cmbAsignarRep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbVisorReportes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbEnvioCorrero As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbCalculadora As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbNotePad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbAyuda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbAcercaDe As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbEstilos As DevExpress.XtraBars.BarSubItem
    Friend WithEvents cmbHerSkinDef As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbHerSkin2007 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbHerSkin2010 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbHerSkin2013 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbHerSkinMac As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rPagHerramientas As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rPagConfiguracion As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents cmbHerSkinTablet As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbHerSkinTabletEx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cbxSkins As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents lblUsuario As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barStaticUsuario As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblPai1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblGrupo As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barStaticGrupo As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblPai2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblArea As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barStaticArea As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents BarMdiChildrenListItem1 As DevExpress.XtraBars.BarMdiChildrenListItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReporte As DevExpress.XtraBars.BarButtonItem
End Class
