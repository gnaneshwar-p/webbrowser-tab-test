Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.se = "google" Then
            RadioButton1.Checked = True
        ElseIf My.Settings.se = "bing" Then
            RadioButton2.Checked = True
        ElseIf My.Settings.se = "brave" Then
            RadioButton3.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            My.Settings.se = "google"
        ElseIf RadioButton2.Checked = True Then
            My.Settings.se = "bing"
        ElseIf RadioButton3.Checked = True Then
            My.Settings.se = "brave"
        End If

        My.Settings.Save()
        My.Settings.Reload()

        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class