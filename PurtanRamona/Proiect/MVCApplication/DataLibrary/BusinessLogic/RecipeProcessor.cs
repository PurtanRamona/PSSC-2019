using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
   public class RecipeProcessor
    {
        public static int  CreateRecipe(string firstName, string lastName, int age, string address, int medicalrecords, string diagnostic, string prescriptions)
        {
            RecipeModel data = new RecipeModel
            {
               
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Address = address,
                MedicalRecords = medicalrecords,
                Diagnostic = diagnostic,
                Prescriptions =prescriptions
            };

            string sql = @"insert into dbo.Recipe ( FirstName, LastName, Age, Address, MedicalRecords, Diagnostic, Prescriptions )
                          values( @FirstName, @LastName, @Age, @Address, @MedicalRecords, @Diagnostic, @Prescriptions) ;";
            return SqlDataAccess.SaveData(sql, data);

        }
        public static List<RecipeModel> LoadRecipe()
        {
            string sql = @"select Id, FirstName, LastName, Age, Address, MedicalRecords, Diagnostic, Prescriptions
                        from dbo.Recipe;";
            return SqlDataAccess.LoadData<RecipeModel>(sql);
        }
    }
}
