Imports System
Imports System.Activities
Imports System.ComponentModel
Imports UiPath.Shared.Activities

Namespace PrtMessageActivity.Activities

    <Category("Custom")>
    <DisplayName("Prt Message Activity")>
    <Description("Returns a greeting message from the provided name.")>
    Public Class PrtMessageActivity
        Inherits CodeActivity

        <Category("Input")>
        <DisplayName("Name")>
        <Description("The name to include in the greeting message.")>
        Public Property InputName As InArgument(Of String)

        <Category("Output")>
        <DisplayName("Result")>
        <Description("The greeting message returned by the activity.")>
        Public Property ResultMessage As OutArgument(Of String)

        Protected Overrides Sub Execute(context As CodeActivityContext)
            Dim inputName = InputName.Get(context)
            If String.IsNullOrWhiteSpace(inputName) Then
                inputName = "World"
            End If

            ResultMessage.Set(context, "Hello, " & inputName)
        End Sub

    End Class
End Namespace