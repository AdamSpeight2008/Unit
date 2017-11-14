
Imports Units.Units.Temperature

Namespace Global.Units.UnitValue.Temperature

    Partial Public NotInheritable Class Kelvin : Inherits AbstractUnitValue(Of Units.Temperature.Kelvin)

        Public Sub New(Value As Decimal)
            MyBase.New(Value, Global.Units.Units.Temperature.Kelvin.Instance)
        End Sub

        Friend Overrides Function CreateNew(Value As Decimal) As AbstractUnitValue(Of Units.Temperature.Kelvin)
            Return New Kelvin(Value)
        End Function

        Public Shared Widening Operator CType(x As Decimal) As Kelvin
            Return New Kelvin(x)
        End Operator

        Public Shared Narrowing Operator CType(x As Kelvin) As Celsius
            Return New Celsius(x.Value - 273.15D)
        End Operator
        Public Shared Narrowing Operator CType(x As Kelvin) As Fahrenheit
            Dim AsCelsius As Celsius = x
            Dim AsFahrenheit As Fahrenheit = AsCelsius
            Return AsFahrenheit
        End Operator


        Partial Public Class Common
            Public Shared ReadOnly Property AbsoluteZero As Kelvin = 0D
        End Class
    End Class

End Namespace