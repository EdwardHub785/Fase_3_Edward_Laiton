<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.radioB_4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.radioB_correcto_3 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lab_time = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbox_preg1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbox_preg1
        '
        Me.gbox_preg1.BackColor = System.Drawing.Color.SkyBlue
        Me.gbox_preg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbox_preg1.Controls.Add(Me.radioB_4)
        Me.gbox_preg1.Controls.Add(Me.RadioButton5)
        Me.gbox_preg1.Controls.Add(Me.radioB_correcto_3)
        Me.gbox_preg1.Controls.Add(Me.Label3)
        Me.gbox_preg1.Controls.Add(Me.Button1)
        Me.gbox_preg1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbox_preg1.Location = New System.Drawing.Point(11, 55)
        Me.gbox_preg1.Name = "gbox_preg1"
        Me.gbox_preg1.Size = New System.Drawing.Size(564, 249)
        Me.gbox_preg1.TabIndex = 15
        Me.gbox_preg1.TabStop = False
        Me.gbox_preg1.Text = "Pregunta 3"
        '
        'radioB_4
        '
        Me.radioB_4.AutoSize = True
        Me.radioB_4.Location = New System.Drawing.Point(47, 72)
        Me.radioB_4.Name = "radioB_4"
        Me.radioB_4.Size = New System.Drawing.Size(194, 19)
        Me.radioB_4.TabIndex = 16
        Me.radioB_4.Text = "Destonillador, Alicates, Llave fija"
        Me.radioB_4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(47, 104)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(245, 19)
        Me.RadioButton5.TabIndex = 15
        Me.RadioButton5.Text = "Reloj Inteligente, Antena 3D, Lentes de sol"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'radioB_correcto_3
        '
        Me.radioB_correcto_3.AutoSize = True
        Me.radioB_correcto_3.Location = New System.Drawing.Point(47, 140)
        Me.radioB_correcto_3.Name = "radioB_correcto_3"
        Me.radioB_correcto_3.Size = New System.Drawing.Size(232, 19)
        Me.radioB_correcto_3.TabIndex = 14
        Me.radioB_correcto_3.Text = "Camara, Hardware, Software, Marcador"
        Me.radioB_correcto_3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(11, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(400, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "¿Escoja los elementos utilizados en la Realidad Aumentada?"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(231, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 34)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Responder"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(242, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Quiz"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lab_time
        '
        Me.lab_time.AutoSize = True
        Me.lab_time.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lab_time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lab_time.Location = New System.Drawing.Point(524, 23)
        Me.lab_time.Name = "lab_time"
        Me.lab_time.Size = New System.Drawing.Size(0, 14)
        Me.lab_time.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(421, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Te quedan"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(586, 348)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lab_time)
        Me.Controls.Add(Me.gbox_preg1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form8"
        Me.Text = "Form8"
        Me.gbox_preg1.ResumeLayout(False)
        Me.gbox_preg1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbox_preg1 As GroupBox
    Friend WithEvents radioB_4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents radioB_correcto_3 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lab_time As Label
    Friend WithEvents Label2 As Label
End Class
