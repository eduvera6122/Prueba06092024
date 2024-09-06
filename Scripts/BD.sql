-- Creación de la tabla Usuario
CREATE TABLE Usuario (
    UsuarioID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
	Password NVARCHAR(100) NOT NULL,
	Tipo NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL UNIQUE,
    Telefono NVARCHAR(15),
    Direccion NVARCHAR(255)
);

-- Creación de la tabla SolicitudPrestamo
CREATE TABLE SolicitudPrestamo (
    SolicitudID INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioID INT,
    FechaSolicitud DATE NOT NULL,
    MontoSolicitado DECIMAL(18, 2) NOT NULL,
    Estado NVARCHAR(50) NOT NULL, -- Ej: Pendiente, Aprobado, Rechazado
    CONSTRAINT FK_Solicitud_Usuario FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID)
);

-- Creación de la tabla Prestamo
CREATE TABLE Prestamo (
    PrestamoID INT IDENTITY(1,1) PRIMARY KEY,
    SolicitudID INT,
    UsuarioID INT,
    FechaAprobacion DATE NOT NULL,
    MontoPrestado DECIMAL(18, 2) NOT NULL,
    TasaInteres DECIMAL(5, 2) NOT NULL, -- Ej: 5.5 representa 5.5%
    Estado NVARCHAR(50) NOT NULL, -- Ej: Activo, Pagado, Cancelado
    CONSTRAINT FK_Prestamo_Solicitud FOREIGN KEY (SolicitudID) REFERENCES SolicitudPrestamo(SolicitudID),
    CONSTRAINT FK_Prestamo_Usuario FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID)
);

-- Creación de la tabla Pago
CREATE TABLE Pago (
    PagoID INT IDENTITY(1,1) PRIMARY KEY,
    PrestamoID INT,
    UsuarioID INT,
    FechaPago DATE NOT NULL,
    MontoPagado DECIMAL(18, 2) NOT NULL,
    MetodoPago NVARCHAR(50) -- Ej: Tarjeta, Transferencia
    CONSTRAINT FK_Pago_Prestamo FOREIGN KEY (PrestamoID) REFERENCES Prestamo(PrestamoID),
    CONSTRAINT FK_Pago_Usuario FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID)
);
