CREATE DATABASE CAREERCOMPASS_DB;
GO

USE CAREERCOMPASS_DB;
GO

-- Tabla Estudiante
CREATE TABLE Estudiante (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NombreCompleto NVARCHAR(150) NOT NULL,
    CorreoElectronico NVARCHAR(150) NOT NULL UNIQUE,
    FechaNacimiento DATE NOT NULL
);
GO

-- Tabla Carrera
CREATE TABLE Carrera (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(MAX) NULL,
    Area NVARCHAR(100) NOT NULL,
    SalarioPromedio DECIMAL(10,2) NULL
);
GO

-- Tabla CarreraSugerida
CREATE TABLE CarreraSugerida (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    EstudianteId INT NOT NULL,
    CarreraId INT NOT NULL,
    Puntaje INT NOT NULL,

    CONSTRAINT FK_CarreraSugerida_Estudiante FOREIGN KEY (EstudianteId)
        REFERENCES Estudiante(Id)
        ON DELETE CASCADE,

    CONSTRAINT FK_CarreraSugerida_Carrera FOREIGN KEY (CarreraId)
        REFERENCES Carrera(Id)
        ON DELETE CASCADE
);
GO

-- Tabla TestVocacional (sin propiedad de navegación en Estudiante)
CREATE TABLE TestVocacional (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    EstudianteId INT NOT NULL,
    CodigoResultado NVARCHAR(100) NOT NULL,
    FechaRealizacion DATETIME NOT NULL,
    Puntaje INT NOT NULL,

    CONSTRAINT FK_TestVocacional_Estudiante FOREIGN KEY (EstudianteId)
        REFERENCES Estudiante(Id)
        ON DELETE CASCADE
);
GO