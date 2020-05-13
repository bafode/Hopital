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
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;//To do this opration we need sqlclient module

namespace HProgramming
{
    public partial class PatientsForm : Form
    {


        Patientsinfomation patientsinfomation = new Patientsinfomation();
        //Now it is time to modeline one objet called patientsinformation of class Patientinformation.I will use yhis odjet to initialize all of the patients information box.
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-FLN043B\CYBDRY;Initial Catalog=HospitalManagmentSyst;Integrated Security=True");
        /*Create the new objet of Sqlconnectionnection using the right connection string.Befor we had create one Sqldatabase called  HospitalManagmentsystem
        */
        int Numberİd = 0;//we declare this number to initialize the patient list each time we update it.
        #region Forma initializer region begin
        public PatientsForm()
        {
            InitializeComponent();
            Centralpanel.Visible = false; //the declared Centralpanel will be hided in the first time
            updatepatientsbtn.Enabled = false;// This will make this button enable because before making an update, the element must already be there in the list
            sendpatientsinfobtn.Enabled = true;//be enaable to send new patinet info to sqlDB
            entrydatepicker.Value = DateTime.Now;//
            quitdatepicker.Value = DateTime.Now;//
            DataFill();//This fonction will be allow to fiil our patients information in our DatagridView

        }
        #endregion Form initializer  region end

        #region Textbox and datepicker or dropbox initilize  begin zone

        private void registrenumbertextbox_OnValueChanged(object sender, EventArgs e)
        {
            patientsinfomation.enregitramentnumber = registrenumbertextbox.Text.Trim();
        }

        private void firstnamepatients_OnValueChanged(object sender, EventArgs e)
        {
            patientsinfomation.firstname = firstnamepatients.Text.Trim();
        }

        private void lastnametextbox_OnValueChanged(object sender, EventArgs e)
        {
            patientsinfomation.lastname = lastnametextbox.Text.Trim();
        }

        private void parentsphonenumbertextbox_OnValueChanged(object sender, EventArgs e)
        {
            patientsinfomation.phoneNumber = parentsphonenumbertextbox.Text.Trim();
        }

        private void deseasedescriptiontextbox_TextChanged(object sender, EventArgs e)
        {
            patientsinfomation.disease_description = deseasedescriptiontextbox.Text.Trim();
        }

        private void departmentdropbox_onItemSelected(object sender, EventArgs e)
        {
            patientsinfomation.department = departmentdropbox.selectedValue.Trim();
        }

        private void roomnumberdropbox_onItemSelected(object sender, EventArgs e)
        {
            patientsinfomation.roomnumber = roomnumberdropbox.selectedValue.Trim();
        }

        private void bednumberdropbox_onItemSelected(object sender, EventArgs e)
        {
            patientsinfomation.bednumber = bednumberdropbox.selectedValue.Trim();
        }

        private void entrydatepicker_onValueChanged(object sender, EventArgs e)
        {
            if (patientsinfomation.MyDateController(entrydatepicker.Value) == true)//we call this methode to verify the cheked date 
            {
                patientsinfomation.entry = entrydatepicker.Value;//if the checked date is correct ? initialize
            }
            else
            {
                MessageBox.Show("Please Check valide date","Past date checked error");//Else this information will be shown
            }
        }

        private void statuschekerdropbox_onItemSelected(object sender, EventArgs e)
        {
            patientsinfomation.status = statuschekerdropbox.selectedValue;
        }

        private void quitdatepicker_onValueChanged(object sender, EventArgs e)
        {
            if (patientsinfomation.MyDateController(quitdatepicker.Value) == true)// same verification
            {
                patientsinfomation.quit = quitdatepicker.Value;//
            }
            else
            {
                MessageBox.Show("You have chosen a past date.Please Check valide date","Past date Error");
            }
        }

        #endregion Textbox and datepicker or dropbox initilize  end zone

        private void viewpatientslistbtn_Click(object sender, EventArgs e)//if this button is clicked patients enregisment form will be close and enregistred list will visible
        {
            Centralpanel.Visible = true;
        }

        private bool BoxController() //this function will allow us to avoid sending empty boxes
        {
            if (string.IsNullOrEmpty(patientsinfomation.firstname) || string.IsNullOrEmpty(patientsinfomation.lastname) || string.IsNullOrEmpty(patientsinfomation.phoneNumber) ||
                 string.IsNullOrEmpty(patientsinfomation.status) || string.IsNullOrEmpty(patientsinfomation.enregitramentnumber) || string.IsNullOrEmpty(patientsinfomation.disease_description) ||
                string.IsNullOrEmpty(patientsinfomation.roomnumber) || string.IsNullOrEmpty(patientsinfomation.department) || string.IsNullOrEmpty(patientsinfomation.bednumber) 
                )
            {
                return false;
            }
            else
                return true;
        }

