<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        CheckBox1 = New CheckBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLightLight
        Label1.Font = New Font("Microsoft YaHei UI", 30F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(49, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 52)
        Label1.TabIndex = 0
        Label1.Text = "Company"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(40, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 16)
        Label2.TabIndex = 1
        Label2.Text = "Employee Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(61, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 16)
        Label3.TabIndex = 2
        Label3.Text = "Employee ID:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(77, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 16)
        Label4.TabIndex = 3
        Label4.Text = "Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(162, 113)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(152, 25)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(162, 158)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(152, 25)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(162, 211)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(152, 23)
        TextBox3.TabIndex = 6
        TextBox3.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LimeGreen
        Button1.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(107, 307)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(239, 307)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 8
        Button2.Text = "EXIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(181, 240)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(105, 19)
        CheckBox1.TabIndex = 9
        CheckBox1.Text = "ShowPassword"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._212
        PictureBox1.Location = New Point(289, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 89)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(416, 437)
        Controls.Add(PictureBox1)
        Controls.Add(CheckBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
