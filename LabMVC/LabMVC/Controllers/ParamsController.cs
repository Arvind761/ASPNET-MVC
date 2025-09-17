using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace LabMVC.Controllers
{
    public class ParamsController : Controller
    {
        public string Index()
        {
            return "It's is a default Action ";
        }
        public string Index1(int id)
        {
            return $"Id is : {id}";
        }
        public string Index2(int id = 0)
        {
            return $"ID can be null : {id}";
        }
        //Passing value to id is optional and if not passed value will be "null" 
        public string Index3(int? id)
        {
            return $"ID is {id}";
        }
        //Passing value to x is mandatory and if passed also it will not take it because of parameter name mis-match 
        public string Index4(int x) {
            return $"ID is {x}";
        }
        //Passing value to x is optional and if passed also it will not take it because of parameter name mismatch 
        public string Index5(int? x)
        {
            return $"ID is {x}";
        }
        //Passing value to Id is option because it is defined as type string & strings are by default Nullable (reference types) 
        public string Index6(string Id)
        {
            return $"ID is {Id}";
        }

        //Passing value to Id is mandatory and Name is optional 
        public string Index7(int Id, string Name)
        {
            return $"Id is: {Id} and Name: {Name}";
        }
//Passing values to Id and Name are optional 
        public string Index8(int? Id, string Name)
        {
            return $"Id is: {Id} and Name: {Name}";

        }

        //query string

        public string Index9(int Pid, string Pname, double Price)
        {
            return $"Pid: {Pid}; Pname: {Pname}; Price: {Price}";

        }

        public string Index10()
        {
            int Pid = Convert.ToInt32(Request.QueryString["Pid"]);
            string Pname = Request.QueryString["Pname"];
            double Price = Convert.ToDouble(Request.QueryString["Price"]);

            return $"Pid: {Pid}; Pname: {Pname}; Price: {Price}";
        }

        public string Validate1()
        {
            string Name = Request["Name"];
            string Pwd = Request["Pwd"];
            if (Name == "ar" && Pwd == "123")
            {
                return "validate User";
            }
            else
            {
                return "Invalide User";
            }

        }  
        public string Validate2(string Name, string Pwd)
        {
            if (Name == "ar" && Pwd == "123")
            {
                return "validate User";
            }
            else
            {
                return "Invalide User";
            }
        }





    }
}