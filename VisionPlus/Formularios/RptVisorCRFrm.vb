Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows
Imports System.Windows.Forms
Imports System.Windows
Imports System.IO
Imports System.Text

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Public Class RptVisorCRFrm
    Public vistas As New ClsVistas
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
    'Public ireport As New ReportDocument
    Dim parametros As New PropReportes
    Dim prmList As New List(Of SqlClient.SqlParameter)
    Dim frm As Form

    Dim emp, cue, cc, sc, usu As String
    Dim cat, per As Integer
    Dim paper As PaperSize = Nothing
    Dim PaperOrientation As PaperOrientation

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        parametros = Nothing
    End Sub
    Public Sub New(Empresa As String, Cuenta As String, CentroCosto As String, Periodo As Integer, Usuario As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        emp = Empresa
        cue = Cuenta
        cc = CentroCosto
        per = Periodo
        usuarioSesion = Usuario
        parametros = Nothing
    End Sub
    Public Sub New(Empresa As String, Cuenta As String, Subcuenta As String, Periodo As Integer, Categoria As Integer, Usuario As String)

        ' This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        emp = Empresa
        cue = Cuenta
        sc = Subcuenta
        per = Periodo
        cat = Categoria
        usuarioSesion = Usuario
        parametros = Nothing
    End Sub
    Public Sub New(parametros As PropReportes, prmList As List(Of SqlClient.SqlParameter), frm As Form)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.prmList = prmList
        Me.frm = frm
    End Sub
    Public Sub New(parametros As PropReportes, prmList As List(Of SqlClient.SqlParameter), frm As Form, paper As PaperSize, PaperOrientation As PaperOrientation)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.prmList = prmList
        Me.frm = frm
        Me.paper = paper
        Me.PaperOrientation = PaperOrientation
    End Sub
    Public Sub New(parametros As PropReportes, prmList As List(Of SqlClient.SqlParameter))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parametros = parametros
        Me.prmList = prmList
    End Sub
    Private Sub RptVisorCRFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ireport As New ReportDocument
        Dim iConnectionInfo As ConnectionInfo = New ConnectionInfo()

        'Nuevo Método 
        If Not IsNothing(parametros) Then
            Me.Text = parametros.Info
            iConnectionInfo.DatabaseName = parametros.DataBase
            iConnectionInfo.UserID = parametros.User
            iConnectionInfo.Password = parametros.Pass
            iConnectionInfo.ServerName = parametros.Server

            iConnectionInfo.Type = ConnectionInfoType.SQL
            ireport.Load(parametros.Reporte & ".rpt")

            SetDBLogonForReport(iConnectionInfo, ireport)

            'Parámetros
            Try
                For Each prm As SqlClient.SqlParameter In prmList
                    ireport.SetParameterValue(prm.ParameterName, prm.Value)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'Tamaño de papel y orientación de página.
            'If Not IsNothing(paper) Then
            '    ireport.PrintOptions.PaperSize = paper
            '    ireport.PrintOptions.PaperOrientation = PaperOrientation
            'End If


            'CrystalReportViewer1.ShowGroupTreeButton = False
            CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            CrystalReportViewer1.ShowRefreshButton = False
            cmdActualizar.Visible = True
            Me.WindowState = FormWindowState.Maximized
            Try
                Me.CrystalReportViewer1.ReportSource = ireport
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

            'Valores todos.
            Try
                Me.Text = info
                iConnectionInfo.DatabaseName = dataBase
                iConnectionInfo.UserID = user
                iConnectionInfo.Password = pass
                iConnectionInfo.ServerName = server

                iConnectionInfo.Type = ConnectionInfoType.SQL
                '
                'ireport.SetParameterValue()
                'ireport.SetParameterValue(4, user)
                ireport.Load(reporte & ".rpt")

                SetDBLogonForReport(iConnectionInfo, ireport)

                If parametro = "" Then
                Else

                    Me.CrystalReportViewer1.ShowRefreshButton = False
                    ireport.SetParameterValue(0, parametro)
                End If

                'Paramertros de los reportes de  presupuesto. Ariel cabrera 21/12/2018
                If Not String.IsNullOrEmpty(cc) Then
                    cmdActualizar.Visible = True
                    'If cc = "--TODOS--" Then
                    '    cc = "%"
                    'End If

                    ireport.SetParameterValue("@Empresa", emp)
                    ireport.SetParameterValue("@FiltroCuenta", cue)
                    ireport.SetParameterValue("@FiltroCC", Replace(cc, "--TODOS--", "%"))
                    ireport.SetParameterValue("@IDMesComparacion", per)
                    ireport.SetParameterValue("@UsuarioID", usuarioSesion)
                    CrystalReportViewer1.ShowGroupTreeButton = False
                    Me.WindowState = FormWindowState.Maximized
                    'Me.TopMost = True

                    CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

                ElseIf Not String.IsNullOrEmpty(sc) Then 'sc.Length > 0
                    cmdActualizar.Visible = True
                    'If sc = "--TODOS--" Then
                    '    sc = "%"
                    'End If

                    ireport.SetParameterValue("@Empresa", emp)
                    ireport.SetParameterValue("@FiltroCuenta", cue)
                    ireport.SetParameterValue("@FiltroSubCta", Replace(sc, "--TODOS--", "%"))
                    ireport.SetParameterValue("@IDMesComparacion", per)
                    ireport.SetParameterValue("@CategoriaID", cat)
                    ireport.SetParameterValue("@UsuarioID", usuarioSesion)
                    CrystalReportViewer1.ShowGroupTreeButton = False
                    Me.WindowState = FormWindowState.Maximized
                    'Me.TopMost = True

                    CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
                End If
                ' Ariel Cabrera 21/12/2018

                Try
                    Me.CrystalReportViewer1.ReportSource = ireport

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Catch ex As Exception
                MsgBox("Error visor: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub
    Public Function ExportToPDF(ByVal rpt As ReportDocument, ByVal NombreArchivo As String) As String
        Dim vFileName As String
        Dim diskOpts As New DiskFileDestinationOptions

        Try
            With rpt.ExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
            End With

            vFileName = "c:\" & NombreArchivo & ".pdf"
            If File.Exists(vFileName) Then File.Delete(vFileName)
            diskOpts.DiskFileName = vFileName
            rpt.ExportOptions.DestinationOptions = diskOpts
            rpt.Export()
        Catch ex As Exception
            Throw ex
        End Try

        Return vFileName
    End Function
    Private Sub ChangeExportButton()
        Dim toolStrip1 As ToolStrip
        Dim toolStripBoton As ToolStripButton
        For Each ctrl As Control In CrystalReportViewer1.Controls
            'Buscar toolstrip del visor de informes
            If ctrl Is toolStrip1 Then
                Dim ts As ToolStrip = CType(ctrl, ToolStrip)
                For Each tsi As ToolStripItem In ts.Items
                    'Buscar el botón exportar por un ImageIndex
                    If tsi Is toolStripBoton AndAlso tsi.ImageIndex = 8 Then

                        Dim crXb As ToolStripButton = CType(tsi, ToolStripButton)
                        'Clonar el aspecto
                        Dim tsb As New ToolStripButton()
                        tsb.Size = crXb.Size
                        tsb.Padding = crXb.Padding
                        tsb.Margin = crXb.Margin
                        tsb.TextImageRelation = crXb.TextImageRelation
                        tsb.Text = crXb.Text
                        tsb.ToolTipText = crXb.ToolTipText
                        tsb.ImageScaling = crXb.ImageScaling
                        tsb.ImageAlign = crXb.ImageAlign
                        tsb.ImageIndex = crXb.ImageIndex
                        tsb.Visible = crXb.Visible
                        tsb.Enabled = crXb.Enabled
                        'Añadir el nuevo botón
                        ts.Items.Insert(0, tsb)
                        tsb.PerformClick()
                        'tsb.Click += New EventHandler(Export_Click)
                        'break()

                    End If

                Next

            End If

        Next
        'Ocultar el botón por defecto
        Me.CrystalReportViewer1.ShowExportButton = False
    End Sub
    Private Sub Export_Click(sender As Object, e As EventArgs)
        Try
            Dim saveDiag As New SaveFileDialog()
            saveDiag.Title = "Exportar Informe"
            saveDiag.Filter = "Adobe Acrobat (*.pdf)|*.pdf|Microsoft Excel (*.xls)|*.xls|Sólo datos de Microsoft Excel (*.xls)|*.xls|Microsoft Word (*.doc)|*.doc|Formato de texto enriquecido (*.rtf)|*.rtf"
            saveDiag.FilterIndex = 1
            If saveDiag.ShowDialog() = DialogResult.OK Then
                SplashScreenManager1.ShowWaitForm()
                Dim crDiskFileDestinationOptions As New DiskFileDestinationOptions()
                Dim rptDoc As ReportDocument = CType(CrystalReportViewer1.ReportSource, ReportDocument)
                Dim crExportOptions As ExportOptions = rptDoc.ExportOptions
                crDiskFileDestinationOptions.DiskFileName = saveDiag.FileName
                crExportOptions.ExportDestinationOptions = crDiskFileDestinationOptions
                crExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
                Select Case saveDiag.FilterIndex
                    Case 1
                        crExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat
                        ' break;
                    Case 2
                        crExportOptions.ExportFormatType = ExportFormatType.Excel
                        ' break;
                    Case 3
                        crExportOptions.ExportFormatType = ExportFormatType.ExcelRecord
                        ' break;
                    Case 4
                        crExportOptions.ExportFormatType = ExportFormatType.WordForWindows
                        ' break;
                    Case 5
                        crExportOptions.ExportFormatType = ExportFormatType.RichText
                        ' break;

                End Select
                rptDoc.Export(crExportOptions) ' rtf

                Try
                    'Realizar copia del archivo en el servidor de Mensajeria interna
                    ProcesoEnvioMensaje(saveDiag.FileName)

                    ' error  
                Catch mensaje As Exception
                    MessageBox.Show(mensaje.Message, "", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Catch ex As Exception
            SplashScreenManager1.CloseWaitForm()
            MsgBox("Para poder exportar el reporte, se necesita visualizar los datos en pantalla. Excepcion controlada: " + ex.Message, MsgBoxStyle.Critical, "Error:")
        End Try
    End Sub
    Public Sub ProcesoEnvioMensaje(strPathOrigen As String)
        asunto = "Envio de Reporte desde Vision Plus"
        cuerpo = "Correo generado desde Mensajeria Interna del Sistema AMIGO..."
        'Crear mensaje
        idMensaje = vistas.CrearMensajexEmisor(usuarioSesion, passwordSesion, asunto, cuerpo, usuarioSesion)

        'archivo = servidor & emisor & "_" & a(a.Length - 1)
        'My.Computer.FileSystem.MoveFile(Me.adjuntos.Items(i), archivo, True)
        'J.ejecutaSentencia("Insert into Produccion.dbo.CEArchXMensaje (Mensaje,Archivo) values ('" & cID.Text & "','" & servidor & emisor & "_" & a(a.Length - 1) & "')")

        'Enviar el mensaje al servicio de mensajeria interna del Sistemo AMIGO
        Dim Archivo As String = Path.GetFileName(strPathOrigen)
        Dim pathArchivo As String = "\\amigots2\Mensajeria\" + usuarioSesion + "_" + Archivo
        My.Computer.FileSystem.MoveFile(strPathOrigen, pathArchivo, True)

        'Insertar la bitacora o log del mensaje 
        Dim dato As String = vistas.CrearLogMensajes(usuarioSesion, passwordSesion, idMensaje, pathArchivo)
        Dim exito As String = dato.Substring(0, 1)
        If (exito.Equals("-")) Then
            MsgBox(dato.Replace(exito, ""), MsgBoxStyle.Critical, "Error al Operar la Base de Datos")
        Else
            SplashScreenManager1.CloseWaitForm()
            MsgBox("El reporte ha sido enviado satisfactoriamente a su correo...", MsgBoxStyle.Information, "Atencion:")
        End If
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'CrystalReportViewer1.ExportReport()
            Export_Click(sender, e)
    End Sub
    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'Nuevo metodo.
        If Not IsNothing(parametros) Then
            Me.Close()
            frm.ShowDialog()


        ElseIf Not String.IsNullOrEmpty(cc) Then
            Dim frm As New SegParametrosFrm(emp, cue, cc, per, usuarioSesion)
            frm.UsuarioID = usuarioSesion
            frm.info = info
            frm.reporte = reporte
            frm.dataBase = dataBase
            frm.user = user
            frm.pass = pass
            frm.server = server
            frm.passwordSesion = passwordSesion
            frm.parametro = parametro
            Me.Close()
            frm.ShowDialog()

        ElseIf Not String.IsNullOrEmpty(sc) Then
            Dim frm As New SegParametrosSubCuentaFrm(emp, cue, sc, cat, per, usuarioSesion)
            frm.UsuarioID = usuarioSesion
            frm.info = info
            frm.reporte = reporte
            frm.dataBase = dataBase
            frm.user = user
            frm.pass = pass
            frm.server = server
            frm.passwordSesion = passwordSesion
            frm.parametro = parametro
            Me.Close()
            frm.ShowDialog()
        End If
    End Sub
End Class