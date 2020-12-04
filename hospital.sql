
CREATE DATABASE hospital_sys;
GO
USE hospital_sys;
GO

CREATE TABLE specialties (
  specialty_id int PRIMARY KEY IDENTITY(1, 1),
  name NVARCHAR(250)
)
GO

CREATE TABLE departaments (
  departament_id int PRIMARY KEY IDENTITY(1, 1),
  name nvarchar(255)
)
GO

CREATE TABLE categories (
  category_id int PRIMARY KEY IDENTITY(1, 1),
  name nvarchar(255)
)
GO

CREATE TABLE users (
  user_id INTEGER PRIMARY KEY IDENTITY(1, 1),
  name nvarchar(255),
  last_nmae nvarchar(255),  
  user_password  nvarchar(255),
  status INTEGER,
  user_type INTEGER,
  specialty_id INTEGER NOT NULL,
  departament_id INTEGER,
  CONSTRAINT fkuser_sp FOREIGN KEY (specialty_id) REFERENCES specialties (specialty_id),
  CONSTRAINT fkuser_dept FOREIGN KEY (departament_id) REFERENCES departaments (departament_id)
)
GO


CREATE TABLE [sessions] (
  user_id INTEGER,
  log_time datetime2,
  log_type INTEGER,
  CONSTRAINT fksession_user FOREIGN KEY (user_id) REFERENCES users (user_id),
)
GO

CREATE TABLE patients (
  patient_id int PRIMARY KEY IDENTITY(1, 1),
  patient_name nvarchar(255),
  last_name nvarchar(255),
  gender bit,
  dni nvarchar(255),  
  grade nvarchar(255),
  sit_admin nvarchar(255),
  state_pml nvarchar(255),
  arma nvarchar(255),
  guarnicion nvarchar(255),
  category_id int,
  CONSTRAINT fkpatient_category FOREIGN KEY (category_id) REFERENCES categories (category_id),
)
GO



CREATE TABLE appointments (
  appointment_id int PRIMARY KEY IDENTITY(1, 1),
  is_work_break bit,
  medical_history TEXT,
  clinical_examination TEXT,
  current_diseases TEXT,
  diagnostic_support TEXT,
  diagnosis TEXT,
  etiology TEXT,
  evolution TEXT,
  secual TEXT,
  treatment TEXT,
  forecat TEXT,
  magnitude_dependecny TEXT,
  degree_dependencty TEXT,
  comments_service_disease TEXT,
  approximate_time TEXT,
  works_to_realize TEXT,
  guarnizion TEXT,
  date_medical_meeting datetime2,
  next_evaluation_date datetime2,
  conclusions TEXT,
  patient_id INTEGER,
  user_id INTEGER,
  CONSTRAINT fkappointment_patient FOREIGN KEY (patient_id) REFERENCES patients (patient_id),
  CONSTRAINT fkappointment_user FOREIGN KEY (user_id) REFERENCES users (user_id),
)
GO



CREATE TABLE work_breaks (
  break_id int PRIMARY KEY IDENTITY(1, 1),  
  doc_status nvarchar(255),
  diagnostic nvarchar(255),
  date_pmi date,
  start_date date,
  end_date date,
  situation nvarchar(255),
  unit int,
  user_id int,
  patient_id int,
  CONSTRAINT fkbreak_patient FOREIGN KEY (patient_id) REFERENCES patients (patient_id),
  CONSTRAINT fkbreak_user FOREIGN KEY (user_id) REFERENCES users (user_id),
)
GO
