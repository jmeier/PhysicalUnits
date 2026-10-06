Option Strict On
Option Infer On

Partial Structure Elevation

#Region "Equality, Comparison"

    Public Shared Operator =(a As Elevation, b As Elevation) As Boolean
        Return a._MetersAboveNN = b._MetersAboveNN
    End Operator
    Public Shared Operator <>(a As Elevation, b As Elevation) As Boolean
        Return a._MetersAboveNN <> b._MetersAboveNN
    End Operator
    Public Shared Operator <(a As Elevation, b As Elevation) As Boolean
        Return a._MetersAboveNN < b._MetersAboveNN
    End Operator
    Public Shared Operator >(a As Elevation, b As Elevation) As Boolean
        Return a._MetersAboveNN > b._MetersAboveNN
    End Operator
    Public Shared Operator <=(a As Elevation, b As Elevation) As Boolean
        Return a._MetersAboveNN <= b._MetersAboveNN
    End Operator
    Public Shared Operator >=(a As Elevation, b As Elevation) As Boolean
        Return a._MetersAboveNN >= b._MetersAboveNN
    End Operator

#End Region

#Region "Arithmetics"

    Public Shared Operator +(a As Elevation, b As Length) As Elevation
        Return Elevation.FromMetersAboveNN(a._MetersAboveNN + b.Meters)
    End Operator
    Public Shared Operator +(a As Length, b As Elevation) As Elevation
        Return Elevation.FromMetersAboveNN(a.Meters + b.MetersAboveNN)
    End Operator

    Public Shared Operator -(a As Elevation, b As Length) As Elevation
        Return Elevation.FromMetersAboveNN(a._MetersAboveNN - b.Meters)
    End Operator
    Public Shared Operator -(a As Length, b As Elevation) As Elevation
        Return Elevation.FromMetersAboveNN(a.Meters - b.MetersAboveNN)
    End Operator

    Public Shared Operator -(a As Elevation, b As Elevation) As Length
        Return Length.FromMeters(a._MetersAboveNN - b.MetersAboveNN)
    End Operator

#End Region


End Structure