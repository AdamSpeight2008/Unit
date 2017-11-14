Namespace Global.Units.Units.AmountOfSubstance
    Interface IUnitsKind_AmountOfSubstance : Inherits IAbstractUnits
    End Interface

    Partial Public MustInherit Class AbstractAmountOfSubstanceUnits
        Inherits AbstractUnits

        Implements IUnitsKind_AmountOfSubstance

        Friend Sub New(Symbol As String, FullName As String)
            Me.Symbol = Symbol
            Me.FullName = FullName
        End Sub
        Public Overrides ReadOnly Property Symbol As String Implements IAbstractUnits.Symbol
        Public Overrides ReadOnly Property FullName As String Implements IAbstractUnits.FullName
    End Class
End Namespace