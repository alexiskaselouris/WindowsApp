Public Class Form1

    Function ReceiveSerialData() As String
        ' Receive strings from a serial port.
        Dim returnStr As String = ""

        Dim com1 As IO.Ports.SerialPort = Nothing
        Dim port As String = TextBox1.Text

        com1 = My.Computer.Ports.OpenSerialPort(port)

        com1.ReadTimeout = 10000
        com1.BaudRate = 9600
        com1.DataBits = 8
        com1.Parity = IO.Ports.Parity.None
        com1.StopBits = IO.Ports.StopBits.One
        com1.Handshake = IO.Ports.Handshake.None
        com1.Encoding = System.Text.Encoding.Default



        Dim Incoming As String = com1.ReadExisting()
        returnStr = Incoming & vbCrLf

        Return returnStr


    End Function




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Label1.Text = (ReceiveSerialData())


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
