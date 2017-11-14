Imports Units.UnitValue.Temperature

Namespace Global.Units.Units.Temperature

    Partial Public NotInheritable Class Celsius : Inherits AbstractTemperatureUnits

        Public Shared ReadOnly Property Instance As New Celsius
        Private Sub New()
            MyBase.New("°C", "Celsius")
        End Sub

    End Class

End Namespace
