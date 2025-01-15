## Configuring appsettings.cs 

### **API**

For the API you should create an API Key which will authenticate services and users.
Generate a strong Key and store it in "ApiKey".
You should also have the Vendus API key [check Vendus instructions], so paste it in "VendusApi".

    {
      "ConnectionStrings": {
        "Database": "Host=db;Port=3306;Database=Aberta;Username=root;Password=P4sSw0+rd@"
      },
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft.AspNetCore": "Warning"
        }
      },
      "ApiKey": "",
      "OpenLibrary":{
        "BaseUrl": "https://openlibrary.org/"
      },
      "Bnp": {
        "BaseUrl": "https://urn.bnportugal.gov.pt/isbn/mods/xml"
      },
      "VendusApi": "",
      "ImagesPath": "/wwwroot/Images/",
      "Port": "5001"
    }



### **BackOffice**
For the BackOffice we will need the API address and image location.

    {
      "ConnectionStrings": {
        "DefaultConnection": "DataSource=Data\\app.db;Cache=Shared"
      },
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft.AspNetCore": "Warning"
        }
      },
      "AbertaApi": {
        "BaseUrl": "http://localhost:5002/",
        "ImageUrl": "http://api:5001/Image/",
	"ApiKey": ""
      },
      "Port": "5002"
    }

### **Scanner**
Finally for the Scanner project, paste the API Key you generated for the API project.

    {
      "ConnectionStrings": {
        "HangfireConnection": "Server=localhost;Database=master;User Id=sa;Password=P4sSw0+rd@-;TrustServerCertificate=True;"
      },
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft.AspNetCore": "Warning"
        }
      },
      "AbertaApi": {
        "BaseUrl": "http://api:5001/Books/",
        "ApiKey": ""
      },
      "Port": "5003"
    }

