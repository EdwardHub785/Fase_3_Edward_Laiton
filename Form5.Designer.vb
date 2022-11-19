<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.lab_1 = New System.Windows.Forms.Label()
        Me.txt_inp = New System.Windows.Forms.TextBox()
        Me.lab_seno = New System.Windows.Forms.Label()
        Me.lab_coseno = New System.Windows.Forms.Label()
        Me.lab_tangente = New System.Windows.Forms.Label()
        Me.lab_Ctangente = New System.Windows.Forms.Label()
        Me.txt_seno = New System.Windows.Forms.TextBox()
        Me.txt_cos = New System.Windows.Forms.TextBox()
        Me.txt_tang = New System.Windows.Forms.TextBox()
        Me.txt_ctan = New System.Windows.Forms.TextBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lab_1
        '
        Me.lab_1.AutoSize = True
        Me.lab_1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lab_1.Location = New System.Drawing.Point(135, 71)
        Me.lab_1.Name = "lab_1"
        Me.lab_1.Size = New System.Drawing.Size(120, 14)
        Me.lab_1.TabIndex = 0
        Me.lab_1.Text = "Digite un número"
        '
        'txt_inp
        '
        Me.txt_inp.Location = New System.Drawing.Point(135, 111)
        Me.txt_inp.Name = "txt_inp"
        Me.txt_inp.Size = New System.Drawing.Size(100, 23)
        Me.txt_inp.TabIndex = 1
        '
        'lab_seno
        '
        Me.lab_seno.AutoSize = True
        Me.lab_seno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lab_seno.Location = New System.Drawing.Point(333, 119)
        Me.lab_seno.Name = "lab_seno"
        Me.lab_seno.Size = New System.Drawing.Size(62, 16)
        Me.lab_seno.TabIndex = 2
        Me.lab_seno.Text = "Su Seno"
        Me.lab_seno.Visible = False
        '
        'lab_coseno
        '
        Me.lab_coseno.AutoSize = True
        Me.lab_coseno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lab_coseno.Location = New System.Drawing.Point(333, 154)
        Me.lab_coseno.Name = "lab_coseno"
        Me.lab_coseno.Size = New System.Drawing.Size(77, 16)
        Me.lab_coseno.TabIndex = 3
        Me.lab_coseno.Text = "Su Coseno"
        Me.lab_coseno.Visible = False
        '
        'lab_tangente
        '
        Me.lab_tangente.AutoSize = True
        Me.lab_tangente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lab_tangente.Location = New System.Drawing.Point(333, 187)
        Me.lab_tangente.Name = "lab_tangente"
        Me.lab_tangente.Size = New System.Drawing.Size(90, 16)
        Me.lab_tangente.TabIndex = 4
        Me.lab_tangente.Text = "Su Tangente"
        Me.lab_tangente.Visible = False
        '
        'lab_Ctangente
        '
        Me.lab_Ctangente.AutoSize = True
        Me.lab_Ctangente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lab_Ctangente.Location = New System.Drawing.Point(333, 219)
        Me.lab_Ctangente.Name = "lab_Ctangente"
        Me.lab_Ctangente.Size = New System.Drawing.Size(106, 16)
        Me.lab_Ctangente.TabIndex = 5
        Me.lab_Ctangente.Text = "Su Cotangente"
        Me.lab_Ctangente.Visible = False
        '
        'txt_seno
        '
        Me.txt_seno.Enabled = False
        Me.txt_seno.Location = New System.Drawing.Point(449, 111)
        Me.txt_seno.Name = "txt_seno"
        Me.txt_seno.Size = New System.Drawing.Size(100, 23)
        Me.txt_seno.TabIndex = 6
        Me.txt_seno.Visible = False
        '
        'txt_cos
        '
        Me.txt_cos.Enabled = False
        Me.txt_cos.Location = New System.Drawing.Point(449, 146)
        Me.txt_cos.Name = "txt_cos"
        Me.txt_cos.Size = New System.Drawing.Size(100, 23)
        Me.txt_cos.TabIndex = 7
        Me.txt_cos.Visible = False
        '
        'txt_tang
        '
        Me.txt_tang.Enabled = False
        Me.txt_tang.Location = New System.Drawing.Point(449, 179)
        Me.txt_tang.Name = "txt_tang"
        Me.txt_tang.Size = New System.Drawing.Size(100, 23)
        Me.txt_tang.TabIndex = 8
        Me.txt_tang.Visible = False
        '
        'txt_ctan
        '
        Me.txt_ctan.Enabled = False
        Me.txt_ctan.Location = New System.Drawing.Point(449, 211)
        Me.txt_ctan.Name = "txt_ctan"
        Me.txt_ctan.Size = New System.Drawing.Size(100, 23)
        Me.txt_ctan.TabIndex = 9
        Me.txt_ctan.Visible = False
        '
        'btn_calcular
        '
        Me.btn_calcular.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_calcular.Enabled = False
        Me.btn_calcular.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_calcular.Location = New System.Drawing.Point(135, 150)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(100, 31)
        Me.btn_calcular.TabIndex = 10
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(135, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 31)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.txt_ctan)
        Me.Controls.Add(Me.txt_tang)
        Me.Controls.Add(Me.txt_cos)
        Me.Controls.Add(Me.txt_seno)
        Me.Controls.Add(Me.lab_Ctangente)
        Me.Controls.Add(Me.lab_tangente)
        Me.Controls.Add(Me.lab_coseno)
        Me.Controls.Add(Me.lab_seno)
        Me.Controls.Add(Me.txt_inp)
        Me.Controls.Add(Me.lab_1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lab_1 As Label
    Friend WithEvents txt_inp As TextBox
    Friend WithEvents lab_seno As Label
    Friend WithEvents lab_coseno As Label
    Friend WithEvents lab_tangente As Label
    Friend WithEvents lab_Ctangente As Label
    Friend WithEvents txt_seno As TextBox
    Friend WithEvents txt_cos As TextBox
    Friend WithEvents txt_tang As TextBox
    Friend WithEvents txt_ctan As TextBox
    Friend WithEvents btn_calcular As Button
    Friend WithEvents Button1 As Button
End Class
