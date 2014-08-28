Imports System.Data.Odbc
Module db_connection
    Public con As New OdbcConnection("DSN=cmcsdsn")
    Public vmemberid As String
End Module
