Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Linq
Imports System.Text
Imports System.Threading

Public Class ClsConexion
    Dim cnx As SqlConnection = Nothing

    Public Function conectar(stru As String, strp As String) As SqlConnection
        Dim appConfig As String = ConfigurationManager.ConnectionStrings("VisionPlus.Settings.Setting").ConnectionString
        appConfig = appConfig + "User ID=" + stru + ";Password=" + strp
        cnx = New SqlConnection(appConfig)
        Return cnx

    End Function
End Class
