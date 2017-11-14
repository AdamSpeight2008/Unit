Imports Units.UnitValue.Mass

Namespace Global.Units.Units.Mass

    Partial Public NotInheritable Class Kilograms : Inherits AbstractMassUnits
        Public Shared ReadOnly Property Instance As New Kilograms
        Private Sub New()
            MyBase.New("kg", "kilograms")
        End Sub

    End Class

End Namespace
