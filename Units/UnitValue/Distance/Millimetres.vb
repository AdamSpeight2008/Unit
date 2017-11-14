
Imports Units.Units.Distance

Namespace Global.Units.UnitValue.Distance

    Partial Public NotInheritable Class Millimetres : Inherits AbstractUnitValue(Of Units.Distance.Millimetres)

        Public Sub New(Value As Decimal)
            MyBase.New(Value, Global.Units.Units.Distance.Millimetres.Instance)
        End Sub

        Friend Overrides Function CreateNew(Value As Decimal) As AbstractUnitValue(Of Units.Distance.Millimetres)
            Return New Millimetres(Value)
        End Function

        Public Shared Widening Operator CType(x As Decimal) As Millimetres
            Return New Millimetres(x)
        End Operator
        Public Shared Narrowing Operator CType(x As Millimetres) As Metres
            Return New Metres(x.Value / 1000D)
        End Operator

    End Class

End Namespace