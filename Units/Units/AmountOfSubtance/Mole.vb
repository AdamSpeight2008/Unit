Imports Units.UnitValue.AmountOfSubstance

Namespace Global.Units.Units.AmountOfSubstance

    Partial Public NotInheritable Class Mole : Inherits AbstractAmountOfSubstanceUnits
        Public Shared ReadOnly Property Instance As New Mole
        Private Sub New()
            MyBase.New("mol", "mole")
        End Sub

    End Class

End Namespace
