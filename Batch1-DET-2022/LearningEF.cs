using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LearningEF
    {
        public static void Main()
        {
            //  GetAllEmpDetails();
            //GetEmpDetailByID();
            //AddNewEmployee();
            //DeleteEmp();
            //UpdateEmp();
            //GetEmployeeSP();
            // DeleteEmployee();
            //GetEmployeeSPByPara();
            CallStoredProcwithSQLParamater_insert();
            Console.ReadLine();

        }

        //private static void GetAllEmpDetails()
        //{
        //    var ctx = new learningtsqlContext();
        //    var emps = ctx.Emps;

        //    foreach (var emp in emps)
        //    {
        //        Console.WriteLine(emp.Ename);
        //    }
        //}


        //private static void GetEmpDetailByID()
        //{
        //    var ctx = new Models.learningtsqlContext();
        //    var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
        //    Console.WriteLine(emp.Ename + "  " + emp.Sal + "  " + emp.Job);

        //}

        //private static void AddNewEmployee()
        //{
        //    var ctx = new Models.learningtsqlContext();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 2979;
        //        employee.Ename = "Vishwanath";
        //        employee.Sal = 1000;
        //        employee.Deptno = 30;
        //        employee.Job = "employee";
        //        ctx.Add(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New employee added");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException);
        //    }
        //}

        //private static void DeleteEmp()
        //{
        //    var ctx = new Models.learningtsqlContext();
        //    Emp employee = new Emp();
        //    employee.Empno = 2979;
        //    employee.Deptno = 30;

        //    ctx.Remove(employee);
        //    ctx.SaveChanges();
        //    Console.WriteLine("employee deleted");
        //}

        //private static void UpdateEmp()
        //{
        //    try
        //    {
        //        var ctx = new Models.learningtsqlContext();
        //        Emp employee = new Emp();
        //        employee.Empno = 7499;
        //        employee.Ename = "Vishwaa";
        //        employee.Deptno = 30;
        //        ctx.Update(employee);
        //        ctx.SaveChangesAsync();
        //        Console.WriteLine("employee Updated ");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException);
        //    }


        //private static void GetEmployeeSP()
        //{
        //    var ctx = new Models.learningtsqlContext();
        //    var employee = ctx.Emps.FromSqlRaw($"sp_GetEmployeeEname").ToList();

        //    foreach (var e in employee)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }
        //}


        //private static void GetEmployeeSPByPara()
        //{
        //    var ctx = new Models.learningtsqlContext();
        //    var employee = ctx.Emps.FromSqlRaw($"EXECUTE dbo.sp_GetEmployeeEname {7521}").ToList();

        //    foreach (var e in employee)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }
        //}

        //private static void DeleteEmployee()
        //{
        //    var ctx = new Models.learningtsqlContext();
        //    var employee = ctx.Emps.Where(e => e.Empno == 7521).SingleOrDefault();
        //    ctx.Remove(employee);
        //    ctx.SaveChanges();

        //}



        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new learningtsqlContext();
            var param = new Microsoft.Data.SqlClient.SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@Empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 7783
                        },

                         new SqlParameter() {
                            ParameterName = "@ename",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Jack"},

                          new SqlParameter() {
                            ParameterName = "@Job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Employee"}

                       };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("insertemployee @Empno, @Ename, @Job", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.InnerException);
            }


            Console.WriteLine("update successful");

        }
    }
}