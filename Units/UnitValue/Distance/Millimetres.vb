
Namespace Global.Units.UnitValue.Distance

    Partial Public NotInheritable Class Millimetres : Inherits AbstractUnitValue(Of Units.Distance.Millimetres)
        Public Sub New(Value As Decimal)
            MyBase.New(Value, Global.Units.Units.Distance.Millimetres.Instance)
        End Sub
        Public Shared Widening Operator CType(x As Decimal) As Millimetres
            Return New Millimetres(x)
        End Operator
    End Class

End Namespace