
Option Explicit On
Option Strict On

Module VariablesAndDataTypesAndStuff

    Sub Main()

        Dim jellyBeans As Integer
        Dim laffyTaffy As Integer
        Dim money As Decimal
        Dim studentName As String

        Console.WriteLine(jellyBeans)

        jellyBeans = 120
        Console.WriteLine(jellyBeans)

        jellyBeans = jellyBeans + 10
        Console.WriteLine(jellyBeans)

        jellyBeans += 10
        Console.WriteLine(jellyBeans)

        laffyTaffy = 26
        Console.WriteLine(laffyTaffy)

        money = 9.12837490812374D
        jellyBeans = CInt(1.56)
        studentName = "7"

        jellyBeans = CInt(studentName)


        Console.WriteLine()

    End Sub

End Module
