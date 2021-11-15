using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProactoDoctor.Utilities
{
    public static class Helper
    {
        public static String Admin = "Admin";
        public static String Patient = "Patient";
        public static String Doctor = "Doctor";
        public static String Examp = "Doctor";

        public static string appointmentAdded = "Appointment Added Successfully.";
        public static string appointmentUpdated = "Appointment Updated Successfully.";
        public static string appointmentDeleted = "Appointment Deleted Successfully.";
        public static string appointmentExits = "Appointment for selected date and time already exists.";
        public static string appointmentNotExits = "Appointment Not Exists.";
        public static string appointmentAddError = "Something went Wrong, Please try again.";
        public static string appointmentUpdateError = "Something went Wrong, Please try again.";
        public static string somethingWentWrong = "Something went Wrong, Please try again.";
        public static int failure_code = 0;
        public static int success_code = 1;

        public static List<SelectListItem> GetRolesForDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Text = Helper.Admin, Value = Helper.Admin},
                new SelectListItem{Text = Helper.Patient, Value = Helper.Patient},
                new SelectListItem{Text = Helper.Doctor, Value = Helper.Doctor},
            };
        }

        public static List<SelectListItem> GetTimeDropDown()
        {
            int minute = 60;
            List<SelectListItem> duration = new();
            for(int i=1; i<=12; i++)
            {
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + "Hr" });
                minute = minute + 30;
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + "Hr 30 min" });
                minute += 30;
            }
            return duration;
        }



    }
}



