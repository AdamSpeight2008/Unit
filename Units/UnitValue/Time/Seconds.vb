
Imports Units.Units.Time

Namespace Global.Units.UnitValue.Time

    Partial Public NotInheritable Class Seconds : Inherits AbstractUnitValue(Of Units.Time.Seconds)


        Public Sub New(Value As Decimal)
            MyBase.New(Value, Global.Units.Units.Time.Seconds.Instance)
        End Sub

        Friend Overrides Function CreateNew(Value As Decimal) As AbstractUnitValue(Of Units.Time.Seconds)
            Return New Seconds(Value)
        End Function

        Public Shared Widening Operator CType(x As Decimal) As Seconds
            Return New Seconds(x)
        End Operator

        Public Shared Narrowing Operator CType(x As Seconds) As Minutes
            Return New Minutes(x.Value / 60D)
        End Operator

    End Class

End Namespace