<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtNumber = New TextBox()
        num7 = New Button()
        num8 = New Button()
        num9 = New Button()
        num6 = New Button()
        num5 = New Button()
        num4 = New Button()
        num3 = New Button()
        num2 = New Button()
        num1 = New Button()
        numDecimal = New Button()
        num0 = New Button()
        add = New Button()
        subtract = New Button()
        equals = New Button()
        multiply = New Button()
        divide = New Button()
        delete = New Button()
        clear = New Button()
        SuspendLayout()
        ' 
        ' txtNumber
        ' 
        txtNumber.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNumber.Location = New Point(12, 23)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(356, 46)
        txtNumber.TabIndex = 0
        txtNumber.Text = "0"
        txtNumber.TextAlign = HorizontalAlignment.Right
        ' 
        ' num7
        ' 
        num7.FlatAppearance.BorderColor = Color.Black
        num7.Font = New Font("Microsoft Sans Serif", 20.25F)
        num7.Location = New Point(12, 156)
        num7.Name = "num7"
        num7.Size = New Size(84, 66)
        num7.TabIndex = 1
        num7.Text = "7"
        num7.UseVisualStyleBackColor = True
        ' 
        ' num8
        ' 
        num8.FlatAppearance.BorderColor = Color.Black
        num8.Font = New Font("Microsoft Sans Serif", 20.25F)
        num8.Location = New Point(102, 156)
        num8.Name = "num8"
        num8.Size = New Size(84, 66)
        num8.TabIndex = 2
        num8.Text = "8"
        num8.UseVisualStyleBackColor = True
        ' 
        ' num9
        ' 
        num9.FlatAppearance.BorderColor = Color.Black
        num9.Font = New Font("Microsoft Sans Serif", 20.25F)
        num9.Location = New Point(194, 157)
        num9.Name = "num9"
        num9.Size = New Size(84, 65)
        num9.TabIndex = 3
        num9.Text = "9"
        num9.UseVisualStyleBackColor = True
        ' 
        ' num6
        ' 
        num6.FlatAppearance.BorderColor = Color.Black
        num6.Font = New Font("Microsoft Sans Serif", 20.25F)
        num6.Location = New Point(194, 231)
        num6.Name = "num6"
        num6.Size = New Size(84, 66)
        num6.TabIndex = 6
        num6.Text = "6"
        num6.UseVisualStyleBackColor = True
        ' 
        ' num5
        ' 
        num5.FlatAppearance.BorderColor = Color.Black
        num5.Font = New Font("Microsoft Sans Serif", 20.25F)
        num5.Location = New Point(102, 231)
        num5.Name = "num5"
        num5.Size = New Size(84, 66)
        num5.TabIndex = 5
        num5.Text = "5"
        num5.UseVisualStyleBackColor = True
        ' 
        ' num4
        ' 
        num4.FlatAppearance.BorderColor = Color.Black
        num4.Font = New Font("Microsoft Sans Serif", 20.25F)
        num4.Location = New Point(12, 231)
        num4.Name = "num4"
        num4.Size = New Size(84, 66)
        num4.TabIndex = 4
        num4.Text = "4"
        num4.UseVisualStyleBackColor = True
        ' 
        ' num3
        ' 
        num3.FlatAppearance.BorderColor = Color.Black
        num3.Font = New Font("Microsoft Sans Serif", 20.25F)
        num3.Location = New Point(194, 303)
        num3.Name = "num3"
        num3.Size = New Size(84, 66)
        num3.TabIndex = 9
        num3.Text = "3"
        num3.UseVisualStyleBackColor = True
        ' 
        ' num2
        ' 
        num2.FlatAppearance.BorderColor = Color.Black
        num2.Font = New Font("Microsoft Sans Serif", 20.25F)
        num2.Location = New Point(102, 303)
        num2.Name = "num2"
        num2.Size = New Size(84, 66)
        num2.TabIndex = 8
        num2.Text = "2"
        num2.UseVisualStyleBackColor = True
        ' 
        ' num1
        ' 
        num1.FlatAppearance.BorderColor = Color.Black
        num1.Font = New Font("Microsoft Sans Serif", 20.25F)
        num1.Location = New Point(12, 303)
        num1.Name = "num1"
        num1.Size = New Size(84, 66)
        num1.TabIndex = 7
        num1.Text = "1"
        num1.UseVisualStyleBackColor = True
        ' 
        ' numDecimal
        ' 
        numDecimal.FlatAppearance.BorderColor = Color.Black
        numDecimal.Font = New Font("Microsoft Sans Serif", 20.25F)
        numDecimal.Location = New Point(194, 375)
        numDecimal.Name = "numDecimal"
        numDecimal.Size = New Size(84, 66)
        numDecimal.TabIndex = 11
        numDecimal.Text = "."
        numDecimal.UseVisualStyleBackColor = True
        ' 
        ' num0
        ' 
        num0.FlatAppearance.BorderColor = Color.Black
        num0.Font = New Font("Microsoft Sans Serif", 20.25F)
        num0.Location = New Point(12, 375)
        num0.Name = "num0"
        num0.Size = New Size(174, 66)
        num0.TabIndex = 10
        num0.Text = "0"
        num0.UseVisualStyleBackColor = True
        ' 
        ' add
        ' 
        add.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        add.FlatAppearance.BorderColor = Color.Black
        add.Font = New Font("Microsoft Sans Serif", 20.25F)
        add.Location = New Point(284, 231)
        add.Name = "add"
        add.Size = New Size(84, 66)
        add.TabIndex = 13
        add.Text = "+"
        add.UseVisualStyleBackColor = False
        ' 
        ' subtract
        ' 
        subtract.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        subtract.FlatAppearance.BorderColor = Color.Black
        subtract.Font = New Font("Microsoft Sans Serif", 20.25F)
        subtract.Location = New Point(284, 157)
        subtract.Name = "subtract"
        subtract.Size = New Size(84, 65)
        subtract.TabIndex = 14
        subtract.Text = "-"
        subtract.UseVisualStyleBackColor = False
        ' 
        ' equals
        ' 
        equals.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        equals.FlatAppearance.BorderColor = Color.Black
        equals.Font = New Font("Microsoft Sans Serif", 20.25F)
        equals.Location = New Point(284, 303)
        equals.Name = "equals"
        equals.Size = New Size(84, 138)
        equals.TabIndex = 15
        equals.Text = "="
        equals.UseVisualStyleBackColor = False
        ' 
        ' multiply
        ' 
        multiply.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        multiply.FlatAppearance.BorderColor = Color.Black
        multiply.Font = New Font("Microsoft Sans Serif", 20.25F)
        multiply.Location = New Point(284, 85)
        multiply.Name = "multiply"
        multiply.Size = New Size(84, 66)
        multiply.TabIndex = 16
        multiply.Text = "*"
        multiply.UseVisualStyleBackColor = False
        ' 
        ' divide
        ' 
        divide.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        divide.FlatAppearance.BorderColor = Color.Black
        divide.Font = New Font("Microsoft Sans Serif", 20.25F)
        divide.Location = New Point(194, 85)
        divide.Name = "divide"
        divide.Size = New Size(84, 66)
        divide.TabIndex = 17
        divide.Text = "/"
        divide.UseVisualStyleBackColor = False
        ' 
        ' delete
        ' 
        delete.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        delete.FlatAppearance.BorderColor = Color.Black
        delete.Font = New Font("Microsoft Sans Serif", 20.25F)
        delete.Location = New Point(102, 85)
        delete.Name = "delete"
        delete.Size = New Size(84, 65)
        delete.TabIndex = 18
        delete.Text = "DEL"
        delete.UseVisualStyleBackColor = False
        ' 
        ' clear
        ' 
        clear.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        clear.FlatAppearance.BorderColor = Color.Black
        clear.Font = New Font("Microsoft Sans Serif", 20.25F)
        clear.Location = New Point(12, 85)
        clear.Name = "clear"
        clear.Size = New Size(84, 66)
        clear.TabIndex = 19
        clear.Text = "CE"
        clear.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(383, 451)
        Controls.Add(clear)
        Controls.Add(delete)
        Controls.Add(divide)
        Controls.Add(multiply)
        Controls.Add(equals)
        Controls.Add(subtract)
        Controls.Add(add)
        Controls.Add(numDecimal)
        Controls.Add(num0)
        Controls.Add(num3)
        Controls.Add(num2)
        Controls.Add(num1)
        Controls.Add(num6)
        Controls.Add(num5)
        Controls.Add(num4)
        Controls.Add(num9)
        Controls.Add(num8)
        Controls.Add(num7)
        Controls.Add(txtNumber)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumber As TextBox
    Friend WithEvents num7 As Button
    Friend WithEvents num8 As Button
    Friend WithEvents num9 As Button
    Friend WithEvents num6 As Button
    Friend WithEvents num5 As Button
    Friend WithEvents num4 As Button
    Friend WithEvents num3 As Button
    Friend WithEvents num2 As Button
    Friend WithEvents num1 As Button
    Friend WithEvents numDecimal As Button
    Friend WithEvents num0 As Button
    Friend WithEvents add As Button
    Friend WithEvents subtract As Button
    Friend WithEvents equals As Button
    Friend WithEvents multiply As Button
    Friend WithEvents divide As Button
    Friend WithEvents delete As Button
    Friend WithEvents clear As Button

End Class
