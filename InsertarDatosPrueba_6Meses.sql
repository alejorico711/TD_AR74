USE [BD_64PR]
GO

-- =========================================================================================
-- Script: InsertarDatosPrueba_6Meses.sql
-- Descripción: Carga datos simulados de 6 meses de actividad hotelera (Junio a Noviembre 2026)
--              para probar el Reporte Inteligente con su Análisis Predictivo y Gráfico.
-- Tablas afectadas: TipoHabitacion, Habitacion, Huesped, Reserva, Pago.
-- =========================================================================================

PRINT 'Iniciando carga de datos simulados...';
GO

-- 1. Limpieza de datos transaccionales previos para evitar conflictos de claves foráneas
PRINT 'Limpiando datos transaccionales previos...';
DELETE FROM [dbo].[Pago];
DELETE FROM [dbo].[SolicitudServicio];
DELETE FROM [dbo].[Reserva];
DELETE FROM [dbo].[Habitacion];
DELETE FROM [dbo].[Huesped];
DELETE FROM [dbo].[TipoHabitacion];
GO

-- 2. Carga de Tipos de Habitación
PRINT 'Insertando Tipos de Habitación...';
SET IDENTITY_INSERT [dbo].[TipoHabitacion] ON;
INSERT INTO [dbo].[TipoHabitacion] ([IdTipoHabitacion], [Descripcion], [Capacidad], [PrecioPorNoche], [Activo]) VALUES 
(1, 'Individual Estándar', 1, 18000.00, 1),
(2, 'Doble Clásica', 2, 28000.00, 1),
(3, 'Triple Confort', 3, 40000.00, 1),
(4, 'Suite Ejecutiva', 4, 60000.00, 1);
SET IDENTITY_INSERT [dbo].[TipoHabitacion] OFF;
GO

-- 3. Carga de Habitaciones
PRINT 'Insertando Habitaciones...';
SET IDENTITY_INSERT [dbo].[Habitacion] ON;
INSERT INTO [dbo].[Habitacion] ([IdHabitacion], [Numero], [Descripcion], [Estado], [IdTipoHabitacion], [Activo]) VALUES
(1, 101, 'Habitación Simple - Piso 1', 'Disponible', 1, 1),
(2, 102, 'Habitación Simple - Piso 1', 'Disponible', 1, 1),
(3, 201, 'Habitación Doble - Vista al Frente', 'Disponible', 2, 1),
(4, 202, 'Habitación Doble - Vista al Jardín', 'Disponible', 2, 1),
(5, 203, 'Habitación Doble - Silenciosa', 'Disponible', 2, 1),
(6, 301, 'Habitación Triple Familiar', 'Disponible', 3, 1),
(7, 302, 'Habitación Triple Superior', 'Disponible', 3, 1),
(8, 401, 'Suite Presidencial con Balcón', 'Disponible', 4, 1);
SET IDENTITY_INSERT [dbo].[Habitacion] OFF;
GO

