Public Class frmError

    Private _isOk As Boolean
    Private _isErr As Boolean
    Private Sub frmError_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public ReadOnly Property isOk As Boolean
        Get
            Return _isOk
        End Get
    End Property

    Public ReadOnly Property isErr() As Boolean
        Get
            Return _isErr
        End Get
   
    End Property

    Public Sub ClearError()
        lvError.Clear()
    End Sub
    Public Sub AddErr(err As String, Tipo As Integer)
        lvError.Items.Add(err, Tipo)
        _isErr = True
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
End Class