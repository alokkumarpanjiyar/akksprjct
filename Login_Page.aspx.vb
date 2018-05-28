Imports Oracle.ManagedDataAccess.Client

Partial Class Login_Page
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OracleConnection("Data Source=SANDYORACLE11G;Persist Security Info=True;User ID=ORA_TUTOR;Password=ora_tutor00;")
        Dim sql As String = "select * from credential_table where user_name= '" & TXT_USERNM.Text & "' and u_password='" & TXT_PASSWORD.Text & "'"
        Dim cmd As New OracleCommand(sql, con)

        If con.State <> Data.ConnectionState.Open Then
            con.Open()
        End If

        Try
            If cmd.ExecuteScalar > 0 Then
                Response.Redirect("http://localhost:21370/Success.aspx")
            Else
                Response.Redirect("http://localhost:21370/Failure.aspx")
            End If
        Catch ex As Exception

        Finally
            con.Close()
        End Try

    End Sub
End Class
