'Elliot Heiner
'Fall 2021
'Variable and Data Type Example
'https://github.com/heinelli/VariableExample.git

Option Strict On        'This code enables or disables predictions of possible calculation errors.
Option Explicit On
Module VariableExample

    Sub Main()

        Dim myNewVariable As String     'Dim is used to declare a variable. The word after Dim is the variable name.
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Double
        Dim test As Boolean
        Dim userResponse As String

        Const DISCOUNT As Decimal = 0.01@   'Uppercase is used to signify a constant value.


        myNewVariable = "hello, world!"
        myNewVariable = "Good bye!"
        myNewVariable &= " Cruel World"

        firstNumber = 5
        secondNumber = 6
        result = firstNumber / secondNumber


        Console.WriteLine("Enter a number.")


        userResponse = Console.ReadLine()
        Console.WriteLine(CInt(userResponse) + 5)
        Console.Beep()
    End Sub

End Module
