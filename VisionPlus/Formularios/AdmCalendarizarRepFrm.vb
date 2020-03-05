Public Class AdmCalendarizarRepFrm 
    Public colidReporte As Integer
    Public colnombreReporte As String
    Private Sub AdmCalendarizarRepFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = Text + " : " + colidReporte.ToString() + " - " + colnombreReporte
    End Sub

    Private Sub cmbSalir_Click(sender As Object, e As EventArgs) Handles cmbSalir.Click
        Close()
    End Sub

    Private Sub rgbFrecuencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgbFrecuencia.SelectedIndexChanged
        Dim index As Int32 = rgbFrecuencia.SelectedIndex
        If index = 0 Then
            txtFecha.Enabled = False
            txtHora.Enabled = False
            txtRepeticion.Enabled = False
            weekDayLista.Enabled = False
        ElseIf index = 1 Then
            lblCambio.Text = "A las "
            lblDiasSemana.Text = " dia"
            lblRepetir.Text = "Repetir cada: "
            txtFecha.Enabled = True
            txtHora.Enabled = True
            txtRepeticion.Enabled = False
            weekDayLista.Enabled = False
        ElseIf index = 2 Then
            lblCambio.Text = "Inicia "
            lblDiasSemana.Text = " dia"
            lblRepetir.Text = "Repetir cada: "
            txtFecha.Enabled = True
            txtHora.Enabled = True
            txtRepeticion.Enabled = True
            weekDayLista.Enabled = False
        ElseIf index = 3 Then
            lblCambio.Text = "Inicia "
            lblDiasSemana.Text = " semana"
            lblRepetir.Text = "Repetir cada: "
            txtFecha.Enabled = True
            txtHora.Enabled = True
            txtRepeticion.Enabled = True
            weekDayLista.Enabled = True
        End If
    End Sub

    Private Sub cmbGuardar_Click(sender As Object, e As EventArgs) Handles cmbGuardar.Click
        AdmProgramarReporteFrm.ShowDialog()
    End Sub
End Class