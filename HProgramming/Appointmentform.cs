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
using System.Data.SqlClient;
using System.Drawing;

namespace HProgramming
{
    public partial class Appointmentform : Form
    {
        SqlConnection sqlConnect = new SqlConnection(@"Data Source=DESKTOP-FLN043B\CYBDRY;Initial Catalog=HospitalManagmentSyst;Integrated Security=True");
        Appointmentİnformation appointmentx = new Appointmentİnformation();
        int todayappointnumber = 0;//i declare this to loop it after for make make currennt appointment counter
        int tomorrowappointnumber = 0;//tomorrow message counter
        string apdate;
       
        public Appointmentform()
        {
            InitializeComponent();

            pointmentdatepicker.Value = DateTime.Now;
            birthofdatepickerappoint.Value = DateTime.Now;
            centralappointcontrol.Visible = false;
            CountAppoinment();
            FillerData();


        }
     
        private void Appointmentform_Load(object sender, EventArgs e)
        {
            
           
        }

        private void appoitementsender_Click(object sender, EventArgs e)
        {


            try
            {
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCom = new SqlCommand("makeappointment", sqlConnect);
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    
                    sqlCom.Parameters.AddWithValue("@Numberİd", 0);
                    
                    sqlCom.Parameters.AddWithValue("@Firstname ", appointmentx.firstname);
                    sqlCom.Parameters.AddWithValue("@Lastname", appointmentx.lastname);
                    sqlCom.Parameters.AddWithValue("@Email ", appointmentx.email);
                    sqlCom.Parameters.AddWithValue("@Phone_number", appointmentx.phoneNumber);
                    sqlCom.Parameters.AddWithValue("@Sex", appointmentx.sex);
                    sqlCom.Parameters.AddWithValue("@Date_Of_Birth", appointmentx.dateofBirth);
                    sqlCom.Parameters.AddWithValue("@Department", appointmentx.department);
                    sqlCom.Parameters.AddWithValue("@Doctors_name", appointmentx.doctorname);
                    sqlCom.Parameters.AddWithValue("@Appointment_date", appointmentx.appointmentdate);
                    sqlCom.Parameters.AddWithValue("@Appointment_time", appointmentx.appoitmenttime);
                    sqlCom.Parameters.AddWithValue("@Address_", Employeesİnfomation.address);
                    


                    if (BoxController() == true)
                    {
                        if(MessageBox.Show("Do you wnat really to send this appointment?,Note that only Admin is enable to do update or any change","Learn please", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            sqlCom.ExecuteNonQuery();
                            MessageBox.Show("Employee is enregitred succesfully", "Success Message");
                            centralappointcontrol.Visible = true;
                        }
                        else
                        {
                            centralappointcontrol.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empity or required fields detected");
                        centralappointcontrol.Visible = false;
                    }


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
                centralappointcontrol.Visible = false;
            }

            finally
            {
                sqlConnect.Close();
            }
            FillerData();
            //send button

        }
        private bool DateController(DateTime date)//Date controller function
        {
            if (date > DateTime.Now)
            {
                return false;
            }
            else
                return true;
        }
        private void CountAppoinment()
        {
            try
            {
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCom = new SqlCommand("SELECT * FROM Appointment_table ", sqlConnect);
                    SqlDataReader reader = sqlCom.ExecuteReader();
                    while (reader.Read())
                    {
                        apdate = (reader["Appointment_date"].ToString());
                        if (Convert.ToDateTime(apdate).Day == DateTime.Now.Day)
                        {
                            todayappointnumber = todayappointnumber + 1;
                            
                        }
                        else if(Convert.ToDateTime(apdate).Day == (DateTime.Now.Day + 1))
                        {
                            tomorrowappointnumber += 1;
                        }

                    }

                    numberappoint.Text = todayappointnumber.ToString();
                    tomorrowappointment.Text = tomorrowappointnumber.ToString();
                    tomorrowporgresscircle.Value = tomorrowappointnumber;
                    progresscircle.Value = todayappointnumber;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message");
            }
            finally
            {
                sqlConnect.Close();
            }
        }
        
        
        private void cancelappointmentbtn_Click(object sender, EventArgs e)//The cancel button will reset all textbox to null and datepicker to datetimenow
        {
            emailtextbox.Text = firsnametextbox.Text = lastnametextbox.Text = phonenumbertextbox.Text = addresstextbox.Text= "";
            birthofdatepickerappoint.Value = pointmentdatepicker.Value = DateTime.Now;
            //cancel button
        }

        private void seetodayappointment_Click(object sender, EventArgs e)
        {
            centralappointcontrol.Visible = true;//Hide the appointmet list panel
        }

        private void firsnametextbox_OnValueChanged(object sender, EventArgs e)
        {
            appointmentx.firstname = firsnametextbox.Text.Trim();
        }

        private void lastnametextbox_OnValueChanged(object sender, EventArgs e)
        {
            appointmentx.lastname = lastnametextbox.Text.Trim();
        }

        private void emailtextbox_OnValueChanged(object sender, EventArgs e)
        {
            appointmentx.email = emailtextbox.Text.Trim();
        }

        private void phonenumbertextbox_OnValueChanged(object sender, EventArgs e)
        {
            appointmentx.phoneNumber = phonenumbertextbox.Text.Trim();
        }

        private void sexappoitmentdropbox_onItemSelected(object sender, EventArgs e)
        {
            appointmentx.sex = sexappoitmentdropbox.selectedValue;
        }

        private void departmentdropdownbtn_onItemSelected(object sender, EventArgs e)
        {
            appointmentx.department = departmentdropdownbtn.selectedValue;
        }

        private void birthofdatepickerappoint_onValueChanged(object sender, EventArgs e)
        {
            if (DateController(birthofdatepickerappoint.Value) == true)
            {
                appointmentx.dateofBirth = birthofdatepickerappoint.Value;
            }
            else
            {
                MessageBox.Show("Check valide date please");
            }
        }

        private void doctorsnameapptext_onItemSelected(object sender, EventArgs e)
        {
            appointmentx.doctorname = doctorsnameapptext.selectedValue;
        }

        private void appointmentdatepicker_onValueChanged(object sender, EventArgs e)
        {
            
            if (pointmentdatepicker.Value >= DateTime.Now)
            {
                appointmentx.appointmentdate = pointmentdatepicker.Value;
            }
            else if(pointmentdatepicker.Value.Day <DateTime.Now.Day)
            {
                MessageBox.Show("Please select valide appointment date");
            }
        }

        private void timedropbox_onItemSelected(object sender, EventArgs e)
        {
            appointmentx.appoitmenttime = timedropbox.selectedValue;
        }

        private void addresstextbox_TextChanged(object sender, EventArgs e)
        {
            Employeesİnfomation.address = addresstextbox.Text.Trim();
        }

        private void searchappointmentbtn_Click(object sender, EventArgs e)
        {
            try
            {
                FillerData();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erroe Message");
            }
        }

        private bool BoxController()
        {
            if (string.IsNullOrEmpty(appointmentx.firstname) || string.IsNullOrEmpty(appointmentx.phoneNumber) ||
                string.IsNullOrEmpty(appointmentx.email) || string.IsNullOrEmpty(Employeesİnfomation.address) ||
                string.IsNullOrEmpty(appointmentx.doctorname) || string.IsNullOrEmpty(appointmentx.appoitmenttime) ||
                string.IsNullOrEmpty(appointmentx.sex)
                
                )
            {
                return false;
            }
            else
                return true;
        }


        private void FillerData()//Fill data int our Data grid
        {
            try
            {



                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();

                    appointmentx.firstname = searchtextboxapp.Text.Trim();

                    SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("Searchappointment", sqlConnect);
                    sqlDataAdapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDataAdapt.SelectCommand.Parameters.AddWithValue("@Firstname", appointmentx.firstname);
                    DataTable dataTable = new DataTable();//Create objet of datatable
                    sqlDataAdapt.Fill(dataTable);
                    bunifuCustomDataGrid1.DataSource = dataTable;
                    bunifuCustomDataGrid1.Columns[0].Visible = false;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void bunifuCustomDataGrid1_CellStyleChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       /*with the cellformatting we will cahnge the style of our datgridview cell
        * 
        */

        private void bunifuCustomDataGrid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 9 && e.Value != null)
                {
                    if (Convert.ToDateTime(e.Value).Day == DateTime.Now.Day)//if appoint is today the the celles back color will be red
                    {
                        e.CellStyle.BackColor = Color.Red;

                    }

                    else if (Convert.ToDateTime(e.Value).Day == (DateTime.Now.Day + 1))//else if it is tomorrow the row cell backcollor will bie Yellowgreen
                    {
                        e.CellStyle.BackColor = Color.YellowGreen;
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        
        
        
        

        private void makenewappointment_Click_1(object sender, EventArgs e)
        {
            centralappointcontrol.Visible = false;
        }
    }
}
