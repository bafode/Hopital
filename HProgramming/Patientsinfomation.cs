/****************************************************************************
**                      SAKARYA ÜNİVERSİTESİ
**                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                    NESNEYE DAYALI PROGRAMLAMA DERSİ
**                         2019-2020 BAHAR DÖNEMİ
**
**                       PROJE NUMARASI.........: 01
**                       ÖĞRENCİ ADI............:ARSENE ADJEVİ
**                       ÖĞRENCİ NUMARASI.......:B181200559
**                       DERSİN ALINDIĞI GRUP...: A
****************************************************************************/



using System;


namespace HProgramming
{
    class Patientsinfomation:Departmentİnformation //İ make ther one polymorphism property
    {
        private string _enregitramentnumber { get; set; } //For all patients we need the enregistrement number.
                                                          //with that we can do faster research in the database.

        private string _disease_description { get; set; }//we need a minimum of detail on the disease.
        private string _status { get; set; }//This is a very important field. This field should be constantly updated to show the patient's real-time status.
        private string _department { get; set; }//With this fields we will know in which department the patient is located.
        private DateTime _entry { get; set; }//It is very important to know the date on which the patient presented to our hospital.
        private DateTime _quit { get; set; }//It is very important to know the date on which the patient left our hospital.

        #region Encapsulation begin zone(public property)
        public string enregitramentnumber
        {
            get { return _enregitramentnumber; }
            set { _enregitramentnumber = value; }
        }
        public string disease_description
        {
            get { return _disease_description; }
            set { _enregitramentnumber = value; }
        }
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string department
        {
            get { return _department; }
            set { _department = value;}
        }
        public DateTime entry
        {
            get { return _entry; }
            set { _entry = value; }
        }
        public DateTime  quit
        {
            get { return _quit; }
            set { _quit = value; }
        }
        #endregion Encapsulation endzone

        public bool MyDateController(DateTime date)//this metode will verify if the valide date is cheked.Normally a valid entry or quit date   must be either today's date or an earlier date.
        {
            if (date.Day < DateTime.Now.Day)
            {
                
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
