Public Class HOTLINE
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        DASHBOARD.Show()
        Me.Dispose()
    End Sub
End Class