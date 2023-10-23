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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        EmployeeName = New TextBox()
        RatePerHour = New TextBox()
        HourPerDay = New TextBox()
        MonthlyWage = New TextBox()
        PhilHealth = New TextBox()
        SSS = New TextBox()
        GrossSalary = New TextBox()
        Deduction = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        GrossSalary1 = New TextBox()
        TotalDeduction = New TextBox()
        NetSalary = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Compute = New Button()
        Label13 = New Label()
        NOofDays = New TextBox()
        Label14 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(73, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 16)
        Label1.TabIndex = 0
        Label1.Text = "Employee Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(73, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 16)
        Label2.TabIndex = 1
        Label2.Text = "Rate Per Hour:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(73, 233)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 16)
        Label3.TabIndex = 2
        Label3.Text = "Hours Per Day:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(230, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 16)
        Label4.TabIndex = 3
        Label4.Text = "Tax 10% "
        ' 
        ' EmployeeName
        ' 
        EmployeeName.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        EmployeeName.Location = New Point(73, 103)
        EmployeeName.Name = "EmployeeName"
        EmployeeName.Size = New Size(117, 25)
        EmployeeName.TabIndex = 4
        ' 
        ' RatePerHour
        ' 
        RatePerHour.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        RatePerHour.Location = New Point(73, 174)
        RatePerHour.Name = "RatePerHour"
        RatePerHour.Size = New Size(117, 25)
        RatePerHour.TabIndex = 5
        ' 
        ' HourPerDay
        ' 
        HourPerDay.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        HourPerDay.Location = New Point(73, 251)
        HourPerDay.Name = "HourPerDay"
        HourPerDay.Size = New Size(117, 25)
        HourPerDay.TabIndex = 6
        ' 
        ' MonthlyWage
        ' 
        MonthlyWage.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        MonthlyWage.Location = New Point(230, 103)
        MonthlyWage.Name = "MonthlyWage"
        MonthlyWage.Size = New Size(118, 25)
        MonthlyWage.TabIndex = 7
        ' 
        ' PhilHealth
        ' 
        PhilHealth.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PhilHealth.Location = New Point(230, 174)
        PhilHealth.Name = "PhilHealth"
        PhilHealth.Size = New Size(118, 25)
        PhilHealth.TabIndex = 15
        ' 
        ' SSS
        ' 
        SSS.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SSS.Location = New Point(230, 251)
        SSS.Name = "SSS"
        SSS.Size = New Size(118, 25)
        SSS.TabIndex = 14
        ' 
        ' GrossSalary
        ' 
        GrossSalary.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        GrossSalary.Location = New Point(385, 103)
        GrossSalary.Name = "GrossSalary"
        GrossSalary.Size = New Size(118, 25)
        GrossSalary.TabIndex = 13
        ' 
        ' Deduction
        ' 
        Deduction.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Deduction.Location = New Point(385, 174)
        Deduction.Name = "Deduction"
        Deduction.Size = New Size(118, 25)
        Deduction.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(230, 156)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 16)
        Label5.TabIndex = 11
        Label5.Text = "PhilHealth 4%"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(230, 233)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 16)
        Label6.TabIndex = 10
        Label6.Text = "SSS 2%"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(385, 85)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 16)
        Label7.TabIndex = 9
        Label7.Text = "Gross Salary"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(385, 156)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 16)
        Label8.TabIndex = 8
        Label8.Text = "Deduction"
        ' 
        ' GrossSalary1
        ' 
        GrossSalary1.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        GrossSalary1.Location = New Point(73, 421)
        GrossSalary1.Name = "GrossSalary1"
        GrossSalary1.Size = New Size(100, 25)
        GrossSalary1.TabIndex = 22
        ' 
        ' TotalDeduction
        ' 
        TotalDeduction.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        TotalDeduction.Location = New Point(230, 421)
        TotalDeduction.Name = "TotalDeduction"
        TotalDeduction.Size = New Size(100, 25)
        TotalDeduction.TabIndex = 21
        ' 
        ' NetSalary
        ' 
        NetSalary.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        NetSalary.Location = New Point(385, 422)
        NetSalary.Name = "NetSalary"
        NetSalary.Size = New Size(100, 25)
        NetSalary.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.DarkRed
        Label10.Location = New Point(73, 403)
        Label10.Name = "Label10"
        Label10.Size = New Size(93, 16)
        Label10.TabIndex = 18
        Label10.Text = "Gross Salary:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.DarkRed
        Label11.Location = New Point(230, 403)
        Label11.Name = "Label11"
        Label11.Size = New Size(113, 16)
        Label11.TabIndex = 17
        Label11.Text = "Total Deduction:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.DarkRed
        Label12.Location = New Point(385, 403)
        Label12.Name = "Label12"
        Label12.Size = New Size(79, 16)
        Label12.TabIndex = 16
        Label12.Text = "Net Salary:"
        ' 
        ' Compute
        ' 
        Compute.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Compute.ForeColor = Color.Lime
        Compute.Location = New Point(153, 482)
        Compute.Name = "Compute"
        Compute.Size = New Size(100, 37)
        Compute.TabIndex = 24
        Compute.Text = "Compute"
        Compute.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft YaHei UI", 30F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.Firebrick
        Label13.Location = New Point(197, 9)
        Label13.Name = "Label13"
        Label13.Size = New Size(172, 52)
        Label13.TabIndex = 25
        Label13.Text = "PayRoll"
        ' 
        ' NOofDays
        ' 
        NOofDays.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        NOofDays.Location = New Point(73, 321)
        NOofDays.Name = "NOofDays"
        NOofDays.Size = New Size(117, 25)
        NOofDays.TabIndex = 26
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(73, 303)
        Label14.Name = "Label14"
        Label14.Size = New Size(140, 16)
        Label14.TabIndex = 27
        Label14.Text = "NO. of Days Worked:"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(311, 482)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 37)
        Button1.TabIndex = 28
        Button1.Text = "Exit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 559)
        Controls.Add(Button1)
        Controls.Add(Label14)
        Controls.Add(NOofDays)
        Controls.Add(Label13)
        Controls.Add(Compute)
        Controls.Add(GrossSalary1)
        Controls.Add(TotalDeduction)
        Controls.Add(NetSalary)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(PhilHealth)
        Controls.Add(SSS)
        Controls.Add(GrossSalary)
        Controls.Add(Deduction)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(MonthlyWage)
        Controls.Add(HourPerDay)
        Controls.Add(RatePerHour)
        Controls.Add(EmployeeName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EmployeeName As TextBox
    Friend WithEvents RatePerHour As TextBox
    Friend WithEvents HourPerDay As TextBox
    Friend WithEvents MonthlyWage As TextBox
    Friend WithEvents PhilHealth As TextBox
    Friend WithEvents SSS As TextBox
    Friend WithEvents GrossSalary As TextBox
    Friend WithEvents Deduction As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GrossSalary1 As TextBox
    Friend WithEvents TotalDeduction As TextBox
    Friend WithEvents NetSalary As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Compute As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents NOofDays As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button1 As Button
End Class
