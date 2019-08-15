using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Modelle
{
    public class UserData
    {
        //define all the properties 

        public string freightOrderId { get; set; }
        public string companyName { get; set; }
        public string description { get; set; }
        public string freightOrderStatus { get; set; }
        public string timestamp { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string streetName { get; set; }
        public string streetNumber { get; set; }
        public string signatureTagPacker { get; set; }
        public string feedbackPacker { get; set; }
        public string photoTagsPacker { get; set; }
        public string signatureTagDriver { get; set; }
        public string feedbackDriver { get; set; }
        public string photoTagsDriver { get; set; }
        public string userId { get; set; }
  
      


          
    }
    public class createUserTable:UserData
    {

    }

    public class readUserData : UserData
    {
        public readUserData()
        {
        }

        public readUserData(DataRow row)
        {
           // to convert for reading 
          
            freightOrderId= row["freightOrderId"].ToString();
            companyName = row["CompanyName"].ToString();
            description= row["Description"].ToString();
            freightOrderStatus= row["freightOrderStatus"].ToString();
            timestamp = row["timestamp"].ToString();
            postalCode= row["PostalCode"].ToString();
            country= row["Country"].ToString();
            city= row["City"].ToString();
            streetName= row["StreetName"].ToString();
            streetNumber= row["StreetNumber"].ToString();
            signatureTagPacker= row["signatureTagPacker"].ToString();
            feedbackPacker= row["feedbackPacker"].ToString();
            photoTagsPacker= row["photoTagsPacker"].ToString();
            signatureTagDriver= row["signatureTagDriver"].ToString();
            feedbackDriver= row["feedbackDriver"].ToString();
            photoTagsDriver= row["photoTagsDriver"].ToString();
            userId= row["userId"].ToString();



        }
        //        public int Id { get; set; }

        public string freightOrderId { get; set; }
        public string companyName { get; set; }
        public string description { get; set; }
        public string freightOrderStatus { get; set; }
        public string timestamp { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string streetName { get; set; }
        public string streetNumber { get; set; }
        public string signatureTagPacker { get; set; }
        public string feedbackPacker { get; set; }
        public string photoTagsPacker { get; set; }
        public string signatureTagDriver { get; set; }
        public string feedbackDriver { get; set; }
        public string photoTagsDriver { get; set; }
        public string userId { get; set; }
    }
}
