Imports System
Imports System.Activities

Public Class PrtMessageActivity
    Inherits CodeActivity

    Public Property Name As InArgument(Of String)
    Public Property Result As OutArgument(Of String)

    Protected Overrides Sub Execute(context As CodeActivityContext)
        Dim inputName = Name.Get(context)
        Result.Set(context, "Hello, " & inputName)
    End Sub
End Class
