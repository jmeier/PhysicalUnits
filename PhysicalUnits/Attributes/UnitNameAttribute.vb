Option Strict On
Option Infer On

<CLSCompliant(True)>
Public Class UnitNameAttribute
    Inherits Attribute

    Sub New(name As String)
        Me.UnitName = name
    End Sub

    Public Property UnitName As String

    Public Shared Function GetUnitName(value As [Enum]) As String
        Dim mFieldInfo = value.GetType().GetField(value.ToString())
        Dim aattr = DirectCast(mFieldInfo.GetCustomAttributes(GetType(UnitNameAttribute), False), UnitNameAttribute())

        If aattr.Length = 1 Then
            Return aattr(0).UnitName
        Else
            Return value.ToString()
        End If

    End Function

End Class