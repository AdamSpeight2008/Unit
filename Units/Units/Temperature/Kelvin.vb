Imports Units.UnitValue.Temperature

Namespace Global.Units.Units.Temperature

    Partial Public NotInheritable Class Kelvin : Inherits AbstractTemperatureUnits

        Public Shared ReadOnly Property Instance As New Kelvin
        Private Sub New()
            MyBase.New("°K", "Kelvins")
        End Sub

    End Class

End Namespace
