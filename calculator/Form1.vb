Public Class Form1

    Private isNewEntry As Boolean = True

    ' On form load, hook up all buttons
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Number buttons
        AddHandler num0.Click, AddressOf Number_Click
        AddHandler num1.Click, AddressOf Number_Click
        AddHandler num2.Click, AddressOf Number_Click
        AddHandler num3.Click, AddressOf Number_Click
        AddHandler num4.Click, AddressOf Number_Click
        AddHandler num5.Click, AddressOf Number_Click
        AddHandler num6.Click, AddressOf Number_Click
        AddHandler num7.Click, AddressOf Number_Click
        AddHandler num8.Click, AddressOf Number_Click
        AddHandler num9.Click, AddressOf Number_Click

        ' Operators
        AddHandler add.Click, AddressOf Operator_Click
        AddHandler subtract.Click, AddressOf Operator_Click
        AddHandler multiply.Click, AddressOf Operator_Click
        AddHandler divide.Click, AddressOf Operator_Click

        ' Other buttons
        AddHandler numDecimal.Click, AddressOf Decimal_Click
    End Sub

    ' Number click
    Private Sub Number_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)

        ' If current text is "Error" or "Overflow", start fresh
        If txtNumber.Text = "Error" Or txtNumber.Text = "Overflow" Then
            txtNumber.Text = btn.Text
            isNewEntry = False
            Return
        End If

        If txtNumber.Text = "0" Or isNewEntry Then
            txtNumber.Text = btn.Text
            isNewEntry = False
        Else
            txtNumber.Text &= btn.Text
        End If
    End Sub


    ' Decimal point click
    Private Sub Decimal_Click(sender As Object, e As EventArgs)
        ' Prevent multiple decimal points in one number segment
        Dim lastPart = GetLastOperand(txtNumber.Text)

        If isNewEntry Then
            txtNumber.Text = "0."
            isNewEntry = False
        ElseIf Not lastPart.Contains(".") Then
            txtNumber.Text &= "."
        End If
    End Sub

    ' Operator click
    Private Sub Operator_Click(sender As Object, e As EventArgs)
        Dim op As String = CType(sender, Button).Text

        ' Allow negative sign at the beginning
        If txtNumber.Text = "0" AndAlso op = "-" Then
            txtNumber.Text = "-"
            isNewEntry = False
            Return
        End If

        ' If textbox is empty or already ends in an operator, replace it (except when it's just "-")
        If txtNumber.Text.EndsWith("+") Or txtNumber.Text.EndsWith("-") Or
       txtNumber.Text.EndsWith("*") Or txtNumber.Text.EndsWith("/") Then

            ' Prevent replacing a leading negative like "-5"
            If txtNumber.Text.Length = 1 AndAlso txtNumber.Text = "-" Then
                Return
            End If

            txtNumber.Text = txtNumber.Text.Substring(0, txtNumber.Text.Length - 1) & op
        Else
            txtNumber.Text &= op
        End If

        isNewEntry = False
    End Sub


    ' Equals click
    Private Sub Equals_Click(sender As Object, e As EventArgs) Handles equals.Click
        Try
            Dim expression As String = txtNumber.Text
            Dim resultObj = New DataTable().Compute(expression, Nothing)
            Dim result As Double = Convert.ToDouble(resultObj)

            ' Check for overflow or too large result
            If Math.Abs(result) > 1000000000 Then ' You can change this limit
                txtNumber.Text = "Overflow"
                isNewEntry = True
                Return
            End If

            ' Format output: no .0 for whole numbers
            If result = Math.Floor(result) Then
                txtNumber.Text = result.ToString("F0") ' Integer
            Else
                txtNumber.Text = result.ToString() ' Decimal
            End If

            isNewEntry = True
        Catch ex As Exception
            txtNumber.Text = "Error"
        End Try
    End Sub



    ' Clear click
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        txtNumber.Text = "0"
        isNewEntry = True
    End Sub

    ' Delete / Backspace click
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If txtNumber.Text.Length > 1 And txtNumber.Text = "Error" Then
            txtNumber.Text = "0"
        ElseIf txtNumber.Text.Length > 1 Then
            txtNumber.Text = txtNumber.Text.Substring(0, txtNumber.Text.Length - 1)
        Else
            txtNumber.Text = "0"
        End If
    End Sub

    ' Helper to get the last number segment (to prevent multiple decimals)
    Private Function GetLastOperand(expression As String) As String
        Dim parts() As String = expression.Split("+"c, "-"c, "*"c, "/"c)
        If parts.Length > 0 Then
            Return parts(parts.Length - 1)
        Else
            Return expression
        End If
    End Function

End Class
