Imports System.Data.SqlClient
Public Class frmPrmRangoFechas
    Dim parametros As New PropReportes
    Dim des As DateTime = Now()
    Dim has As DateTime = Now()
    Dim emp As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(parametros As PropReportes, emp As String, des As DateTime, has As DateTime)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.parametros = parametros
        Me.des = des
        Me.has = has
        Me.emp = emp
    End Sub
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim frm As New frmError
        Dim prmList As New List(Of SqlParameter)

        frm.ClearError()
        If IsNothing(dtpDesde.EditValue) Then frm.AddErr("Debe seleccionar la fecha inicial", 0)
        If IsNothing(dtpHasta.EditValue) Then frm.AddErr("Debe seleccionar la fecha final", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            prmList.Add(New SqlParameter("@des", dtpDesde.EditValue))
            prmList.Add(New SqlParameter("@has", dtpHasta.EditValue))
            prmList.Add(New SqlParameter("@emp", emp))

            Dim frmRpt As New RptVisorCRFrm(parametros, prmList, New frmPrmRangoFechas(parametros, emp, CDate(dtpDesde.EditValue), CDate(dtpHasta.EditValue)), CrystalDecisions.Shared.PaperSize.PaperLetter, CrystalDecisions.Shared.PaperOrientation.Portrait)

            Try
                frmRpt.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.Close()
        End If
    End Sub

    Private Sub frmPrmRangoFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDesde.EditValue = des
        dtpHasta.EditValue = has
    End Sub
End Class