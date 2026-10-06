Option Strict On
Option Infer On

<CLSCompliant(True)>
Public Class UnitSymbolAttribute
    Inherits Attribute

    Sub New(symbol As String)
        Me.UnitSymbol = symbol
    End Sub

    Sub New(symbol As String, alternatives As String())
        Me.UnitSymbol = symbol
        Me.Alternatives.AddRange(alternatives)
    End Sub

    Public Property UnitSymbol As String

    Public ReadOnly Property Alternatives As New List(Of String)

    Public Shared Function GetUnitSymbol(value As [Enum]) As String
        Dim mFieldInfo = value.GetType().GetField(value.ToString())
        Dim aattr = DirectCast(mFieldInfo.GetCustomAttributes(GetType(UnitSymbolAttribute), False), UnitSymbolAttribute())

        If aattr.Length = 1 Then
            Return aattr(0).UnitSymbol
        Else
            Return value.ToString()
        End If

    End Function

End Class
