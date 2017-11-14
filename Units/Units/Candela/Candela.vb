Imports Units.UnitValue.LuminousIntensity

Namespace Global.Units.Units.LuminousIntensity

    Partial Public NotInheritable Class Candela : Inherits AbstractLuminousIntensityUnits
        Public Shared ReadOnly Property Instance As New Candela
        Private Sub New()
            MyBase.New("cd", "candela")
        End Sub

    End Class

End Namespace
