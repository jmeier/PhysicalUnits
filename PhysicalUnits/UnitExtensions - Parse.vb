Option Strict On
Option Infer On

Imports System.Runtime.CompilerServices

Partial Module UnitExtensions

    Friend Function GetKnownUnitDictionary(Of TKey As Structure)() As ObjectModel.ReadOnlyDictionary(Of TKey, String())
        Dim dict As New Dictionary(Of TKey, String())

        Dim units = [Enum].GetValues(GetType(TKey))
        For Each unit In units.OfType(Of TKey)
            Dim symbol = UnitSymbolAttribute.GetUnitSymbol(DirectCast(CObj(unit), [Enum]))
            dict.Add(unit, {symbol})
        Next

        Return New ObjectModel.ReadOnlyDictionary(Of TKey, String())(dict)
    End Function

    Friend Function Parse(Of TKey As Structure)(s As String,
                                                provider As IFormatProvider,
                                                knownUnits As ObjectModel.ReadOnlyDictionary(Of TKey, String())) As KeyValuePair(Of Double, TKey)

        Dim t = s.TrimEnd
        Dim foundUnit As TKey = Nothing, foundSet = False
        Dim foundValue = 0.0
        For Each unit In knownUnits
            Dim symbols = unit.Value
            For Each symbol In symbols
                If t.EndsWith(" "c & symbol) Then
                    If foundSet Then
                        Throw New FormatException
                    Else
                        foundUnit = unit.Key
                        foundValue = Double.Parse(t.Substring(startIndex:=0, length:=t.Length - 1 - symbol.Length), provider)
                        foundSet = True
                    End If
                End If
            Next
        Next

        If foundSet Then
            Return New KeyValuePair(Of Double, TKey)(foundValue, foundUnit)
        Else
            Throw New FormatException
        End If
    End Function

End Module