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
        Math = New TextBox()
        Oral = New TextBox()
        Physical = New TextBox()
        Average = New TextBox()
        comprog = New TextBox()
        Remarks = New TextBox()
        compute = New Button()
        Label1 = New Label()
        PE = New Label()
        OC = New Label()
        CP = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Grade = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Math
        ' 
        Math.Location = New Point(96, 119)
        Math.Name = "Math"
        Math.Size = New Size(153, 23)
        Math.TabIndex = 0
        ' 
        ' Oral
        ' 
        Oral.Location = New Point(296, 119)
        Oral.Name = "Oral"
        Oral.Size = New Size(153, 23)
        Oral.TabIndex = 1
        ' 
        ' Physical
        ' 
        Physical.Location = New Point(96, 200)
        Physical.Name = "Physical"
        Physical.Size = New Size(153, 23)
        Physical.TabIndex = 2
        ' 
        ' Average
        ' 
        Average.Location = New Point(96, 364)
        Average.Name = "Average"
        Average.Size = New Size(100, 23)
        Average.TabIndex = 3
        ' 
        ' comprog
        ' 
        comprog.Location = New Point(296, 200)
        comprog.Name = "comprog"
        comprog.Size = New Size(153, 23)
        comprog.TabIndex = 4
        ' 
        ' Remarks
        ' 
        Remarks.Location = New Point(225, 364)
        Remarks.Name = "Remarks"
        Remarks.Size = New Size(100, 23)
        Remarks.TabIndex = 5
        ' 
        ' compute
        ' 
        compute.Location = New Point(205, 275)
        compute.Name = "compute"
        compute.Size = New Size(132, 38)
        compute.TabIndex = 6
        compute.Text = "Compute"
        compute.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(96, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 7
        Label1.Text = "Math:"
        ' 
        ' PE
        ' 
        PE.AutoSize = True
        PE.Location = New Point(96, 182)
        PE.Name = "PE"
        PE.Size = New Size(24, 15)
        PE.TabIndex = 8
        PE.Text = "P.E:"
        ' 
        ' OC
        ' 
        OC.AutoSize = True
        OC.Location = New Point(296, 101)
        OC.Name = "OC"
        OC.Size = New Size(123, 15)
        OC.TabIndex = 9
        OC.Text = "Oral Communication:"
        ' 
        ' CP
        ' 
        CP.AutoSize = True
        CP.Location = New Point(296, 182)
        CP.Name = "CP"
        CP.Size = New Size(145, 15)
        CP.TabIndex = 10
        CP.Text = "Computer Programming:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(119, 390)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 15)
        Label5.TabIndex = 11
        Label5.Text = "Average"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(250, 390)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 12
        Label6.Text = "Remarks"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(371, 390)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 14
        Label7.Text = "Grade"
        ' 
        ' Grade
        ' 
        Grade.Location = New Point(349, 364)
        Grade.Name = "Grade"
        Grade.Size = New Size(100, 23)
        Grade.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(214, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 30)
        Label2.TabIndex = 15
        Label2.Text = "Computer"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(225, 435)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 23)
        Button1.TabIndex = 16
        Button1.Text = "Next "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(552, 470)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(Grade)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(CP)
        Controls.Add(OC)
        Controls.Add(PE)
        Controls.Add(Label1)
        Controls.Add(compute)
        Controls.Add(Remarks)
        Controls.Add(comprog)
        Controls.Add(Average)
        Controls.Add(Physical)
        Controls.Add(Oral)
        Controls.Add(Math)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Math As TextBox
    Friend WithEvents Oral As TextBox
    Friend WithEvents Physical As TextBox
    Friend WithEvents Average As TextBox
    Friend WithEvents comprog As TextBox
    Friend WithEvents Remarks As TextBox
    Friend WithEvents compute As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PE As Label
    Friend WithEvents OC As Label
    Friend WithEvents CP As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Grade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
