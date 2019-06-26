using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.MY_Sql_Gateway;





namespace WebApplication3.Controllers
{

    public class HomeController : Controller

    {
        #region Fields

        private MYSQLGATWAY _objDataHelper;

        #endregion

        #region Home Controller constructor
        public HomeController()
        {
            this._objDataHelper = new MYSQLGATWAY();

        }

        #endregion

        #region Methods


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {

            return View(); ;
        }

        /// <summary>
        /// Information Regarding DropDown 
        /// </summary>
        /// <returns></returns>
        public IActionResult GetRegistered()
        {
            SqlConnection con = new SqlConnection("data source=DESKTOP-5D77V30; database=MasterDistrict; integrated security=SSPI");
            if (con.State == ConnectionState.Closed)
            {

                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Choose_District", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ViewData["DistrictName"] = ds.Tables[0];
                con.Close();
            }
           
            //ViewBag.Child = ChildRegistrationDetails();
            //ViewBag.head = HeadRegistrationDetails();
            //ViewBag.spouse = SpouseRegistreationDetails();

            return View();
        }
        /// <summary>
        /// Registration Forms 
        /// </summary>
        /// <param name="Bind"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetRegistered(BindingModel Bind)
        {
            SqlConnection con = new SqlConnection("data source=DESKTOP-5D77V30; database=MasterDistrict; integrated security=SSPI");
            if (con.State == ConnectionState.Closed)
            {


                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Insertion_Binding_Model", con);

            cmd.Parameters.AddWithValue("@HeadName", Bind.head.FirstOrDefault().HeadName.ToString());
            cmd.Parameters.AddWithValue("@TotalfamilyMember", Bind.head.FirstOrDefault().TotalfamilyMember.ToString());
            cmd.Parameters.AddWithValue("@HeadAge", Bind.head.FirstOrDefault().HeadAge.ToString());
            cmd.Parameters.AddWithValue("@HeadGender", Bind.head.FirstOrDefault().HeadGender.ToString());
            cmd.Parameters.AddWithValue("@HeadCaste", Bind.head.FirstOrDefault().HeadCaste.ToString());
            cmd.Parameters.AddWithValue("@HeadReligion", Bind.head.FirstOrDefault().HeadReligion.ToString());
            cmd.Parameters.AddWithValue("@HeadAddress", Bind.head.FirstOrDefault().HeadAddress.ToString());
            cmd.Parameters.AddWithValue("@HeadHighestEducationDetails", Bind.head.FirstOrDefault().HeadHighestEducationDetails.ToString());
            cmd.Parameters.AddWithValue("@FamilyAilment", Bind.head.FirstOrDefault().FamilyAilment.ToString());
            cmd.Parameters.AddWithValue("@HeadAnunalIncome", Bind.head.FirstOrDefault().HeadAnunalIncome.ToString());
            cmd.Parameters.AddWithValue("@HeadAdharCardNumber", Bind.head.FirstOrDefault().HeadAdharCardNumber.ToString());
            cmd.Parameters.AddWithValue("@HeadMobileNumber", Bind.head.FirstOrDefault().HeadMobileNumber.ToString());
            cmd.Parameters.AddWithValue("@Martial_Status", Bind.head.FirstOrDefault().Martial_Status.ToString());
            cmd.Parameters.AddWithValue("@SpouseName", Bind.spouse.FirstOrDefault().SpouseName.ToString());
            cmd.Parameters.AddWithValue("@SpouseAge", Bind.spouse.FirstOrDefault().SpouseAge.ToString());
            cmd.Parameters.AddWithValue("@SpouseOccupation", Bind.spouse.FirstOrDefault().SpouseOccupation.ToString());
            cmd.Parameters.AddWithValue("@SpouseGender", Bind.spouse.FirstOrDefault().SpouseGender.ToString());
            cmd.Parameters.AddWithValue("@SpouseRelation", Bind.spouse.FirstOrDefault().SpouseRelation.ToString());
            cmd.Parameters.AddWithValue("@SpouseLivingSince", Bind.spouse.FirstOrDefault().SpouseLivingSince.ToString());
            cmd.Parameters.AddWithValue("@SpouseHighestEducationDetails", Bind.spouse.FirstOrDefault().SpouseHighestEducationDetails.ToString()); ;
            cmd.Parameters.AddWithValue("@SpouseFamilyAilment", Bind.spouse.FirstOrDefault().SpouseFamilyAilment.ToString());
            cmd.Parameters.AddWithValue("@SpouseReligion", Bind.spouse.FirstOrDefault().SpouseReligion.ToString());
            cmd.Parameters.AddWithValue("@SpouseRemarks", Bind.spouse.FirstOrDefault().SpouseRemarks.ToString());
            cmd.Parameters.AddWithValue("@SpouseAdharCardNumber", Bind.spouse.FirstOrDefault().SpouseAdharCardNumber.ToString());
            cmd.Parameters.AddWithValue("@SpouseMobileNumber", Bind.spouse.FirstOrDefault().SpouseMobileNumber.ToString());
            cmd.Parameters.AddWithValue("@Child", Bind.spouse.FirstOrDefault().Child.ToString());
            cmd.Parameters.AddWithValue("@ChildName", Bind.Child.FirstOrDefault().ChildName.ToString());
            cmd.Parameters.AddWithValue("@ChildOccupation", Bind.Child.FirstOrDefault().ChildOccupation.ToString());
            cmd.Parameters.AddWithValue("@ChildAge", Bind.Child.FirstOrDefault().ChildAge.ToString());
            cmd.Parameters.AddWithValue("@ChildGender", Bind.Child.FirstOrDefault().ChildGender.ToString());
            cmd.Parameters.AddWithValue("@ChildRelation", Bind.Child.FirstOrDefault().ChildRelation.ToString());
            cmd.Parameters.AddWithValue("@ChildLivingSince", Bind.Child.FirstOrDefault().ChildLivingSince.ToString());
            cmd.Parameters.AddWithValue("@ChildHighestEducationDetails", Bind.Child.FirstOrDefault().ChildHighestEducationDetails.ToString());
            cmd.Parameters.AddWithValue("@ChildFamilyAilment", Bind.Child.FirstOrDefault().ChildFamilyAilment.ToString());
            cmd.Parameters.AddWithValue("@ChildReligion", Bind.Child.FirstOrDefault().ChildReligion.ToString());
            cmd.Parameters.AddWithValue("@ChildRemarks", Bind.Child.FirstOrDefault().ChildRemarks.ToString());
            cmd.Parameters.AddWithValue("@ChildAdharCardNumber", Bind.Child.FirstOrDefault().ChildAdharCardNumber.ToString());
            cmd.Parameters.AddWithValue("@ChildMobileNumber", Bind.Child.FirstOrDefault().ChildMobileNumber.ToString());



            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable ds = new DataTable();
            
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //adp.Fill(ds);
           
            con.Close();

           return View();
        }


        public IActionResult DistrictModel()
        {
            SqlConnection con = new SqlConnection("data source=DESKTOP-5D77V30; database=MasterDistrict; integrated security=SSPI");
            if (con.State == ConnectionState.Closed)
            {

                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Choose_District", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ViewData["DistrictName"] = ds.Tables[0];
                con.Close();
            }
            return View();
        }

        public JsonResult TehsilModel(string id)
        {

            SqlConnection con = new SqlConnection("data source=DESKTOP-5D77V30; database=MasterDistrict; integrated security=SSPI");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("District_Select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DistrictCode", id);
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ViewData["TehsilName"] = ds.Tables[0];
                con.Close();
            }

            return Json(ds.Tables[0]);
        }

