Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO


Public Class frmTipocuenta
    Dim sql As String
    Dim ejecutar As New OleDb.OleDbCommand
    Dim buscar As OleDb.OleDbDataReader
    Public Function tamanioColum(ByVal dgv As DataGridView) As Single()
        Dim valores As Single() = New Single(dgv.ColumnCount - 1) {}
        For i As Integer = 0 To dgv.ColumnCount - 1
            valores(i) = CSng(dgv.Columns(i).Width)
        Next
        Return valores
    End Function
    Public Sub ExportarPDF(ByVal documento As Document)
        'crear el numero de columnas
        Dim datosTabla As New PdfPTable(dgvCuentas.ColumnCount)
        'crea el relleno de las celdas
        datosTabla.DefaultCell.Padding = 3
        'asignar el tamanio de las columnas
        Dim anchoEncabezado As Single() = tamanioColum(dgvCuentas)
        datosTabla.SetWidths(anchoEncabezado)
        datosTabla.WidthPercentage = 100
        datosTabla.DefaultCell.BorderWidth = 2
        datosTabla.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'se crea el encabezado en el PDF
        Dim encabezado As New Paragraph("Tipos de cuenta", New Font(Font.Name = "Arial Black", 14, Font.Bold))
        'Dim encabezadoSecundario As New Paragraph(btnImprimir.Text, New Font(Font.Name = "Algerian", 12, Font.Bold))
        'logo del PDF 
        'Dim imagen As iTextSharp.text.Image
        'imagen = iTextSharp.text.Image.GetInstance(My.Computer.FileSystem.CurrentDirectory & "\nombre.extencion")
        'imagen.ScalePercent(12)
        'imagen.SetAbsolutePosition(720, 520)
        'captura de datos 
        For i As Integer = 0 To dgvCuentas.ColumnCount - 1
            datosTabla.AddCell(dgvCuentas.Columns(i).HeaderText)
        Next
        datosTabla.HeaderRows = 1
        datosTabla.DefaultCell.BorderWidth = 1
        'se generan las columnas del datagridview rellenar con los registros 

        For i As Integer = 0 To dgvCuentas.RowCount - 2
            For j As Integer = 0 To dgvCuentas.ColumnCount - 1
                datosTabla.AddCell(dgvCuentas(j, i).Value.ToString())
            Next
            datosTabla.CompleteRow()
        Next
        'agregar datos al PDF 
        'documento.Add(imagen)
        documento.Add(encabezado)
        'salto de linea
        documento.Add(New Chunk(""))
        'documento .Add(encabezadoSecundario)
        documento.Add(New Chunk(""))
        documento.Add(datosTabla)

    End Sub
    Private Sub cuentas()

        sql = "SELECT * FROM tipocuenta"
        conectar()
        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = connection
        ejecutar.CommandText = sql
        Try
            buscar = ejecutar.ExecuteReader
            While buscar.Read
                dgvCuentas.Rows.Add(buscar!cod_tipocuenta, buscar!nombre, buscar!descripcion)
            End While
        Catch ex As Exception
            MsgBox("ERROR EN LA BUSQUEDA", vbOKOnly + vbCritical, "ERROR EN LA BUSQUEDA.")
        End Try
        desconectar()
    End Sub

    Private Sub frmTipocuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cuentas()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            'GENERAR EL DOCUMENTO
            Dim doc As New Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10)
            'guardar derectorio especifico
            Dim nombreArchivo As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Tipos de cuenta.pdf"
            'crear el archivo fisico
            Dim archivo As New FileStream(nombreArchivo, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, archivo)
            doc.Open()
            ExportarPDF(doc)
            doc.Close()
            Process.Start(nombreArchivo)
            MsgBox("Archivo creado. ", vbOKOnly + vbInformation, "Exportar pdf...")
        Catch ex As Exception
            MsgBox("Error al generar pdf.", vbOKOnly + vbCritical, "Error pdf...")
        End Try
    End Sub
End Class
