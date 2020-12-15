
Public Class Form1
    Dim OperatorState As String
    Dim data1 As String
    Dim result As String
    Dim data2 As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Text1.Text = Text1.Text + "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Text1.Text = Text1.Text + "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Text1.Text = Text1.Text + "3"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Text1.Text = Text1.Text + "4"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Text1.Text = Text1.Text + "5"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Text1.Text = Text1.Text + "6"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Text1.Text = Text1.Text + "7"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Text1.Text = Text1.Text + "8"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Text1.Text = Text1.Text + "9"
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Text1.Text = Text1.Text * 0.01
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Text1.Text = ""
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Text1.Text = Text1.Text + "0"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        data1 = Val(Text1.Text)
        OperatorState = 1
        Text1.Text = ""

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        data1 = Val(Text1.Text)
        OperatorState = 2
        Text1.Text = ""
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        data1 = Val(Text1.Text)
        OperatorState = 3
        Text1.Text = ""
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        data1 = Val(Text1.Text)
        OperatorState = 4
        Text1.Text = ""
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        data2 = Val(Text1.Text)
        If (OperatorState = 1) Then
            result = data1 + data2
        End If
        If (OperatorState = 2) Then
            result = data1 - data2
        End If
        If (OperatorState = 3) Then
            result = data1 * data2
        End If
        If (OperatorState = 4) Then
            result = data1 / data2
        End If
        Text1.Text = Str(result)
    End Sub


End Class
