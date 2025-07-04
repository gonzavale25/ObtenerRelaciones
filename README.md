###  ESTRUCTURA A COPIAR:
```
└── 📁ObtenerSolucionesMicroservice.Domain.csproj
        └── ObtenerRelacionesDomain.cs
└── 📁ObtenerSolucionesMicroservice.Entities
        └── 📁DTOs
            └── .empty
            └── RelacionesDTO.cs
└── 📁ObtenerSolucionesMicroservice.Infraestructure
        └── ObtenerRelacionesRepository.cs
└── 📁ObtenerSolucionesMicroservice.Repository
        └── IObtenerRelacionesRepository.cs
```

### ESTRUCTURA DEL PROYECTO EN GENERAL 
```
    └── ObtenerSoluciones.sln
    └── 📁ObtenerSolucionesMicroservice.Api
        └── appsettings.Development.json
        └── appsettings.json
        └── 📁Controllers
            └── ObtenerRelacionesController.cs
        └── 📁Extensions
            └── ApplicationBuilderExtensions.cs
            └── ServiceCollectionExtensions.cs
        └── Program.cs
        └── Startup.cs
        └── Startup.cs
        └── ObtenerSolucionesMicroservice.Api.csproj
        └── ObtenerSolucionesMicroservice.Api.csproj.user
        └── EjemploDomain.cs
    └── 📁ObtenerSolucionesMicroservice.Domain.csproj
        └── ObtenerRelacionesDomain.cs
        └── ObtenerSolucionesMicroservice.Domain.csproj
    └── 📁ObtenerSolucionesMicroservice.Entities
        └── 📁Enums
            └── .empty
        └── 📁Filter
            └── .empty
            └── EjemploFilter.cs
            └── EjemploFilterType.cs
        └── 📁FilterValidator
            └── EjemploFilterValidator.cs
        └── 📁Model
            └── .empty
            └── ObtenerRelacionesEntity.cs
        └── 📁DTOs
            └── .empty
            └── RelacionesDTO.cs
        └── 📁Request
            └── BaseRequest.cs
            └── EjemploRequest.cs
        └── 📁Response
            └── BaseResponse.cs
            └── EjemploResponse.cs
        └── ObtenerSolucionesMicroservice.Entities.csproj
    └── 📁ObtenerSolucionesMicroservice.Exceptions
        └── CustomException.cs
        └── EjemplHeaderException.cs
        └── FluentValidatorExceptions.cs
        └── ObtenerSolucionesMicroservice.Exceptions.csproj
    └── 📁ObtenerSolucionesMicroservice.Infraestructure
        └── BaseRepository.cs
        └── ConnectionFactory.cs
        └── ObtenerRelacionesRepository.cs
        └── ObtenerSolucionesMicroservice.Infraestructure.csproj
    └── 📁ObtenerSolucionesMicroservice.Repository
        └── IConnectionFactory.cs
        └── IObtenerRelacionesRepository.cs
        └── IGenericRepository.cs
        └── ObtenerSolucionesMicroservice.Repository.csproj
    └── 📁ObtenerSolucionesTest
        └── EjemploDomainTest.cs
        └── ObtenerSolucionesTest.csproj
    └── 📁ObtenerSolucionesTest
        └── EjemploDomainTest.cs
        └── ObtenerSolucionesTest.csproj
    └── 📁Util
        └── TrackerConfig.cs
        └── Util.csproj
```

