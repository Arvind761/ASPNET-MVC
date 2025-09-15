using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject1.Controllers
{
    public class ParamsController : Controller
    {
        //Passing value to id is mandatory 
        public string Index1(int id)
        {
            return "The value of id is: " + id;
        }
        //Passing value to id is optional and if not passed value will be "0" 
        public string Index2(int id = 0)
        {
            return "The value of id is: " + id;
        }
        //Passing value to id is optional and if not passed value will be "null" 
        public string Index3(int? id)
        {
            return "The value of id is: " + id;
        }
        //Passing value to x is mandatory and if passed also it will not take it because of parameter name mis-match 
        public string Index4(int x)
        {
            return "The value of id is: " + x;
        }
        //Passing value to x is optional and if passed also it will not take it because of parameter name mis-match 
        public string Index5(int? x)
        {
            return "The value of id is: " + x;
        }
        //Passing value to Id is mandatory and Name is optional 
        public string Index7(int Id, string Name)
        {
            return $"Value of Id is: {Id} and value of Name is: {Name}";
        }
        //Passing values to Id and Name are optional 
        public string Index8(int? Id, string Name)
        {
            return $"Value of Id is: {Id} and value of Name is: {Name}";
        }

        public string Index9(int Pid, string Pname, double Price)
        {
            return $"Pid: {Pid}; Pname: {Pname}; Price: {Price}";
        }

        public string Index10()
        {
            int Pid = int.Parse(Request.QueryString["Pid"]);
            string Pname = Request.QueryString["Pname"];
            double Price = double.Parse(Request.QueryString["Price"]);
            return $"Pid: {Pid}; Pname: {Pname}; Price: {Price}";
        }

        public string Index11()
        {
            int Pid = Convert.ToInt32(Request.QueryString["Pid"]); ;
            string Pname = Request.QueryString["Pname"];
            double Price = Convert.ToDouble(Request.QueryString["Price"]);
            return $"Pid: {Pid}; Pname: {Pname}; Price: {Price}";
        }
        public string Validate1()
        {
            string Name = Request["Name"];
            string Pwd = Request["Pwd"];
            if (Name == "Raju" && Pwd == "Admin")
                return "Valid User";
            else
                return "Invalid User";
        }
        public string Validate2(string Name, string Pwd)
        {
            if (Name == "Raju" && Pwd == "Admin")
                return "Valid User";
            else
                return "Invalid User";
        }
    }
}