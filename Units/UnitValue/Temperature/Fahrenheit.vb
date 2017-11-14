
Imports Units.Units.Temperature

Namespace Global.Units.UnitValue.Temperature

    Partial Public NotInheritable Class Fahrenheit : Inherits AbstractUnitValue(Of Units.Temperature.Fahrenheit)

        Public Sub New(Value As Decimal)
            MyBase.New(Value, Global.Units.Units.Temperature.Fahrenheit.Instance)
        End Sub

        Friend Overrides Function CreateNew(Value As Decimal) As AbstractUnitValue(Of Units.Temperature.Fahrenheit)
            Return New Fahrenheit(Value)
        End Function

        Public Shared Widening Operator CType(x As Decimal) As Fahrenheit
            Return New Fahrenheit(x)
        End Operator


        Public Shared Narrowing Operator CType(x As Fahrenheit) As Celsius
            Return New Celsius((x.Value - 32D) * (5D / 9D))
        End Operator
        Public Shared Narrowing Operator CType(x As Fahrenheit) As Kelvin
            Return New Kelvin(((9D / 5D) * (x.Value - 273.15D)) + 32D)
        End Operator

        Partial Public Class Common
            Public Shared ReadOnly Property AbsoluteZero As Fahrenheit = (-459.67D)
        End Class
    End Class

End Namespace