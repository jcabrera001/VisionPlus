Imports System.Data
Imports System.Linq
Imports System.Text
Public Class AdmMtoAreasFrm
    Public vistas As New ClsVistas
    Public dataSet1 As DataSet
    Public usuario As String
    Public grupo, perfil As String
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
    Public idgrupo, idarea As Integer
    Public bandera As Boolean
    Public Sub FuncionInicial(dtUsuarios As DataTable, carpeta As String, pc As String, pw As String)
        'idgrupo = CInt(dtUsuarios.Rows(0).Item(0))
        'grupo = dtUsuarios.Rows(0).Item(1).ToString
        'idarea = CInt(dtUsuarios.Rows(0).Item(2))
        'perfil = dtUsuarios.Rows(0).Item(3).ToString
        idusuario = CInt(dtUsuarios.Rows(0).Item(4))
        usuario = dtUsuarios.Rows(0).Item(5).ToString
        password = pw
        CarpetaRaiz = carpeta
        NombreServidorRep = pc
    End Sub
    Private Sub AdmMtoAreasFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bandera = False
        CargarAreasTrabajo()
    End Sub

    Public Sub CargarAreasTrabajo()
        GridControl1.DataSource = vistas.ObtenerAreasTrabajo(usuario, password).Tables(0)
    End Sub

    Private Sub cmbSalir_Click(sender As Object, e As EventArgs) Handles cmbSalir.Click
        Close()
    End Sub

    Public Sub LimpiarPantalla()
        bandera = False
        idarea = -1
        cmbGuardar.Text = "Guardar"
        txtDescripcion.Text = ""
        txtNombre.Text = ""
        CargarAreasTrabajo()
    End Sub
    Private Sub cmbCancelar_Click(sender As Object, e As EventArgs) Handles cmbCancelar.Click
        LimpiarPantalla()
        'cmbNuevo.Enabled = True
    End Sub

    Private Sub dgvDatos_DoubleClick(sender As Object, e As EventArgs) Handles dgvDatos.DoubleClick
        Try
            bandera = True
            cmbGuardar.Text = "Modificar"
            idarea = CInt(dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, colIdArea))
            txtNombre.Text = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, colNombre).ToString()
            txtDescripcion.Text = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, colDescripcion).ToString()
        Catch ex As Exception

        End Try
    End Sub

    Public Function ValidarTextBox() As String
        Try
            Dim dt As DataTable = vistas.ObtenerLongitudColTabla(usuario, password, "J_AREA", "-1")
            Dim lenCol0 As Int32 = CInt(dt.Rows(0).Item(2)) 'idarea
            Dim lenCol1 As Int32 = CInt(dt.Rows(1).Item(2)) 'nombre
            Dim lenCol2 As Int32 = CInt(dt.Rows(2).Item(2)) 'descripcion
            If (String.IsNullOrEmpty(txtNombre.Text)) Then
                Return "Ingrese nombre del area de trabajo"
            ElseIf (txtNombre.Text.Length > lenCol1) Then
                Return "Longitud maxima permitida de caracteres es de " & lenCol1 & ". Favor verifique"
            ElseIf (String.IsNullOrEmpty(txtDescripcion.Text)) Then
                Return "Ingrese descripcion del area de trabajo"
            ElseIf (txtDescripcion.Text.Length > lenCol2) Then
                Return "Longitud maxima permitida de caracteres para la descripcion es de " & lenCol2 & ". Usted ha digitado hasta los momentos la cantidad de " & txtDescripcion.Text.Length & ". Favor verifique"
            End If
            Return "1"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atencion")
            Return "-1"
        End Try
    End Function

    Private Sub cmbGuardar_Click(sender As Object, e As EventArgs) Handles cmbGuardar.Click
        Dim validacion As String = ValidarTextBox()
        If (validacion.Equals("1")) Then
            GuardarModificar()
            LimpiarPantalla()
        Else
            MsgBox(validacion, MsgBoxStyle.Critical, "Atencion")
            idarea = -1
        End If
    End Sub

    Public Sub GuardarModificar()
        Dim mensaje As String = ""
        mensaje = vistas.GuardarModificarAreasTrabajo(usuario, password, idarea, bandera, txtNombre.Text, txtDescripcion.Text)
        Dim confirmacion As String = mensaje.Substring(0, 1)
        If (confirmacion.Equals("+")) Then
            MsgBox(mensaje.Replace(confirmacion, ""), MsgBoxStyle.Information, "Confirmacion")
        Else
            MsgBox(mensaje.Replace(confirmacion, ""), MsgBoxStyle.Critical, "Error")
        End If
        'Refrescar el gridView
        CargarAreasTrabajo()
        cmbNuevo.Enabled = True
    End Sub

    Private Sub cmbNuevo_Click(sender As Object, e As EventArgs) Handles cmbNuevo.Click
        bandera = False
        cmbGuardar.Text = "Guardar"
        cmbNuevo.Enabled = False
        gbxDatos.Enabled = True
        txtNombre.Focus()
    End Sub

    Private Sub cmbEliminar_Click(sender As Object, e As EventArgs) Handles cmbEliminar.Click
        Dim validacion As String = ValidarTextBox()
        If (validacion.Equals("1")) Then
            Dim hay As Integer = vistas.VerificarAreasGruposTrabajo(usuario, password, idarea)
            If (hay > 0) Then
                MsgBox("Esta Area de Trabajo esta siendo usada por " & hay & " Grupos de Trabajo, primero debe restringirles el acceso antes de eliminar el Area", MsgBoxStyle.Exclamation, "No puede borrar el Area")
            Else
                Dim n As MsgBoxResult
                n = MessageBox.Show("Esta Seguro de Eliminar permanentemente el Area de Trabajo " & txtNombre.Text & "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If n = MsgBoxResult.Yes Then
                    Dim resultado As String = vistas.EliminarAreasTrabajo(usuario, password, idarea)
                    Dim exito As String = resultado.Substring(0, 1)
                    If (exito.Equals("+")) Then
                        MsgBox(resultado.Replace(exito, ""), MsgBoxStyle.Information, "Confirmacion")
                        LimpiarPantalla()
                    Else
                        MsgBox(resultado.Replace(exito, ""), MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        Else
            MsgBox(validacion, MsgBoxStyle.Critical, "Atencion")
        End If
    End Sub
End Class