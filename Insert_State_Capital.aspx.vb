Imports Oracle.ManagedDataAccess.Client
Partial Class Insert_State_Capital
    Inherits System.Web.UI.Page

 
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OracleConnection("Data Source=SANDYORACLE11G;Persist Security Info=True;User ID=ORA_TUTOR;Password=ora_tutor00;")
        Dim sql As String = "INSERT INTO ORA_TUTOR.STATE (STATE_NAME, CAPITAL) VALUES ( '" & TextBox1.Text & "','" & TextBox2.Text & "')"
        Dim cmd As New OracleCommand(sql, con)

        If con.State <> Data.ConnectionState.Open Then
            con.Open()
        End If

        Try
            cmd.ExecuteNonQuery()
        Catch

        Finally
            con.Close()
        End Try
    End Sub
End Class
