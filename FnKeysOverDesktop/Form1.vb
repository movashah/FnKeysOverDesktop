Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Dim FrmH As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim AllW As Integer = My.Computer.Screen.Bounds.Width '1366
        Dim FrmW As Integer = My.Forms.Form1.Size.Width '937
        FrmH = My.Forms.Form1.Size.Height '68
        My.Forms.Form1.Top = 0
        Dim LefP As Integer = AllW / 2 - FrmW / 2
        If LefP > 0 Then My.Forms.Form1.Left = LefP
        Timer2.Enabled = True
        'MsgBox(FrmH)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        Timer1.Enabled = True
        'MsgBox("GoHide")
    End Sub

    Dim AutoHide As Boolean = True
    Dim FnPanel As Boolean = True
    Dim Tedad As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1
        'Tedad += 1
        'My.Forms.Form1.Top = -58
        'MsgBox(My.Forms.Form1.Top)
        'Timer1.Stop()
        'Timer1.Enabled = False
        'If Tedad > 10 Then Timer1.Enabled = False
        If FnPanel Then
            'MsgBox(My.Forms.Form1.Top + FrmH)
            If My.Forms.Form1.Top + FrmH > 14 Then
                My.Forms.Form1.Top -= 2
                'MsgBox(My.Forms.Form1.Top)
            Else
                Timer1.Enabled = False
                FnPanel = False
                'MsgBox(My.Forms.Form1.Top)
            End If
        Else
            If My.Forms.Form1.Top < 0 Then
                My.Forms.Form1.Top += 2
                'MsgBox(My.Forms.Form1.Top)
            Else
                If AutoHide Then
                    Timer2.Enabled = True
                End If
                Timer1.Enabled = False
                FnPanel = True
                'MsgBox(My.Forms.Form1.Top)
            End If
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'F2
        'Dim ProcID As Integer
        'ProcID = Shell("NOTEPAD.EXE", AppWinStyle.NormalFocus)
        'Dim LasP As IntPtr = Process.GetCurrentProcess().MainWindowHandle
        'MsgBox(LasP)
        'AppActivate(ProcID)
        My.Computer.Keyboard.SendKeys("%{TAB}", True)
        My.Computer.Keyboard.SendKeys("{F2}", True)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If ModifierKeys.HasFlag(Keys.Shift) Then
            Form2.Show()
        Else
            If AutoHide Then
                Timer2.Enabled = False
                AutoHide = False
                Button14.ForeColor = Color.DarkGray
            Else
                Timer2.Enabled = True
                AutoHide = True
                Button14.ForeColor = Color.Blue
            End If
        End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'F1
        My.Computer.Keyboard.SendKeys("%{TAB}", True)
        My.Computer.Keyboard.SendKeys("{F1}", True)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'F3
        My.Computer.Keyboard.SendKeys("%{TAB}", True)
        My.Computer.Keyboard.SendKeys("{F3}", True)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'F4
        My.Computer.Keyboard.SendKeys("%{TAB}", True)
        My.Computer.Keyboard.SendKeys("{F4}", True)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'F5
        My.Computer.Keyboard.SendKeys("%{TAB}", True)
        My.Computer.Keyboard.SendKeys("{F5}", True)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'F6
        My.Computer.Keyboard.SendKeys("%{TAB}", True)
        My.Computer.Keyboard.SendKeys("{F6}", True)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'F7
        My.Computer.Keyboard.SendKeys("%{TAB}", True)
        My.Computer.Keyboard.SendKeys("{F7}", True)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'F8
        My.Computer.Keyboard.SendKeys("%{TAB}", True)
        My.Computer.Keyboard.SendKeys("{F8}", True)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'F9
        My.Computer.Keyboard.SendKeys("%{TAB}", True)
        My.Computer.Keyboard.SendKeys("{F9}", True)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'F10
        My.Computer.Keyboard.SendKeys("%{TAB}", True)
        My.Computer.Keyboard.SendKeys("{F10}", True)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'F11
        My.Computer.Keyboard.SendKeys("%{TAB}", True)
        My.Computer.Keyboard.SendKeys("{F11}", True)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'F12
        My.Computer.Keyboard.SendKeys("%{TAB}", True)
        My.Computer.Keyboard.SendKeys("{F12}", True)
        'Dim oShell = CreateObject("WScript.Shell")
        'oShell.run("%SystemRoot%\System32\SndVol.exe") 'Runs The Master Volume App.
        'For i = 0 To 100000000 : Next
        'oShell.SendKeys("{PGUP}", True) 'Turns Up The Volume 20, If It Is Muted Then It Will Unmute It
        'oShell.SendKeys("%{F4}", True)  ' ALT F4 To Exit The App.
        'My.Computer.Keyboard.SendKeys(ChrW(&HAE), True)

    End Sub
End Class
