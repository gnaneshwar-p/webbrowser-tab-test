Imports AxSHDocVw

Public Class tab
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Navigate(txbAdress.Text)
    End Sub

    Private Sub RemoveTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTabToolStripMenuItem.Click
        Form1.TabControl1.TabPages.Remove(Form1.TabControl1.SelectedTab)
    End Sub

    Private Sub AddTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTabToolStripMenuItem.Click
        Dim t As New TabPage
        Dim newtab As New tab
        newtab.Show()
        newtab.TopLevel = False
        newtab.Dock = DockStyle.Fill
        t.Controls.Add(newtab)
        Form1.TabControl1.TabPages.Add(t)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txbAdress.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txbAdress.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.PerformClick()
        End If
    End Sub

    Private Sub tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.ScriptErrorsSuppressed = True
        WebBrowser1.Navigate("www.google.com")
    End Sub

    Private Sub AxWebBrowser1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub WebBrowser1_NavigateComplete2(sender As Object, e As DWebBrowserEvents2_NavigateComplete2Event)
        Parent.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub txbsearch_TextChanged(sender As Object, e As EventArgs) Handles txbsearch.TextChanged

    End Sub

    Private Sub txbsearch_Click(sender As Object, e As EventArgs) Handles txbsearch.Click
        If txbsearch.Text = "search" Then
            txbsearch.Text = ""
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If My.Settings.se = "google" Then
            WebBrowser1.Navigate(My.Settings.google + txbsearch.Text)
        ElseIf My.Settings.se = "bing" Then
            WebBrowser1.Navigate(My.Settings.bing + txbsearch.Text)
        ElseIf My.Settings.se = "brave" Then
            WebBrowser1.Navigate(My.Settings.brave + txbsearch.Text)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form3.Show()
    End Sub

    Private Sub tmrstatus_Tick(sender As Object, e As EventArgs) Handles tmrstatus.Tick
        Label1.Text = WebBrowser1.StatusText.ToString
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        WebBrowser1.ScriptErrorsSuppressed = True
    End Sub
    Sub checkadress() Handles WebBrowser1.DocumentCompleted
        txbAdress.Text = WebBrowser1.Url.ToString
    End Sub
End Class