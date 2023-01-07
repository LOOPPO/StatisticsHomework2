Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class Form1
    Public ListofElem As New List(Of person)
    Function Catchint(value As Double, IntervalSize As Double, ByRef listofInterval As List(Of Interval)) As Interval

        Dim stAllocated As Boolean = False
        For Each interval In listofInterval
            If value >= interval.lowerEnd AndAlso value <= interval.upperend Then Return interval
        Next

        Try
            If value <= listofInterval(0).upperend Then
                Do
                    Dim newLeftint As New Interval
                    newLeftint.upperend = listofInterval(0).lowerEnd
                    newLeftint.lowerEnd = newLeftint.upperend - IntervalSize

                    listofInterval.Insert(0, newLeftint)
                    If value >= newLeftint.lowerEnd AndAlso value <= newLeftint.upperend Then Return newLeftint


                Loop
            ElseIf value > listofInterval(listofInterval.Count - 1).upperend Then

                Do
                    Dim newRightint As New Interval
                    newRightint.lowerEnd = listofInterval(listofInterval.Count - 1).upperend
                    newRightint.upperend = newRightint.lowerEnd + IntervalSize
                    listofInterval.Add(newRightint)
                    If value > newRightint.lowerEnd AndAlso value <= newRightint.upperend Then Return newRightint

                Loop
            Else
                If value.Equals(Nothing) Then
                    Dim INT As New Interval

                    INT.lowerEnd = 0

                    INT.upperend = 0
                    Return INT


                End If
            End If

        Catch E As ArgumentOutOfRangeException
            Dim INT As New Interval
            INT.lowerEnd = 0
            INT.upperend = 0
            Return INT
        End Try



    End Function

    Function Univariate(listofObs As List(Of Double), IntervalSize As Double, StartingEndP As Double) As Dictionary(Of Interval, frequenciesForValue)

        Dim FRdis As New Dictionary(Of Interval, frequenciesForValue)

        Dim Interval_0 As New Interval
        Interval_0.lowerEnd = StartingEndP
        Interval_0.upperend = StartingEndP + IntervalSize

        Dim listofInterval As New List(Of Interval)
        listofInterval.Add(Interval_0)
        For Each v As Double In listofObs
            Dim intervalfall = Me.Catchint(v, IntervalSize, listofInterval)


            If FRdis.ContainsKey(intervalfall) Then
                FRdis(intervalfall).count += 1

            Else
                FRdis.Add(intervalfall, New frequenciesForValue)
            End If

        Next
        Return FRdis
    End Function

    Sub printresult(nameofvar As String, frdis As Dictionary(Of Interval, frequenciesForValue))
        Me.RichTextBox1.Clear()
        Me.RichTextBox1.AppendText(vbCrLf & vbCrLf & "Distribution of " & nameofvar & vbCrLf & vbCrLf)
        Me.RichTextBox1.AppendText(nameofvar.PadRight(15) & "Count" & vbCrLf)

        For Each kvp As KeyValuePair(Of Interval, frequenciesForValue) In frdis
            Dim interval As Interval = kvp.Key
            Dim frequenciesForValue As frequenciesForValue = kvp.Value
            Me.RichTextBox1.AppendText(("[" & interval.lowerEnd & "-" & interval.upperend & "]").PadRight(20) & frequenciesForValue.count & vbCrLf)

        Next
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Path As String = ""

        Using R As New TextFieldParser(Path)
            R.Delimiters = New String() {","}
            Dim first As String = R.ReadLine
            Do While Not R.EndOfData
                Dim Values() As String = R.ReadFields()
                Dim student As New person

                If Not String.IsNullOrWhiteSpace(Values(0)) Then student.name = Values(0)
                If Not String.IsNullOrWhiteSpace(Values(1)) Then student.sex = Values(1)
                If Not String.IsNullOrWhiteSpace(Values(2)) Then student.weight = Convert.ToDouble(Values(2))
                If Not String.IsNullOrWhiteSpace(Values(3)) Then student.height = Convert.ToDouble(Values(3))
                If Not String.IsNullOrWhiteSpace(Values(4)) Then student.hair = Values(4)
                If Not String.IsNullOrWhiteSpace(Values(5)) Then student.eye = Values(5)
                If Not String.IsNullOrWhiteSpace(Values(6)) Then student.age = CDbl(Values(6))
                If Not String.IsNullOrWhiteSpace(Values(7)) Then student.shoe_size = CDbl(Values(7))
                If Not String.IsNullOrWhiteSpace(Values(8)) Then student.numberOfsiblings = (Values(8))
                If Not String.IsNullOrWhiteSpace(Values(9)) Then student.numberOfcars = CDbl(Values(9))
                If Not String.IsNullOrWhiteSpace(Values(10)) Then student.favoriteHobby = Values(10)
                If Not String.IsNullOrWhiteSpace(Values(11)) Then student.smoker = (Values(11))
                If Not String.IsNullOrWhiteSpace(Values(12)) Then student.numberofpets = CDbl(Values(12))
                If Not String.IsNullOrWhiteSpace(Values(13)) Then student.work = (Values(13))
                If Not String.IsNullOrWhiteSpace(Values(14)) Then student.favoriteNumber = CDbl(Values(14))

                ListofElem.Add(student)

            Loop
        End Using
    End Sub
    Private Sub ShoesRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles ShoesRadioButton1.CheckedChanged
        Dim CurrentAvg As Double = 0
        Dim CurrentIndex As Integer = 0
        Dim IntervalSize As Double = 3
        Dim StartingEndP As Double = 100
        Dim frequenciesForValue As Double = 0

        Dim listofDailystudent As New List(Of Double)
        For Each v As person In ListofElem
            If Not v.shoe_size.Equals(0) Then
                listofDailystudent.Add(v.shoe_size)
            End If
        Next
        Dim frdis_UNIV As Dictionary(Of Interval, frequenciesForValue) = Me.Univariate(listofDailystudent, IntervalSize, StartingEndP)
        Me.printresult("Shoe Size  ", frdis_UNIV)

    End Sub

    Private Sub WeightRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles WeightRadioButton1.CheckedChanged
        Dim CurrentAvg As Double = 0
        Dim CurrentIndex As Integer = 0
        Dim IntervalSize As Double = 5
        Dim StartingEndP As Double = 100
        Dim frequenciesForValue As Double = 0

        Dim listofDailystudent As New List(Of Double)
        For Each v As person In ListofElem
            If Not v.weight.Equals(0) Then
                listofDailystudent.Add(v.weight)
            End If
        Next
        Dim frdis_UNIV As Dictionary(Of Interval, frequenciesForValue) = Me.Univariate(listofDailystudent, IntervalSize, StartingEndP)
        Me.printresult("Weight  ", frdis_UNIV)
    End Sub

    Private Sub HeightRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles HeightRadioButton2.CheckedChanged
        Dim CurrentAvg As Double = 0
        Dim CurrentIndex As Integer = 0
        Dim IntervalSize As Double = 10
        Dim StartingEndP As Double = 100
        Dim frequenciesForValue As Double = 0

        Dim listofDailystudent As New List(Of Double)
        For Each v As person In ListofElem
            If Not v.height.Equals(0) Then
                listofDailystudent.Add(v.height)
            End If
        Next
        Dim frdis_UNIV As Dictionary(Of Interval, frequenciesForValue) = Me.Univariate(listofDailystudent, IntervalSize, StartingEndP)
        Me.printresult("Height  ", frdis_UNIV)
    End Sub

    Private Sub AgeRadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles AgeRadioButton3.CheckedChanged
        Dim CurrentAvg As Double = 0
        Dim CurrentIndex As Integer = 0
        Dim IntervalSize As Double = 3
        Dim StartingEndP As Double = 100
        Dim frequenciesForValue As Double = 0

        Dim listofDailystudent As New List(Of Double)
        For Each v As person In ListofElem
            If Not v.age.Equals(0) Then
                listofDailystudent.Add(v.age)
            End If
        Next
        Dim frdis_UNIV As Dictionary(Of Interval, frequenciesForValue) = Me.Univariate(listofDailystudent, IntervalSize, StartingEndP)
        Me.printresult("Age  ", frdis_UNIV)
    End Sub

    Private Sub SimblingsRadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles SimblingsRadioButton4.CheckedChanged
        Dim CurrentAvg As Double = 0
        Dim CurrentIndex As Integer = 0
        Dim IntervalSize As Double = 2
        Dim StartingEndP As Double = 100
        Dim frequenciesForValue As Double = 0

        Dim listofDailystudent As New List(Of Double)
        For Each v As person In ListofElem
            If Not v.numberOfsiblings.Equals(0) Then
                listofDailystudent.Add(v.numberOfsiblings)
            End If
        Next
        Dim frdis_UNIV As Dictionary(Of Interval, frequenciesForValue) = Me.Univariate(listofDailystudent, IntervalSize, StartingEndP)
        Me.printresult("Number of Simblings   ", frdis_UNIV)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PetsRadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles PetsRadioButton1.CheckedChanged
        Dim CurrentAvg As Double = 0
        Dim CurrentIndex As Integer = 0
        Dim IntervalSize As Double = 2
        Dim StartingEndP As Double = 100
        Dim frequenciesForValue As Double = 0

        Dim listofDailystudent As New List(Of Double)
        For Each v As person In ListofElem
            If Not v.numberofpets.Equals(0) Then
                listofDailystudent.Add(v.numberofpets)
            End If
        Next
        Dim frdis_UNIV As Dictionary(Of Interval, frequenciesForValue) = Me.Univariate(listofDailystudent, IntervalSize, StartingEndP)
        Me.printresult("Number of Pets   ", frdis_UNIV)
    End Sub

    Private Sub CarsRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles CarsRadioButton1.CheckedChanged
        Dim CurrentAvg As Double = 0
        Dim CurrentIndex As Integer = 0
        Dim IntervalSize As Double = 2
        Dim StartingEndP As Double = 100
        Dim frequenciesForValue As Double = 0

        Dim listofDailystudent As New List(Of Double)
        For Each v As person In ListofElem
            If Not v.numberOfcars.Equals(0) Then
                listofDailystudent.Add(v.numberOfcars)
            End If
        Next
        Dim frdis_UNIV As Dictionary(Of Interval, frequenciesForValue) = Me.Univariate(listofDailystudent, IntervalSize, StartingEndP)
        Me.printresult("Number of Cars   ", frdis_UNIV)
    End Sub
End Class

Public Class person
    Public name As String
    Public sex As String
    Public weight As Double
    Public height As Double
    Public hair As String
    Public eye As String
    Public age As Double
    Public shoe_size As Double
    Public numberOfsiblings As String
    Public numberOfcars As Double
    Public favoriteHobby As String
    Public smoker As String
    Public numberofpets As Double
    Public work As String
    Public favoriteNumber As String


    Public share_doses_used As Double

End Class
Public Class Interval
    Implements IComparable(Of Interval)
    Public lowerEnd As Double
    Public upperend As Double
    Overrides Function toString() As String
        Return "(" & lowerEnd & "  " & upperend & "}"
    End Function
    Public Function CompareTo(other As Interval) As Integer Implements System.IComparable(Of Interval).CompareTo
        Return Comparer(Of Double).Default.Compare(Me.lowerEnd, other.lowerEnd)
    End Function
End Class
