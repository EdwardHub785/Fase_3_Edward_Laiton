<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txt_1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txt_2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txt_3 = New System.Windows.Forms.Label()
        Me.Btn_1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_1
        '
        Me.txt_1.AutoSize = True
        Me.txt_1.Location = New System.Drawing.Point(99, 67)
        Me.txt_1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(166, 18)
        Me.txt_1.TabIndex = 0
        Me.txt_1.Text = "Escoja una variable"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Velocidad", "Tiempo", "Distancia"})
        Me.ComboBox1.Location = New System.Drawing.Point(99, 101)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(171, 26)
        Me.ComboBox1.TabIndex = 1
        '
        'txt_2
        '
        Me.txt_2.AutoSize = True
        Me.txt_2.Location = New System.Drawing.Point(376, 67)
        Me.txt_2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_2.Name = "txt_2"
        Me.txt_2.Size = New System.Drawing.Size(170, 18)
        Me.txt_2.TabIndex = 2
        Me.txt_2.Text = "Escoja otra variable"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Velocidad", "Tiempo", "Distancia"})
        Me.ComboBox2.Location = New System.Drawing.Point(376, 101)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(171, 26)
        Me.ComboBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(99, 186)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 26)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(376, 186)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(171, 26)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(657, 101)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(299, 26)
        Me.TextBox3.TabIndex = 6
        '
        'txt_3
        '
        Me.txt_3.AutoSize = True
        Me.txt_3.Location = New System.Drawing.Point(657, 67)
        Me.txt_3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_3.Name = "txt_3"
        Me.txt_3.Size = New System.Drawing.Size(90, 18)
        Me.txt_3.TabIndex = 7
        Me.txt_3.Text = "Resultado"
        '
        'Btn_1
        '
        Me.Btn_1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Btn_1.Enabled = False
        Me.Btn_1.Location = New System.Drawing.Point(99, 329)
        Me.Btn_1.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_1.Name = "Btn_1"
        Me.Btn_1.Padding = New System.Windows.Forms.Padding(4)
        Me.Btn_1.Size = New System.Drawing.Size(122, 45)
        Me.Btn_1.TabIndex = 8
        Me.Btn_1.Text = "Calcular"
        Me.Btn_1.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(657, 329)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(4)
        Me.Button1.Size = New System.Drawing.Size(122, 45)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(99, 146)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(171, 26)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(377, 146)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(170, 26)
        Me.TextBox5.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gold
        Me.Button2.Location = New System.Drawing.Point(376, 329)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(4)
        Me.Button2.Size = New System.Drawing.Size(122, 45)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1143, 540)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_1)
        Me.Controls.Add(Me.txt_3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.txt_2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txt_1)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txt_2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txt_3 As Label
    Friend WithEvents Btn_1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button2 As Button
End Class
