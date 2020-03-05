Imports System.Data.SqlClient
Public Class frmReportes
    Dim cnx As New SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=Produccion;Server=AMIGODB\AMIGODB")
    Dim adp As New SqlDataAdapter
    Dim dt As New DataTable
    Dim f As New Funciones
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        f.Conexion = cnx
    End Sub
    

    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()
        f.NewTable("spDataBaseSelect", "DataBases")

        f.InitGridControl(gcReporte, gvReporte, dt, "", False)
        f.SetGridLookUpEdit(cmbBase, f.dsDesarrollo.Tables("DataBases"), "Nombre", "Nombre")

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ClaerFields()
    End Sub

    Private Sub gvReporte_DoubleClick(sender As Object, e As EventArgs) Handles gvReporte.DoubleClick
        txtNombre.Text = gvReporte.GetFocusedRowCellValue("Nombre").ToString()
        txtNombre.Tag = gvReporte.GetFocusedRowCellValue("idReporte").ToString()
        txtDescripcion.Text = gvReporte.GetFocusedRowCellValue("Descripcion").ToString()
        txtObjeto.Text = gvReporte.GetFocusedRowCellValue("Objeto").ToString()
        txtReporte.Text = gvReporte.GetFocusedRowCellValue("Reporte").ToString()
        cmbBase.EditValue = gvReporte.GetFocusedRowCellValue("DataBase").ToString()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand
        Try
            cnx.Open()
            If txtNombre.Tag.ToString() = "0" Then
                cmd = New SqlCommand("spJ_reportesInsert", cnx)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nom", txtNombre.Text)
                cmd.Parameters.AddWithValue("@des", txtDescripcion.Text)
                cmd.Parameters.AddWithValue("@dat", cmbBase.EditValue)
                cmd.Parameters.AddWithValue("@rep", txtReporte.Text)
                cmd.Parameters.AddWithValue("@obj", txtObjeto.Text)

                cmd.ExecuteNonQuery()
            Else
                cmd = New SqlCommand("spJ_reportesUpdate", cnx)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", txtNombre.Tag)
                cmd.Parameters.AddWithValue("@nom", txtNombre.Text)
                cmd.Parameters.AddWithValue("@des", txtDescripcion.Text)
                cmd.Parameters.AddWithValue("@dat", cmbBase.EditValue)
                cmd.Parameters.AddWithValue("@rep", txtReporte.Text)
                cmd.Parameters.AddWithValue("@obj", txtObjeto.Text)

                cmd.ExecuteNonQuery()
            End If
            LoadData()
            ClaerFields()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnx.Close()
        End Try
    End Sub

    Private Sub LoadData()
        dt.Clear()
        adp = New SqlDataAdapter("spJ_reportesSelect", cnx)
        adp.Fill(dt)
    End Sub
    Private Sub ClaerFields()
        txtNombre.Text = ""
        txtNombre.Tag = "0"
        txtDescripcion.Text = ""
        txtObjeto.Text = ""
        txtReporte.Text = ""
        cmbBase.EditValue = Nothing
    End Sub
End Class