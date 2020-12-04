CREATE TABLE [usuarios] (
  [id_usuario] int PRIMARY KEY IDENTITY(1, 1),
  [nombre] nvarchar(255),
  [apellidos] nvarchar(255),
  [id_especialidad] int,
  [clave] nvarchar(255),
  [estado] boolean
)
GO

CREATE TABLE [pacientes] (
  [id_paciente] int PRIMARY KEY IDENTITY(1, 1),
  [nombre] nvarchar(255),
  [apellido] nvarchar(255),
  [sex] boolean,
  [dni] nvarchar(255),
  [id_usuario] id,
  [grado] nvarchar(255),
  [sit_admin] boolean,
  [estadoPML] nvarchar(255),
  [id_depart] int,
  [arma] nvarchar(255),
  [n_pentaje] int,
  [guarnicion] nvarchar(255),
  [id_categoria_militar] id
)
GO

CREATE TABLE [categorias] (
  [id_categoria] int PRIMARY KEY IDENTITY(1, 1),
  [nombre] nvarchar(255)
)
GO

CREATE TABLE [departamentos] (
  [id_depart] int PRIMARY KEY IDENTITY(1, 1),
  [nombre] nvarchar(255)
)
GO

CREATE TABLE [descansos] (
  [id_descansos] int PRIMARY KEY IDENTITY(1, 1),
  [id_paciente] int,
  [estado_acta] boolean,
  [diagnostico] nvarchar(255),
  [fechaPMI] date,
  [fecha_inicio] date,
  [fecha_final] date,
  [situacion] nvarchar(255),
  [id_usuario] int,
  [unidad] int
)
GO

CREATE TABLE [especialidades] (
  [id_especialidad] int PRIMARY KEY IDENTITY(1, 1),
  [nombre] nvarchar(255)
)
GO

CREATE TABLE [reports] (
  [id_report] int PRIMARY KEY IDENTITY(1, 1),
  [fecha] date,
  [id_paciente] int,
  [id_usuario] int,
  [antecedentes] nvarchar(255),
  [enfermedades] nvarchar(255),
  [examen_clinico] nvarchar(255),
  [apoyo_diagnostico] nvarchar(255),
  [diagonostico] nvarchar(255),
  [etiologia] nvarchar(255),
  [tratamiento] nvarchar(255),
  [evolucion] nvarchar(255),
  [pronostico] nvarchar(255),
  [secuela] nvarchar(255),
  [magnitud_discapacidad] nvarchar(255),
  [grado_dependencia] nvarchar(255),
  [relacion_enfermedad] nvarchar(255),
  [fecha_tratamiento] date,
  [trabajo] nvarchar(255),
  [guarniciones] nvarchar(255),
  [fecha_junta] date,
  [fecha_reevaluacion] date,
  [conclusiones] nvarchar(255)
)
GO

ALTER TABLE [pacientes] ADD FOREIGN KEY ([id_usuario]) REFERENCES [usuarios] ([id_usuario])
GO

ALTER TABLE [pacientes] ADD FOREIGN KEY ([id_depart]) REFERENCES [departamentos] ([id_depart])
GO

ALTER TABLE [usuarios] ADD FOREIGN KEY ([id_especialidad]) REFERENCES [especialidades] ([id_especialidad])
GO

ALTER TABLE [pacientes] ADD FOREIGN KEY ([id_paciente]) REFERENCES [descansos] ([id_paciente])
GO

ALTER TABLE [usuarios] ADD FOREIGN KEY ([id_usuario]) REFERENCES [descansos] ([id_usuario])
GO

ALTER TABLE [pacientes] ADD FOREIGN KEY ([id_categoria_militar]) REFERENCES [categorias] ([id_categoria])
GO

ALTER TABLE [reports] ADD FOREIGN KEY ([id_paciente]) REFERENCES [pacientes] ([id_paciente])
GO

ALTER TABLE [reports] ADD FOREIGN KEY ([id_usuario]) REFERENCES [usuarios] ([id_usuario])
GO
