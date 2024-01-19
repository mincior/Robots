Public Class Combustibil
	Private _properties As New Dictionary(Of String, Object)
	Public Property propByName() As Dictionary(Of String, Object)
		Get
			Return _properties
		End Get
		Set(ByVal value As Dictionary(Of String, Object))
			_properties = value
		End Set

	End Property

	Public Property Tip As String
		Get
			On Error Resume Next
			Return _properties("Tip")
		End Get
		Set(ByVal value As String)
			_properties("Tip") = value
		End Set

	End Property

	Public Property Data As Date
		Get
			On Error Resume Next
			Return _properties("Data")
		End Get
		Set(ByVal value As Date)
			_properties("Data") = value
		End Set

	End Property

	Public Property Pret As Double
		Get
			On Error Resume Next
			Return _properties("Pret")
		End Get
		Set(ByVal value As Double)
			_properties("Pret") = value
		End Set

	End Property

	Public Property id As Integer
		Get
			On Error Resume Next
			Return _properties("id")
		End Get
		Set(ByVal value As Integer)
			_properties("id") = value
		End Set

	End Property

	Public Property operatie As String
		Get
			On Error Resume Next
			Return _properties("operatie")
		End Get
		Set(ByVal value As String)
			_properties("operatie") = value
		End Set

	End Property
End Class

