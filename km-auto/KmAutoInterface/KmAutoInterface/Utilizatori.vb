Public Class Utilizator
	Private _properties As New Dictionary(Of String, Object)
	Public Property propByName() As Dictionary(Of String, Object)
		Get
			Return _properties
		End Get
		Set(ByVal value As Dictionary(Of String, Object))
			_properties = value
		End Set

	End Property

	Public Property id As Long
		Get
			On Error Resume Next
			Return _properties("id")
		End Get
		Set(ByVal value As Long)
			_properties("id") = value
		End Set

	End Property

	Public Property DataInrolarii As Double
		Get
			On Error Resume Next
			Return _properties("DataInrolarii")
		End Get
		Set(ByVal value As Double)
			_properties("DataInrolarii") = value
		End Set

	End Property
	Public Property Nume As String
		Get
			On Error Resume Next
			Return _properties("Nume")
		End Get
		Set(ByVal value As String)
			_properties("Nume") = value
		End Set

	End Property

	Public Property Email As String
		Get
			On Error Resume Next
			Return _properties("Email")
		End Get
		Set(ByVal value As String)
			_properties("Email") = value
		End Set

	End Property


	Public Property LimitaKm As String
		Get
			On Error Resume Next
			Return _properties("LimitaKm")
		End Get
		Set(ByVal value As String)
			_properties("LimitaKm") = value
		End Set

	End Property

	Public Property FilialaId As Long
		Get
			On Error Resume Next
			Return _properties("FilialaId")
		End Get
		Set(ByVal value As Long)
			_properties("FilialaId") = value
		End Set

	End Property

	Public Property Activ As String
		Get
			On Error Resume Next
			Return _properties("Activ")
		End Get
		Set(ByVal value As String)
			_properties("Activ") = value
		End Set

	End Property

	Public Property Retinere As String
		Get
			On Error Resume Next
			Return _properties("Retinere")
		End Get
		Set(ByVal value As String)
			_properties("Retinere") = value
		End Set

	End Property

	Public Property EmailConsolight As String
		Get
			On Error Resume Next
			Return _properties("EmailConsolight")
		End Get
		Set(ByVal value As String)
			_properties("EmailConsolight") = value
		End Set

	End Property

	Public Property DeObiceiFolosesteMasina As String
		Get
			On Error Resume Next
			Return _properties("DeObiceiFolosesteMasina")
		End Get
		Set(ByVal value As String)
			_properties("DeObiceiFolosesteMasina") = value
		End Set

	End Property

	Public Property Observatii As String
		Get
			On Error Resume Next
			Return _properties("Observatii")
		End Get
		Set(ByVal value As String)
			_properties("Observatii") = value
		End Set

	End Property

	Public Property Telefon As String
		Get
			On Error Resume Next
			Return _properties("Telefon")
		End Get
		Set(ByVal value As String)
			_properties("Telefon") = value
		End Set

	End Property

	Public Property Alias_ As String
		Get
			On Error Resume Next
			Return _properties("Alias_")
		End Get
		Set(ByVal value As String)
			_properties("Alias_") = value
		End Set

	End Property

	Public Property Operatie As String
		Get
			On Error Resume Next
			Return _properties("Operatie")
		End Get
		Set(ByVal value As String)
			_properties("Operatie") = value
		End Set

	End Property

End Class

