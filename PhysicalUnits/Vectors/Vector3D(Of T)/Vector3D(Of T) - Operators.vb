Option Strict On
Option Infer On

Partial Structure Vector3D(Of T As {Structure, IUnitSupportingArithmetics, IEquatable(Of T), IComparable(Of T)})

    Public Shared Operator =(a As Vector3D(Of T), b As Vector3D(Of T)) As Boolean
        Return ((a._X.Equals(b._X)) AndAlso (a._Y.Equals(b._Y)) AndAlso (a._Z.Equals(b._Z)))
    End Operator

    Public Shared Operator <>(a As Vector3D(Of T), b As Vector3D(Of T)) As Boolean
        Return Not a = b
    End Operator

    Private Shared Function Flip(a As T) As T
        Dim unit = a.DefaultUnit
        Return CType(a.Create(-a.GetValue(unit), unit), T)
    End Function
    Private Shared Function Add(a As T, b As T) As T
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a.GetValue(unit) + b.GetValue(unit), unit), T)
    End Function
    Private Shared Function Subtract(a As T, b As T) As T
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a.GetValue(unit) - b.GetValue(unit), unit), T)
    End Function
    Private Shared Function Multiply(a As T, d As Double) As T
        Dim unit = a.DefaultUnit
        Return CType(a.Create(a.GetValue(unit) * d, unit), T)
    End Function


    Public Shared Operator +(a As Vector3D(Of T)) As Vector3D(Of T)
        Return a
    End Operator

    Public Shared Operator +(a As Vector3D(Of T), b As Vector3D(Of T)) As Vector3D(Of T)
        Return New Vector3D(Of T)(x:=Add(a._X, b._X),
                                  y:=Add(a._Y, b._Y),
                                  z:=Add(a._Z, b._Z))
    End Operator

    Public Shared Operator -(a As Vector3D(Of T)) As Vector3D(Of T)
        Return New Vector3D(Of T)(x:=Flip(a._X),
                                  y:=Flip(a._Y),
                                  z:=Flip(a._Z))
    End Operator

    Public Shared Operator -(a As Vector3D(Of T), b As Vector3D(Of T)) As Vector3D(Of T)
        Return New Vector3D(Of T)(x:=Subtract(a._X, b._X),
                                  y:=Subtract(a._Y, b._Y),
                                  z:=Subtract(a._Z, b._Z))
    End Operator

    Public Shared Operator *(a As Vector3D(Of T), d As Double) As Vector3D(Of T)
        Return New Vector3D(Of T)(x:=Multiply(a._X, d),
                                  y:=Multiply(a._Y, d),
                                  z:=Multiply(a._Z, d))
    End Operator

    Public Shared Operator *(d As Double, a As Vector3D(Of T)) As Vector3D(Of T)
        Return New Vector3D(Of T)(x:=Multiply(a._X, d),
                                  y:=Multiply(a._Y, d),
                                  z:=Multiply(a._Z, d))
    End Operator

    Public Shared Operator /(a As Vector3D(Of T), d As Double) As Vector3D(Of T)
        Return New Vector3D(Of T)(x:=Multiply(a._X, 1 / d),
                                  y:=Multiply(a._Y, 1 / d),
                                  z:=Multiply(a._Z, 1 / d))
    End Operator

End Structure
