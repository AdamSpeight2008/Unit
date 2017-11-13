Namespace Global.Units.UnitValue

    Public Interface IUnitValue(Of TUnits As Units.AbstractUnits)
        ReadOnly Property Value As Decimal
        ReadOnly Property Units As TUnits
    End Interface

    Public MustInherit Class AbstractUnitValue(Of TUnits As Units.AbstractUnits)
        Implements IUnitValue(Of TUnits)
        Friend Sub New(Value As Decimal, Units As TUnits)
            Me.Value = Value
            Me.Units = Units
        End Sub
        Public ReadOnly Property Value As Decimal Implements IUnitValue(Of TUnits).Value
        Public ReadOnly Property Units As TUnits Implements IUnitValue(Of TUnits).Units
        Public Overrides Function ToString() As String
            Return $"{Value} {Units.ToString}"
        End Function
        Public Overloads Function ToString(format As String) As String
            Dim u = Me.Units.ToString(format)
            Return $"{Value} {u}"
        End Function
    End Class

End Namespace