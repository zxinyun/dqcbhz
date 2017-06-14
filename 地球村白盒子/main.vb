Imports System.IO
Imports Microsoft.Win32.Registry
Public Class main
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(LinkLabel1.Tag.ToString)
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Process.Start(Label1.Text.ToString)
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.TopMost = False
        NotifyIcon1.Visible = False
        NotifyIcon1.Dispose()
        Me.Close()
    End Sub

    Private Sub 软件说明ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 软件说明ToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub 作者围脖ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 作者围脖ToolStripMenuItem.Click
        Process.Start("http://www.ynevsoft.com")
        Me.TopMost = False
    End Sub


    Private Sub main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' e.Cancel = False
        Dim tishi As Integer
        tishi = MsgBox("确定关闭白盒子", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "提示")
        Select Case tishi
            Case MsgBoxResult.Yes
                e.Cancel = False
                Exit Sub
                NotifyIcon1.Visible = False
                NotifyIcon1.Dispose()
                End
            Case MsgBoxResult.No
                e.Cancel = True
                NotifyIcon1.Visible = True
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Text.PadRight(100)
        Label11.Text = "http://doc.evsoft.cn:8080/share" + vbNewLine + " /page/site/evsoft/documentlibrary"
    End Sub
    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As TabControlEventArgs) Handles TabControl1.Selected
        If e.TabPage.TabIndex = TabPage2.TabIndex Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start(LinkLabel2.Tag.ToString)
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start(LinkLabel3.Tag.ToString)
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start(LinkLabel4.Tag.ToString)
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Process.Start(LinkLabel5.Tag.ToString)
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Process.Start(LinkLabel6.Tag.ToString)
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Process.Start(LinkLabel7.Tag.ToString)
        Me.TopMost = False
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Process.Start(LinkLabel2.Tag.ToString)
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Process.Start(Label3.Text.ToString)
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Process.Start(Label4.Text.ToString)
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Process.Start(Label5.Text.ToString)
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Process.Start(Label6.Text.ToString)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim Reg As Microsoft.Win32.RegistryKey
        Dim path As Object = Application.ExecutablePath
        Try
            If path <> "" Then
                If CheckBox1.Checked = True Then
                    Reg = CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
                    Reg.SetValue("evsoft", path)
                    Reg.Close()
                    MsgBox("设置成功！")
                Else
                    Reg = CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
                    'Reg.SetValue("evsoft", "")
                    Reg.DeleteValue("evsoft")
                    Reg.Close()
                    MsgBox("已取消开机启动！")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim home As Microsoft.Win32.RegistryKey
        home = CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main", True)
        Try
            home.SetValue("Start Page", "http://www.evsoft.com.cn")
        Catch ex As Exception
            home.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim home As Microsoft.Win32.RegistryKey
        home = CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main", True)
        Try
            home.SetValue("Start Page", "about:blank")
        Catch ex As Exception
            home.Close()
        End Try
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AboutBox1.Show()
    End Sub


    Private Sub 显示ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 显示ToolStripMenuItem.Click
        If 显示ToolStripMenuItem.Text = "隐藏" Then
            Me.Visible = False
            Me.WindowState = FormWindowState.Minimized
            显示ToolStripMenuItem.Text = "显示"
        Else
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            Me.TopMost = True
        End If

    End Sub
    Private Sub main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
            显示ToolStripMenuItem.Text = "显示"
        ElseIf WindowState = FormWindowState.Maximized Then
            Me.ShowInTaskbar = True
            显示ToolStripMenuItem.Text = "隐藏"
        Else
            显示ToolStripMenuItem.Text = "隐藏"
        End If
    End Sub
    Private Sub CreateShortcutFile(Title As String, URL As String, SpecialFolder As String)
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Favorites)
        My.Computer.FileSystem.CurrentDirectory = path
        If Not Directory.Exists("地球村") Then
            FileIO.FileSystem.CreateDirectory("地球村")
        End If
        Dim objWriter = System.IO.File.CreateText(SpecialFolder + "\\" + Title + ".url")
        'Dim sw As StreamWriter = New System.IO.StreamWriter("objWriter")
        objWriter.WriteLine("[InternetShortcut]")
        objWriter.WriteLine("URL=" + URL)
        objWriter.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'Dim fav As Microsoft.Win32.RegistryKey
        'Dim favpath As String
        'fav = CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", True)
        'path = fav.GetValue("Favorites")
        'My.Computer.FileSystem.CurrentDirectory = path
        'FileIO.FileSystem.CreateDirectory("地球村")
        'IO.File.Create("地球村\地球村论坛.url")
        'favpath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites)
        ' MsgBox(path)
        Dim favpath As String
        favpath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\" + "地球村"
        CreateShortcutFile(LinkLabel1.Text, Label1.Text, favpath)
        MsgBox("已添加" + LinkLabel1.Text + "到收藏夹！")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim favpath As String
        favpath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\" + "地球村"
        CreateShortcutFile(LinkLabel2.Text, Label2.Text, favpath)
        MsgBox("已添加" + LinkLabel2.Text + "到收藏夹！")
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim favpath As String
        favpath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\" + "地球村"
        CreateShortcutFile(LinkLabel3.Text, Label3.Text, favpath)
        MsgBox("已添加" + LinkLabel3.Text + "到收藏夹！")
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim favpath As String
        favpath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\" + "地球村"
        CreateShortcutFile(LinkLabel5.Text, Label5.Text, favpath)
        MsgBox("已添加" + LinkLabel5.Text + "到收藏夹！")
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim favpath As String
        favpath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\" + "地球村"
        CreateShortcutFile(LinkLabel6.Text, Label6.Text, favpath)
        MsgBox("已添加" + LinkLabel6.Text + "到收藏夹！")
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim favpath As String
        favpath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\" + "地球村"
        CreateShortcutFile(LinkLabel4.Text, Label4.Text, favpath)
        MsgBox("已添加" + LinkLabel4.Text + "到收藏夹！")
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Dim favpath As String
        favpath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\" + "地球村"
        If CheckBox2.Checked Then
            CreateShortcutFile(LinkLabel1.Text, Label1.Text, favpath)
            CreateShortcutFile(LinkLabel2.Text, Label2.Text, favpath)
            CreateShortcutFile(LinkLabel3.Text, Label3.Text, favpath)
            CreateShortcutFile(LinkLabel4.Text, Label4.Text, favpath)
            CreateShortcutFile(LinkLabel5.Text, Label5.Text, favpath)
            CreateShortcutFile(LinkLabel6.Text, Label6.Text, favpath)
            CreateShortcutFile(LinkLabel8.Text, Label10.Text, favpath)
            CreateShortcutFile(LinkLabel9.Text, Label11.Text, favpath)
            MsgBox("已添加以上地址到地球村收藏夹！")
        Else
            Directory.Delete("地球村", True)
            MsgBox("已取消添加收藏！")
            'Try
            '    My.Computer.FileSystem.DeleteDirectory("地球村", FileIO.DeleteDirectoryOption.ThrowIfDirectoryNonEmpty)
            'Catch ex As Exception
            '    MessageBox.Show(ex.ToString)
            'End Try
        End If
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Process.Start(LinkLabel8.Tag.ToString)
    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click
        Process.Start(Label10.Text.ToString)
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim favpath As String
        favpath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\" + "地球村"
        CreateShortcutFile(LinkLabel8.Text, Label10.Text, favpath)
        MsgBox("已添加" + LinkLabel8.Text + "到收藏夹！")
    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Process.Start(LinkLabel9.Tag.ToString)
    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click

        Process.Start("http://doc.evsoft.cn:8080/share/page/site/evsoft/documentlibrary")
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Dim favpath As String
        favpath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\" + "地球村"
        CreateShortcutFile(LinkLabel9.Text, Label11.Text, favpath)
        MsgBox("已添加" + LinkLabel9.Text + "到收藏夹！")
    End Sub

    Private Sub 作者简介ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 作者简介ToolStripMenuItem.Click
        AboutBox2.Show()
    End Sub

    Private Sub main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Exit Sub
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim favpath As String
        favpath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\" + "地球村"
        CreateShortcutFile(LinkLabel10.Text, Label12.Text, favpath)
        MsgBox("已添加" + LinkLabel10.Text + "到收藏夹！")
    End Sub

 
    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        Process.Start(LinkLabel10.Tag.ToString)
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        Process.Start(Label12.Text.ToString)
    End Sub


End Class
