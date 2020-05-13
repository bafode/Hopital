namespace HProgramming
{
    partial class PatientsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.patiensinfo = new System.Windows.Forms.GroupBox();
            this.statuschekerdropbox = new Bunifu.Framework.UI.BunifuDropdown();
            this.bednumberdropbox = new Bunifu.Framework.UI.BunifuDropdown();
            this.roomnumberdropbox = new Bunifu.Framework.UI.BunifuDropdown();
            this.departmentdropbox = new Bunifu.Framework.UI.BunifuDropdown();
            this.quitdatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.entrydatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.deseasedescriptiontextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registrenumbertextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lastnametextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.parentsphonenumbertextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.firstnamepatients = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sendpatientsinfobtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.viewpatientslistbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updatepatientsbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Centralpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.addnewpatientsbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Datagridviewpatientsbunifu = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.numberİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enregitreNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentphonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bednumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofentryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quitdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientstableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagmentSystDataSet4 = new HProgramming.HospitalManagmentSystDataSet4();
            this.searchpatientbn = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchtextbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.patients_tableTableAdapter = new HProgramming.HospitalManagmentSystDataSet4TableAdapters.Patients_tableTableAdapter();
            this.patiensinfo.SuspendLayout();
            this.Centralpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridviewpatientsbunifu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientstableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagmentSystDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchpatientbn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("RomanT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(60, 35);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(546, 39);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Patient\'s Enregistration Form";
            // 
            // patiensinfo
            // 
            this.patiensinfo.Controls.Add(this.statuschekerdropbox);
            this.patiensinfo.Controls.Add(this.bednumberdropbox);
            this.patiensinfo.Controls.Add(this.roomnumberdropbox);
            this.patiensinfo.Controls.Add(this.departmentdropbox);
            this.patiensinfo.Controls.Add(this.quitdatepicker);
            this.patiensinfo.Controls.Add(this.entrydatepicker);
            this.patiensinfo.Controls.Add(this.deseasedescriptiontextbox);
            this.patiensinfo.Controls.Add(this.label4);
            this.patiensinfo.Controls.Add(this.label3);
            this.patiensinfo.Controls.Add(this.label10);
            this.patiensinfo.Controls.Add(this.lab);
            this.patiensinfo.Controls.Add(this.label9);
            this.patiensinfo.Controls.Add(this.label8);
            this.patiensinfo.Controls.Add(this.label7);
            this.patiensinfo.Controls.Add(this.label6);
            this.patiensinfo.Controls.Add(this.label5);
            this.patiensinfo.Controls.Add(this.label2);
            this.patiensinfo.Controls.Add(this.label1);
            this.patiensinfo.Controls.Add(this.registrenumbertextbox);
            this.patiensinfo.Controls.Add(this.lastnametextbox);
            this.patiensinfo.Controls.Add(this.parentsphonenumbertextbox);
            this.patiensinfo.Controls.Add(this.firstnamepatients);
            this.patiensinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.patiensinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.patiensinfo.Location = new System.Drawing.Point(1, 87);
            this.patiensinfo.Name = "patiensinfo";
            this.patiensinfo.Size = new System.Drawing.Size(860, 428);
            this.patiensinfo.TabIndex = 4;
            this.patiensinfo.TabStop = false;
            this.patiensinfo.Text = "Patient\'s İnformation";
            // 
            // statuschekerdropbox
            // 
            this.statuschekerdropbox.BackColor = System.Drawing.Color.Transparent;
            this.statuschekerdropbox.BorderRadius = 3;
            this.statuschekerdropbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statuschekerdropbox.ForeColor = System.Drawing.Color.White;
            this.statuschekerdropbox.Items = new string[] {
        "Under Treatment",
        "Plight",
        "Recovery",
        "Die"};
            this.statuschekerdropbox.Location = new System.Drawing.Point(607, 287);
            this.statuschekerdropbox.Name = "statuschekerdropbox";
            this.statuschekerdropbox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.statuschekerdropbox.onHoverColor = System.Drawing.Color.Teal;
            this.statuschekerdropbox.selectedIndex = -1;
            this.statuschekerdropbox.Size = new System.Drawing.Size(217, 42);
            this.statuschekerdropbox.TabIndex = 4;
            this.statuschekerdropbox.onItemSelected += new System.EventHandler(this.statuschekerdropbox_onItemSelected);
            // 
            // bednumberdropbox
            // 
            this.bednumberdropbox.BackColor = System.Drawing.Color.Transparent;
            this.bednumberdropbox.BorderRadius = 3;
            this.bednumberdropbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bednumberdropbox.ForeColor = System.Drawing.Color.White;
            this.bednumberdropbox.Items = new string[] {
        "1\t",
        "2\t",
        "3\t",
        "4\t",
        "5\t",
        "6\t",
        "7\t",
        "8\t",
        "9\t",
        "10",
        "11\t",
        "12\t",
        "13\t",
        "14\t",
        "15\t",
        "16\t",
        "17\t",
        "18\t",
        "19\t",
        "20",
        "21\t",
        "22\t",
        "23\t",
        "24\t",
        "25\t",
        "26\t",
        "27\t",
        "28\t",
        "29\t",
        "30",
        "31\t",
        "32\t",
        "33\t",
        "34\t",
        "35\t",
        "36\t",
        "37\t",
        "38\t",
        "39\t",
        "40",
        "41\t",
        "42\t",
        "43\t",
        "44\t",
        "45\t",
        "46\t",
        "47\t",
        "48\t",
        "49\t",
        "50",
        "51\t",
        "52\t",
        "53\t",
        "54\t",
        "55\t",
        "56\t",
        "57\t",
        "58\t",
        "59\t",
        "60",
        "61\t",
        "62\t",
        "63\t",
        "64\t",
        "65\t",
        "66\t",
        "67\t",
        "68\t",
        "69\t",
        "70",
        "71\t",
        "72\t",
        "73\t",
        "74\t",
        "75\t",
        "76\t",
        "77\t",
        "78\t",
        "79\t",
        "80",
        "81\t",
        "82\t",
        "83\t",
        "84\t",
        "85\t",
        "86\t",
        "87\t",
        "88\t",
        "89\t",
        "90",
        "91\t",
        "92\t",
        "93\t",
        "94\t",
        "95\t",
        "96\t",
        "97\t",
        "98\t",
        "99\t",
        "100"};
            this.bednumberdropbox.Location = new System.Drawing.Point(607, 171);
            this.bednumberdropbox.Name = "bednumberdropbox";
            this.bednumberdropbox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.bednumberdropbox.onHoverColor = System.Drawing.Color.Teal;
            this.bednumberdropbox.selectedIndex = -1;
            this.bednumberdropbox.Size = new System.Drawing.Size(217, 37);
            this.bednumberdropbox.TabIndex = 4;
            this.bednumberdropbox.onItemSelected += new System.EventHandler(this.bednumberdropbox_onItemSelected);
            // 
            // roomnumberdropbox
            // 
            this.roomnumberdropbox.BackColor = System.Drawing.Color.Transparent;
            this.roomnumberdropbox.BorderRadius = 3;
            this.roomnumberdropbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roomnumberdropbox.ForeColor = System.Drawing.Color.White;
            this.roomnumberdropbox.Items = new string[] {
        "1\t",
        "2\t",
        "3\t",
        "4\t",
        "5\t",
        "6\t",
        "7\t",
        "8\t",
        "9\t",
        "10",
        "11\t",
        "12\t",
        "13\t",
        "14\t",
        "15\t",
        "16\t",
        "17\t",
        "18\t",
        "19\t",
        "20",
        "21\t",
        "22\t",
        "23\t",
        "24\t",
        "25\t",
        "26\t",
        "27\t",
        "28\t",
        "29\t",
        "30",
        "31\t",
        "32\t",
        "33\t",
        "34\t",
        "35\t",
        "36\t",
        "37\t",
        "38\t",
        "39\t",
        "40",
        "41\t",
        "42\t",
        "43\t",
        "44\t",
        "45\t",
        "46\t",
        "47\t",
        "48\t",
        "49\t",
        "50",
        "51\t",
        "52\t",
        "53\t",
        "54\t",
        "55\t",
        "56\t",
        "57\t",
        "58\t",
        "59\t",
        "60",
        "61\t",
        "62\t",
        "63\t",
        "64\t",
        "65\t",
        "66\t",
        "67\t",
        "68\t",
        "69\t",
        "70",
        "71\t",
        "72\t",
        "73\t",
        "74\t",
        "75\t",
        "76\t",
        "77\t",
        "78\t",
        "79\t",
        "80",
        "81\t",
        "82\t",
        "83\t",
        "84\t",
        "85\t",
        "86\t",
        "87\t",
        "88\t",
        "89\t",
        "90",
        "91\t",
        "92\t",
        "93\t",
        "94\t",
        "95\t",
        "96\t",
        "97\t",
        "98\t",
        "99\t",
        "100"};
            this.roomnumberdropbox.Location = new System.Drawing.Point(607, 103);
            this.roomnumberdropbox.Name = "roomnumberdropbox";
            this.roomnumberdropbox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.roomnumberdropbox.onHoverColor = System.Drawing.Color.Teal;
            this.roomnumberdropbox.selectedIndex = -1;
            this.roomnumberdropbox.Size = new System.Drawing.Size(217, 40);
            this.roomnumberdropbox.TabIndex = 4;
            this.roomnumberdropbox.onItemSelected += new System.EventHandler(this.roomnumberdropbox_onItemSelected);
            // 
            // departmentdropbox
            // 
            this.departmentdropbox.BackColor = System.Drawing.Color.Transparent;
            this.departmentdropbox.BorderRadius = 3;
            this.departmentdropbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.departmentdropbox.ForeColor = System.Drawing.Color.White;
            this.departmentdropbox.Items = new string[] {
        "Toxicology",
        "Neurology",
        "Hematology",
        "Oncology",
        "İnfections Deseases",
        "Chirurgy"};
            this.departmentdropbox.Location = new System.Drawing.Point(607, 20);
            this.departmentdropbox.Name = "departmentdropbox";
            this.departmentdropbox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.departmentdropbox.onHoverColor = System.Drawing.Color.Teal;
            this.departmentdropbox.selectedIndex = -1;
            this.departmentdropbox.Size = new System.Drawing.Size(217, 35);
            this.departmentdropbox.TabIndex = 4;
            this.departmentdropbox.onItemSelected += new System.EventHandler(this.departmentdropbox_onItemSelected);
            // 
            // quitdatepicker
            // 
            this.quitdatepicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.quitdatepicker.BorderRadius = 0;
            this.quitdatepicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.quitdatepicker.ForeColor = System.Drawing.Color.White;
            this.quitdatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.quitdatepicker.FormatCustom = null;
            this.quitdatepicker.Location = new System.Drawing.Point(607, 351);
            this.quitdatepicker.Name = "quitdatepicker";
            this.quitdatepicker.Size = new System.Drawing.Size(217, 42);
            this.quitdatepicker.TabIndex = 3;
            this.quitdatepicker.Value = new System.DateTime(2020, 5, 11, 14, 32, 42, 745);
            this.quitdatepicker.onValueChanged += new System.EventHandler(this.quitdatepicker_onValueChanged);
            // 
            // entrydatepicker
            // 
            this.entrydatepicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.entrydatepicker.BorderRadius = 0;
            this.entrydatepicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.entrydatepicker.ForeColor = System.Drawing.Color.White;
            this.entrydatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.entrydatepicker.FormatCustom = null;
            this.entrydatepicker.Location = new System.Drawing.Point(607, 227);
            this.entrydatepicker.Name = "entrydatepicker";
            this.entrydatepicker.Size = new System.Drawing.Size(217, 36);
            this.entrydatepicker.TabIndex = 3;
            this.entrydatepicker.Value = new System.DateTime(2020, 5, 11, 14, 32, 42, 745);
            this.entrydatepicker.onValueChanged += new System.EventHandler(this.entrydatepicker_onValueChanged);
            // 
            // deseasedescriptiontextbox
            // 
            this.deseasedescriptiontextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.deseasedescriptiontextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.deseasedescriptiontextbox.Location = new System.Drawing.Point(163, 311);
            this.deseasedescriptiontextbox.Multiline = true;
            this.deseasedescriptiontextbox.Name = "deseasedescriptiontextbox";
            this.deseasedescriptiontextbox.Size = new System.Drawing.Size(213, 82);
            this.deseasedescriptiontextbox.TabIndex = 2;
            this.deseasedescriptiontextbox.TextChanged += new System.EventHandler(this.deseasedescriptiontextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Disease Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lastname:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(465, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Quit date:";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(465, 311);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(44, 15);
            this.lab.TabIndex = 1;
            this.lab.Text = "Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Date of Entry:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Bed-N:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Room-Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Parent\'s phonenumber:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "N-Enregistrement:";
            // 
            // registrenumbertextbox
            // 
            this.registrenumbertextbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.registrenumbertextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.registrenumbertextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.registrenumbertextbox.ForeColor = System.Drawing.Color.White;
            this.registrenumbertextbox.HintForeColor = System.Drawing.Color.Empty;
            this.registrenumbertextbox.HintText = "";
            this.registrenumbertextbox.isPassword = false;
            this.registrenumbertextbox.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.registrenumbertextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.registrenumbertextbox.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.registrenumbertextbox.LineThickness = 3;
            this.registrenumbertextbox.Location = new System.Drawing.Point(163, 34);
            this.registrenumbertextbox.Margin = new System.Windows.Forms.Padding(4);
            this.registrenumbertextbox.Name = "registrenumbertextbox";
            this.registrenumbertextbox.Size = new System.Drawing.Size(213, 44);
            this.registrenumbertextbox.TabIndex = 0;
            this.registrenumbertextbox.Text = "Registre Number";
            this.registrenumbertextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.registrenumbertextbox.OnValueChanged += new System.EventHandler(this.registrenumbertextbox_OnValueChanged);
            this.registrenumbertextbox.Enter += new System.EventHandler(this.registrenumbertextbox_Enter);
            this.registrenumbertextbox.Leave += new System.EventHandler(this.registrenumbertextbox_Leave);
            // 
            // lastnametextbox
            // 
            this.lastnametextbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastnametextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastnametextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lastnametextbox.ForeColor = System.Drawing.Color.White;
            this.lastnametextbox.HintForeColor = System.Drawing.Color.Empty;
            this.lastnametextbox.HintText = "";
            this.lastnametextbox.isPassword = false;
            this.lastnametextbox.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.lastnametextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.lastnametextbox.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.lastnametextbox.LineThickness = 3;
            this.lastnametextbox.Location = new System.Drawing.Point(163, 171);
            this.lastnametextbox.Margin = new System.Windows.Forms.Padding(4);
            this.lastnametextbox.Name = "lastnametextbox";
            this.lastnametextbox.Size = new System.Drawing.Size(213, 44);
            this.lastnametextbox.TabIndex = 0;
            this.lastnametextbox.Text = "Patient\'s lastname";
            this.lastnametextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastnametextbox.OnValueChanged += new System.EventHandler(this.lastnametextbox_OnValueChanged);
            this.lastnametextbox.Enter += new System.EventHandler(this.lastnametextbox_Enter);
            this.lastnametextbox.Leave += new System.EventHandler(this.lastnametextbox_Leave);
            // 
            // parentsphonenumbertextbox
            // 
            this.parentsphonenumbertextbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.parentsphonenumbertextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.parentsphonenumbertextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.parentsphonenumbertextbox.ForeColor = System.Drawing.Color.White;
            this.parentsphonenumbertextbox.HintForeColor = System.Drawing.Color.Empty;
            this.parentsphonenumbertextbox.HintText = "";
            this.parentsphonenumbertextbox.isPassword = false;
            this.parentsphonenumbertextbox.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.parentsphonenumbertextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.parentsphonenumbertextbox.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.parentsphonenumbertextbox.LineThickness = 3;
            this.parentsphonenumbertextbox.Location = new System.Drawing.Point(163, 237);
            this.parentsphonenumbertextbox.Margin = new System.Windows.Forms.Padding(4);
            this.parentsphonenumbertextbox.Name = "parentsphonenumbertextbox";
            this.parentsphonenumbertextbox.Size = new System.Drawing.Size(213, 44);
            this.parentsphonenumbertextbox.TabIndex = 0;
            this.parentsphonenumbertextbox.Text = "Patient\'s parent phonenumber";
            this.parentsphonenumbertextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.parentsphonenumbertextbox.OnValueChanged += new System.EventHandler(this.parentsphonenumbertextbox_OnValueChanged);
            this.parentsphonenumbertextbox.Enter += new System.EventHandler(this.parentsphonenumbertextbox_Enter);
            this.parentsphonenumbertextbox.Leave += new System.EventHandler(this.parentsphonenumbertextbox_Leave);
            // 
            // firstnamepatients
            // 
            this.firstnamepatients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstnamepatients.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstnamepatients.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.firstnamepatients.ForeColor = System.Drawing.Color.White;
            this.firstnamepatients.HintForeColor = System.Drawing.Color.Empty;
            this.firstnamepatients.HintText = "";
            this.firstnamepatients.isPassword = false;
            this.firstnamepatients.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.firstnamepatients.LineIdleColor = System.Drawing.Color.Gray;
            this.firstnamepatients.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.firstnamepatients.LineThickness = 3;
            this.firstnamepatients.Location = new System.Drawing.Point(163, 103);
            this.firstnamepatients.Margin = new System.Windows.Forms.Padding(4);
            this.firstnamepatients.Name = "firstnamepatients";
            this.firstnamepatients.Size = new System.Drawing.Size(213, 44);
            this.firstnamepatients.TabIndex = 0;
            this.firstnamepatients.Text = "Patient\'s firstname";
            this.firstnamepatients.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.firstnamepatients.OnValueChanged += new System.EventHandler(this.firstnamepatients_OnValueChanged);
            this.firstnamepatients.Enter += new System.EventHandler(this.firstnamepatients_Enter);
            this.firstnamepatients.Leave += new System.EventHandler(this.firstnamepatients_Leave);
            // 
            // sendpatientsinfobtn
            // 
            this.sendpatientsinfobtn.Activecolor = System.Drawing.Color.Teal;
            this.sendpatientsinfobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.sendpatientsinfobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendpatientsinfobtn.BorderRadius = 0;
            this.sendpatientsinfobtn.ButtonText = "Send To DB";
            this.sendpatientsinfobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendpatientsinfobtn.DisabledColor = System.Drawing.Color.Gray;
            this.sendpatientsinfobtn.Iconcolor = System.Drawing.Color.Transparent;
            this.sendpatientsinfobtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("sendpatientsinfobtn.Iconimage")));
            this.sendpatientsinfobtn.Iconimage_right = null;
            this.sendpatientsinfobtn.Iconimage_right_Selected = null;
            this.sendpatientsinfobtn.Iconimage_Selected = null;
            this.sendpatientsinfobtn.IconMarginLeft = 0;
            this.sendpatientsinfobtn.IconMarginRight = 0;
            this.sendpatientsinfobtn.IconRightVisible = true;
            this.sendpatientsinfobtn.IconRightZoom = 0D;
            this.sendpatientsinfobtn.IconVisible = true;
            this.sendpatientsinfobtn.IconZoom = 90D;
            this.sendpatientsinfobtn.IsTab = false;
            this.sendpatientsinfobtn.Location = new System.Drawing.Point(598, 528);
            this.sendpatientsinfobtn.Name = "sendpatientsinfobtn";
            this.sendpatientsinfobtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.sendpatientsinfobtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendpatientsinfobtn.OnHoverTextColor = System.Drawing.Color.White;
            this.sendpatientsinfobtn.selected = false;
            this.sendpatientsinfobtn.Size = new System.Drawing.Size(140, 48);
            this.sendpatientsinfobtn.TabIndex = 5;
            this.sendpatientsinfobtn.Text = "Send To DB";
            this.sendpatientsinfobtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendpatientsinfobtn.Textcolor = System.Drawing.Color.White;
            this.sendpatientsinfobtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendpatientsinfobtn.Click += new System.EventHandler(this.sendpatientsinfobtn_Click);
            // 
            // viewpatientslistbtn
            // 
            this.viewpatientslistbtn.Activecolor = System.Drawing.Color.Teal;
            this.viewpatientslistbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.viewpatientslistbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewpatientslistbtn.BorderRadius = 0;
            this.viewpatientslistbtn.ButtonText = "View Patient\'s List";
            this.viewpatientslistbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewpatientslistbtn.DisabledColor = System.Drawing.Color.Gray;
            this.viewpatientslistbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.viewpatientslistbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("viewpatientslistbtn.Iconimage")));
            this.viewpatientslistbtn.Iconimage_right = null;
            this.viewpatientslistbtn.Iconimage_right_Selected = null;
            this.viewpatientslistbtn.Iconimage_Selected = null;
            this.viewpatientslistbtn.IconMarginLeft = 0;
            this.viewpatientslistbtn.IconMarginRight = 0;
            this.viewpatientslistbtn.IconRightVisible = true;
            this.viewpatientslistbtn.IconRightZoom = 0D;
            this.viewpatientslistbtn.IconVisible = true;
            this.viewpatientslistbtn.IconZoom = 90D;
            this.viewpatientslistbtn.IsTab = false;
            this.viewpatientslistbtn.Location = new System.Drawing.Point(622, 45);
            this.viewpatientslistbtn.Name = "viewpatientslistbtn";
            this.viewpatientslistbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.viewpatientslistbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewpatientslistbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.viewpatientslistbtn.selected = false;
            this.viewpatientslistbtn.Size = new System.Drawing.Size(213, 48);
            this.viewpatientslistbtn.TabIndex = 5;
            this.viewpatientslistbtn.Text = "View Patient\'s List";
            this.viewpatientslistbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewpatientslistbtn.Textcolor = System.Drawing.Color.White;
            this.viewpatientslistbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewpatientslistbtn.Click += new System.EventHandler(this.viewpatientslistbtn_Click);
            // 
            // updatepatientsbtn
            // 
            this.updatepatientsbtn.Activecolor = System.Drawing.Color.Teal;
            this.updatepatientsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.updatepatientsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updatepatientsbtn.BorderRadius = 0;
            this.updatepatientsbtn.ButtonText = "Update";
            this.updatepatientsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatepatientsbtn.DisabledColor = System.Drawing.Color.Gray;
            this.updatepatientsbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updatepatientsbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("updatepatientsbtn.Iconimage")));
            this.updatepatientsbtn.Iconimage_right = null;
            this.updatepatientsbtn.Iconimage_right_Selected = null;
            this.updatepatientsbtn.Iconimage_Selected = null;
            this.updatepatientsbtn.IconMarginLeft = 0;
            this.updatepatientsbtn.IconMarginRight = 0;
            this.updatepatientsbtn.IconRightVisible = true;
            this.updatepatientsbtn.IconRightZoom = 0D;
            this.updatepatientsbtn.IconVisible = true;
            this.updatepatientsbtn.IconZoom = 90D;
            this.updatepatientsbtn.IsTab = false;
            this.updatepatientsbtn.Location = new System.Drawing.Point(755, 528);
            this.updatepatientsbtn.Name = "updatepatientsbtn";
            this.updatepatientsbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.updatepatientsbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updatepatientsbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updatepatientsbtn.selected = false;
            this.updatepatientsbtn.Size = new System.Drawing.Size(106, 48);
            this.updatepatientsbtn.TabIndex = 5;
            this.updatepatientsbtn.Text = "Update";
            this.updatepatientsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatepatientsbtn.Textcolor = System.Drawing.Color.White;
            this.updatepatientsbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatepatientsbtn.Click += new System.EventHandler(this.udatepatientsbtn_Click);
            // 
            // Centralpanel
            // 
            this.Centralpanel.Controls.Add(this.pictureBox1);
            this.Centralpanel.Controls.Add(this.label12);
            this.Centralpanel.Controls.Add(this.label11);
            this.Centralpanel.Controls.Add(this.addnewpatientsbtn);
            this.Centralpanel.Controls.Add(this.Datagridviewpatientsbunifu);
            this.Centralpanel.Controls.Add(this.searchpatientbn);
            this.Centralpanel.Controls.Add(this.searchtextbox);
            this.Centralpanel.Location = new System.Drawing.Point(1, 24);
            this.Centralpanel.Name = "Centralpanel";
            this.Centralpanel.Size = new System.Drawing.Size(871, 573);
            this.Centralpanel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 509);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(96, 526);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Search Only By Enregitre_Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("RomanT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(315, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 39);
            this.label11.TabIndex = 4;
            this.label11.Text = "Patient\'s List";
            // 
            // addnewpatientsbtn
            // 
            this.addnewpatientsbtn.Activecolor = System.Drawing.Color.Teal;
            this.addnewpatientsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.addnewpatientsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addnewpatientsbtn.BorderRadius = 0;
            this.addnewpatientsbtn.ButtonText = "Add New Patients";
            this.addnewpatientsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addnewpatientsbtn.DisabledColor = System.Drawing.Color.Gray;
            this.addnewpatientsbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addnewpatientsbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addnewpatientsbtn.Iconimage")));
            this.addnewpatientsbtn.Iconimage_right = null;
            this.addnewpatientsbtn.Iconimage_right_Selected = null;
            this.addnewpatientsbtn.Iconimage_Selected = null;
            this.addnewpatientsbtn.IconMarginLeft = 0;
            this.addnewpatientsbtn.IconMarginRight = 0;
            this.addnewpatientsbtn.IconRightVisible = true;
            this.addnewpatientsbtn.IconRightZoom = 0D;
            this.addnewpatientsbtn.IconVisible = true;
            this.addnewpatientsbtn.IconZoom = 90D;
            this.addnewpatientsbtn.IsTab = false;
            this.addnewpatientsbtn.Location = new System.Drawing.Point(683, 514);
            this.addnewpatientsbtn.Name = "addnewpatientsbtn";
            this.addnewpatientsbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.addnewpatientsbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addnewpatientsbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addnewpatientsbtn.selected = false;
            this.addnewpatientsbtn.Size = new System.Drawing.Size(177, 48);
            this.addnewpatientsbtn.TabIndex = 3;
            this.addnewpatientsbtn.Text = "Add New Patients";
            this.addnewpatientsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addnewpatientsbtn.Textcolor = System.Drawing.Color.White;
            this.addnewpatientsbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewpatientsbtn.Click += new System.EventHandler(this.addnewpatientsbtn_Click);
            // 
            // Datagridviewpatientsbunifu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Datagridviewpatientsbunifu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Datagridviewpatientsbunifu.AutoGenerateColumns = false;
            this.Datagridviewpatientsbunifu.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Datagridviewpatientsbunifu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datagridviewpatientsbunifu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagridviewpatientsbunifu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Datagridviewpatientsbunifu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagridviewpatientsbunifu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberİdDataGridViewTextBoxColumn,
            this.enregitreNumberDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.parentphonenumberDataGridViewTextBoxColumn,
            this.diseaseDescriptionDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.roomnumberDataGridViewTextBoxColumn,
            this.bednumberDataGridViewTextBoxColumn,
            this.dateofentryDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.quitdateDataGridViewTextBoxColumn});
            this.Datagridviewpatientsbunifu.DataSource = this.patientstableBindingSource;
            this.Datagridviewpatientsbunifu.DoubleBuffered = true;
            this.Datagridviewpatientsbunifu.EnableHeadersVisualStyles = false;
            this.Datagridviewpatientsbunifu.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.Datagridviewpatientsbunifu.HeaderForeColor = System.Drawing.Color.Lime;
            this.Datagridviewpatientsbunifu.Location = new System.Drawing.Point(0, 153);
            this.Datagridviewpatientsbunifu.Name = "Datagridviewpatientsbunifu";
            this.Datagridviewpatientsbunifu.ReadOnly = true;
            this.Datagridviewpatientsbunifu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Datagridviewpatientsbunifu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagridviewpatientsbunifu.Size = new System.Drawing.Size(868, 338);
            this.Datagridviewpatientsbunifu.TabIndex = 2;
            this.Datagridviewpatientsbunifu.DoubleClick += new System.EventHandler(this.Datagridviewpatientsbunifu_DoubleClick);
            // 
            // numberİdDataGridViewTextBoxColumn
            // 
            this.numberİdDataGridViewTextBoxColumn.DataPropertyName = "Numberİd";
            this.numberİdDataGridViewTextBoxColumn.HeaderText = "Numberİd";
            this.numberİdDataGridViewTextBoxColumn.Name = "numberİdDataGridViewTextBoxColumn";
            this.numberİdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enregitreNumberDataGridViewTextBoxColumn
            // 
            this.enregitreNumberDataGridViewTextBoxColumn.DataPropertyName = "Enregitre_Number";
            this.enregitreNumberDataGridViewTextBoxColumn.HeaderText = "Enregitre_Number";
            this.enregitreNumberDataGridViewTextBoxColumn.Name = "enregitreNumberDataGridViewTextBoxColumn";
            this.enregitreNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parentphonenumberDataGridViewTextBoxColumn
            // 
            this.parentphonenumberDataGridViewTextBoxColumn.DataPropertyName = "Parent_phonenumber";
            this.parentphonenumberDataGridViewTextBoxColumn.HeaderText = "Parent_phonenumber";
            this.parentphonenumberDataGridViewTextBoxColumn.Name = "parentphonenumberDataGridViewTextBoxColumn";
            this.parentphonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diseaseDescriptionDataGridViewTextBoxColumn
            // 
            this.diseaseDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Disease_Description";
            this.diseaseDescriptionDataGridViewTextBoxColumn.HeaderText = "Disease_Description";
            this.diseaseDescriptionDataGridViewTextBoxColumn.Name = "diseaseDescriptionDataGridViewTextBoxColumn";
            this.diseaseDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomnumberDataGridViewTextBoxColumn
            // 
            this.roomnumberDataGridViewTextBoxColumn.DataPropertyName = "Room_number";
            this.roomnumberDataGridViewTextBoxColumn.HeaderText = "Room_number";
            this.roomnumberDataGridViewTextBoxColumn.Name = "roomnumberDataGridViewTextBoxColumn";
            this.roomnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bednumberDataGridViewTextBoxColumn
            // 
            this.bednumberDataGridViewTextBoxColumn.DataPropertyName = "Bed_number";
            this.bednumberDataGridViewTextBoxColumn.HeaderText = "Bed_number";
            this.bednumberDataGridViewTextBoxColumn.Name = "bednumberDataGridViewTextBoxColumn";
            this.bednumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofentryDataGridViewTextBoxColumn
            // 
            this.dateofentryDataGridViewTextBoxColumn.DataPropertyName = "Date_of_entry";
            this.dateofentryDataGridViewTextBoxColumn.HeaderText = "Date_of_entry";
            this.dateofentryDataGridViewTextBoxColumn.Name = "dateofentryDataGridViewTextBoxColumn";
            this.dateofentryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status_";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status_";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quitdateDataGridViewTextBoxColumn
            // 
            this.quitdateDataGridViewTextBoxColumn.DataPropertyName = "Quit_date";
            this.quitdateDataGridViewTextBoxColumn.HeaderText = "Quit_date";
            this.quitdateDataGridViewTextBoxColumn.Name = "quitdateDataGridViewTextBoxColumn";
            this.quitdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientstableBindingSource
            // 
            this.patientstableBindingSource.DataMember = "Patients_table";
            this.patientstableBindingSource.DataSource = this.hospitalManagmentSystDataSet4;
            // 
            // hospitalManagmentSystDataSet4
            // 
            this.hospitalManagmentSystDataSet4.DataSetName = "HospitalManagmentSystDataSet4";
            this.hospitalManagmentSystDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchpatientbn
            // 
            this.searchpatientbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.searchpatientbn.Image = ((System.Drawing.Image)(resources.GetObject("searchpatientbn.Image")));
            this.searchpatientbn.ImageActive = null;
            this.searchpatientbn.Location = new System.Drawing.Point(763, 101);
            this.searchpatientbn.Name = "searchpatientbn";
            this.searchpatientbn.Size = new System.Drawing.Size(71, 44);
            this.searchpatientbn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchpatientbn.TabIndex = 1;
            this.searchpatientbn.TabStop = false;
            this.searchpatientbn.Zoom = 10;
            this.searchpatientbn.Click += new System.EventHandler(this.searchpatientbn_Click);
            // 
            // searchtextbox
            // 
            this.searchtextbox.BorderColorFocused = System.Drawing.Color.SlateGray;
            this.searchtextbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchtextbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.searchtextbox.BorderThickness = 3;
            this.searchtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchtextbox.ForeColor = System.Drawing.Color.White;
            this.searchtextbox.isPassword = false;
            this.searchtextbox.Location = new System.Drawing.Point(428, 102);
            this.searchtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchtextbox.Name = "searchtextbox";
            this.searchtextbox.Size = new System.Drawing.Size(328, 44);
            this.searchtextbox.TabIndex = 0;
            this.searchtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchtextbox.OnValueChanged += new System.EventHandler(this.searchtextbox_OnValueChanged);
            // 
            // patients_tableTableAdapter
            // 
            this.patients_tableTableAdapter.ClearBeforeFill = true;
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(873, 586);
            this.Controls.Add(this.Centralpanel);
            this.Controls.Add(this.viewpatientslistbtn);
            this.Controls.Add(this.updatepatientsbtn);
            this.Controls.Add(this.sendpatientsinfobtn);
            this.Controls.Add(this.patiensinfo);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(642, 362);
            this.Name = "PatientsForm";
            this.Text = "PatientsForm";
            this.Load += new System.EventHandler(this.PatientsForm_Load);
            this.patiensinfo.ResumeLayout(false);
            this.patiensinfo.PerformLayout();
            this.Centralpanel.ResumeLayout(false);
            this.Centralpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridviewpatientsbunifu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientstableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagmentSystDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchpatientbn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox patiensinfo;
        private Bunifu.Framework.UI.BunifuDropdown roomnumberdropbox;
        private Bunifu.Framework.UI.BunifuDropdown departmentdropbox;
        private Bunifu.Framework.UI.BunifuDatepicker quitdatepicker;
        private Bunifu.Framework.UI.BunifuDatepicker entrydatepicker;
        private System.Windows.Forms.TextBox deseasedescriptiontextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox registrenumbertextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lastnametextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox parentsphonenumbertextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox firstnamepatients;
        private Bunifu.Framework.UI.BunifuDropdown bednumberdropbox;
        private Bunifu.Framework.UI.BunifuDropdown statuschekerdropbox;
        private System.Windows.Forms.Label lab;
        private Bunifu.Framework.UI.BunifuFlatButton sendpatientsinfobtn;
        private Bunifu.Framework.UI.BunifuFlatButton viewpatientslistbtn;
        private Bunifu.Framework.UI.BunifuFlatButton updatepatientsbtn;
        private System.Windows.Forms.Panel Centralpanel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Datagridviewpatientsbunifu;
        private Bunifu.Framework.UI.BunifuImageButton searchpatientbn;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchtextbox;
        private Bunifu.Framework.UI.BunifuFlatButton addnewpatientsbtn;
        private System.Windows.Forms.Label label11;
        private HospitalManagmentSystDataSet4 hospitalManagmentSystDataSet4;
        private System.Windows.Forms.BindingSource patientstableBindingSource;
        private HospitalManagmentSystDataSet4TableAdapters.Patients_tableTableAdapter patients_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enregitreNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentphonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bednumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofentryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quitdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
    }
}