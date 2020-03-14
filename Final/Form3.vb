Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Public Class Form3
    Dim dice As Integer
    Dim Random As Random
    Dim ServerStatus As Boolean = False
    Dim ServerTrying As Boolean = False
    Dim Server As TcpListener
    Dim Clients As New List(Of TcpClient)
    '  Dim Rx As StreamReader
    '  Dim Dx As StreamWriter

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Startserver()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StopServer()
    End Sub
    Private Sub Btn_dice_Click(sender As Object, e As EventArgs) Handles Btn_dice.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim textbox1 As New TextBox
            Random = New Random
            ProgressBar1.Increment(5)

            If ProgressBar1.Value = 100 Then
                Timer1.Stop()
                If dice = 1 Then
                    If ProgressBar2.Value <= 5 Then
                        ProgressBar2.Value = ProgressBar2.Value = 0
                        MsgBox("You win!")

                    Else
                        textbox1.Text = "Oppoonent used a Handgun!!!  Damage -5"
                        Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, textbox1.Text)
                        ProgressBar2.Value = ProgressBar2.Value - 5

                    End If
                End If
                If dice = 2 Then
                    If ProgressBar2.Value <= 15 Then
                        ProgressBar2.Value = ProgressBar2.Value = 0
                        MsgBox("You win!")
                    Else
                        textbox1.Text = "Opponent Punch You!!!  Damage -15"
                        ProgressBar2.Value = ProgressBar2.Value - 10
                        Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, textbox1.Text)
                    End If
                End If
                If dice = 3 Then
                    If ProgressBar2.Value <= 25 Then
                        ProgressBar2.Value = ProgressBar2.Value = 0
                        MsgBox("You win!")
                    Else
                        textbox1.Text = "Opponent used an Axe!!!  Damage -25"
                        ProgressBar2.Value = ProgressBar2.Value - 15
                        Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, textbox1.Text)

                    End If
                End If
                If dice = 4 Then
                    If ProgressBar2.Value <= 35 Then
                        ProgressBar2.Value = ProgressBar2.Value = 0
                        MsgBox("You win!")
                    Else textbox1.Text = "Opponent used a Sword!!!  Damage -35"
                        ProgressBar2.Value = ProgressBar2.Value - 20
                        Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, textbox1.Text)
                    End If
                End If
                If dice = 5 Then
                    If ProgressBar2.Value <= 25 Then
                        ProgressBar2.Value = ProgressBar2.Value = 0
                        MsgBox("You win!")
                    Else
                        textbox1.Text = "Opponent used Machine Gun!!!  Damage -45"
                        ProgressBar2.Value = ProgressBar2.Value - 25
                        Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, textbox1.Text)
                    End If
                End If
                If dice = 6 Then
                    If ProgressBar2.Value <= 55 Then
                        ProgressBar2.Value = ProgressBar2.Value = 0
                        MsgBox("You win!")
                    Else
                        textbox1.Text = "Opponent Suck!!!!  Damage -55"
                        ProgressBar2.Value = ProgressBar2.Value - 30
                        Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, textbox1.Text)
                    End If
                End If
                ProgressBar1.Value = 0
            Else

                dice = Random.Next(1, 6)
                Select Case (dice)
                                   End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function Startserver()
        If ServerStatus = False Then
            ServerTrying = True
            Try
                Server = New TcpListener(IPAddress.Any, 4305)
                Server.Start()
                ServerStatus = True
                Threading.ThreadPool.QueueUserWorkItem(AddressOf Handler_Client)
            Catch ex As Exception
                ServerStatus = False
            End Try
            ServerTrying = False
        End If
        Return True
    End Function
    Function StopServer()
        If ServerStatus = True Then
            ServerTrying = True
            Try
                For Each Client As TcpClient In Clients
                    Client.Close()
                Next
                Server.Stop()
                ServerStatus = False
            Catch ex As Exception
                StopServer()
            End Try
            ' ServerTrying = False
        End If
        Return True
    End Function
    Function Handler_Client(ByVal state As Object)
        Dim TempClient As TcpClient

        Try
            Using Client As TcpClient = Server.AcceptTcpClient
                ''     Console.Beep()

                If ServerTrying = False Then
                    Threading.ThreadPool.QueueUserWorkItem(AddressOf Handler_Client)
                End If
                Clients.Add(Client)
                TempClient = Client
                Dim TX As New StreamWriter(Client.GetStream)
                Dim RX As New StreamReader(Client.GetStream)
                ' Try
                If RX.BaseStream.CanRead = True Then
                    While RX.BaseStream.CanRead = True
                        Dim RawData As String = RX.ReadLine
                        RichTextBox1.Text += "Player1>>" + RawData + vbNewLine
                        ProgressBar2.Value = ProgressBar3.Value
                    End While
                End If
                If RX.BaseStream.CanRead = False Then
                    Client.Close()
                    Clients.Remove(Client)
                End If
            End Using

            If TempClient.GetStream.CanRead = False Then
                TempClient.Close()
                Clients.Remove(TempClient)
            End If
        Catch ex As Exception
            If TempClient.GetStream.CanRead = False Then
                TempClient.Close()
                Clients.Remove(TempClient)
            End If
        End Try

        Return True
    End Function
    Function SendToClients(ByVal Data As String)
        If ServerStatus = True Then
            If Clients.Count > 0 Then
                Try

                    For Each Client As TcpClient In Clients
                        Dim TX1 As New StreamWriter(Client.GetStream)
                        TX1.WriteLine(Data)
                        TX1.Flush()
                    Next
                Catch ex As Exception
                    SendToClients(Data)
                End Try
            End If
        End If
        Return True
    End Function
End Class