Namespace Global.Units.Units.Mass
    Interface IUnitsKind_Mass : Inherits IAbstractUnits
    End Interface

    Partial Public MustInherit Class AbstractMassUnits
        Inherits AbstractUnits

        Implements IUnitsKind_Mass

        Friend Sub New(Symbol As String, FullName As String)
            Me.Symbol = Symbol
            Me.FullName = FullName
        End Sub
        Public Overrides ReadOnly Property Symbol As String Implements IAbstractUnits.Symbol
        Public Overrides ReadOnly Property FullName As String Implements IAbstractUnits.FullName
    End Class
End Namespace