-- 4. Carga de Huéspedes
PRINT 'Insertando Huéspedes...';
SET IDENTITY_INSERT [dbo].[Huesped] ON;
INSERT INTO [dbo].[Huesped] ([IdHuesped], [Dni], [Nombre], [Apellido], [FechaNacimiento], [CorreoElectronico], [Telefono], [Activo]) VALUES
(1, '35123456', 'Lucas Martín', 'Benítez', '1990-05-14', 'lucas.benitez@gmail.com', '1145239871', 1),
(2, '37894561', 'María Florencia', 'Gómez', '1993-11-22', 'flor.gomez@gmail.com', '1163259874', 1),
(3, '28456123', 'Carlos Alberto', 'Rodríguez', '1980-03-19', 'carlos.rodriguez@hotmail.com', '1152147896', 1),
(4, '40123789', 'Sofía Valentina', 'López', '1997-08-04', 'sofia.lopez@gmail.com', '1136985214', 1),
(5, '32145698', 'Martín Ignacio', 'Díaz', '1986-09-30', 'm.diaz@outlook.com', '1147852369', 1),
(6, '39654123', 'Camila Belén', 'Álvarez', '1996-01-15', 'camila.alvarez@gmail.com', '1125896314', 1),
(7, '34789654', 'Joaquín', 'Pérez Ramos', '1989-12-08', 'joaquin.ramos@gmail.com', '1169874123', 1),
(8, '36985214', 'Agustina', 'Martínez Paz', '1992-07-25', 'agustina.martinez@gmail.com', '1154789632', 1),
(9, '30147852', 'Diego Fernando', 'Romero', '1983-04-12', 'diego.romero@yahoo.com', '1132145698', 1),
(10, '41258963', 'Valentina Rocío', 'Fernández', '1998-10-18', 'valen.fernandez@gmail.com', '1178963254', 1),
(11, '33652147', 'Nicolás Esteban', 'Silva', '1988-06-27', 'nico.silva@gmail.com', '1141258963', 1),
(12, '38452178', 'Julieta Denise', 'Morales', '1994-02-09', 'julieta.morales@hotmail.com', '1163258741', 1);
SET IDENTITY_INSERT [dbo].[Huesped] OFF;
GO

-- 5. Carga de Reservas (Junio a Noviembre 2026 - Finalizadas)
PRINT 'Insertando Reservas...';
SET IDENTITY_INSERT [dbo].[Reserva] ON;
INSERT INTO [dbo].[Reserva] ([IdReserva], [FechaCheckIn], [FechaCheckOut], [CantidadPersonas], [Estado], [IdHabitacion], [IdHuesped], [FechaAlta]) VALUES
-- MES 1: JUNIO 2026 (5 reservas)
(1, '2026-06-02', '2026-06-05', 1, 'Finalizada', 1, 1, '2026-05-28 10:15:00'),
(2, '2026-06-08', '2026-06-11', 2, 'Finalizada', 3, 2, '2026-06-01 11:30:00'),
(3, '2026-06-14', '2026-06-16', 3, 'Finalizada', 6, 3, '2026-06-10 16:45:00'),
(4, '2026-06-20', '2026-06-22', 1, 'Finalizada', 2, 4, '2026-06-15 09:20:00'),
(5, '2026-06-24', '2026-06-28', 2, 'Finalizada', 4, 5, '2026-06-18 14:10:00'),

-- MES 2: JULIO 2026 (Vacaciones de invierno - 6 reservas con mayor estadía y suite)
(6, '2026-07-02', '2026-07-06', 2, 'Finalizada', 3, 6, '2026-06-25 12:00:00'),
(7, '2026-07-08', '2026-07-12', 3, 'Finalizada', 6, 7, '2026-06-30 18:20:00'),
(8, '2026-07-11', '2026-07-15', 4, 'Finalizada', 8, 8, '2026-07-01 15:40:00'),
(9, '2026-07-16', '2026-07-19', 1, 'Finalizada', 1, 9, '2026-07-10 10:00:00'),
(10, '2026-07-20', '2026-07-24', 2, 'Finalizada', 4, 10, '2026-07-12 16:30:00'),
(11, '2026-07-24', '2026-07-28', 1, 'Finalizada', 2, 11, '2026-07-18 11:15:00'),

-- MES 3: AGOSTO 2026 (6 reservas)
(12, '2026-08-01', '2026-08-04', 2, 'Finalizada', 3, 12, '2026-07-26 14:00:00'),
(13, '2026-08-06', '2026-08-09', 1, 'Finalizada', 1, 1, '2026-08-01 09:45:00'),
(14, '2026-08-11', '2026-08-15', 3, 'Finalizada', 6, 2, '2026-08-05 17:10:00'),
(15, '2026-08-17', '2026-08-20', 4, 'Finalizada', 8, 3, '2026-08-10 13:20:00'),
(16, '2026-08-22', '2026-08-26', 2, 'Finalizada', 4, 4, '2026-08-15 16:00:00'),
(17, '2026-08-27', '2026-08-30', 1, 'Finalizada', 2, 5, '2026-08-20 11:30:00'),

