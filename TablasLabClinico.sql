CREATE DATABASE LaboratorioClinico;

CREATE TABLE Roles_Usuario (
  Id_Rol INT PRIMARY KEY,
  Nombre_rol VARCHAR(255)
);

CREATE TABLE Usuarios (
  Id_usuario INT PRIMARY KEY,
  Nombre_us VARCHAR(255),
  Contraseña_us VARCHAR(255),
  Estatus_us BIT,
  Correo_us VARCHAR(255),
  Id_Rol INT,
  FOREIGN KEY (Id_Rol) REFERENCES Roles_Usuario (Id_Rol)
);


CREATE TABLE Especialidad (
  Id_Especialidad INT PRIMARY KEY,
  Nombre_Esp VARCHAR(255),
  Fecha_Esp DATE,
  Estatus_Esp BIT
);


CREATE TABLE Medico (
  Id_Medico INT PRIMARY KEY,
  Nombre_med VARCHAR(255),
  Apellido_matmed VARCHAR(255),
  Apellido_patmed VARCHAR(255),
  Direccion_med VARCHAR(255),
  Tel_med VARCHAR(255),
  Fecha_Ingresomed DATE,
  Id_Especialidad INT,
  Id_usuario INT,
  FOREIGN KEY (Id_Especialidad) REFERENCES Especialidad (Id_Especialidad),
  FOREIGN KEY (Id_usuario) REFERENCES Usuarios (Id_usuario)
);

CREATE TABLE Paciente (
  Id_paciente INT PRIMARY KEY,
  Nombre_pacient VARCHAR(255),
  Apellido_mapacient VARCHAR(255),
  Apellido_patpacient VARCHAR(255),
  dni_pacient VARCHAR(255),
  Tel_pacient VARCHAR(255),
  Edad_pacient INT,
  EdadTipo_pacient VARCHAR(255),
  Sexo_pacient VARCHAR(255)
);

CREATE TABLE Analisis (
  Id_analisis INT PRIMARY KEY,
  Nombre_ans VARCHAR(255),
  Fecha_ans DATE,
  Estatus_ans BIT
);


CREATE TABLE Examen (
  Id_Examen INT PRIMARY KEY,
  Nombre_exm VARCHAR(255),
  Fecha_exm DATE,
  Estatus_exm BIT,
  Id_analisis INT,
  FOREIGN KEY (Id_analisis) REFERENCES Analisis (Id_analisis)
);


CREATE TABLE Resultado (
  Id_resultado INT PRIMARY KEY,
  Fecha_result DATE,
  Estatus_result BIT,
  Id_paciente INT,
  Id_usuario INT,
  FOREIGN KEY (Id_paciente) REFERENCES Paciente (Id_paciente),
  FOREIGN KEY (Id_usuario) REFERENCES Usuarios (Id_usuario)
);


CREATE TABLE RealizarExamen (
  Id_realizarexm INT PRIMARY KEY,
  Indica_rexamen VARCHAR(255),
  Nomindica_rexamen VARCHAR(255),
  Fecha_rexamen DATE,
  Estatus_rexamen BIT,
  Id_usuario INT,
  Id_paciente INT,
  FOREIGN KEY (Id_usuario) REFERENCES Usuarios (Id_usuario),
  FOREIGN KEY (Id_paciente) REFERENCES Paciente (Id_paciente)
);

CREATE TABLE RealizarExamenDetalle (
  Id_rexmdetalle INT PRIMARY KEY,
  Id_Examen INT,
  Id_analisis INT,
  Id_realizarexm INT,
  FOREIGN KEY (Id_Examen) REFERENCES Examen (Id_Examen),
  FOREIGN KEY (Id_analisis) REFERENCES Analisis (Id_analisis),
  FOREIGN KEY (Id_realizarexm) REFERENCES RealizarExamen (Id_realizarexm)
);

CREATE TABLE ResultadoDetalle (
  Id_resultadodetalle INT PRIMARY KEY,
  Id_resultado INT,
  Archivo_rdetalle VARCHAR(255),
  Id_rexmdetalle INT,
  FOREIGN KEY (Id_resultado) REFERENCES Resultado (Id_resultado),
  FOREIGN KEY (Id_rexmdetalle) REFERENCES RealizarExamenDetalle (Id_rexmdetalle)
);
