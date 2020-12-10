using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_sys.Models
{
    public class Appointment
    {
        private int id;
        private int isWorkBreak;
        private String medicalHistory;
        private String clinicalExamination;
        private String currentDisease;
        private String diagnosticSupport;
        private String diagnosis;
        private String etilogy;
        private String evolution;
        private String secual;
        private String treatment;
        private String forcecat;
        private String magnitudeDependecny;
        private String dregreeDpendency;
        private String commentsServiceDisease;
        private String aproximateTime;
        private String workRelize;
        private String guarnizion;
        private DateTime dateMedicalMeeting;
        private DateTime nextEvaluationDate;
        private String conclusion;
        private int patientId;
        private int userId;


        public int Id { get => id; set => id = value; }
        public int IsWorkBreak { get => isWorkBreak; set => isWorkBreak = value; }
        public string MedicalHistory { get => medicalHistory; set => medicalHistory = value; }
        public string ClinicalExamination { get => clinicalExamination; set => clinicalExamination = value; }
        public string CurrentDisease { get => currentDisease; set => currentDisease = value; }
        public string DiagnosticSupport { get => diagnosticSupport; set => diagnosticSupport = value; }
        public string Diagnosis { get => diagnosis; set => diagnosis = value; }
        public string Etilogy { get => etilogy; set => etilogy = value; }
        public string Evolution { get => evolution; set => evolution = value; }
        public string Secual { get => secual; set => secual = value; }
        public string Treatment { get => treatment; set => treatment = value; }
        public string Forcecat { get => forcecat; set => forcecat = value; }
        public string MagnitudeDependecny { get => magnitudeDependecny; set => magnitudeDependecny = value; }
        public string DregreeDpendency { get => dregreeDpendency; set => dregreeDpendency = value; }
        public string CommentsServiceDisease { get => commentsServiceDisease; set => commentsServiceDisease = value; }
        public string AproximateTime { get => aproximateTime; set => aproximateTime = value; }
        public string WorkRelize { get => workRelize; set => workRelize = value; }
        public string Guarnizion { get => guarnizion; set => guarnizion = value; }
        public DateTime DateMedicalMeeting { get => dateMedicalMeeting; set => dateMedicalMeeting = value; }
        public DateTime NextEvaluationDate { get => nextEvaluationDate; set => nextEvaluationDate = value; }
        public string Conclusion { get => conclusion; set => conclusion = value; }
        public int PatientId { get => patientId; set => patientId = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