-- MES 4: SEPTIEMBRE 2026 (7 reservas)
(18, '2026-09-02', '2026-09-05', 2, 'Finalizada', 5, 6, '2026-08-28 10:30:00'),
(19, '2026-09-06', '2026-09-10', 3, 'Finalizada', 7, 7, '2026-09-01 12:45:00'),
(20, '2026-09-11', '2026-09-14', 1, 'Finalizada', 1, 8, '2026-09-05 09:15:00'),
(21, '2026-09-15', '2026-09-19', 4, 'Finalizada', 8, 9, '2026-09-08 14:00:00'),
(22, '2026-09-20', '2026-09-24', 2, 'Finalizada', 3, 10, '2026-09-12 18:20:00'),
(23, '2026-09-25', '2026-09-29', 2, 'Finalizada', 4, 11, '2026-09-18 16:50:00'),
(24, '2026-09-27', '2026-09-30', 1, 'Finalizada', 2, 12, '2026-09-22 11:00:00'),

-- MES 5: OCTUBRE 2026 (8 reservas)
(25, '2026-10-01', '2026-10-05', 2, 'Finalizada', 3, 1, '2026-09-25 15:30:00'),
(26, '2026-10-05', '2026-10-09', 3, 'Finalizada', 6, 2, '2026-09-28 10:20:00'),
(27, '2026-10-09', '2026-10-13', 4, 'Finalizada', 8, 3, '2026-10-02 11:45:00'),
(28, '2026-10-13', '2026-10-16', 1, 'Finalizada', 1, 4, '2026-10-08 09:00:00'),
(29, '2026-10-16', '2026-10-20', 2, 'Finalizada', 4, 5, '2026-10-10 14:15:00'),
(30, '2026-10-20', '2026-10-24', 3, 'Finalizada', 7, 6, '2026-10-14 16:30:00'),
(31, '2026-10-24', '2026-10-28', 2, 'Finalizada', 5, 7, '2026-10-18 12:40:00'),
(32, '2026-10-27', '2026-10-31', 1, 'Finalizada', 2, 8, '2026-10-22 17:00:00'),

-- MES 6: NOVIEMBRE 2026 (8 reservas hasta fecha actual)
(33, '2026-11-01', '2026-11-04', 2, 'Finalizada', 3, 9, '2026-10-26 10:00:00'),
(34, '2026-11-03', '2026-11-07', 3, 'Finalizada', 6, 10, '2026-10-28 15:20:00'),
(35, '2026-11-06', '2026-11-10', 4, 'Finalizada', 8, 11, '2026-11-01 11:15:00'),
(36, '2026-11-09', '2026-11-13', 1, 'Finalizada', 1, 12, '2026-11-04 09:30:00'),
(37, '2026-11-12', '2026-11-16', 2, 'Finalizada', 4, 1, '2026-11-06 14:40:00'),
(38, '2026-11-14', '2026-11-18', 3, 'Finalizada', 7, 2, '2026-11-08 17:00:00'),
(39, '2026-11-16', '2026-11-20', 2, 'Finalizada', 5, 3, '2026-11-10 12:15:00'),
(40, '2026-11-17', '2026-11-20', 1, 'Finalizada', 2, 4, '2026-11-12 16:30:00');
SET IDENTITY_INSERT [dbo].[Reserva] OFF;
GO

-- 6. Carga de Pagos correspondientes a cada reserva
PRINT 'Insertando Pagos...';
SET IDENTITY_INSERT [dbo].[Pago] ON;
INSERT INTO [dbo].[Pago] ([IdPago], [IdReserva], [MetodoPago], [Monto], [FechaPago]) VALUES
-- Pagos Junio
(1, 1, 'Efectivo', 54000.00, '2026-06-05 10:30:00'),
(2, 2, 'Tarjeta De Debito', 84000.00, '2026-06-11 11:00:00'),
(3, 3, 'Transferencia', 80000.00, '2026-06-16 10:45:00'),
(4, 4, 'Efectivo', 36000.00, '2026-06-22 09:30:00'),
(5, 5, 'Tarjeta De Credito', 112000.00, '2026-06-28 12:15:00'),

