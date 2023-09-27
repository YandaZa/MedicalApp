Imports System.Net.Http
Imports DevOne.Security.Cryptography.BCrypt
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json


Public Class Util
    Private apiKey As String = "9221414dfab6644a7a8889229aa74ee7"
    Private baseUrl As String = "https://api.openweathermap.org/data/2.5/weather"
    Public Shared Function generateOTP(OTPlength As Integer) As String

        ' Create an instance of the Random class
        Dim randomizer As New Random()
        Dim otp As String = ""
        ' Define the characters you want to choose from
        Dim characters As String = "0123456789"


        Do While otp.Length < OTPlength
            ' Generate a random index within the range of the characters string
            Dim randomIndex As Integer = randomizer.Next(0, characters.Length)

            ' Get the random character
            Dim randomChar As Char = characters(randomIndex)
            otp += randomChar
        Loop

        Return otp
    End Function

    Public Shared Function generateOTP(OTPlength As Integer, OTPtype As String) As String

        ' Create an instance of the Random class
        Dim randomizer As New Random()
        Dim otp As String = ""
        ' Define the characters you want to choose from
        Dim characters As String = ""

        If OTPtype.ToUpper() = "DIGITS" Then
            characters = "0123456789"
        ElseIf OTPtype.ToUpper() = "ALPHA" Then
            characters = "abcdefghijklmnopqrstuvwxyz"
        ElseIf OTPtype.ToUpper() = "MIXED" Then
            characters = "0123456789abcdefghijklmnopqrstuvwxyz"
        Else
            MsgBox("Error Generating OTP, Incorrect OTP Type")
        End If


        Do While otp.Length < OTPlength
            ' Generate a random index within the range of the characters string
            Dim randomIndex As Integer = randomizer.Next(0, characters.Length)

            ' Get the random character
            Dim randomChar As Char = characters(randomIndex)
            otp += randomChar
        Loop

        Return otp
    End Function

    Public Shared Function verifyOTP(userInput As TextBox, generatedOTP As String) As Boolean
        If Not userInput.Text.Trim = generatedOTP Then Return False
        Return True
    End Function


    Public Shared Function stringToTextBox(S As String) As TextBox
        Dim result As New TextBox
        result.Text = S.Trim
        Return result
    End Function

    Private Async Function GetWeatherDataAsync(cityName As String, Temp As Label, Descript As Label, Visible As Label,
                                              Speed As Label, Cloud As Label, Humid As Label) As Task
        Try
            Using client As New HttpClient()
                Dim apiUrl = $"{baseUrl}?q={cityName}&appid={apiKey}&units=metric"
                Dim response = Await client.GetStringAsync(apiUrl)
                Dim jsonData As JObject = JObject.Parse(response)

                ' Extract weather information from the JSON response
                Dim temperature As Double = jsonData("main")("temp").Value(Of Double)
                Dim description As String = jsonData("weather")(0)("description").Value(Of String)
                Dim visibility As Integer = jsonData("visibility").Value(Of Integer)
                Dim windSpeed As Double = jsonData("wind")("speed").Value(Of Double)
                Dim cloudCover As Integer = jsonData("clouds")("all").Value(Of Integer)
                Dim humidity As Integer = jsonData("main")("humidity").Value(Of Integer)

                ' Update UI elements with weather data
                Temp.Text = $"Temperature: {temperature}°C"
                Descript.Text = $"Description: {description}"
                Visible.Text = $"Visibility: {visibility} meters"
                Speed.Text = $"Wind Speed: {windSpeed} m/s"
                Cloud.Text = $"Cloud Cover: {cloudCover}%"
                Humid.Text = $"Humidity: {humidity}%"
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Weather App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

End Class
