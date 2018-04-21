Imports System.Xml
Imports System.IO



Public Class Form1
    Dim enumerado As Boolean = False
    Dim Alfa As Boolean = False
    Dim mayu As Boolean = False


    Private Sub Alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alta.Click

        'foco en el textbox
        TextBox1.Focus()

        If TextBox1.Text.Trim = "-" Then
            Exit Sub

        End If

        'entrada de datos
        ListBox1.Items.Add(TextBox1.Text.Trim)

        'limpia luego del alta 
        TextBox1.Clear()

    End Sub

    Private Sub baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Baja.Click

        'foco en el texbox
        TextBox1.Focus()

        If ListBox1.SelectedIndex = -1 Then
            Exit Sub

        End If

        'bajada de datos
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        TextBox1.Clear()

    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click

        TextBox1.Text = ListBox1.Items(ListBox1.SelectedIndex)
        TextBox1.Focus()

    End Sub



    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        TextBox1.Focus()

        If ListBox1.SelectedIndex = -1 Then
            Exit Sub

        End If

        ListBox1.Items(ListBox1.SelectedIndex) = TextBox1.Text
        TextBox1.Clear()

        'limpiar lo seleccionado
        ListBox1.ClearSelected()

    End Sub


    Private Sub Enumerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enumerar.Click
        Dim x As Integer

        If enumerado Then Exit Sub


        For x = 0 To ListBox1.Items.Count - 1

            ListBox1.Items.Item(x) = CStr(x) + "-" + ListBox1.Items.Item(x).ToString


        Next
        TextBox1.Focus()
        enumerado = True


    End Sub


    Private Sub Alfabetizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alfabetizar.Click
        Dim x As Integer

        If Alfa Or enumerado Then

            Exit Sub
        End If
        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.Items.Item(x) = Chr(x + 65) + "-" + ListBox1.Items.Item(x).ToString
        Next
        TextBox1.Focus()
        Alfa = True

    End Sub

    Private Sub Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quitar.Click
        Dim x, g As Integer

        For x = 0 To ListBox1.Items.Count - 1

            'g obtiene el valor de columna donde se encuentra el primer guion
            g = ListBox1.Items.Item(x).ToString.IndexOf("-")

            'devuelve una cadena a partir de g+1 hasta el final
            ListBox1.Items.Item(x) = ListBox1.Items.Item(x).substring(g + 1).ToString.ToLower


        Next
        enumerado = False
        Alfa = False
        mayu = False

    End Sub

    Private Sub Mayuscula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mayus.Click
        Dim x As Integer

        If mayu Then Exit Sub
        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.Items.Item(x) = ListBox1.Items.Item(x).ToString.ToUpper


        Next
        TextBox1.Focus()

        mayu = True


    End Sub

    Private Sub GrabarXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrabarXml.Click
        Dim ruta As String
        ruta = CurDir.Substring(0, CurDir.Length - 9)

        Dim escritor As New XmlTextWriter(ruta + "lista.xml", System.Text.Encoding.UTF8)
        escritor.WriteStartDocument(True)
        escritor.Formatting = Formatting.Indented
        escritor.Indentation = 4
        escritor.WriteStartElement("lista")

        Dim x As Integer
        For x = 0 To ListBox1.Items.Count - 1
            escritor.WriteStartElement("elemento")
            escritor.WriteString(ListBox1.Items.Item(x).ToString)
            escritor.WriteEndElement()



        Next
        escritor.WriteEndElement()
        escritor.WriteEndDocument()
        escritor.Close()

        MsgBox("guardado correctamente")
        TextBox1.Focus()
    End Sub

    
    Private Sub LeerXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeerXml.Click
        Dim xmld As New XmlDocument
        Dim listaNodos As XmlNodeList
        Dim nodo As XmlNode
        Dim ruta As String

        ruta = CurDir().Substring(0, CurDir().Length - 9)
        If Not File.Exists(ruta + "lista.xml") Then Exit Sub
        xmld.Load(ruta + "lista.xml")
        listaNodos = xmld.SelectNodes("lista/elemento")

        For Each nodo In listaNodos
            ListBox1.Items.Add(nodo.InnerText)

        Next
        TextBox1.Focus()

    End Sub
End Class
