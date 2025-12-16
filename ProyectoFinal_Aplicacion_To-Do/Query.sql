-- =============================================
-- Database: ToDoListDB
-- Description: Base de datos para aplicación To-Do List
-- Created by: Miguel Martínez
-- Date: 10/12/2024
-- =============================================

-- 1. Crear base de datos si no existe
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'ToDoListDB')
BEGIN
    CREATE DATABASE ToDoListDB;
    PRINT 'Base de datos ToDoListDB creada exitosamente.';
END
ELSE
BEGIN
    PRINT 'La base de datos ToDoListDB ya existe.';
END
GO

-- 2. Usar la base de datos
USE ToDoListDB;
GO

-- 3. Crear tabla Tareas
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tareas')
BEGIN
    CREATE TABLE Tareas (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Titulo NVARCHAR(100) NOT NULL,
        Descripcion NVARCHAR(500) NULL,
        FechaCreacion DATETIME2 NOT NULL DEFAULT GETDATE(),
        FechaVencimiento DATETIME2 NULL,
        Completada BIT NOT NULL DEFAULT 0,
        Prioridad INT NOT NULL DEFAULT 2 CHECK (Prioridad BETWEEN 1 AND 3)
    );
    PRINT 'Tabla Tareas creada exitosamente.';
END
ELSE
BEGIN
    PRINT 'La tabla Tareas ya existe.';
END
GO

--4.  Crear tabla Usuarios
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Usuarios')
BEGIN
    CREATE TABLE Usuarios (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        NombreUsuario NVARCHAR(50) NOT NULL UNIQUE,
        Password NVARCHAR(100) NOT NULL,
        Email NVARCHAR(100) NULL,
        NombreCompleto NVARCHAR(100) NULL,
        FechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
        Activo BIT NOT NULL DEFAULT 1
    );
    PRINT 'Tabla Usuarios creada exitosamente.';
END

--5. Crear usuario de prueba (contraseña: demo123)
IF NOT EXISTS (SELECT * FROM Usuarios WHERE NombreUsuario = 'Cuenta Prueba')
BEGIN
    INSERT INTO Usuarios (NombreUsuario, Password, NombreCompleto, Email)
    VALUES ('demo', 'C4CA4238A0B923820DCC509A6F75849B', 'Usuario Demo', 'demo@example.com');
    PRINT 'Usuario demo creado (contraseña: demo123)';
END

-- 6. Crear índices para mejorar rendimiento
CREATE INDEX IX_Tareas_Completada ON Tareas(Completada);
CREATE INDEX IX_Tareas_Prioridad ON Tareas(Prioridad DESC);
CREATE INDEX IX_Tareas_FechaVencimiento ON Tareas(FechaVencimiento);
GO

-- =============================================
-- PROCEDIMIENTOS ALMACENADOS
-- =============================================

-- 1. Obtener todas las tareas
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_ObtenerTareas')
    DROP PROCEDURE usp_ObtenerTareas;
GO

CREATE PROCEDURE usp_ObtenerTareas
AS
BEGIN
    SELECT 
        Id,
        Titulo,
        Descripcion,
        FechaCreacion,
        FechaVencimiento,
        Completada,
        Prioridad
    FROM Tareas
    ORDER BY 
        CASE WHEN Completada = 1 THEN 1 ELSE 0 END,       -- Completadas al final
        Prioridad DESC,
        CASE WHEN FechaVencimiento IS NULL THEN 1 ELSE 0 END, -- NULLS LAST
        FechaVencimiento ASC;
END
GO


-- 2. Obtener tarea por ID
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_ObtenerTareaPorId')
    DROP PROCEDURE usp_ObtenerTareaPorId;
GO

CREATE PROCEDURE usp_ObtenerTareaPorId
    @Id INT
AS
BEGIN
    SELECT 
        Id,
        Titulo,
        Descripcion,
        FechaCreacion,
        FechaVencimiento,
        Completada,
        Prioridad
    FROM Tareas
    WHERE Id = @Id;
END
GO

-- 3. Insertar nueva tarea
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_InsertarTarea')
    DROP PROCEDURE usp_InsertarTarea;
