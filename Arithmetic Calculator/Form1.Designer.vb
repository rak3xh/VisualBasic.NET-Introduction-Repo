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
        txtNumber1 = New TextBox()
        txtNumber2 = New TextBox()
        lblNumber1 = New Label()
        lblNumber2 = New Label()
        btnAdd = New Button()
        btnSubtract = New Button()
        btnMultiply = New Button()
        btnDivide = New Button()
        btnPower = New Button()
        btnRemainder = New Button()
        SuspendLayout()
        ' 
        ' txtNumber1
        ' 
        txtNumber1.AccessibleName = "txtNumber1"
        txtNumber1.Location = New Point(200, 42)
        txtNumber1.Name = "txtNumber1"
        txtNumber1.Size = New Size(125, 27)
        txtNumber1.TabIndex = 0
        ' 
        ' txtNumber2
        ' 
        txtNumber2.AccessibleName = "txtNumber2"
        txtNumber2.Location = New Point(200, 92)
        txtNumber2.Name = "txtNumber2"
        txtNumber2.Size = New Size(125, 27)
        txtNumber2.TabIndex = 1
        ' 
        ' lblNumber1
        ' 
        lblNumber1.AutoSize = True
        lblNumber1.ForeColor = SystemColors.ControlLightLight
        lblNumber1.Location = New Point(83, 45)
        lblNumber1.Name = "lblNumber1"
        lblNumber1.Size = New Size(75, 20)
        lblNumber1.TabIndex = 2
        lblNumber1.Text = "Number 1"
        ' 
        ' lblNumber2
        ' 
        lblNumber2.AutoSize = True
        lblNumber2.ForeColor = SystemColors.ControlLightLight
        lblNumber2.Location = New Point(83, 97)
        lblNumber2.Name = "lblNumber2"
        lblNumber2.Size = New Size(75, 20)
        lblNumber2.TabIndex = 3
        lblNumber2.Text = "Number 2"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(29, 174)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Location = New Point(162, 174)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(94, 29)
        btnSubtract.TabIndex = 5
        btnSubtract.Text = "Subtract"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Location = New Point(297, 174)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(94, 29)
        btnMultiply.TabIndex = 6
        btnMultiply.Text = "Multiply"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(29, 240)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(94, 29)
        btnDivide.TabIndex = 7
        btnDivide.Text = "Divide"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnPower
        ' 
        btnPower.Location = New Point(162, 240)
        btnPower.Name = "btnPower"
        btnPower.Size = New Size(94, 29)
        btnPower.TabIndex = 8
        btnPower.Text = "Power"
        btnPower.UseVisualStyleBackColor = True
        ' 
        ' btnRemainder
        ' 
        btnRemainder.Location = New Point(297, 240)
        btnRemainder.Name = "btnRemainder"
        btnRemainder.Size = New Size(94, 29)
        btnRemainder.TabIndex = 9
        btnRemainder.Text = "Modulus"
        btnRemainder.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AccessibleName = "Calculator"
        AccessibleRole = AccessibleRole.None
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(403, 437)
        Controls.Add(btnRemainder)
        Controls.Add(btnPower)
        Controls.Add(btnDivide)
        Controls.Add(btnMultiply)
        Controls.Add(btnSubtract)
        Controls.Add(btnAdd)
        Controls.Add(lblNumber2)
        Controls.Add(lblNumber1)
        Controls.Add(txtNumber2)
        Controls.Add(txtNumber1)
        Name = "Form1"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents lblNumber1 As Label
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnPower As Button
    Friend WithEvents btnRemainder As Button

End Class
