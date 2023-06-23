Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO

Module Conexiones

    Public SQL As String
    Public Db As New OleDb.OleDbConnection
    Public T As New DataSet
    Public respuesta As OleDb.OleDbDataReader
    Public consulta As OleDb.OleDbCommand

    Friend Sub CONECTAR()
        DESCONECTAR()

        Dim Ruta As String
        Ruta = "File Name=" & Application.StartupPath & "\ruta.udl"
        Db.ConnectionString = Ruta
        Db.Open()
        Exit Sub
    End Sub

    Friend Sub DESCONECTAR()
        Db.Close()
    End Sub

    Friend Sub CARGAR_TABLA(ByRef Tabla_Temporal As DataSet, ByVal Sql As String)
        CONECTAR()
        Dim Consulta As New OleDb.OleDbDataAdapter(Sql, Db)
        Consulta.Fill(Tabla_Temporal)
        DESCONECTAR()
    End Sub

    Friend Sub EJECUTAR(ByVal Sql As String)
        CONECTAR()
        Dim Comando As New OleDb.OleDbCommand(Sql, Db)
        Comando.ExecuteNonQuery()
        DESCONECTAR()
    End Sub

    'Friend Sub EJECUTAR(ByVal Sql As String, ByVal parametros As OleDbParameter())
    '    CONECTAR()
    '    Dim Comando As New OleDbCommand(Sql, Db)

    '    If parametros IsNot Nothing AndAlso parametros.Length > 0 Then
    '        Comando.Parameters.AddRange(parametros)
    '    End If

    '    Comando.ExecuteNonQuery()

    '    DESCONECTAR()
    'End Sub

    Friend Function PK(ByVal TABLA As String, ByVal ID As String) As Integer
        T.Tables.Clear()
        SQL = "SELECT " & ID & " FROM " & TABLA
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            T.Tables.Clear()
            SQL = "SELECT MAX(" & ID & ") FROM " & TABLA
            CARGAR_TABLA(T, SQL)
            PK = T.Tables(0).Rows(0).ItemArray(0) + 1
        Else
            PK = 1
        End If
    End Function

    'Function ConsultaByte(ByVal Name As String) As Byte()
    '    CONECTAR()
    '    Dim imageBytes As Byte()
    '    Dim query As String = "SELECT IMAGEN FROM PERSONA WHERE Nombre= '" & Name & "'"

    '    Dim data As New DataTable

    '    consulta = New OleDbCommand(query, Db)

    '    Using respuesta = consulta.ExecuteReader()
    '        If respuesta.Read Then
    '            imageBytes = DirectCast(respuesta("Imagen"), Byte())

    '            ' Guarda los datos de la imagen en un archivo (opcional)
    '            Dim imagePath As String = "D:\Backup\OneDrive\Imágenes\Tarea1.jpg" ' Ruta y nombre del archivo de imagen
    '            File.WriteAllBytes(imagePath, imageBytes)
    '            Return imageBytes
    '        End If

    '    End Using

    '    ''consulta = New OleDbDataAdapter("SELECT IMAGEN FROM PERSONA WHERE Nombre= '" & Name & "'", Db)

    '    Return imageBytes
    'End Function
End Module
