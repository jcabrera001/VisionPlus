
Public Class PropReportes
 

    Private _info As String
    Private _usuario As String
    Private _reporte As String
    Private _dataBase As String
    Private _user As String
    Private _pass As String
    Private _server As String
    Private _passSesion As String
    Public Property PassSesion() As String
        Get
            Return _passSesion
        End Get
        Set(ByVal value As String)
            _passSesion = value
        End Set
    End Property
    Public Property Server() As String
        Get
            Return _server
        End Get
        Set(ByVal value As String)
            _server = value
        End Set
    End Property
    Public Property Pass() As String
        Get
            Return _pass
        End Get
        Set(ByVal value As String)
            _pass = value
        End Set
    End Property
    Public Property User() As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property
    Public Property DataBase() As String
        Get
            Return _dataBase
        End Get
        Set(ByVal value As String)
            _dataBase = value
        End Set
    End Property
    Public Property Reporte() As String
        Get
            Return _reporte
        End Get
        Set(ByVal value As String)
            _reporte = value
        End Set
    End Property
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property
    Public Property Info() As String
        Get
            Return _info
        End Get
        Set(ByVal value As String)
            _info = value
        End Set
    End Property

End Class