GO

CREATE PROCEDURE usp_InsertarTarea
    @Titulo NVARCHAR(100),
    @Descripcion NVARCHAR(500) = NULL,
    @FechaVencimiento DATETIME = NULL,
    @Prioridad INT = 2,
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO Tareas (
        Titulo,
        Descripcion,
        FechaCreacion,
        FechaVencimiento,
        Completada,
        Prioridad
    ) VALUES (
        @Titulo,
        @Descripcion,
        GETDATE(),
        @FechaVencimiento,
        0,
        @Prioridad
    );
    
    SET @Id = SCOPE_IDENTITY();
    
    PRINT 'Tarea insertada exitosamente. ID: ' + CAST(@Id AS NVARCHAR(10));
END
GO

-- 4. Actualizar tarea
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_ActualizarTarea')
    DROP PROCEDURE usp_ActualizarTarea;
GO

CREATE PROCEDURE usp_ActualizarTarea
    @Id INT,
    @Titulo NVARCHAR(100),
    @Descripcion NVARCHAR(500) = NULL,
    @FechaVencimiento DATETIME = NULL,
    @Completada BIT,
    @Prioridad INT
AS
BEGIN
    UPDATE Tareas SET
        Titulo = @Titulo,
        Descripcion = @Descripcion,
        FechaVencimiento = @FechaVencimiento,
        Completada = @Completada,
        Prioridad = @Prioridad
    WHERE Id = @Id;
    
    PRINT 'Tarea actualizada exitosamente. Filas afectadas: ' + CAST(@@ROWCOUNT AS NVARCHAR(10));
END
GO

-- 5. Eliminar tarea
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_EliminarTarea')
    DROP PROCEDURE usp_EliminarTarea;
GO

CREATE PROCEDURE usp_EliminarTarea
    @Id INT
AS
BEGIN
    DELETE FROM Tareas 
    WHERE Id = @Id;
    
    PRINT 'Tarea eliminada exitosamente. Filas afectadas: ' + CAST(@@ROWCOUNT AS NVARCHAR(10));
END
GO

-- 6. Marcar tarea como completada
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_MarcarCompletada')
    DROP PROCEDURE usp_MarcarCompletada;
GO

CREATE PROCEDURE usp_MarcarCompletada
    @Id INT,
    @Completada BIT
AS
BEGIN
    UPDATE Tareas SET
        Completada = @Completada
    WHERE Id = @Id;
    
    PRINT 'Estado de tarea actualizado. Filas afectadas: ' + CAST(@@ROWCOUNT AS NVARCHAR(10));
END
GO

-- 7. Obtener tareas pendientes (no completadas)
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_ObtenerTareasPendientes')
    DROP PROCEDURE usp_ObtenerTareasPendientes;
GO

CREATE PROCEDURE usp_ObtenerTareasPendientes
AS
BEGIN
    SELECT 
        Id,
        Titulo,
        Descripcion,
        FechaCreacion,
        FechaVencimiento,
        Completada,
        Prioridad
    FROM Tareas
    WHERE Completada = 0
    ORDER BY 
        Prioridad DESC,
        CASE WHEN FechaVencimiento IS NULL THEN 1 ELSE 0 END,
        FechaVencimiento ASC;
END
GO


-- 8. Obtener estadísticas
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_ObtenerEstadisticas')
    DROP PROCEDURE usp_ObtenerEstadisticas;
GO

CREATE PROCEDURE usp_ObtenerEstadisticas
AS
BEGIN
    DECLARE @Total INT, @Completadas INT, @Pendientes INT, @Vencidas INT;
    
    SELECT @Total = COUNT(*) FROM Tareas;
    SELECT @Completadas = COUNT(*) FROM Tareas WHERE Completada = 1;
    SELECT @Pendientes = COUNT(*) FROM Tareas WHERE Completada = 0;
    SELECT @Vencidas = COUNT(*) FROM Tareas 
    WHERE Completada = 0 
    AND FechaVencimiento < GETDATE();
    
    SELECT 
        @Total AS TotalTareas,
        @Completadas AS TareasCompletadas,
        @Pendientes AS TareasPendientes,
        @Vencidas AS TareasVencidas;
