<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.gbox_preg1 = New System.Windows.Forms.GroupBox()
        Me.radioB_correcto_1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lab_time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbox_preg1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbox_preg1
        '
        Me.gbox_preg1.BackColor = System.Drawing.Color.SkyBlue
        Me.gbox_preg1.Controls.Add(Me.radioB_correcto_1)
        Me.gbox_preg1.Controls.Add(Me.RadioButton2)
        Me.gbox_preg1.Controls.Add(Me.RadioButton1)
        Me.gbox_preg1.Controls.Add(Me.Button1)
        Me.gbox_preg1.Controls.Add(Me.Label2)
        Me.gbox_preg1.Location = New System.Drawing.Point(14, 45)
        Me.gbox_preg1.Name = "gbox_preg1"
        Me.gbox_preg1.Size = New System.Drawing.Size(564, 249)
        Me.gbox_preg1.TabIndex = 13
        Me.gbox_preg1.TabStop = False
        Me.gbox_preg1.Text = "Pregunta 5"
        '
        'radioB_correcto_1
        '
        Me.radioB_correcto_1.AutoSize = True
        Me.radioB_correcto_1.Location = New System.Drawing.Point(31, 151)
        Me.radioB_correcto_1.Name = "radioB_correcto_1"
        Me.radioB_correcto_1.Size = New System.Drawing.Size(170, 19)
        Me.radioB_correcto_1.TabIndex = 15
        Me.radioB_correcto_1.Text = "Google Lens, Ingress, Layar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.radioB_correcto_1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(31, 115)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(172, 19)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.Text = "Whatsapp, Facebook, Twiter"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(31, 76)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(144, 19)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.Text = "Gmail, Hotmail, Yahoo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(231, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 34)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Responder"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(509, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "¿Cuales de las siguientes aplicaciones corresponden a Realidad Aumentada?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(245, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Quiz"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(431, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Te quedan"
        '
        'lab_time
        '
        Me.lab_time.AutoSize = True
        Me.lab_time.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lab_time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lab_time.Location = New System.Drawing.Point(534, 13)
        Me.lab_time.Name = "lab_time"
        Me.lab_time.Size = New System.Drawing.Size(0, 14)
        Me.lab_time.TabIndex = 18
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 309)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lab_time)
        Me.Controls.Add(Me.gbox_preg1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.gbox_preg1.ResumeLayout(False)
        Me.gbox_preg1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbox_preg1 As GroupBox
    Friend WithEvents radioB_correcto_1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lab_time As Label
    Friend WithEvents Timer1 As Timer
End Class
