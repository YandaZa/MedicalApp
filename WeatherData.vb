Imports Newtonsoft.Json

Public Class WeatherData
    <JsonProperty("main")>
    Public Property Main As WeatherMain
    <JsonProperty("weather")>
    Public Property Weather As List(Of WeatherDescription)
    <JsonProperty("visibility")>
    Public Property Visibility As Integer
    <JsonProperty("wind")>
    Public Property Wind As WeatherWind
    <JsonProperty("clouds")>
    Public Property Clouds As WeatherClouds

    Public Class WeatherWind
        <JsonProperty("speed")>
        Public Property Speed As Double
    End Class

    Public Class WeatherClouds
        <JsonProperty("all")>
        Public Property All As Integer
    End Class
End Class

Public Class WeatherMain
    <JsonProperty("temp")>
    Public Property Temp As Double
    <JsonProperty("humidity")>
    Public Property Humidity As Integer
End Class

Public Class WeatherDescription
    <JsonProperty("description")>
    Public Property Description As String
End Class
