﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_sys
{
    public class PatientModel
    {
        private int id;
        private String name;
        private String last_name;
        private String gender;
        private String dni;
        private String grade;
        private String sit_admin;
        private String state_pml;
        private String arma;
        private String unit;
        private String guarnicion;
        private int category;
        private int genderId;
        private String created;
        private String catetegoryValue;
        

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Grade { get => grade; set => grade = value; }
        public string Sit_admin { get => sit_admin; set => sit_admin = value; }
        public string State_pml { get => state_pml; set => state_pml = value; }
        public string Arma { get => arma; set => arma = value; }
        public string Guarnicion { get => guarnicion; set => guarnicion = value; }
        public int Category { get => category; set => category = value; }
        public int GenderId { get => genderId; set => genderId = value; }
        public string Created { get => created; set => created = value; }
        public string CatetegoryValue { get => catetegoryValue; set => catetegoryValue = value; }
        public string Unit { get => unit; set => unit = value; }
    }
}