END
GO

-- =============================================
-- DATOS DE PRUEBA (OPCIONAL)
-- =============================================

-- Insertar datos de prueba si la tabla está vacía
IF NOT EXISTS (SELECT TOP 1 * FROM Tareas)
BEGIN
    PRINT 'Insertando datos de prueba...';
    
    DECLARE @NewId INT;
    
    -- Tarea 1
    EXEC usp_InsertarTarea 
        @Titulo = 'Completar proyecto final',
        @Descripcion = 'Terminar aplicación To-Do List para Desarrollo de Software IV',
        @FechaVencimiento = '2024-12-16',
        @Prioridad = 3,
        @Id = @NewId OUTPUT;
    
    -- Tarea 2
    EXEC usp_InsertarTarea 
        @Titulo = 'Estudiar para examen',
        @Descripcion = 'Repasar temas de C# y ASP.NET MVC',
        @FechaVencimiento = '2024-12-18',
        @Prioridad = 2,
        @Id = @NewId OUTPUT;
    
    -- Tarea 3
    EXEC usp_InsertarTarea 
        @Titulo = 'Comprar víveres',
        @Descripcion = 'Ir al supermercado para la semana',
        @FechaVencimiento = '2024-12-20',
        @Prioridad = 1,
        @Id = @NewId OUTPUT;
    
    -- Tarea 4 (ya completada)
    EXEC usp_InsertarTarea 
        @Titulo = 'Configurar Visual Studio',
        @Descripcion = 'Instalar extensiones y configurar entorno',
        @FechaVencimiento = '2024-12-10',
        @Prioridad = 2,
        @Id = @NewId OUTPUT;
    
    -- Marcar la última como completada
    UPDATE Tareas SET Completada = 1 WHERE Id = @NewId;
    
    PRINT 'Datos de prueba insertados exitosamente.';
END
ELSE
BEGIN
    PRINT 'La tabla ya contiene datos. No se insertaron datos de prueba.';
END
GO

-- =============================================
-- VERIFICACIÓN
-- =============================================

PRINT '=============================================';
PRINT 'VERIFICACIÓN DE LA BASE DE DATOS';
PRINT '=============================================';

-- Mostrar todas las tablas
SELECT 
    t.name AS Tabla,
    (SELECT COUNT(*) FROM sys.columns c WHERE c.object_id = t.object_id) AS Columnas
FROM sys.tables t
WHERE t.type = 'U'
ORDER BY t.name;

-- Mostrar todos los procedimientos almacenados
SELECT 
    ROUTINE_NAME AS Procedimiento,
    ROUTINE_DEFINITION AS Definicion
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_TYPE = 'PROCEDURE'
ORDER BY ROUTINE_NAME;

-- Mostrar datos de prueba
PRINT '=============================================';
PRINT 'DATOS EN LA TABLA TAREAS:';
PRINT '=============================================';

SELECT 
    Id,
    Titulo,
    CASE 
        WHEN Completada = 1 THEN '✅ Completada'
        WHEN FechaVencimiento < GETDATE() THEN '❌ Vencida'
        ELSE '⏳ Pendiente'
    END AS Estado,
    CASE Prioridad
        WHEN 1 THEN '🔵 Baja'
        WHEN 2 THEN '🟡 Media'
        WHEN 3 THEN '🔴 Alta'
    END AS Prioridad,
    CONVERT(VARCHAR, FechaCreacion, 103) AS Creado,
    ISNULL(CONVERT(VARCHAR, FechaVencimiento, 103), 'Sin fecha') AS Vence
FROM Tareas
ORDER BY Prioridad DESC, FechaVencimiento ASC;

-- Probar procedimiento de estadísticas
PRINT '=============================================';
PRINT 'ESTADÍSTICAS:';
PRINT '=============================================';

EXEC usp_ObtenerEstadisticas;

PRINT '=============================================';
PRINT 'BASE DE DATOS ToDoListDB CONFIGURADA EXITOSAMENTE';
PRINT '=============================================';


Select * from Usuarios;

Select * from Tareas;

Delete from Usuarios where Id = 1;