Public Class Form1

    Dim tabcount As Integer
    Dim browser As New WebBrowser
    Dim sayfa As TabPage
    Dim silinen As Integer

    Private Sub SekmeEkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SekmeEkleToolStripMenuItem.Click
        On Error Resume Next
        Dim Browser As New WebBrowser
        TabControl1.TabPages.Add(ToolStripTextBox1.Text)
        TabControl1.SelectTab(tabCount)
        Browser.Dock = DockStyle.Fill
        tabcount = tabcount + 1
        TabControl1.SelectedTab.Controls.Add(Browser)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ToolStripTextBox1.Text)
    End Sub

    Private Sub SekmeyiKapatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SekmeyiKapatToolStripMenuItem.Click
        sayfa = TabControl1.SelectedTab
        If TabControl1.SelectedIndex = 0 And TabControl1.TabCount = 1 Then Exit Sub
        If Not sayfa Is Nothing Then
            sayfa.Dispose()
            silinen = silinen + 1
            TabControl1.SelectedIndex = TabControl1.TabCount - silinen
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ToolStripTextBox1.Text)
    End Sub
End Class
