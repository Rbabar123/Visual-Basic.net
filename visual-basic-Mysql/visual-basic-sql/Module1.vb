﻿Imports MySql.Data.MysqlClient

Module Module1
    Public con As New MySqlConnection

    Sub openCon()
        con.ConnectionString = "server=localhost;username=root;password=;database=db_tutorial"

        con.Open()
    End Sub
End Module
