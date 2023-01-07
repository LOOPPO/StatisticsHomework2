Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports Microsoft.VisualBasic.FileIO

Public Class Form1

    Public path As String
    Private HasHeader As Boolean
    Public Matrix As List(Of String) = New List(Of String)


    Private Function OpenFile()
        Dim o As New OpenFileDialog
        o.ShowDialog()

        If Not String.IsNullOrWhiteSpace(o.FileName) And o.FileName.EndsWith(".csv") Then
            Me.TextBox1.Text = o.FileName & Environment.NewLine
        Else
            Me.RichTextBox1.AppendText("Seleziona un file valido")
            Return ""
        End If

        Return o.FileName

    End Function

    Private Function Has_Header_Line(FirstLine As String) As Boolean '

        Dim line As String() = FirstLine.Split(",")
        For Each s In line
            If IsNumeric(s) Then
                Return False
            End If
        Next
        Return True
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        path = OpenFile()
        If path = "" Then
            Exit Sub
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.RichTextBox1.Clear()
        Dim R As New TextFieldParser(path, Encoding.Default)
        R.CommentTokens = New String() {"#"}
        R.HasFieldsEnclosedInQuotes = False
        R.Delimiters = New String() {",", ";", "''"}

        Dim FirstLine As String = R.ReadLine
        If R.EndOfData Then
            Me.RichTextBox1.AppendText("File Vuoto")
            Exit Sub
        End If
        Do While Not R.EndOfData
            If String.IsNullOrWhiteSpace(FirstLine) Then
                Me.RichTextBox1.AppendText("RIGA VUOTA" & Environment.NewLine)
                FirstLine = R.ReadLine 'leggo prossima riga
            Else

                HasHeader = Has_Header_Line(FirstLine)
                Dim elem As String
                'Dim prova As String

                For Each elem In R.ReadFields
                    Me.RichTextBox1.AppendText(elem & " ")
                    Dim strn = elem.Split()(0)
                    Matrix.Add(strn)
                Next
                Me.RichTextBox1.AppendText(Environment.NewLine)

            End If
        Loop

    End Sub
End Class
