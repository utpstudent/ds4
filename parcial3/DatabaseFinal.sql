DROP DATABASE IF EXISTS MiguelMartinez;
GO

-- Crear nueva BD simplificada
CREATE DATABASE MiguelMartinez;
GO

USE MiguelMartinez;
GO

CREATE TABLE MM_Usuarios (
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Contrasena NVARCHAR(100) NOT NULL,
    Rol NVARCHAR(20) DEFAULT 'Investigador'
);
GO

CREATE TABLE MM_Articulos (
    ArticuloID INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(300) NOT NULL,
    Resumen NVARCHAR(1000),
    Autores NVARCHAR(500) NOT NULL,
    PalabrasClave NVARCHAR(200),
    DOI NVARCHAR(100),
    Estado NVARCHAR(50) DEFAULT 'En revisión',
    FechaPublicacion DATE,
    FechaRegistro DATETIME DEFAULT GETDATE(),
    UsuarioID INT FOREIGN KEY REFERENCES MM_Usuarios(UsuarioID)
);
GO

CREATE TABLE MM_Revistas (
    RevistaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(200) NOT NULL,
    ISSN NVARCHAR(50),
    FactorImpacto DECIMAL(4,2),
    Cuartil NVARCHAR(2),
    ArticuloID INT FOREIGN KEY REFERENCES MM_Articulos(ArticuloID)
);
GO

USE MiguelMartinez;
GO

-- ============================================
-- 1. INSERTAR USUARIOS
-- ============================================
INSERT INTO MM_Usuarios (Nombre, Email, Contrasena, Rol) VALUES
('Dra. María González', 'maria.gonzalez@universidad.edu', 'pass123', 'Investigador'),
('Dr. Carlos Ruiz', 'carlos.ruiz@instituto.edu', 'pass123', 'Investigador'),
('Dr. Ana Martínez', 'ana.martinez@centro.edu', 'pass123', 'Administrador'),
('Lic. Pedro Sánchez', 'pedro.sanchez@lab.edu', 'pass123', 'Investigador'),
('MSc. Laura Díaz', 'laura.diaz@ciencia.edu', 'pass123', 'Investigador');
GO

-- ============================================
-- 2. INSERTAR ARTÍCULOS
-- ============================================
INSERT INTO MM_Articulos (Titulo, Resumen, Autores, PalabrasClave, DOI, Estado, FechaPublicacion, FechaRegistro, UsuarioID) VALUES
('Machine Learning aplicado al diagnóstico temprano de cáncer de mama', 
 'Este estudio evalúa la efectividad de algoritmos de machine learning para la detección temprana de cáncer de mama mediante imágenes médicas.',
 'María González, Carlos López, Ana Pérez',
 'machine learning, cáncer, diagnóstico, inteligencia artificial',
 '10.1016/j.cancer.2023.123456',
 'Publicado',
 '2023-05-15',
 DATEADD(day, -60, GETDATE()),
 1),

('Análisis de sostenibilidad en agricultura urbana del siglo XXI', 
 'Investigación sobre técnicas innovadoras de agricultura urbana y su impacto en la sostenibilidad ambiental de grandes ciudades.',
 'Pedro Sánchez, Laura Martínez, Roberto Jiménez',
 'sostenibilidad, agricultura urbana, medio ambiente, ciudades',
 '10.1080/0028825X.2023.987654',
 'Aceptado',
 '2024-02-20',
 DATEADD(day, -45, GETDATE()),
 2),

('Blockchain para la trazabilidad de productos farmacéuticos', 
 'Propuesta de sistema basado en blockchain para mejorar la trazabilidad y autenticidad de medicamentos en la cadena de suministro.',
 'Ana Martínez, David Torres, Sofía Ramírez',
 'blockchain, farmacéuticos, trazabilidad, seguridad',
 '10.1109/ACCESS.2023.112233',
 'En revisión',
 NULL,
 DATEADD(day, -30, GETDATE()),
 3),

('Impacto del cambio climático en la biodiversidad marina del Caribe', 
 'Estudio longitudinal sobre los efectos del cambio climático en los ecosistemas marinos del Caribe colombiano.',
 'Carlos Ruiz, Elena Vargas, Miguel Ángel Cruz',
 'cambio climático, biodiversidad, Caribe, ecosistemas marinos',
 '10.3354/meps12345',
 'Publicado',
 '2022-11-10',
 DATEADD(day, -90, GETDATE()),
 4),

('Desarrollo de materiales nanocompuestos para energía solar', 
 'Síntesis y caracterización de nuevos materiales nanocompuestos con aplicaciones en celdas solares de tercera generación.',
 'Laura Díaz, Fernando Ortega, Claudia Rojas',
 'nanocompuestos, energía solar, materiales, renovables',
 '10.1039/D2TA01234',
 'Rechazado',
 NULL,
 DATEADD(day, -15, GETDATE()),
 5),

('Inteligencia Artificial en la predicción de enfermedades cardiovasculares', 
 'Modelo predictivo basado en IA para evaluar riesgos de enfermedades cardiovasculares usando datos clínicos no invasivos.',
 'María González, Jorge Silva, Patricia Mendoza',
 'inteligencia artificial, salud, cardiología, predicción',
 '10.1161/CIRCULATIONAHA.2023.445566',
 'Publicado',
 '2023-08-30',
 DATEADD(day, -75, GETDATE()),
 1),

('Economía circular en la industria manufacturera colombiana', 
 'Análisis de la implementación de principios de economía circular en pequeñas y medianas empresas manufactureras.',
 'Pedro Sánchez, Adriana Castro, Ricardo Peña',
 'economía circular, manufactura, sostenibilidad, Colombia',
 '10.1080/09537287.2023.223344',
 'Aceptado',
 '2024-03-15',
 DATEADD(day, -20, GETDATE()),
 2);
GO

-- ============================================
-- 3. INSERTAR REVISTAS
-- ============================================
INSERT INTO MM_Revistas (Nombre, ISSN, FactorImpacto, Cuartil, ArticuloID) VALUES
('Journal of Cancer Research', '1234-5678', 8.45, 'Q1', 1),
('Sustainability Science Review', '8765-4321', 6.78, 'Q2', 2),
('IEEE Transactions on Blockchain', '2345-6789', 7.90, 'Q1', 3),
('Marine Ecology Progress Series', '3456-7890', 5.65, 'Q2', 4),
('Journal of Materials Chemistry A', '4567-8901', 9.25, 'Q1', 5),
('Circulation: AI in Medicine', '5678-9012', 10.15, 'Q1', 6),
('Circular Economy Insights', '6789-0123', 4.35, 'Q3', 7);
GO


INSERT INTO MM_Articulos (Titulo, Autores, UsuarioID, FechaRegistro)
VALUES ('Prueba SQL', 'Autor Test', 1, GETDATE());

select * from MM_Articulos;