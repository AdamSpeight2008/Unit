
Imports Units.Units.AmountOfSubstance

Namespace Global.Units.UnitValue.AmountOfSubstance

    Partial Public NotInheritable Class Mole : Inherits AbstractUnitValue(Of Units.AmountOfSubstance.Mole)

        Public Sub New(Value As Decimal)
            MyBase.New(Value, Global.Units.Units.AmountOfSubstance.Mole.Instance)
        End Sub

        Friend Overrides Function CreateNew(Value As Decimal) As AbstractUnitValue(Of Units.AmountOfSubstance.Mole)
            Return New Mole(Value)
        End Function

        Public Shared Widening Operator CType(x As Decimal) As 
            Return New Mole(x)
        End Operator


    End Class

End Namespace