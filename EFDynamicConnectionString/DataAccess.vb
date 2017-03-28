Imports System.Data.Entity.Core.EntityClient
Imports System.Data.SqlClient

Public Class DataAccess
    Public Shared Function TestConnection() As Boolean

        'Here the connection is in plain text, but you could have it stored in another secured location.

        'The following approaches can be used when using dynamic connection string:

        '(1): If you are going to store the EF connection string in a varchar field into a database, it must have the 
        'following format (Ex. using Integrated Windows Authentication)
        '-->  'metadata=res://*/ModelName.csdl|res://*/ModelName.ssdl|res://*/ModelName.msl;provider=System.Data.SqlClient;provider connection string="Data Source=ServerName;Initial Catalog=DatabaseName;Integrated Security=True"'

        Dim connected As Boolean = False
        Dim connectionString As String = Nothing

        Try

            '(2) If you are going to build the connection string programmatically, then use this approach:
            'Inspired from: https://msdn.microsoft.com/en-us/library/system.data.entityclient.entityconnectionstringbuilder(v=vs.110).aspx

            '-----BEGIN------*******Uncomment/comment the code below to test this approach*********
            '' Initialize the connection string builder for the underlying provider.
            'Dim sqlBuilder As New SqlConnectionStringBuilder

            ''Change the ServerName accordingly
            'sqlBuilder.DataSource = "D348070\SQLSERVER2016"
            ''Set the properties for the data source accordingly.            
            'sqlBuilder.InitialCatalog = "WideWorldImporters"
            'sqlBuilder.IntegratedSecurity = True

            '' Build the SqlConnection connection string.
            'Dim providerString As String = sqlBuilder.ToString

            '' Initialize the EntityConnectionStringBuilder.
            'Dim entityBuilder As New EntityConnectionStringBuilder

            ''Set the provider name.
            'entityBuilder.Provider = "System.Data.SqlClient"
            '' Set the provider-specific connection string.
            'entityBuilder.ProviderConnectionString = providerString
            '' Set the Metadata location to the current directory.
            'entityBuilder.Metadata = "res://*/MyModel.csdl|" &
            '                "res://*/MyModel.ssdl|" &
            '                "res://*/MyModel.msl"

            'connectionString = entityBuilder.ToString

            '-----END------*******Uncomment/comment the code above to test this approach*********

            '(3) Or simply read the string variable from another location from your preference using the following format:
            '-----BEGIN------*******Uncomment/comment the code bellow to test this approach*********
            connectionString = "metadata=res://*/MyModel.csdl|res://*/MyModel.ssdl|res://*/MyModel.msl;provider=System.Data.SqlClient;provider connection string=""Data Source=D348070\SQLSERVER2016;Initial Catalog=WideWorldImporters;Integrated Security=True"""
            '-----END------*******Uncomment/comment the code above to test this approach*********

            Using dbContext As New WideWorldImportersEntities(connectionString)
                connected = dbContext.Database.Exists()

                'When finish using the context dispose it
                dbContext.Dispose()

            End Using

            Return connected

        Catch ex As Exception
            Throw ex
        End Try
    End Function



End Class
