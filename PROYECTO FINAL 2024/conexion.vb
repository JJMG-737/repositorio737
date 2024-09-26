Module conexion
    Public connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\5toCompu\Pictures\john\VISUAL2015\PROYECTO FINAL 2024\PROYECTO FINAL 2024\bin\Debug\CIUDADANOS.accdb")
    Public Sub conectar()
        Try
            connection.Open()

        Catch ex As Exception
            MsgBox("ERROR AL CONECTAR", vbOKOnly + vbCritical)
        End Try

    End Sub
    Public Sub desconectar()
        Try
            connection.Close()

        Catch ex As Exception
            MsgBox("ERROR AL DESCONECTAR", vbOKOnly + vbCritical)
        End Try
    End Sub
End Module
