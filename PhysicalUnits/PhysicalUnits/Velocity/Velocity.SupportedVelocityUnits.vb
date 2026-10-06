Option Strict On
Option Infer On

Partial Structure Velocity

    Private Shared ReadOnly KnownUnits As ObjectModel.ReadOnlyDictionary(Of SupportedVelocityUnits, String()) = UnitExtensions.GetKnownUnitDictionary(Of SupportedVelocityUnits)()

    Public Enum SupportedVelocityUnits

        ''' <summary> Velocity in m/s </summary>
        <UnitSymbol("m/s")>
        MetersPerSecond = 0

        ''' <summary> Velocity in km/h </summary>
        <UnitSymbol("km/h")>
        KilometersPerHour

        ''' <summary> Velocity in m/day </summary>
        <UnitSymbol("m/day")>
        MetersPerDay

    End Enum

    Private Shared Function ConversionFactor([to] As SupportedVelocityUnits) As Double
        Select Case [to]
            Case SupportedVelocityUnits.MetersPerSecond
                Return 1

            Case SupportedVelocityUnits.KilometersPerHour
                Return 60 * 60 / 1000

            Case SupportedVelocityUnits.MetersPerDay
                Return 60 * 60 * 24 / 1

            Case Else
                Throw New ArgumentException

        End Select
    End Function

End Structure