        private void sendpatientsinfobtn_Click(object sender, EventArgs e)//send patients infomation do sqldb button
        {
            //It is highly recommended to use  try-case-finally for all operations linked to the sqlbd database.This avoids the recording of dirty data.
            try
            {
                if (sqlCon.State == ConnectionState.Closed)//now verify if our connection is open 
                {
                    sqlCon.Open();
                    /*First time we create Patient_table in our sql server and after that   we create a one storedprocedure called AddOrUpdatePatient
                    in order to create the function which will allow us to record the information in our datatable and update it*/
                    
                    SqlCommand sqlcmd = new SqlCommand("AddOrUpdatePatient", sqlCon);//Create new Sqlcommand objet
                    sqlcmd.CommandType = CommandType.StoredProcedure;//The StoredProccedure methode allows us to avoid possible sql injections
                    sqlcmd.Parameters.AddWithValue("@mode", "Send");//İf our declared mode=="Send" we will send new data
                     
                    #region Add new informatiom to our datatable begin zone

                    sqlcmd.Parameters.AddWithValue("@Numberİd", 0);
                    sqlcmd.Parameters.AddWithValue("@Enregitre_Number", patientsinfomation.enregitramentnumber);
                    sqlcmd.Parameters.AddWithValue("@Firstname", patientsinfomation.firstname);
                    sqlcmd.Parameters.AddWithValue("@Lastname", patientsinfomation.lastname);
                    sqlcmd.Parameters.AddWithValue("@Parent_phonenumber", patientsinfomation.phoneNumber);
                    sqlcmd.Parameters.AddWithValue("@Disease_Description", patientsinfomation.disease_description);
                    sqlcmd.Parameters.AddWithValue("@Department", patientsinfomation.department);
                    sqlcmd.Parameters.AddWithValue("@Room_number", patientsinfomation.roomnumber);
                    sqlcmd.Parameters.AddWithValue("@Bed_number", patientsinfomation.bednumber);
                    sqlcmd.Parameters.AddWithValue("@Date_of_entry", patientsinfomation.entry);
                    sqlcmd.Parameters.AddWithValue("@Status_", patientsinfomation.status);
                    sqlcmd.Parameters.AddWithValue("@Quit_date", patientsinfomation.quit);

                    #endregion Add new informatiom to our datatable end zone
                    //befor executenonquerry we will verified if there are empity field or not
                    if (BoxController() == true)//if not execute
                    {
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show("Patient's informations are Saved sucessfully");//
                        Centralpanel.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("You are not enable to submit empity fields please");//else this message will be show
                        Centralpanel.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
            DataFill();
            //send
        }

        private void DataFill()//This is the function available to fill our data in to DatagridView
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    patientsinfomation.enregitramentnumber = searchtextbox.Text.Trim(); //We must trim all saved in our database to avoid sql injection;
                    SqlDataAdapter sqlData = new SqlDataAdapter("Searchpatient", sqlCon);//We use another storedProcedure 
                    sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlData.SelectCommand.Parameters.AddWithValue("@Enregitre_Number", patientsinfomation.enregitramentnumber);
                    DataTable dtl = new DataTable();
                    sqlData.Fill(dtl);
                    Datagridviewpatientsbunifu.DataSource = dtl;
                    Datagridviewpatientsbunifu.Columns[0].Visible = false;


                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Mesage");
            }
            finally
            {
                sqlCon.Close();//İt very important close the connection after all try condiction
            }
        }




        private void udatepatientsbtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (sqlCon.State == ConnectionState.Closed)//Checked if connection is open or close
                {
                    sqlCon.Open();

                    SqlCommand sqlcmd = new SqlCommand("AddOrUpdatePatient", sqlCon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@mode", "Update");//Now our storedprocedure is Update
                    
                    #region Send sent the information updated data in the database begin zone

                    sqlcmd.Parameters.AddWithValue("@Numberİd", Numberİd);
                    sqlcmd.Parameters.AddWithValue("@Enregitre_Number", patientsinfomation.enregitramentnumber);
                    sqlcmd.Parameters.AddWithValue("@Firstname", patientsinfomation.firstname);
                    sqlcmd.Parameters.AddWithValue("@Lastname", patientsinfomation.lastname);
                    sqlcmd.Parameters.AddWithValue("@Parent_phonenumber", patientsinfomation.phoneNumber);
                    sqlcmd.Parameters.AddWithValue("@Disease_Description", patientsinfomation.disease_description);
                    sqlcmd.Parameters.AddWithValue("@Department", patientsinfomation.department);
                    sqlcmd.Parameters.AddWithValue("@Room_number", patientsinfomation.roomnumber);
                    sqlcmd.Parameters.AddWithValue("@Bed_number", patientsinfomation.bednumber);
                    sqlcmd.Parameters.AddWithValue("@Date_of_entry", patientsinfomation.entry);
                    sqlcmd.Parameters.AddWithValue("@Status_", patientsinfomation.status);
                    sqlcmd.Parameters.AddWithValue("@Quit_date", patientsinfomation.quit);

                    #endregion  Send sent the information updated data in the database end zone
                    
                    if (BoxController() == true)//avoid empity field submit
                    {
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show("Patient's information is update sucessfully");
                        Centralpanel.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("You are not enable to submit empity fields please");
                        Centralpanel.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }

            DataFill();




        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void searchtextbox_OnValueChanged(object sender, EventArgs e)
        {
            //search text box
        }

        private void searchpatientbn_Click(object sender, EventArgs e)//The clik event of this functiom allow us to Search data
        {
            try
            {
                DataFill();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error message");
            }
        }

        private void Datagridviewpatientsbunifu_DoubleClick(object sender, EventArgs e)
            /*Doubleclik event is very important to update information in Datagridview.
            to activate this function you must first change the read only function to true of this datagridview.*/
        {
            /*
             * 
             * if you double click on a row whose have exit index  , i.e. different from -1, 
             * the patient list closes and the value corresponding to the patient is selected in the recording format.
             * Now we can update this patinet's information
             */
            if (Datagridviewpatientsbunifu.CurrentRow.Index != -1)
            {
                Numberİd= Convert.ToInt32(Datagridviewpatientsbunifu.CurrentRow.Cells[0].Value.ToString());
                registrenumbertextbox.Text = Datagridviewpatientsbunifu.CurrentRow.Cells[1].Value.ToString();
                firstnamepatients.Text = Datagridviewpatientsbunifu.CurrentRow.Cells[2].Value.ToString();
                lastnametextbox.Text = Datagridviewpatientsbunifu.CurrentRow.Cells[3].Value.ToString();
                parentsphonenumbertextbox.Text = Datagridviewpatientsbunifu.CurrentRow.Cells[4].Value.ToString();
                deseasedescriptiontextbox.Text = Datagridviewpatientsbunifu.CurrentRow.Cells[5].Value.ToString();
                entrydatepicker.Value = Convert.ToDateTime( Datagridviewpatientsbunifu.CurrentRow.Cells[9].Value.ToString());
                quitdatepicker.Value = Convert.ToDateTime( Datagridviewpatientsbunifu.CurrentRow.Cells[11].Value.ToString());


            }
            Centralpanel.Visible = false;//this  is hide to show patient recording
            sendpatientsinfobtn.Enabled = false;// Send button will disable to avoid all data cloning
            updatepatientsbtn.Enabled = true;//Update button will enable to resend the updated data
        }

        private void addnewpatientsbtn_Click(object sender, EventArgs e)//Add new patient  is use to return to patient enroll format if the lis format is open
        {
            Centralpanel.Visible = false;
            sendpatientsinfobtn.Enabled = true;
            updatepatientsbtn.Enabled = false;
        }

        #region enter and Leave event begin zone

        private void registrenumbertextbox_Enter(object sender, EventArgs e)
        {
            if(registrenumbertextbox.Text== "Registre Number")
            {
                registrenumbertextbox.Text = "";
            }
            
        }

        private void registrenumbertextbox_Leave(object sender, EventArgs e)
        {
            if (registrenumbertextbox.Text == "")
            {
                registrenumbertextbox.Text = "Registre Number";
            }

        }

        private void firstnamepatients_Enter(object sender, EventArgs e)
        {
            if (firstnamepatients.Text == "Patient's firstname")
            {
                firstnamepatients.Text = "";
            }
        }

        private void firstnamepatients_Leave(object sender, EventArgs e)
        {
            if(firstnamepatients.Text== "")
            {
                firstnamepatients.Text = "Patient's firstname";
            }
        }

        private void lastnametextbox_Enter(object sender, EventArgs e)
        {
            if(lastnametextbox.Text== "Patient's lastname")
            {
                lastnametextbox.Text = "";
            }
        }

        private void lastnametextbox_Leave(object sender, EventArgs e)
        {
            if (lastnametextbox.Text == "")
            {
                lastnametextbox.Text = "Patient's lastname";
            }
        }

        private void parentsphonenumbertextbox_Enter(object sender, EventArgs e)
        {
            if(parentsphonenumbertextbox.Text== "Patient's parent phonenumber")
            {
                parentsphonenumbertextbox.Text = "";
            }

        }

        private void parentsphonenumbertextbox_Leave(object sender, EventArgs e)
        {
            if (parentsphonenumbertextbox.Text == "")
            {
                parentsphonenumbertextbox.Text = "Patient's parent phonenumber";
            }
        }
        #endregion Enter and Leave event end Zone
    }
}
