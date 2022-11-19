<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.lab_error = New System.Windows.Forms.Label()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.error_p = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lab_tem = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.error_p, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(297, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digite su Usuario"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(297, 83)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(193, 23)
        Me.txt_usuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(297, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Digite su Contraseña"
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(297, 161)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(193, 23)
        Me.txt_contraseña.TabIndex = 3
        Me.txt_contraseña.UseSystemPasswordChar = True
        '
        'lab_error
        '
        Me.lab_error.AutoSize = True
        Me.lab_error.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lab_error.ForeColor = System.Drawing.Color.Red
        Me.lab_error.Location = New System.Drawing.Point(297, 218)
        Me.lab_error.Name = "lab_error"
        Me.lab_error.Size = New System.Drawing.Size(155, 18)
        Me.lab_error.TabIndex = 4
        Me.lab_error.Text = "Datos Incorrectos"
        Me.lab_error.Visible = False
        '
        'btn_ingresar
        '
        Me.btn_ingresar.BackColor = System.Drawing.Color.Navy
        Me.btn_ingresar.Enabled = False
        Me.btn_ingresar.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_ingresar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_ingresar.Location = New System.Drawing.Point(297, 276)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(116, 38)
        Me.btn_ingresar.TabIndex = 5
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = False
        '
        'error_p
        '
        Me.error_p.ContainerControl = Me
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lab_tem
        '
        Me.lab_tem.AutoSize = True
        Me.lab_tem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lab_tem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lab_tem.Location = New System.Drawing.Point(670, 24)
        Me.lab_tem.Name = "lab_tem"
        Me.lab_tem.Size = New System.Drawing.Size(0, 16)
        Me.lab_tem.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(600, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tienes"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(695, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "para ingresar"
        Me.Label4.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(473, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 38)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 428)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lab_tem)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.lab_error)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.error_p, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents lab_error As Label
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents error_p As ErrorProvider
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lab_tem As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
