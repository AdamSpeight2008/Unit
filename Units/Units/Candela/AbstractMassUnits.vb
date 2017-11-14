Namespace Global.Units.Units.LuminousIntensity
    Interface IUnitsKind_LuminousIntensity : Inherits IAbstractUnits
    End Interface

    Partial Public MustInherit Class AbstractLuminousIntensityUnits
        Inherits AbstractUnits

        Implements IUnitsKind_LuminousIntensity

        Friend Sub New(Symbol As String, FullName As String)
            Me.Symbol = Symbol
            Me.FullName = FullName
        End Sub
        Public Overrides ReadOnly Property Symbol As String Implements IAbstractUnits.Symbol
        Public Overrides ReadOnly Property FullName As String Implements IAbstractUnits.FullName
    End Class
End Namespace