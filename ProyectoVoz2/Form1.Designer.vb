<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txt_TextoRec = New System.Windows.Forms.TextBox()
        Me.btnDeterminar = New System.Windows.Forms.Button()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.cmbPuertos = New System.Windows.Forms.ComboBox()
        Me.txtEnviar = New System.Windows.Forms.TextBox()
        Me.txtRecibe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.USBConex = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txt_TextoRec
        '
        Me.txt_TextoRec.Location = New System.Drawing.Point(392, 28)
        Me.txt_TextoRec.Name = "txt_TextoRec"
        Me.txt_TextoRec.Size = New System.Drawing.Size(100, 20)
        Me.txt_TextoRec.TabIndex = 0
        '
        'btnDeterminar
        '
        Me.btnDeterminar.Location = New System.Drawing.Point(22, 12)
        Me.btnDeterminar.Name = "btnDeterminar"
        Me.btnDeterminar.Size = New System.Drawing.Size(135, 23)
        Me.btnDeterminar.TabIndex = 1
        Me.btnDeterminar.Text = "Determinar conexión"
        Me.btnDeterminar.UseVisualStyleBackColor = True
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(239, 88)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(75, 23)
        Me.btnConectar.TabIndex = 2
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(239, 163)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 3
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'cmbPuertos
        '
        Me.cmbPuertos.FormattingEnabled = True
        Me.cmbPuertos.Location = New System.Drawing.Point(22, 90)
        Me.cmbPuertos.Name = "cmbPuertos"
        Me.cmbPuertos.Size = New System.Drawing.Size(164, 21)
        Me.cmbPuertos.TabIndex = 4
        '
        'txtEnviar
        '
        Me.txtEnviar.Location = New System.Drawing.Point(22, 163)
        Me.txtEnviar.Name = "txtEnviar"
        Me.txtEnviar.Size = New System.Drawing.Size(193, 20)
        Me.txtEnviar.TabIndex = 5
        '
        'txtRecibe
        '
        Me.txtRecibe.Location = New System.Drawing.Point(22, 234)
        Me.txtRecibe.Multiline = True
        Me.txtRecibe.Name = "txtRecibe"
        Me.txtRecibe.Size = New System.Drawing.Size(193, 105)
        Me.txtRecibe.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Lista de puertos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Datos a enviar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Datos recibidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Reconocer voz"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 426)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRecibe)
        Me.Controls.Add(Me.txtEnviar)
        Me.Controls.Add(Me.cmbPuertos)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.btnDeterminar)
        Me.Controls.Add(Me.txt_TextoRec)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_TextoRec As System.Windows.Forms.TextBox
    Friend WithEvents btnDeterminar As System.Windows.Forms.Button
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents cmbPuertos As System.Windows.Forms.ComboBox
    Friend WithEvents txtEnviar As System.Windows.Forms.TextBox
    Friend WithEvents txtRecibe As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents USBConex As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
