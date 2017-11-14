
Imports Units.Units.Time

Namespace Global.Units.UnitValue.Time

    Partial Public NotInheritable Class Minutes : Inherits AbstractUnitValue(Of Units.Time.Minutes)

        Public Sub New(Value As Decimal)
            MyBase.New(Value, Global.Units.Units.Time.Minutes.Instance)
        End Sub

        Friend Overrides Function CreateNew(Value As Decimal) As AbstractUnitValue(Of Units.Time.Minutes)
            Return New Minutes(Value)
        End Function

        Public Shared Widening Operator CType(x As Decimal) As Minutes
            Return New Minutes(x)
        End Operator
        Public Shared Narrowing Operator CType(x As Minutes) As Seconds
            Return New Seconds(x.Value * 60D)
        End Operator

    End Class

End Namespace