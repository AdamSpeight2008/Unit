Imports Units.UnitValue.Temperature

Namespace Global.Units.Units.Temperature

    Partial Public NotInheritable Class Fahrenheit : Inherits AbstractTemperatureUnits

        Public Shared ReadOnly Property Instance As New Fahrenheit
        Private Sub New()
            MyBase.New("°F", "Fahrenheit")
        End Sub

    End Class

End Namespace
