using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace BLL.Network
{
    //用户
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    //病人信息
    public class PatientInfo
    {
        public string patientID { get; set; }
        public string name { get; set; }
        public string cardNum { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        public string registration_time { get; set; }
        public string visting_time { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string tempeterature { get; set; }
        public string respiration { get; set; }
        public string pulse { get; set; }
        public string blood_pressure { get; set; }
        public string disease_description { get; set; }
        public string blood_sugar { get; set; }
    }
    //诊室信息
    public class OfficeInfo
    {
        public string officeID { get; set; }
        public string name { get; set; }
    }
    //医生信息
    public class DoctorInfo
    {
        public string doctorID { get; set; }
        public string name { get; set; }
        public string office { get; set; }
        public string empId { get; set; }
        public string introduction { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
    }
    //队列信息
    public class QueueInfo
    {
        public string q_officeID { get; set; }
        public string[] first_diagnosis = new string[1000];
        public string[] twice_diagnosis = new string[1000];
        public string[] triage = new string[1000];
    }
    //所有信息
    public class AllInfo
    {
        public PatientInfo[] allPatient=new PatientInfo[1000];
        public OfficeInfo[] allOffice = new OfficeInfo[1000];
        public DoctorInfo[] allDoctor = new DoctorInfo[1000];
        public QueueInfo[] allQueue = new QueueInfo[1000];
    }
    //Type0：初始化
    public class INITIALIZE
    {
        string opcode = "0";
        public User user { get; set; }
    }
    //Type1：刷新
    public class REFRESH
    {
        string opcode = "1";
    }
    //Type2：患者队列变换
    public class CHANGE_PATIENT_QUEUE
    {
        string opcode = "2";
        public string patientID { get; set; }
        public string officeID { get; set; }
        public string current_queueID { get; set; }
        public string current_doctorID { get; set; }
        public string target_queueID { get; set; }
        public string target_doctorID { get; set; }
    }
    //Type3： 患者诊室变换
    public class CHANGE_PATIENT_OFFICE
    {
        string opcode = "3";
        public string patientID { get; set; }
        public string current_officeID { get; set; }
        public string current_doctorID { get; set; }
        public string current_queueID { get; set; }
        public string target_officeID { get; set; }
    }
    //Type4：设置患者个人信息
    public class SET_PATIENT_INFO
    {
        string opcode = "4";
        public PatientInfo info { get; set; }
    }
    //Type5：更新诊室信息
    public class SET_OFFICE_INFO
    {
        string opcode = "5";
        public OfficeInfo info { get; set; }
    }
    //Type6：更新医生信息
    public class SET_DOCTOR_INFO
    {
        string opcode = "6";
        public DoctorInfo info { get; set; }
    }
    //Type7：添加患者信息
    public class ADD_PATIENT
    {
        string opcode = "7";
        public PatientInfo info { get; set; }
    }
    //Type8：添加诊室信息
    public class ADD_OFFICE
    {
        string opcode = "8";
        public OfficeInfo info { get; set; }
    }
    //Type9：添加医生信息
    public class ADD_DOCTOR
    {
        string opcode = "9";
        public DoctorInfo info { get; set; }
    }
    //Type10：医生队列变化，也就是“下一个”
    public class DOCTOR_SAY_NEXT
    {
        string opcode = "10";
        public string doctorID { get; set; }
    }
    /*以下是应答*/
    //Type0：初始化
    public class INITIALIZE_ECHO
    {
        string opcode = "0";
        public AllInfo info { get; }
    }
    //Type1：刷新
    public class REFRESH_ECHO
    {
        string opcode = "1";
        public AllInfo info { get;}
    }
    //Type2：患者队列变换
    public class CHANGE_PATIENT_QUEUE_ECHO
    {
        string opcode = "2";
        public string is_succeed { get; }
        public string error { get; }
    }
    //Type3： 患者诊室变换
    public class CHANGE_PATIENT_OFFICE_ECHO
    {
        string opcode = "3";
        public string is_succeed { get; }
        public string error { get; }
    }
    //Type4：设置患者个人信息
    public class SET_PATIENT_INFO_ECHO
    {
        string opcode = "4";
        public string is_succeed { get; }
        public string error { get; }
    }
    //Type5：更新诊室信息
    public class SET_OFFICE_INFO_ECHO
    {
        string opcode = "5";
        public string is_succeed { get; }
        public string error { get; }
    }
    //Type6：更新医生信息
    public class SET_DOCTOR_INFO_ECHO
    {
        string opcode = "6";
        public string is_succeed { get; }
        public string error { get; }
    }
    //Type7：添加患者信息
    public class ADD_PATIENT_ECHO
    {
        string opcode = "7";
        public string is_succeed { get; }
        public string error { get; }
    }
    //Type8：添加诊室信息
    public class ADD_OFFICE_ECHO
    {
        string opcode = "8";
        public string is_succeed { get; }
        public string error { get; }
    }
    //Type9：添加医生信息
    public class ADD_DOCTOR_ECHO
    {
        string opcode = "9";
        public string is_succeed { get; }
        public string error { get; }
    }
    //Type10：医生队列变化，也就是“下一个”
    public class DOCTOR_SAY_NEXT_ECHO
    {
        string opcode = "10";
        public string is_succeed { get; }
        public string error { get; }
    }
}
