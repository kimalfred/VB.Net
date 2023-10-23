<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        cmdday2 = New ComboBox()
        bday = New ListBox()
        txtname = New TextBox()
        cmdday = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        Label12 = New Label()
        Button1 = New Button()
        emailtxt = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        addresstxt = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        sectiontxt = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        coursetxt = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        nametxt = New TextBox()
        lbl1 = New Label()
        Listbox = New ListBox()
        Label3 = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(0, 2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(705, 470)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Button2)
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(697, 442)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(344, 406)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 1
        Button2.Text = "SUBMIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cmdday2)
        GroupBox1.Controls.Add(bday)
        GroupBox1.Controls.Add(txtname)
        GroupBox1.Controls.Add(cmdday)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(143, 48)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(461, 335)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' cmdday2
        ' 
        cmdday2.FormattingEnabled = True
        cmdday2.Items.AddRange(New Object() {"Monday ", "Tuesday", "Wednesday", "Thursday", "Friday ", "Saturday", "Sunday"})
        cmdday2.Location = New Point(314, 69)
        cmdday2.Name = "cmdday2"
        cmdday2.Size = New Size(121, 23)
        cmdday2.TabIndex = 6
        ' 
        ' bday
        ' 
        bday.FormattingEnabled = True
        bday.ItemHeight = 15
        bday.Items.AddRange(New Object() {"January", "Febuary", "March", "April ", "May ", "June ", "July ", "August ", "September", "October ", "November", "December"})
        bday.Location = New Point(136, 133)
        bday.Name = "bday"
        bday.Size = New Size(186, 169)
        bday.TabIndex = 5
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(115, 22)
        txtname.Name = "txtname"
        txtname.Size = New Size(100, 23)
        txtname.TabIndex = 4
        ' 
        ' cmdday
        ' 
        cmdday.FormattingEnabled = True
        cmdday.Items.AddRange(New Object() {"1 ", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        cmdday.Location = New Point(171, 69)
        cmdday.Name = "cmdday"
        cmdday.Size = New Size(121, 23)
        cmdday.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 2
        Label2.Text = "Days of the week"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label12)
        TabPage2.Controls.Add(Button1)
        TabPage2.Controls.Add(emailtxt)
        TabPage2.Controls.Add(Label10)
        TabPage2.Controls.Add(Label11)
        TabPage2.Controls.Add(addresstxt)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(sectiontxt)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(coursetxt)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(nametxt)
        TabPage2.Controls.Add(lbl1)
        TabPage2.Controls.Add(Listbox)
        TabPage2.Controls.Add(Label3)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(697, 442)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(202, 19)
        Label12.Name = "Label12"
        Label12.Size = New Size(247, 22)
        Label12.TabIndex = 17
        Label12.Text = "STUDENT INFORMATION"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(293, 352)
        Button1.Name = "Button1"
        Button1.Size = New Size(123, 33)
        Button1.TabIndex = 16
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' emailtxt
        ' 
        emailtxt.Location = New Point(112, 284)
        emailtxt.Name = "emailtxt"
        emailtxt.Size = New Size(170, 23)
        emailtxt.TabIndex = 15
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(31, 284)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 19)
        Label10.TabIndex = 14
        Label10.Text = "Email :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(31, 248)
        Label11.Name = "Label11"
        Label11.Size = New Size(0, 15)
        Label11.TabIndex = 13
        ' 
        ' addresstxt
        ' 
        addresstxt.Location = New Point(112, 238)
        addresstxt.Name = "addresstxt"
        addresstxt.Size = New Size(170, 23)
        addresstxt.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(31, 238)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 19)
        Label8.TabIndex = 11
        Label8.Text = "Address :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(31, 204)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 15)
        Label9.TabIndex = 10
        ' 
        ' sectiontxt
        ' 
        sectiontxt.Location = New Point(112, 191)
        sectiontxt.Name = "sectiontxt"
        sectiontxt.Size = New Size(170, 23)
        sectiontxt.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(31, 191)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 19)
        Label6.TabIndex = 8
        Label6.Text = "Section :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(31, 162)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 7
        ' 
        ' coursetxt
        ' 
        coursetxt.Location = New Point(112, 143)
        coursetxt.Name = "coursetxt"
        coursetxt.Size = New Size(170, 23)
        coursetxt.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(31, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 19)
        Label4.TabIndex = 5
        Label4.Text = "Course :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(31, 104)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 4
        ' 
        ' nametxt
        ' 
        nametxt.Location = New Point(112, 92)
        nametxt.Name = "nametxt"
        nametxt.Size = New Size(170, 23)
        nametxt.TabIndex = 3
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbl1.Location = New Point(31, 92)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(58, 19)
        lbl1.TabIndex = 2
        lbl1.Text = "Name :"
        ' 
        ' Listbox
        ' 
        Listbox.FormattingEnabled = True
        Listbox.ItemHeight = 15
        Listbox.Location = New Point(346, 92)
        Listbox.Name = "Listbox"
        Listbox.Size = New Size(320, 214)
        Listbox.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 0
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(701, 467)
        Controls.Add(TabControl1)
        Name = "Form2"
        Text = "Form2"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents bday As ListBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents cmdday As ComboBox
    Friend WithEvents nametxt As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents Listbox As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents coursetxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents addresstxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents sectiontxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents cmdday2 As ComboBox
End Class
