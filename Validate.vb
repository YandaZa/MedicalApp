Imports System.Text.RegularExpressions.Regex
Public Class Validate

    'Validation of names
    Public Shared Function Names(N As TextBox) As Boolean

        If N.Text.Trim().Length() <= 2 Then
            MessageBox.Show("Please enter a valid name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            N.Clear()
            N.Focus()
            Return False
        End If

        If N.Text.Trim() = "" Then
            MessageBox.Show(N.Name.Substring(3) + " cannot be empty", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            N.Clear()
            N.Focus()
            Return False
        End If

        If Not IsMatch(N.Text.Trim(), "^[a-zA-Z ]+$") Then
            MessageBox.Show(N.Name.Substring(3) + " may only contain alphabets and spaces", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            N.Clear()
            N.Focus()
            Return False
        End If
        Return True
    End Function

    'email validation
    Public Shared Function IsValidEmail(email As TextBox) As Boolean

        If email.Text.Trim() = "" Then
            MessageBox.Show(email.Name.Substring(3) + " may not be empty", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            email.Clear()
            email.Focus()
            Return False
        End If

        Dim EmailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z.-]+\.[a-zA-Z]{2,}$"

        If IsMatch(email.Text.Trim(), EmailPattern) = False Then

            MessageBox.Show(email.Name.Substring(3) + " captured incorrectly try name@domain.tld", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            email.Clear()
            email.Focus()
            Return False

        End If
        Return True
    End Function


    Public Shared Function IDNumber(ID As TextBox) As Boolean

        If Not IsNumeric(ID.Text.Trim) Then
            MessageBox.Show(ID.Name.Substring(3) + " should be 13 numerals", "Invalid ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ID.Clear()
            ID.Focus()
            Return False
        End If

        If ID.Text.Trim.Length <> 13 Then
            MessageBox.Show(ID.Name.Substring(3) + " should be 13 numerals", "Invalid ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ID.Clear()
            ID.Focus()
            Return False
        End If

        'Taking the year out of system time to be used as the upper limit if the 2000s

        Dim sysTime As Date = Now 'for now, current system time.
        Dim Tym As String = sysTime.ToString '


        If CInt(ID.Text.Trim.Substring(0, 2)) >= 6 And CInt(ID.Text.Trim.Substring(0, 2)) <= Tym.Substring(2, 2) Then
            MessageBox.Show("Sorry! You are underage", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ID.Clear()
            ID.Focus()
            Return False
        End If

        If ID.Text.Trim.Substring(2, 2) > 12 Or ID.Text.Trim.Substring(2, 2) = 0 Then
            MessageBox.Show("Sorry! please enter a valid month??", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ID.Clear()
            ID.Focus()
            Return False
        End If

        If ID.Text.Trim.Substring(4, 2) = 0 Or ID.Text.Trim.Substring(4, 2) > 31 Then
            MessageBox.Show("Sorry! please enter a valid day of birth??", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ID.Clear()
            ID.Focus()
            Return False
        End If


        If ID.Text.Trim.Substring(2, 2) = 2 And ID.Text.Trim.Substring(4, 2) > 29 Then
            MessageBox.Show("Sorry! please enter a valid day of birth??", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ID.Clear()
            ID.Focus()
            Return False
        End If

        If ID.Text.Trim.Substring(0, 2) Mod 4 <> 0 And ID.Text.Trim.Substring(4, 2) >= 29 Then
            MessageBox.Show("The year provided is not a leap year and February cannot end on the 29th", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ID.Clear()
            ID.Focus()
            Return False
        End If

        Return True
    End Function


    'Returns Gender from Id Number
    Public Shared Function IDReturnGender(Id As TextBox) As String
        If Not IDNumber(Id) Then
            Return ""
        End If

        If (Id.Text.Trim.Substring(6, 1) >= 0 And (Id.Text.Trim.Substring(6, 1) > 5)) Or Id.Text.Trim.Substring(6, 1) <= 4 Then
            Return "Female"
        End If

        If Id.Text.Trim.Substring(6, 1) >= 5 Or Id.Text.Trim.Substring(6, 1) <= 9 Then
            Return "Male"
        End If
    End Function

    Public Shared Function IDReturnCitizen(id As TextBox) As String

        If Not IDNumber(id) Then
            Return ""
        End If

        If CInt(id.Text.Chars(10).ToString) = 0 Then
            Return "South African Citizen"
        ElseIf CInt(id.Text.Chars(10).ToString) > 0 Then
            Return "Permanent Citizen"
        End If
    End Function



    '*********************************************************************************************************************


    Public Shared Function IsAcceptiblePass(pass As TextBox) As Boolean

        If pass.Text.Trim.Length <= 7 Then

            MessageBox.Show("Password must contain at least 8 characters and constitute of an Uppercase, lowercase, special characters and numbers", "Unacceptable Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            pass.Clear()
            pass.Focus()
            Return False

        End If

        If IsMatch(pass.Text.Trim, "[!@#$%^&*()_+{}\[\]:;<>,.?/~=-]") = False Then
            MessageBox.Show("Password must contain at least one special character", "Unacceptable Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            pass.Clear()
            pass.Focus()
            Return False
        End If

        If Not IsMatch(pass.Text.Trim, "[a-z]") Then
            MessageBox.Show("Password must contain at least one lowercase character", "Unacceptable Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            pass.Clear()
            pass.Focus()
            Return False
        End If

        If Not IsMatch(pass.Text.Trim, "[A-Z]") Then
            MessageBox.Show("Password must contain at least one uppercase character", "Unacceptable Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            pass.Clear()
            pass.Focus()
            Return False
        End If

        If Not IsMatch(pass.Text.Trim, "[0-9]") Then
            MessageBox.Show("Password must contain at least one Number", "Unacceptable Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            pass.Clear()
            pass.Focus()
            Return False
        End If

        Return True
    End Function




    '************************************************************************************************************************

    Public Shared Function IsAcceptiblePass(pass As TextBox, passConfirm As TextBox) As Boolean

        If Not IsAcceptiblePass(pass) Then
            Return False
        End If

        If Not pass.Text.Trim = passConfirm.Text.Trim Then
            MessageBox.Show("Your entered passwords do not match", "Mismatched Passwords", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    '******************************************************************************************************

    Public Shared Function ValidateContact(CellNumber As TextBox) As Boolean


        If CellNumber.Text.Trim = Nothing Then
            MessageBox.Show("Mobile number should be 10 digits", "Invalid Mobile Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CellNumber.Clear()
            CellNumber.Focus()
            Return False
        End If

        If Not CellNumber.Text.StartsWith("0") Then
            MessageBox.Show("Mobile number should start with 0", "Invalid Mobile Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CellNumber.Clear()
            CellNumber.Focus()
            Return False
        End If

        If Not IsNumeric(CellNumber.Text.Trim) Then
            MessageBox.Show("Mobile number should be 10 digits", "Invalid Mobile Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CellNumber.Clear()
            CellNumber.Focus()
            Return False
        End If

        If CellNumber.Text.Trim.Substring(1, 1) = "0" Then
            MessageBox.Show("Mobile number should not begin with double 0's", "Invalid Mobile Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CellNumber.Clear()
            CellNumber.Focus()
            Return False
        End If

        Return True
    End Function


End Class
