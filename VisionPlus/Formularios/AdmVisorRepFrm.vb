Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.IO
Imports LibVisionPlus001
Imports System.Data.SqlClient
Public Class AdmVisorRepFrm

    Public vistas As New ClsVistas
    Public dataSet1 As DataSet
    Public xlib As ClsUtilidades = New ClsUtilidades()
    Public usuario, emp, sit As String
    Public grupo, perfil, cnombreReporte As String
    Public CarpetaRaiz As String
    Public NombreServidorRep As String
    Public reporte As String = ""
    Public database As String = ""
    Public user As String = ""
    Public pass, password As String
    Public server As String = ""
    Public si As String = ""
    Public er, idusuario As Integer
    Public info As String = ""
    Public idgrupo, idarea, cidReporte As Integer
    Dim adp As SqlClient.SqlDataAdapter
    Dim dt As New DataTable
    Private ReadOnly cnxProtean As New SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=ProteanERP;Server=AMIGODB\AMIGODB")
    Private ReadOnly cnxNomina As New SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=Nomina;Server=AMIGODB\AMIGODB")


    'Public Sub FuncionInicial(perfilUsuario As String, carpeta As String, pc As String, cuenta As String, id As Int32)
    Public Sub FuncionInicial(dtUsuarios As DataTable, carpeta As String, pc As String, pw As String, emp As String, sit As String)
        'perfil = perfilUsuario
        'idusuario = id
        'usuario = cuenta
        idgrupo = CInt(dtUsuarios.Rows(0).Item(0))
        grupo = dtUsuarios.Rows(0).Item(1).ToString
        idarea = CInt(dtUsuarios.Rows(0).Item(2))
        perfil = dtUsuarios.Rows(0).Item(3).ToString
        idusuario = CInt(dtUsuarios.Rows(0).Item(4))
        usuario = dtUsuarios.Rows(0).Item(5).ToString
        password = pw
        CarpetaRaiz = carpeta
        NombreServidorRep = pc

        Me.emp = emp
        Me.sit = sit
    End Sub
    Private Sub AdmVisorRepFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar el sitio donde pertenece el usuario
        CargarSitios()

        'Si el usuario es Admin, despliega todos los usuarios disponibles del sistema
        If perfil.Equals("Admin") Then
            cbxUsuarios.Enabled = True
            cbxSitios.Enabled = True
            'Cargar todos los usuarios
            CargarComboPerfil()
        Else
            'Cargar reportes disponibles del usuario
            CargarReportesxPerfil()
        End If
    End Sub

    Public Sub CargarSitios()
        Dim dsTemp As DataSet
        dsTemp = vistas.CargarSitiosxUsuario(idusuario, usuario, password)
        cbxSitios.Properties.DataSource = dsTemp.Tables(0)
        cbxSitios.Properties.ValueMember = dsTemp.Tables(0).Columns(0).ToString()
        cbxSitios.Properties.DisplayMember = dsTemp.Tables(0).Columns(0).ToString()
    End Sub

    Public Sub CargarComboPerfil()
        Dim dsTemp As DataSet
        dsTemp = vistas.CargarPerfiles(usuario, password)
        cbxUsuarios.Properties.DataSource = dsTemp.Tables(0)
        cbxUsuarios.Properties.ValueMember = dsTemp.Tables(0).Columns(0).ToString()
        cbxUsuarios.Properties.DisplayMember = dsTemp.Tables(0).Columns(0).ToString()
    End Sub

    Public Sub CargarReportesxPerfil()
        Dim dsTemp As DataSet
        dsTemp = vistas.BuscarRepxUsuario(1, perfil, usuario, password)
        gcReportes.DataSource = dsTemp.Tables(0)
        dgvReportes.GroupPanelText = "Reportes disponibles: " & dsTemp.Tables(0).Rows.Count
    End Sub

    Private Sub cmbSalir_Click(sender As Object, e As EventArgs) Handles cmbSalir.Click
        Close()
    End Sub

    Private Sub cmbRefrescar_Click(sender As Object, e As EventArgs) Handles cmbRefrescar.Click
        CargarReportesxPerfil()
    End Sub

    Private Sub cbxUsuarios_EditValueChanged(sender As Object, e As EventArgs) Handles cbxUsuarios.EditValueChanged
        perfil = cbxUsuarios.EditValue.ToString()
        CargarReportesxPerfil()
    End Sub

    Private Sub cmbVerRep_Click(sender As Object, e As EventArgs) Handles cmbVerRep.Click
        'SplashScreenManager1.ShowWaitForm()
        fnxGenerarReporte()
    End Sub

    Public Sub fnxGenerarReporte()

        'MsgBox(dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colIdReporte))
        'Ariel Cabrera 20/12/2018
        Dim prop As New PropReportes()
        prop.Usuario = usuario
        prop.Info = info
        prop.Reporte = "\\" + NombreServidorRep + "\" + CarpetaRaiz + "\" + reporte
        prop.DataBase = database
        prop.User = user
        prop.Pass = pass
        prop.Server = server
        prop.PassSesion = password
        'Variable para  saber que reporte fue seleccionado.
        Dim ReporteID = dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colIdReporte).ToString()

        'If dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, "Reporte").ToString() = "PRESUPUESTOS\Reporte Comparativo Real vs Presupuesto filtrado por CC" Then
        '    MsgBox(ReporteID)
        '    adp = New SqlClient.SqlDataAdapter("spCuentaUsuarios " & usuario, cnx)
        '    adp.Fill(dt)

        '    If dt.Rows.Count > 0 Then
        '        Dim frm As New SegParametrosFrm
        '        frm.UsuarioID = usuario
        '        frm.info = info
        '        frm.reporte = "\\" + NombreServidorRep + "\" + CarpetaRaiz + "\" + reporte
        '        frm.dataBase = database
        '        frm.user = user
        '        frm.pass = pass
        '        frm.server = server
        '        frm.passwordSesion = password

        '        If Convert.ToBoolean(dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colSolicitar)) Then
        '            frm.parametro = si
        '        End If
        '        frm.Show()
        '    Else
        '        MsgBox("Actualmente su usuario: " & usuario & ", no posee permisos para ver este reporte.", MsgBoxStyle.Critical, "ERROR")
        '    End If
        'ElseIf dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colIdReporte).ToString() = "351" Then 'Reporte de cuenta Mayor.
        '   Dim frm As New frmParametros(prop)
        '  frm.Show()

        If ReporteID = "355" Then
            Dim frm As New frmParametrosCho(prop, usuario)
            frm.Show() 'Reporte de Choluteca Filtrado por cuenta
        ElseIf ReporteID = "356" Then
            Dim frm As New frmParametrosChoCC(prop, usuario)
            frm.Show() 'Reporte de Choluteca Filtrado por Sub Cuenta
        ElseIf ReporteID = "357" Or ReporteID = "358" Then
            Dim frm As New frmParametrosGenerales(prop)
            frm.Show() 'Reportes de presupuesto confidenciales de Choluteca
        ElseIf ReporteID = "359" Or ReporteID = "365" Then
            Dim frm As New frmParametrosGasto(prop, usuario)
            frm.Show() 'Reporte de busqueda de gasto CAHSA y ACHSA. 
        ElseIf ReporteID = "361" Or ReporteID = "373" Then
            Dim frm As New frmParmFiltroCC(prop, usuario) 'CAHSA
            frm.Show() 'Reporte gasto vs Presupuesto detallado por subcuenta y filtrado por . 
        ElseIf ReporteID = "362" Or ReporteID = "372" Then
            Dim frm As New frmParmFiltroSub(prop, usuario) 'CAHSA
            frm.Show() 'Reporte gasto vs Presupuesto detallado por Centro Costo y filtrado por SubCuenta. 
        ElseIf ReporteID = "363" Then
            Dim frm As New frmParmFiltroGenerales(prop) 'CAHSA
            frm.Show() 'Reporte gasto vs Presupuesto Todas la subcuentas 1800
        ElseIf ReporteID = "364" Then
            Dim frm As New frmParmFiltroSubCuenta(prop)  'frmParmFiltroGenerales(prop) 'CAHSA
            frm.Show() 'Reporte gasto vs Presupuesto Todas la cuentas 1800 
        ElseIf ReporteID = "367" Then
            Dim frm As New frmBitacoraPresupuesto(prop, 355)
            frm.Show() 'Reporte de bitacora de presupuesto ACHSA
        ElseIf ReporteID = "368" Then
            Dim frm As New frmParmDistrito(prop)
            frm.Show() 'Reporte de de SubCunetas y Distritos de CAHSA
        ElseIf ReporteID = "374" Then
            Dim frm As New frmParmDistritoSub(prop)
            frm.Show() 'Reporte de Distritos y Fincas de CAHSA, filtro SubCuenta
        ElseIf ReporteID = "375" Then
            Dim frm As New frmParmTM(prop, emp)
            frm.Show() 'Reporte de facturacion interna Taller Mecanico.
        ElseIf ReporteID = "376" Or ReporteID = "380" Then
            Dim frm As New frmPrmRangoFechas(prop, emp, Now(), Now())
            frm.Show() 'Reporte de facturacion Avantis - Protena  CAHSA.
        ElseIf ReporteID = "395" Then
            Dim frm As New frmParmBonsucro(prop)
            frm.Show() 'Reporte de promedio de horas para Bonsucro.
        ElseIf ReporteID = "378" Or ReporteID = "394" Then
            Dim frm As New frmHorasEmpleado(prop)
            frm.Show() 'Reporte de horas trabajadas agrupadas por departamento, Bonsucro


            'ElseIf dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, "Reporte").ToString() = "PRESUPUESTOS\Reporte Comparativo Real vs Presupuesto filtrado por SubCta" Then
            '    MsgBox(ReporteID)
            '    adp = New SqlClient.SqlDataAdapter("spCuentaUsuarios " & usuario, cnx)
            '    adp.Fill(dt)

            '    If dt.Rows.Count > 0 Then
            '        Dim frm As New SegParametrosSubCuentaFrm
            '        frm.UsuarioID = usuario
            '        frm.info = info
            '        frm.reporte = "\\" + NombreServidorRep + "\" + CarpetaRaiz + "\" + reporte
            '        frm.dataBase = database
            '        frm.user = user
            '        frm.pass = pass
            '        frm.server = server
            '        frm.passwordSesion = password

            '        If Convert.ToBoolean(dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colSolicitar)) Then
            '            frm.parametro = si
            '        End If
            '        frm.Show()
            '    Else
            '        MsgBox("Actualmente su usuario: " & usuario & ", no posee permisos para ver este reporte.", MsgBoxStyle.Critical, "ERROR")
            '    End If

        Else
            Try
                'info = "Visor de Reportes  -  " & DGV.Item(0, DGV.CurrentRow.Index).Value & " " & DGV.Item(1, DGV.CurrentRow.Index).Value
                'reporte = DGV.Item(2, DGV.CurrentRow.Index).Value
                'database = DGV.Item(3, DGV.CurrentRow.Index).Value
                'user = DGV.Item(4, DGV.CurrentRow.Index).Value
                'pass = DGV.Item(5, DGV.CurrentRow.Index).Value
                'server = DGV.Item(6, DGV.CurrentRow.Index).Value

                Dim titulo_nombre As String = dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colNombre).ToString
                Dim titulo_descri As String = dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colDescripcion).ToString
                info = "Visor de Reportes - " + titulo_nombre +
                                        " " + titulo_descri.Replace(titulo_nombre, "")

            Catch ex As Exception
                er = 1
            End Try

            Dim v As RptVisorCRFrm
            If er = 1 Then
                MsgBox("No hay Reporte que mostrar ", MsgBoxStyle.Information, "Reporte")
                er = 0
            Else
                Try
                    v = New RptVisorCRFrm
                    v.info = info
                    v.reporte = "\\" + NombreServidorRep + "\" + CarpetaRaiz + "\" + reporte
                    v.dataBase = database
                    v.user = user 'usuario  'user
                    v.pass = pass 'password 'pass
                    v.server = server
                    v.usuarioSesion = usuario
                    v.passwordSesion = password
                    If Convert.ToBoolean(dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colSolicitar)) Then
                        v.parametro = si

                    End If

                    v.Show()
                    er = 0
                Catch ex As Exception
                    MsgBox("Ocurrio un error al cargar el visor de Reportes " & ex.Message, MsgBoxStyle.Critical, "Reporte")
                    v = Nothing
                End Try
            End If
            SplashScreenManager1.CloseWaitForm()
            'End If
        End If
    End Sub

    Private Sub dgvReportes_DoubleClick(sender As Object, e As EventArgs) Handles dgvReportes.DoubleClick
        Try

            cmbVerRep_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ConstruirDatatable("C:\VS2013\CSV\IT_ObjetosBDxReporte1.csv")
    End Sub
    Private Function ConstruirDatatable(ByVal RutaCompletaArchivo As String) As DataTable

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente
        Dim MiTabla As DataTable = New DataTable("MyTable")
        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta
        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(RutaCompletaArchivo)
            fieldValues = miReader.ReadLine().Split(CChar(","))
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                MiTabla.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(CChar(","))
                MiFila = MiTabla.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                MiTabla.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()

            'Recorrer el datatable para actualizar cada fila en la tabla J_Reportes
            For Each row As DataRow In MiTabla.Rows
                Dim id As Int32 = CInt(row("ID"))
                Dim tipo As String = row("TIPO").ToString()
                Dim objeto As String = row("OBJETO").ToString()
                Dim observ As String = row("OBSERVACIONES").ToString()
                Dim mensaje As String = vistas.ActualizarCamposAdicionalesRep(usuario, password, id, tipo, objeto, observ)
            Next
        Catch ex As Exception
            'Gestionamos las excepciones, Aqui cada uno puede hacer lo que crea conveniente: Mostrar un error en Javascript en este caso y devolver el Datatable vacío
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
            'System.Web.UI.ScriptManager.RegisterStartupScript(Page, Me.GetType(), "ErrorConstruirDatabale", mensaje, True)
            Return New DataTable("Empty")
        Finally
            'Si queremos ejecutar algo exista excepción o no
        End Try
        'Devolvemos el DataTable si todo ha ido bien
        Return MiTabla
    End Function

    Private Sub dgvReportes_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles dgvReportes.RowCellClick
        Try
            cidReporte = Convert.ToInt32(dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colIdReporte))
            cnombreReporte = dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colDescripcion).ToString()

            reporte = dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colReporte).ToString
            database = dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colBD).ToString
            user = dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colBDUsuario).ToString
            pass = xlib.FnxProcDC001(dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colBDPasswd).ToString)
            server = dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colServidor).ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbProgramarRep_Click(sender As Object, e As EventArgs) Handles cmbProgramarRep.Click
        Dim PR As AdmProgramarReporteFrm = New AdmProgramarReporteFrm()
        PR.colidReporte = cidReporte
        PR.colnombreReporte = cnombreReporte
        PR.usuario = usuario
        PR.passwd = password
        PR.colBD = database
        PR.ShowDialog()
    End Sub
End Class