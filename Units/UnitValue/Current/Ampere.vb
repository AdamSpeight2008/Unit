
Imports Units.Units.Electric.Current

Namespace Global.Units.UnitValue.Electric.Current

    Partial Public NotInheritable Class Ampere : Inherits AbstractUnitValue(Of Units.Electric.Current.Ampere)

        Public Sub New(Value As Decimal)
            MyBase.New(Value, Global.Units.Electric.Current.Ampere.Instance)
        End Sub

        Friend Overrides Function CreateNew(Value As Decimal) As AbstractUnitValue(Of Units.Electric.Current.Ampere)
            Return New Ampere(Value)
        End Function

        Public Shared Widening Operator CType(x As Decimal) As Ampere
            Return New Ampere(x)
        End Operator


    End Class

End Namespace