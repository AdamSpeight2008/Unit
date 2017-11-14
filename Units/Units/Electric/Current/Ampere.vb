Imports Units.UnitValue.Electric.Current

Namespace Global.Units.Units.Electric.Currents

    Partial Public NotInheritable Class Ampere : Inherits AbstractCurrentUnits

        Public Shared ReadOnly Property Instance As New Ampere
        Private Sub New()
            MyBase.New("A", "amperes")
        End Sub

    End Class

End Namespace
