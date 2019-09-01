Imports System.Speech.Recognition

Public Class Form1

    Dim GRABA As New SpeechRecognitionEngine
    Dim PALABRA As String

    Dim cadenaEntrada As String
    Dim cadenaSalida As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim VOCABULARIO As New GrammarBuilder
        VOCABULARIO.Append(New Choices("encender cocina", "encender cuarto", "encender sala", "encender baño", "encender todo",
                                       "apagar cocina", "apagar cuarto", "apagar sala", "apagar baño", "apagar todo"))
        GRABA.LoadGrammar(New Grammar(VOCABULARIO))

        GRABA.SetInputToDefaultAudioDevice()
        GRABA.RecognizeAsync(RecognizeMode.Multiple)
        AddHandler GRABA.SpeechRecognized, AddressOf RECONOCE

        cadenaEntrada = ""
        cadenaSalida = ""
        btnConectar.Enabled = False
        btnEnviar.Enabled = False
        Timer1.Enabled = False

    End Sub

    Public Sub RECONOCE(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs)
        Dim RESULTADO As RecognitionResult
        RESULTADO = e.Result
        PALABRA = RESULTADO.Text
        txt_TextoRec.Text = RESULTADO.Text

        If btnEnviar.Enabled = True Then
            If PALABRA = "encender cocina" Then
                cadenaSalida = "a"
                USBConex.Write(cadenaSalida)
            End If
            If PALABRA = "encender cuarto" Then
                cadenaSalida = "e"
                USBConex.Write(cadenaSalida)
            End If
            If PALABRA = "encender sala" Then
                cadenaSalida = "i"
                USBConex.Write(cadenaSalida)
            End If
            If PALABRA = "encender baño" Then
                cadenaSalida = "o"
                USBConex.Write(cadenaSalida)
            End If

            If PALABRA = "apagar cocina" Then
                cadenaSalida = "A "
                USBConex.Write(cadenaSalida)
            End If
            If PALABRA = "apagar cuarto" Then
                cadenaSalida = "E"
                USBConex.Write(cadenaSalida)
            End If
            If PALABRA = "apagar sala" Then
                cadenaSalida = "I"
                USBConex.Write(cadenaSalida)
            End If
            If PALABRA = "apagar baño" Then
                cadenaSalida = "O"
                USBConex.Write(cadenaSalida)
            End If

            If PALABRA = "encender todo" Then
                cadenaSalida = "X"
                USBConex.Write(cadenaSalida)
            End If
            If PALABRA = "apagar todo" Then
                cadenaSalida = "T"
                USBConex.Write(cadenaSalida)
            End If

        End If

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnDeterminar_Click(sender As Object, e As EventArgs) Handles btnDeterminar.Click
        cmbPuertos.Items.Clear()
        For Each puertoDisponible As String In My.Computer.Ports.SerialPortNames 'se almacenarán en esta variable >puertoDisponible
            cmbPuertos.Items.Add(puertoDisponible)
        Next

        If cmbPuertos.Items.Count > 0 Then
            cmbPuertos.Text = cmbPuertos.Items(0) 'va a encontrar el primer elemento que es 0
            MessageBox.Show("Seleccione el puerto a utilizar")
            btnConectar.Enabled = True
        Else
            MessageBox.Show("Ningun puerto encontrado :( ")
            btnConectar.Enabled = False
            btnEnviar.Enabled = False
            cmbPuertos.Items.Clear()
            cmbPuertos.Text = ""

        End If
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        If btnConectar.Text = "Conectar" Then
            USBConex.PortName = cmbPuertos.Text
            btnConectar.Text = "Desconectar"
            btnEnviar.Enabled = True
            Timer1.Enabled = True
            USBConex.Open()
        Else
            btnConectar.Text = "Conectar"
            btnEnviar.Enabled = False
            Timer1.Enabled = False
            USBConex.Close()

        End If
    End Sub

    Sub enviar()
        USBConex.DiscardInBuffer()
        cadenaSalida = txt_TextoRec.Text()
        USBConex.Write(cadenaSalida)
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        enviar()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cadenaEntrada = USBConex.ReadExisting
        If cadenaEntrada <> "" Then
            txtRecibe.Text = txtRecibe.Text + cadenaEntrada
            cadenaEntrada = ""
            USBConex.DiscardInBuffer()
        End If

    End Sub

    Private Sub txt_TextoRec_TextChanged(sender As Object, e As EventArgs) Handles txt_TextoRec.TextChanged
    End Sub
End Class
