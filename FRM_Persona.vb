Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Drawing.Imaging
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class FRM_Persona
    Public imgn As Byte()
    Dim ID As Integer

    Friend Sub validar_lleno()
        If txt_identificacion.Text <> "" And txt_nombreCompleto.Text <> "" And pct_picture.Tag <> "" Then
            BTN_Registrar.Enabled = True
        Else
            BTN_Registrar.Enabled = False
            BTN_Eliminar.Enabled = False
            BTN_Limpiar.Enabled = False
        End If
    End Sub

    Friend Sub Nuevo()
        Refrescar(1)
        ID = 0
        pct_picture.Tag = ""
        txt_identificacion.Clear()
        txt_nombreCompleto.Clear()
        nmb_telefono.Clear()
        tpn_telefono.Text = ""
        tpn_telefono.Tag = 0 'Cero tel fijo, 1 tel móvil'
        nace_nacimiento.Value = Now.Date
        pct_picture.Image = My.Resources._2
        imgn = New Byte() {}
    End Sub

    Friend Sub Refrescar(ByVal PROCESO As Byte)
        L.Items.Clear()
        T.Tables.Clear()

        Select Case PROCESO
            Case 1 'CARGAR INFORMACION GENERAL
                SQL = "SELECT ID, IDENTIFICACION, NOMBRE, TELEFONO FROM PERSONA"
            Case 2 'BUSCAR INFORMACION
                SQL = "SELECT ID, IDENTIFICACION, NOMBRE, TELEFONO FROM PERSONA WHERE NOMBRE LIKE '" & TXT_Buscar.Text & "%'"
        End Select

        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                L.Items.Add(T.Tables(0).Rows(I).ItemArray(0))
                For J = 1 To 3
                    L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).ItemArray(J))
                Next
            Next
            'ajuste el tamaño de las columnas
            L.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            L.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            L.Columns(0).Width = 0
        End If
    End Sub

    Private Sub FRM_Persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FRM_Principal
        Nuevo()
    End Sub

    Private Sub FRM_Persona_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txt_identificacion_TextChanged(sender As Object, e As EventArgs) Handles txt_identificacion.TextChanged
        validar_lleno()
    End Sub

    Private Sub txt_nombreCompleto_TextChanged(sender As Object, e As EventArgs) Handles txt_nombreCompleto.TextChanged
        validar_lleno()
    End Sub

    Private Sub pct_picture_Click(sender As Object, e As EventArgs) Handles pct_picture.Click
        If Abrir.ShowDialog = DialogResult.OK Then
            pct_picture.Image = Image.FromFile(Abrir.FileName)
            pct_picture.Tag = Abrir.FileName
        End If
        validar_lleno()
    End Sub

    Private Sub nace_nacimiento_ValueChanged(sender As Object, e As EventArgs) Handles nace_nacimiento.ValueChanged
        validar_lleno()
    End Sub

    Private Sub tpn_telefono_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tpn_telefono.SelectedIndexChanged
        Select Case tpn_telefono.Text
            Case "Fijo"
                tpn_telefono.Tag = 0
            Case Else
                tpn_telefono.Tag = 1
        End Select
    End Sub

    Private Sub BTN_Salir_Click(sender As Object, e As EventArgs) Handles BTN_Salir.Click
        Me.Close()
    End Sub

    Private Sub BTN_Registrar_Click(sender As Object, e As EventArgs) Handles BTN_Registrar.Click
        Try
            If ID = 0 Then
                Dim ms As New System.IO.MemoryStream()
                pct_picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim fotoBytes As Byte() = ms.ToArray()

                Dim fotoHex As String = String.Join("", fotoBytes.Select(Function(b) b.ToString("X2")))

                SQL = "INSERT INTO PERSONA (ID, IDENTIFICACION, NOMBRE, TIPOTELEFONO, TELEFONO, NACE, FOTO, IMAGEN) VALUES(" & PK("PERSONA", "ID") & ", '" & txt_identificacion.Text & "', '" & txt_nombreCompleto.Text & "', " & tpn_telefono.Tag & ", '" & nmb_telefono.Text & "', '" & Format(nace_nacimiento.Value, "yyyy/MM/dd") & "', '" & pct_picture.Tag & "', 0x" & fotoHex & ")"
            Else
                Dim ms As New System.IO.MemoryStream()
                pct_picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim fotoBytes As Byte() = ms.ToArray()

                Dim fotoHex As String = String.Join("", fotoBytes.Select(Function(b) b.ToString("X2")))
                SQL = "UPDATE PERSONA SET IDENTIFICACION = '" & txt_identificacion.Text & "', NOMBRE = '" & txt_nombreCompleto.Text & "', TIPOTELEFONO = '" & tpn_telefono.Tag & "', TELEFONO = '" & nmb_telefono.Text & "', NACE = '" & Format(nace_nacimiento.Value, "yyyy/MM/dd") & "', FOTO = '" & pct_picture.Tag & "', IMAGEN = 0x" & fotoHex & " WHERE ID = " & ID & ""
            End If
            EJECUTAR(SQL)
            Nuevo()
            MsgBox("Información registrada satisfactoriamente", vbInformation + vbOKOnly, "Guardado")
        Catch ex As Exception
            MsgBox("Error al registrar la información: " & ex.Message, vbExclamation + vbOKOnly, "Error")
            ' Manejar la excepción adecuadamente
        End Try
    End Sub

    'Private Function ImageToBase64(image As Image) As String
    '    If image IsNot Nothing Then
    '        Using memoryStream As New MemoryStream()
    '            image.Save(memoryStream, image.RawFormat)
    '            Dim imageBytes As Byte() = memoryStream.ToArray()
    '            Return Convert.ToBase64String(imageBytes)
    '        End Using
    '    End If

    '    Return String.Empty
    'End Function

    Private Sub BTN_Buscar_Click(sender As Object, e As EventArgs) Handles BTN_Buscar.Click
        Refrescar(2)
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then
            ID = L.SelectedItems(0).SubItems(0).Text
            T.Tables.Clear()
            SQL = "SELECT IDENTIFICACION, NOMBRE, TIPOTELEFONO, TELEFONO, NACE, FOTO, IMAGEN FROM PERSONA WHERE ID = " & ID & ""
            CARGAR_TABLA(T, SQL)
            txt_identificacion.Text = T.Tables(0).Rows(0).ItemArray(0)
            txt_nombreCompleto.Text = T.Tables(0).Rows(0).ItemArray(1)

            Select Case T.Tables(0).Rows(0).ItemArray(2)
                Case 0
                    tpn_telefono.Tag = 0
                    tpn_telefono.Text = "Fijo"
                Case Else
                    tpn_telefono.Tag = 1
                    tpn_telefono.Text = "Movil"
            End Select

            nmb_telefono.Text = T.Tables(0).Rows(0).ItemArray(3)
            nace_nacimiento.Value = T.Tables(0).Rows(0).ItemArray(4)
            pct_picture.Tag = T.Tables(0).Rows(0).ItemArray(5)
            Dim ms As New System.IO.MemoryStream()
            Dim imageBuffer() As Byte = CType(T.Tables(0).Rows(0).ItemArray(6), Byte())
            ms = New System.IO.MemoryStream(imageBuffer)
            'pct_picquery.Image = Nothing
            pct_picture.Image = (Image.FromStream(ms))
            'pct_picture.Image = Image.FromFile(T.Tables(0).Rows(0).Item(5))
            PANTALLA.SelectTab(0)
            BTN_Eliminar.Enabled = True
            BTN_Limpiar.Enabled = True
            validar_lleno()

        End If
    End Sub

    'Private Sub MENU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MENU_ELIMINAR.Click
    '    If L.SelectedItems.Count > 0 Then
    '        If MsgBox("¿Desea eliminar esta información?", vbQuestion + vbYes, "Confirmar") = vbYes Then
    '            SQL = "DELETE FROM PERSONA WHERE ID = " & L.SelectedItems(0).SubItems(0).Text & ""
    '            EJECUTAR(SQL)
    '            Nuevo()
    '            MsgBox("Información eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
    '        End If
    '    End If
    'End Sub

    Private Sub BTN_Eliminar_Click(sender As Object, e As EventArgs) Handles BTN_Eliminar.Click
        If L.SelectedItems.Count > 0 Then
            If MsgBox("¿Desea eliminar esta información?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                SQL = "DELETE FROM PERSONA WHERE ID = " & L.SelectedItems(0).SubItems(0).Text & ""
                EJECUTAR(SQL)
                Nuevo()
                MsgBox("Información eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
            End If
        End If
    End Sub

    Private Sub BTN_Limpiar_Click(sender As Object, e As EventArgs) Handles BTN_Limpiar.Click
        Nuevo()
    End Sub
End Class
