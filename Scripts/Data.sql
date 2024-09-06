-- Inserción de datos en la tabla Usuario
INSERT INTO Usuario (Nombre, Password, Tipo, Correo, Telefono, Direccion)
VALUES
('Juan Pérez', 'pass1234', 'Cliente', 'juan.perez@example.com', '0987654321', 'Av. 10 de Agosto, Quito'),
('María López', 'securepass', 'Cliente', 'maria.lopez@example.com', '0981234567', 'Calle 5-32, Guayaquil'),
('Carlos Sánchez', 'mypassword', 'Administrador', 'carlos.sanchez@example.com', '0988765432', 'Av. De los Shyris, Quito'),
('Ana Morales', 'admin123', 'Cliente', 'ana.morales@example.com', '0981122334', 'Calle 10, Loja'),
('Pedro Fernández', 'passw0rd', 'Cliente', 'pedro.fernandez@example.com', '0985566778', 'Av. 6 de Diciembre, Quito');



-- Inserción de datos en la tabla SolicitudPrestamo
INSERT INTO SolicitudPrestamo (UsuarioID, FechaSolicitud, MontoSolicitado, Estado)
VALUES
(1, '2024-09-01', 1500.00, 'Pendiente'),
(2, '2024-09-02', 2000.00, 'Aprobado'),
(3, '2024-09-03', 2500.00, 'Rechazado'),
(4, '2024-09-04', 3000.00, 'Pendiente'),
(5, '2024-09-05', 3500.00, 'Aprobado');


-- Inserción de datos en la tabla Prestamo
INSERT INTO Prestamo (SolicitudID, UsuarioID, FechaAprobacion, MontoPrestado, TasaInteres, Estado)
VALUES
(2, 2, '2024-09-02', 2000.00, 5.50, 'Activo'),
(5, 5, '2024-09-05', 3500.00, 6.00, 'Activo'),
(1, 1, '2024-09-06', 1500.00, 5.00, 'Activo'),
(4, 4, '2024-09-06', 3000.00, 5.75, 'Pagado'),
(3, 3, '2024-09-07', 2500.00, 6.25, 'Cancelado');


-- Inserción de datos en la tabla Pago
INSERT INTO Pago (PrestamoID, UsuarioID, FechaPago, MontoPagado, MetodoPago)
VALUES
(1, 1, '2024-09-07', 500.00, 'Transferencia'),
(2, 2, '2024-09-08', 1000.00, 'Tarjeta'),
(3, 3, '2024-09-09', 2500.00, 'Transferencia'),
(4, 4, '2024-09-10', 1500.00, 'Tarjeta'),
(5, 5, '2024-09-11', 2000.00, 'Transferencia');


