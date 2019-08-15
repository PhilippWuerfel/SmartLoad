using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenerateFreightOrderDummies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;



        private void button1_Click(object sender, EventArgs e)
        {
            List < FreightOrder > freightOrders = new List<FreightOrder>();
            DateTime today = new DateTime();
            String dateString = Convert.ToString(today.Date);
            FreightOrder freightOrder;
            int random_id;
            int random_postalcode;
            Random random = new Random();

            int amount = 1;
            for (int i = 0; i< amount; i++)
            {
                random_id = random.Next(1,100000000);
                random_postalcode = random.Next(10000, 99999);
                // FreightOrder(string id, string companyName, string description, EnumFreightOrderStatus freightOrderStatus, string date, string postalCode, string country, string city, string streetName, string streetNumber, string signatureTagPacker, string feedbackPacker, List<string> photoTagsPacker, string signatureTagDriver, string feedbackDriver, List<string> photoTagsDriver)
                freightOrder = new FreightOrder(Convert.ToString(random_id), "Mustermann Company", "Construction Elements", EnumFreightOrderStatus.BEFORE_PACKING, dateString,
                    Convert.ToString(random_postalcode), "Germany", "Berlin", "Mustermannstreet", "99", "sign_Packer_MaxMustermann"+Convert.ToString(random_id), "FeedbackPacker Text", "PhotoTagsPacker Tag1, Tag2, Tagn", "sign_Driver_MaxMustermann" + Convert.ToString(random_id), "FeedbackDriver Text", "PhotoTagsDriver Tag1, Tag2, Tagn");
                freightOrders.Add(freightOrder);
            }
            Console.WriteLine(freightOrders);

            ListViewItem listViewItem_FreightOrder = new ListViewItem();
            for (int i = 0; i<freightOrders.Count; i++)
            {                
                listView_FreightOrders.Items.Add(freightOrders.ElementAt(i).getCompanyName()+" ID: " + freightOrders.ElementAt(i).getId() );

                // -----------------------------------------------------------------------------------------S Q L ----------------------------------------------------------------------------------------------------------------------
                // Insert SQL Statements for transfering freightOrders to database
                // Example accessing ID of FreightOrder

                String test_id = freightOrders.ElementAt(i).getId();
                con = new SqlConnection(@"data source=bsspublic.database.windows.net; Initial catalog=HTW; user id=HTW; Password=u3Q9##X6&I;");
                
                cmd = new SqlCommand("INSERT INTO SmartLoadAppData(id,companyName, description,freightOrderStatus,date,postalCode,country,city,streetName,streetNumber,signatureTagPacker,feedbackPacker,photoTagsPacker,signatureTagDriver,feedbackDriver,photoTagsDriver) VALUES (150,'"+this.CompanyName+ "','description','BEFORE_PACKING','17.06.2019','10318','Germany','Berlin',1,1,1,1,1,1,1,1)", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



                // -----------------------------------------------------------------------------------------S Q L ----------------------------------------------------------------------------------------------------------------------
            }

        }

        enum EnumFreightOrderStatus
        {
            BEFORE_PACKING,
            ON_PACKING,
            AFTER_PACKING,
            BEFORE_DELIVERY,
            ON_DELIVERY,
        }

        private class FreightOrder
        {
            //currently only Strings --> Dummy testing
            private string id;
            private string companyName;
            private string description;
            private EnumFreightOrderStatus freightOrderStatus;
            private string date;
            private string postalCode;
            private string country;
            private string city;
            private string streetName;
            private string streetNumber;

            private string signatureTagPacker;
            private string feedbackPacker;
            private string photoTagsPacker;

            private string signatureTagDriver;
            private string feedbackDriver;
            private string photoTagsDriver;

            public FreightOrder(string id, string companyName, string description, EnumFreightOrderStatus freightOrderStatus, string date, string postalCode, string country, string city, string streetName, string streetNumber, string signatureTagPacker, string feedbackPacker, string photoTagsPacker, string signatureTagDriver, string feedbackDriver, string photoTagsDriver)
            {
                this.id = id;
                this.companyName = companyName;
                this.description = description;
                this.freightOrderStatus = freightOrderStatus;
                this.date = date;
                this.postalCode = postalCode;
                this.country = country;
                this.city = city;
                this.streetName = streetName;
                this.streetNumber = streetNumber;
                this.signatureTagPacker = signatureTagPacker;
                this.feedbackPacker = feedbackPacker;
                this.photoTagsPacker = photoTagsPacker;
                this.signatureTagDriver = signatureTagDriver;
                this.feedbackDriver = feedbackDriver;
                this.photoTagsDriver = photoTagsDriver;
            }

            public string getId()
            {
                return id;
            }

            public void setId(string id)
            {
                this.id = id;
            }

            public string getCompanyName()
            {
                return companyName;
            }

            public void setCompanyName(string companyName)
            {
                this.companyName = companyName;
            }

            public string getDescription()
            {
                return description;
            }

            public void setDescription(string description)
            {
                this.description = description;
            }

            public EnumFreightOrderStatus getFreightOrderStatus()
            {
                return freightOrderStatus;
            }

            public void setFreightOrderStatus(EnumFreightOrderStatus freightOrderStatus)
            {
                this.freightOrderStatus = freightOrderStatus;
            }

            public string getDate()
            {
                return date;
            }

            public void setDate(string date)
            {
                this.date = date;
            }

            public string getPostalCode()
            {
                return postalCode;
            }

            public void setPostalCode(string postalCode)
            {
                this.postalCode = postalCode;
            }

            public string getCountry()
            {
                return country;
            }

            public void setCountry(string country)
            {
                this.country = country;
            }

            public string getCity()
            {
                return city;
            }

            public void setCity(string city)
            {
                this.city = city;
            }

            public string getStreetName()
            {
                return streetName;
            }

            public void setStreetName(string streetName)
            {
                this.streetName = streetName;
            }

            public string getStreetNumber()
            {
                return streetNumber;
            }

            public void setStreetNumber(string streetNumber)
            {
                this.streetNumber = streetNumber;
            }

            public string getSignatureTagPacker()
            {
                return signatureTagPacker;
            }

            public void setSignatureTagPacker(string signatureTagPacker)
            {
                this.signatureTagPacker = signatureTagPacker;
            }

            public string getFeedbackPacker()
            {
                return feedbackPacker;
            }

            public void setFeedbackPacker(string feedbackPacker)
            {
                this.feedbackPacker = feedbackPacker;
            }

            public string getPhotoTagsPacker()
            {
                return photoTagsPacker;
            }

            public void setPhotoTagsPacker(string photoTagsPacker)
            {
                this.photoTagsPacker = photoTagsPacker;
            }

            public string getSignatureTagDriver()
            {
                return signatureTagDriver;
            }

            public void setSignatureTagDriver(string signatureTagDriver)
            {
                this.signatureTagDriver = signatureTagDriver;
            }

            public string getFeedbackDriver()
            {
                return feedbackDriver;
            }

            public void setFeedbackDriver(string feedbackDriver)
            {
                this.feedbackDriver = feedbackDriver;
            }

            public string getPhotoTagsDriver()
            {
                return photoTagsDriver;
            }

            public void setPhotoTagsDriver(string photoTagsDriver)
            {
                this.photoTagsDriver = photoTagsDriver;
            }
        }


    }
}
