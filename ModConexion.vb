Imports MySqlConnector

Public Module ModConexion

    Private Const CADENA As String =
        "Server=localhost;Port=3306;Database=bibliotecadb;" &
        "Uid=app_lectura;Pwd=Lectura2026;"

    Public Function ObtenerConexion() As MySqlConnection
        Return New MySqlConnection(CADENA)
    End Function

End Module