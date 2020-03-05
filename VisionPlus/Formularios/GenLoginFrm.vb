Public Class GenLoginFrm

    Public vistas As New ClsVistas
    Public indicador, idUser, idgrupo, idarea As Int32
    Public usert, passt, grupo, area, emp, sit As String
    Public dta As New DataTable
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Validar()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        indicador = 0
        Me.Close()
    End Sub

    Private Sub Validar()
        usert = txtUsuario.Text
        passt = txtPassword.Text
        Dim ok As Integer
        'Dim dgv As New DataGridView
        Try

            dta = vistas.VerificarUsuario(usert, passt)
            idUser = CInt(dta.Rows(0).Item(4))
            ok = dta.Rows.Count
        Catch ex As Exception
            MsgBox("Problema en validacion: " & ex.Message, MsgBoxStyle.Critical, "Acceso a Base de datos")
            ok = -1
        End Try

        If ok = 1 Then
            Try
                'Me.Hide()
                'LlamaPrincipal()
                indicador = 1
                idgrupo = CInt(dta.Rows(0).Item(0))
                grupo = dta.Rows(0).Item(1).ToString
                idarea = CInt(dta.Rows(0).Item(2))
                area = dta.Rows(0).Item(3).ToString
                emp = dta.Rows(0).Item("Empresa").ToString()
                sit = dta.Rows(0).Item("Sitio").ToString()
                Close()
            Catch ex As Exception
                MsgBox("Ocurrio un error al llamar el formulario " & ex.Message, MsgBoxStyle.Critical, "Reporte")
            End Try
        Else
            'MsgBox("Debe ingresar un usuario y una clave valida para poder accesar", MsgBoxStyle.Information, "Usuario Invalido")
            'txtUsuario.Clear()
            txtPassword.Clear()
            txtUsuario.Focus()

        End If
    End Sub

    Private Sub GenLoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Gets the name if authenticated.
        txtUsuario.Text = Environment.UserName
        txtUsuario.Focus()
        txtPassword.Clear()
    End Sub

    Private Sub GenLoginFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'indicador = 0
        'Me.Close()
    End Sub
End Class