-- Pagos Julio (Vacaciones de invierno)
(6, 6, 'Tarjeta De Debito', 112000.00, '2026-07-06 10:00:00'),
(7, 7, 'Transferencia', 160000.00, '2026-07-12 11:30:00'),
(8, 8, 'Tarjeta De Credito', 240000.00, '2026-07-15 12:00:00'),
(9, 9, 'Efectivo', 54000.00, '2026-07-19 09:15:00'),
(10, 10, 'Tarjeta De Credito', 112000.00, '2026-07-24 10:45:00'),
(11, 11, 'Efectivo', 72000.00, '2026-07-28 11:00:00'),

-- Pagos Agosto
(12, 12, 'Transferencia', 84000.00, '2026-08-04 10:20:00'),
(13, 13, 'Efectivo', 54000.00, '2026-08-09 09:50:00'),
(14, 14, 'Tarjeta De Debito', 160000.00, '2026-08-15 11:10:00'),
(15, 15, 'Tarjeta De Credito', 180000.00, '2026-08-20 12:00:00'),
(16, 16, 'Transferencia', 112000.00, '2026-08-26 10:30:00'),
(17, 17, 'Efectivo', 54000.00, '2026-08-30 09:40:00'),

-- Pagos Septiembre
(18, 18, 'Tarjeta De Debito', 84000.00, '2026-09-05 10:15:00'),
(19, 19, 'Transferencia', 160000.00, '2026-09-10 11:45:00'),
(20, 20, 'Efectivo', 54000.00, '2026-09-14 09:30:00'),
(21, 21, 'Tarjeta De Credito', 240000.00, '2026-09-19 12:20:00'),
(22, 22, 'Tarjeta De Debito', 112000.00, '2026-09-24 10:50:00'),
(23, 23, 'Transferencia', 112000.00, '2026-09-29 11:10:00'),
(24, 24, 'Efectivo', 54000.00, '2026-09-30 09:15:00'),

-- Pagos Octubre
(25, 25, 'Tarjeta De Debito', 112000.00, '2026-10-05 10:00:00'),
(26, 26, 'Transferencia', 160000.00, '2026-10-09 11:30:00'),
(27, 27, 'Tarjeta De Credito', 240000.00, '2026-10-13 12:15:00'),
(28, 28, 'Efectivo', 54000.00, '2026-10-16 09:20:00'),
(29, 29, 'Tarjeta De Debito', 112000.00, '2026-10-20 10:45:00'),
(30, 30, 'Transferencia', 160000.00, '2026-10-24 11:15:00'),
(31, 31, 'Efectivo', 112000.00, '2026-10-28 10:30:00'),
(32, 32, 'Tarjeta De Debito', 72000.00, '2026-10-31 09:45:00'),

-- Pagos Noviembre
(33, 33, 'Tarjeta De Credito', 84000.00, '2026-11-04 10:10:00'),
(34, 34, 'Transferencia', 160000.00, '2026-11-07 11:40:00'),
(35, 35, 'Tarjeta De Credito', 240000.00, '2026-11-10 12:00:00'),
(36, 36, 'Efectivo', 72000.00, '2026-11-13 09:30:00'),
(37, 37, 'Tarjeta De Debito', 112000.00, '2026-11-16 10:50:00'),
(38, 38, 'Transferencia', 160000.00, '2026-11-18 11:20:00'),
(39, 39, 'Efectivo', 112000.00, '2026-11-20 10:15:00'),
(40, 40, 'Tarjeta De Debito', 54000.00, '2026-11-20 10:30:00');
SET IDENTITY_INSERT [dbo].[Pago] OFF;
GO

PRINT 'Carga completada exitosamente.';
PRINT 'Se generaron 40 reservas con sus respectivos pagos entre Junio 2026 y Noviembre 2026.';
GO
