Imports System
Imports System.Activities
Imports System.ComponentModel
Imports System.Windows.Forms
Imports UiPath.Shared.Activities

Namespace PrtMessageActivity.Activities

    <Category("Custom")>
    <DisplayName("Prt Message Box")>
    <Description("Shows a message box with a greeting based on the provided name.")>
    Public Class PrtMessageBoxActivity
        Inherits CodeActivity

        <Category("Input")>
        <DisplayName("Name")>
        <Description("The name to include in the greeting message.")>
        Public Property InputName As InArgument(Of String)

        <Category("Input")>
        <DisplayName("Title")>
        <Description("The title of the message box.")>
        Public Property Title As InArgument(Of String)

        Protected Overrides Sub Execute(context As CodeActivityContext)
            Dim inputName = InputName.Get(context)
            If String.IsNullOrWhiteSpace(inputName) Then
                inputName = "World"
            End If

            Dim title = Title.Get(context)
            If String.IsNullOrWhiteSpace(title) Then
                title = "Greeting"
            End If

            MessageBox.Show("Hello, " & inputName, title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

    End Class
End Namespace