        public JsonResult CityModel(string id)
        {

            SqlConnection con = new SqlConnection("data source=DESKTOP-5D77V30; database=MasterDistrict; integrated security=SSPI");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Tehsil_City_Select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TehsilCode", id);
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ViewData["CityName"] = ds.Tables[0];
                con.Close();
            }

            return Json(ds.Tables[0]);
        }
        public JsonResult VillageModel(string id)
        {

            SqlConnection con = new SqlConnection("data source=DESKTOP-5D77V30; database=MasterDistrict; integrated security=SSPI");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Tehsil_Select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CityCode", id);
            cmd.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ViewData["VillageName"] = ds.Tables[0];
                con.Close();
            }

            return Json(ds.Tables[0]);
        }
        [HttpGet]
        public IActionResult HeadRegistrationDetails()
        {
            return View();

        }
        [HttpPost]
        public IActionResult HeadRegistrationDetails(HeadRegistrationDetails Headdetails)
        {
            var userRec = new Responsemodel();

            List<KeyValuePair<string, string>> keyValuePairs = new List<KeyValuePair<string, string>>();
            keyValuePairs.Add(new KeyValuePair<string, string>("TotalfamilyMember", Headdetails.TotalfamilyMember.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("HeadName", Headdetails.HeadName.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("HeadGender", Headdetails.HeadGender.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("HeadCaste", Headdetails.HeadCaste.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("HeadReligion", Headdetails.HeadReligion.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("HeadAddress", Headdetails.HeadAddress.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("HeadAge", Headdetails.HeadAge.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("HeadHighestEducationDetails", Headdetails.HeadHighestEducationDetails.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("FamilyAilment", Headdetails.FamilyAilment.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("HeadAnunalIncome", Headdetails.HeadAnunalIncome.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("HeadAdharCardNumber", Headdetails.HeadAdharCardNumber.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("HeadMobileNumber", Headdetails.HeadMobileNumber.ToString()));

            DataTable dataTable;
            dataTable = _objDataHelper.ExecuteProcedure("Insertion_In_Head_table", keyValuePairs);
            userRec.response = dataTable.Rows[0]["response"].ToString();
            userRec.message = dataTable.Rows[0]["message"].ToString();
            return Ok(userRec);
        }


        [HttpGet]
        public IActionResult SpouseRegistreationDetails()
        {

            return View();
        }
        [HttpPost]
        public IActionResult SpouseRegistreationDetails(SpouseRegistreationDetails Spousedetails)
        {
            var userRec = new Responsemodel();

            List<KeyValuePair<string, string>> keyValuePairs = new List<KeyValuePair<string, string>>();
            keyValuePairs.Add(new KeyValuePair<string, string>("SpouseName", Spousedetails.SpouseName.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("SpouseOccupation", Spousedetails.SpouseOccupation.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("SpouseGender", Spousedetails.SpouseGender.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("SpouseLivingSince", Spousedetails.SpouseLivingSince.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("SpouseHighestEducationDetails", Spousedetails.SpouseHighestEducationDetails.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("SpouseAge", Spousedetails.SpouseAge.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("SpouseRelation", Spousedetails.SpouseRelation.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("SpouseFamilyAilment", Spousedetails.SpouseFamilyAilment.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("SpouseReligion", Spousedetails.SpouseReligion.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("SpouseRemarks", Spousedetails.SpouseRemarks.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("SpouseAdharCardNumber", Spousedetails.SpouseAdharCardNumber.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("SpouseMobileNumber", Spousedetails.SpouseMobileNumber.ToString()));

            DataTable dataTable;
            dataTable = _objDataHelper.ExecuteProcedure("Insertion_Into_Spouse", keyValuePairs);
            userRec.response = dataTable.Rows[0]["response"].ToString();
            userRec.message = dataTable.Rows[0]["message"].ToString();


            return Ok(userRec);

        }

        [HttpGet]
        public IActionResult ChildRegistrationDetails()

        {
            
            return View();
        }
        [HttpPost]
        public IActionResult ChildRegistrationDetails(ChildRegistrationDetails Childdetails)
        {
            var userRec = new Responsemodel();

            List<KeyValuePair<string, string>> keyValuePairs = new List<KeyValuePair<string, string>>();
            keyValuePairs.Add(new KeyValuePair<string, string>("ChildName", Childdetails.ChildName.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("ChildOccupation", Childdetails.ChildOccupation.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("ChildGender", Childdetails.ChildGender.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("ChildRelation", Childdetails.ChildRelation.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("ChildLivingSince", Childdetails.ChildLivingSince.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("ChildAge", Childdetails.ChildAge.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("ChildHighestEducationDetails", Childdetails.ChildHighestEducationDetails.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("ChildFamilyAilment", Childdetails.ChildFamilyAilment.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("ChildReligion", Childdetails.ChildReligion.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("ChildRemarks", Childdetails.ChildRemarks.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("ChildAdharCardNumber", Childdetails.ChildAdharCardNumber.ToString()));
            keyValuePairs.Add(new KeyValuePair<string, string>("ChildMobileNumber", Childdetails.ChildMobileNumber.ToString()));

            DataTable dataTable;
            dataTable = _objDataHelper.ExecuteProcedure("Insertion_In_Child_table", keyValuePairs);
            userRec.response = dataTable.Rows[0]["response"].ToString();
            userRec.message = dataTable.Rows[0]["message"].ToString();


            return Ok(userRec);


        }
        #endregion


    }
}
