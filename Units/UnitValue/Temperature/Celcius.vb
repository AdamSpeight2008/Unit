
Imports Units.Units.Temperature

Namespace Global.Units.UnitValue.Temperature

    Partial Public NotInheritable Class Celsius : Inherits AbstractUnitValue(Of Units.Temperature.Celsius)

        Public Sub New(Value As Decimal)
            MyBase.New(Value, Global.Units.Units.Temperature.Celsius.Instance)
        End Sub

        Friend Overrides Function CreateNew(Value As Decimal) As AbstractUnitValue(Of Units.Temperature.Celsius)
            Return New Celsius(Value)
        End Function

        Public Shared Widening Operator CType(x As Decimal) As Celsius
            Return New Celsius(x)
        End Operator

        Public Shared Narrowing Operator CType(x As Celsius) As Fahrenheit
            Return New Fahrenheit((x.Value * (9D / 5D)) + 32D)
        End Operator
        Public Shared Narrowing Operator CType(x As Celsius) As Kelvin
            Dim AsFahrenheit As Fahrenheit = x
            Return New Kelvin(x.Value - 273.15D)
        End Operator


        Partial Public Class Common
            Public Shared ReadOnly Property AbsoluteZero As Celsius = (-273.15D)
        End Class
    End Class

End Namespace