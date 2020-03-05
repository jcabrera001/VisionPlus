Public Class AdmProgramarReporteFrm
    Public vistas As New ClsVistas
    Public dataSet1 As DataSet
    Public colidReporte As Integer
    Public colnombreReporte, usuario, passwd, colBD As String

    'Variables para validacion de tipo de dato de cada columna
    Public sp_tipoDato, sp_mensaje As String
    Private Sub AdmProgramarReporteFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = colidReporte.ToString() + " - " + colnombreReporte
    End Sub

    Private Sub cmbSalir_Click(sender As Object, e As EventArgs) Handles cmbSalir.Click
        Close()
    End Sub

    Private Sub cmdMostrarParametro_Click(sender As Object, e As EventArgs) Handles cmdMostrarParametro.Click
        dataSet1 = vistas.ObtenerParametrosxReporte(usuario, passwd, colidReporte, colBD)
        GridControl1.DataSource = dataSet1
        GridControl1.DataMember = "parametros"

        'Validar y formatear columnas en tiempo de ejecucion
        'ValidarFormatearCamposGrid()
    End Sub

    Public Sub ValidarFormatearCamposGrid()
        'colSecuencia
        dgvCampos.Columns("colSecuencia").OptionsColumn.AllowEdit = False
        dgvCampos.Columns("colSecuencia").OptionsColumn.AllowMove = False
        dgvCampos.Columns("colSecuencia").OptionsColumn.FixedWidth = True
        dgvCampos.Columns("colSecuencia").OptionsColumn.ReadOnly = True
        dgvCampos.Columns("colSecuencia").OptionsFilter.AllowAutoFilter = False
        dgvCampos.Columns("colSecuencia").OptionsFilter.AllowFilter = False
        dgvCampos.Columns("colSecuencia").Visible = True
        dgvCampos.Columns("colSecuencia").VisibleIndex = 0

        'colParametro
        dgvCampos.Columns("colParametro").OptionsColumn.AllowEdit = False
        dgvCampos.Columns("colParametro").OptionsColumn.AllowMove = False
        dgvCampos.Columns("colParametro").OptionsColumn.FixedWidth = True
        dgvCampos.Columns("colParametro").OptionsColumn.ReadOnly = True
        dgvCampos.Columns("colParametro").OptionsFilter.AllowAutoFilter = False
        dgvCampos.Columns("colParametro").OptionsFilter.AllowFilter = False
        dgvCampos.Columns("colParametro").Visible = True
        dgvCampos.Columns("colParametro").VisibleIndex = 1

        'colTipoDato
        dgvCampos.Columns("colTipoDato").OptionsColumn.AllowEdit = False
        dgvCampos.Columns("colTipoDato").OptionsColumn.AllowMove = False
        dgvCampos.Columns("colTipoDato").OptionsColumn.FixedWidth = True
        dgvCampos.Columns("colTipoDato").OptionsColumn.ReadOnly = True
        dgvCampos.Columns("colTipoDato").OptionsFilter.AllowAutoFilter = False
        dgvCampos.Columns("colTipoDato").OptionsFilter.AllowFilter = False
        dgvCampos.Columns("colTipoDato").Visible = True
        dgvCampos.Columns("colTipoDato").VisibleIndex = 2

        'colMaximo
        dgvCampos.Columns("colMaximo").OptionsColumn.AllowEdit = False
        dgvCampos.Columns("colMaximo").OptionsColumn.AllowMove = False
        dgvCampos.Columns("colMaximo").OptionsColumn.FixedWidth = True
        dgvCampos.Columns("colMaximo").OptionsColumn.ReadOnly = True
        dgvCampos.Columns("colMaximo").OptionsFilter.AllowAutoFilter = False
        dgvCampos.Columns("colMaximo").OptionsFilter.AllowFilter = False
        dgvCampos.Columns("colMaximo").Visible = True
        dgvCampos.Columns("colMaximo").VisibleIndex = 3
    End Sub

    Private Sub dgvCampos_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles dgvCampos.ValidatingEditor
        GetSelectedValues()
       
        Select dgvCampos.FocusedColumn.Name
            Case "colValor"
                If sp_tipoDato.Equals("smalldatetime") = True Or sp_tipoDato.Equals("date") Or sp_tipoDato.Equals("datetime") Then
                    Try
                        Dim validarFecha As Date = New Date()
                        validarFecha = Convert.ToDateTime(e.Value)
                    Catch ex As Exception
                        sp_mensaje = sp_tipoDato
                        e.Valid = False
                    End Try
                End If
                If sp_tipoDato.Equals("int") Then
                    Try
                        Dim validarInt As Integer
                        validarInt = Convert.ToInt32(validarInt)
                    Catch ex As Exception
                        sp_mensaje = sp_tipoDato
                        e.Valid = False
                    End Try
                End If
                If sp_tipoDato.Equals("decimal") = True Or sp_tipoDato.Equals("float") = True Or sp_tipoDato.Equals("money") = True Then
                    Try
                        Dim validarDecimal As Decimal
                        validarDecimal = Convert.ToDecimal(validarDecimal)
                    Catch ex As Exception
                        sp_mensaje = sp_tipoDato
                        e.Valid = False
                    End Try
                End If
        End Select
    End Sub

    Public Sub GetSelectedValues()

        'If dgvCampos.SelectedRowsCount = 0 Then Return ""

        'Const CellDelimiter As String = vbTab
        'Const LineDelimiter As String = vbCrLf
        Dim Result As String = ""

        ' iterate cells and compose a tab delimited string of cell values
        'Dim I, J As Integer
        Dim Row As Integer

        For I = dgvCampos.SelectedRowsCount - 1 To 0 Step -1
            Row = dgvCampos.GetSelectedRows()(I)
            'For J = 0 To dgvCampos.VisibleColumns.Count - 1
            '    Result += dgvCampos.GetRowCellDisplayText(Row, dgvCampos.VisibleColumns(J))
            '    If J <> dgvCampos.VisibleColumns.Count - 1 Then
            '        Result += CellDelimiter
            '    End If
            'Next

            'If I <> 0 Then
            '    Result += LineDelimiter
            'End If
        Next

        sp_tipoDato = dgvCampos.GetRowCellDisplayText(Row, dgvCampos.VisibleColumns(2)).ToString

        'Return Result

    End Sub

    Private Sub dgvCampos_InvalidValueException(sender As Object, e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles dgvCampos.InvalidValueException
        Select Case dgvCampos.FocusedColumn.Name
            Case "colValor"
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
                e.WindowCaption = "Error en el valor ingresado"
                e.ErrorText = "El valor no es de tipo " + sp_mensaje
        End Select
    End Sub
End Class