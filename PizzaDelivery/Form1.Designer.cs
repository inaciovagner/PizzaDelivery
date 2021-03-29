
namespace PizzaDelivery
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.cdmContinue = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAddress01 = new System.Windows.Forms.TextBox();
            this.txtAddress02 = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlExtras = new System.Windows.Forms.Panel();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.pnlTopping = new System.Windows.Forms.Panel();
            this.radTop00 = new System.Windows.Forms.RadioButton();
            this.radTop01 = new System.Windows.Forms.RadioButton();
            this.radTop02 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.radBas00 = new System.Windows.Forms.RadioButton();
            this.radBas01 = new System.Windows.Forms.RadioButton();
            this.radBas02 = new System.Windows.Forms.RadioButton();
            this.chkExt00 = new System.Windows.Forms.CheckBox();
            this.chkExt01 = new System.Windows.Forms.CheckBox();
            this.chkExt02 = new System.Windows.Forms.CheckBox();
            this.chkExt03 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.nudDrk00 = new System.Windows.Forms.NumericUpDown();
            this.nudDrk01 = new System.Windows.Forms.NumericUpDown();
            this.nudDrk02 = new System.Windows.Forms.NumericUpDown();
            this.nudDrk03 = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblOrderValue = new System.Windows.Forms.Label();
            this.lblDeliveryCharge = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.prtContinuation = new System.Drawing.Printing.PrintDocument();
            this.prtDeliveryNote = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlExtras.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.pnlTopping.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrk00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrk01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrk02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrk03)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 63);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(203, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(822, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODER BABA PIZZA DELIVERY - ORDER FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(353, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telephone Number:";
            // 
            // textTel
            // 
            this.textTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTel.Location = new System.Drawing.Point(547, 76);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(263, 34);
            this.textTel.TabIndex = 2;
            // 
            // cdmContinue
            // 
            this.cdmContinue.BackColor = System.Drawing.Color.White;
            this.cdmContinue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cdmContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cdmContinue.Location = new System.Drawing.Point(832, 69);
            this.cdmContinue.Name = "cdmContinue";
            this.cdmContinue.Size = new System.Drawing.Size(129, 41);
            this.cdmContinue.TabIndex = 3;
            this.cdmContinue.Text = "Continue";
            this.cdmContinue.UseVisualStyleBackColor = false;
            this.cdmContinue.Click += new System.EventHandler(this.cdmContinue_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlLeft.Controls.Add(this.txtOrder);
            this.pnlLeft.Controls.Add(this.label9);
            this.pnlLeft.Controls.Add(this.cmdSave);
            this.pnlLeft.Controls.Add(this.txtPostcode);
            this.pnlLeft.Controls.Add(this.txtSurname);
            this.pnlLeft.Controls.Add(this.txtAddress01);
            this.pnlLeft.Controls.Add(this.txtAddress02);
            this.pnlLeft.Controls.Add(this.txtTown);
            this.pnlLeft.Controls.Add(this.txtForename);
            this.pnlLeft.Controls.Add(this.label8);
            this.pnlLeft.Controls.Add(this.label7);
            this.pnlLeft.Controls.Add(this.label6);
            this.pnlLeft.Controls.Add(this.label5);
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.label3);
            this.pnlLeft.Location = new System.Drawing.Point(215, 126);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(367, 543);
            this.pnlLeft.TabIndex = 4;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(13, 351);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrder.Size = new System.Drawing.Size(342, 180);
            this.txtOrder.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(13, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Order Details";
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Yellow;
            this.cmdSave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdSave.Location = new System.Drawing.Point(116, 249);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(210, 51);
            this.cmdSave.TabIndex = 12;
            this.cmdSave.Text = "Save Customer";
            this.cmdSave.UseVisualStyleBackColor = false;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPostcode.Location = new System.Drawing.Point(116, 191);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(239, 21);
            this.txtPostcode.TabIndex = 11;
            this.txtPostcode.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSurname.Location = new System.Drawing.Point(116, 45);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(239, 21);
            this.txtSurname.TabIndex = 10;
            // 
            // txtAddress01
            // 
            this.txtAddress01.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress01.Location = new System.Drawing.Point(116, 81);
            this.txtAddress01.Name = "txtAddress01";
            this.txtAddress01.Size = new System.Drawing.Size(239, 21);
            this.txtAddress01.TabIndex = 9;
            // 
            // txtAddress02
            // 
            this.txtAddress02.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress02.Location = new System.Drawing.Point(116, 117);
            this.txtAddress02.Name = "txtAddress02";
            this.txtAddress02.Size = new System.Drawing.Size(239, 21);
            this.txtAddress02.TabIndex = 8;
            // 
            // txtTown
            // 
            this.txtTown.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTown.Location = new System.Drawing.Point(116, 154);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(239, 21);
            this.txtTown.TabIndex = 7;
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtForename.Location = new System.Drawing.Point(116, 11);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(239, 21);
            this.txtForename.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "PostCode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Address 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Address 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRight.Controls.Add(this.cmdClear);
            this.pnlRight.Controls.Add(this.cmdPrint);
            this.pnlRight.Controls.Add(this.lblOrderTotal);
            this.pnlRight.Controls.Add(this.lblDeliveryCharge);
            this.pnlRight.Controls.Add(this.lblOrderValue);
            this.pnlRight.Controls.Add(this.panel2);
            this.pnlRight.Controls.Add(this.label21);
            this.pnlRight.Controls.Add(this.label20);
            this.pnlRight.Controls.Add(this.label19);
            this.pnlRight.Controls.Add(this.button1);
            this.pnlRight.Controls.Add(this.pnlExtras);
            this.pnlRight.Controls.Add(this.pnlBase);
            this.pnlRight.Controls.Add(this.pnlTopping);
            this.pnlRight.Location = new System.Drawing.Point(666, 126);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(521, 543);
            this.pnlRight.TabIndex = 5;
            // 
            // pnlExtras
            // 
            this.pnlExtras.BackColor = System.Drawing.Color.Yellow;
            this.pnlExtras.Controls.Add(this.chkExt03);
            this.pnlExtras.Controls.Add(this.chkExt02);
            this.pnlExtras.Controls.Add(this.chkExt01);
            this.pnlExtras.Controls.Add(this.chkExt00);
            this.pnlExtras.Controls.Add(this.label12);
            this.pnlExtras.Location = new System.Drawing.Point(352, 23);
            this.pnlExtras.Name = "pnlExtras";
            this.pnlExtras.Size = new System.Drawing.Size(149, 153);
            this.pnlExtras.TabIndex = 1;
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlBase.Controls.Add(this.radBas02);
            this.pnlBase.Controls.Add(this.radBas01);
            this.pnlBase.Controls.Add(this.radBas00);
            this.pnlBase.Controls.Add(this.label11);
            this.pnlBase.Location = new System.Drawing.Point(182, 23);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(149, 153);
            this.pnlBase.TabIndex = 1;
            // 
            // pnlTopping
            // 
            this.pnlTopping.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlTopping.Controls.Add(this.label10);
            this.pnlTopping.Controls.Add(this.radTop02);
            this.pnlTopping.Controls.Add(this.radTop01);
            this.pnlTopping.Controls.Add(this.radTop00);
            this.pnlTopping.Location = new System.Drawing.Point(11, 23);
            this.pnlTopping.Name = "pnlTopping";
            this.pnlTopping.Size = new System.Drawing.Size(149, 153);
            this.pnlTopping.TabIndex = 0;
            // 
            // radTop00
            // 
            this.radTop00.AutoSize = true;
            this.radTop00.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radTop00.ForeColor = System.Drawing.Color.White;
            this.radTop00.Location = new System.Drawing.Point(16, 38);
            this.radTop00.Name = "radTop00";
            this.radTop00.Size = new System.Drawing.Size(115, 27);
            this.radTop00.TabIndex = 0;
            this.radTop00.TabStop = true;
            this.radTop00.Text = "Margherita";
            this.radTop00.UseVisualStyleBackColor = true;
            // 
            // radTop01
            // 
            this.radTop01.AutoSize = true;
            this.radTop01.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radTop01.ForeColor = System.Drawing.Color.White;
            this.radTop01.Location = new System.Drawing.Point(16, 71);
            this.radTop01.Name = "radTop01";
            this.radTop01.Size = new System.Drawing.Size(131, 27);
            this.radTop01.TabIndex = 0;
            this.radTop01.TabStop = true;
            this.radTop01.Text = "Four Seasons";
            this.radTop01.UseVisualStyleBackColor = true;
            // 
            // radTop02
            // 
            this.radTop02.AutoSize = true;
            this.radTop02.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radTop02.ForeColor = System.Drawing.Color.White;
            this.radTop02.Location = new System.Drawing.Point(19, 104);
            this.radTop02.Name = "radTop02";
            this.radTop02.Size = new System.Drawing.Size(114, 27);
            this.radTop02.TabIndex = 0;
            this.radTop02.TabStop = true;
            this.radTop02.Text = "Meat Feast";
            this.radTop02.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(19, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 35);
            this.label10.TabIndex = 6;
            this.label10.Text = "Topping";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(34, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 35);
            this.label11.TabIndex = 6;
            this.label11.Text = "Base";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(27, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 28);
            this.label12.TabIndex = 6;
            this.label12.Text = "Extras";
            // 
            // radBas00
            // 
            this.radBas00.AutoSize = true;
            this.radBas00.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBas00.ForeColor = System.Drawing.Color.White;
            this.radBas00.Location = new System.Drawing.Point(9, 38);
            this.radBas00.Name = "radBas00";
            this.radBas00.Size = new System.Drawing.Size(120, 27);
            this.radBas00.TabIndex = 7;
            this.radBas00.TabStop = true;
            this.radBas00.Text = "25 cm/10in.";
            this.radBas00.UseVisualStyleBackColor = true;
            // 
            // radBas01
            // 
            this.radBas01.AutoSize = true;
            this.radBas01.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBas01.ForeColor = System.Drawing.Color.White;
            this.radBas01.Location = new System.Drawing.Point(9, 71);
            this.radBas01.Name = "radBas01";
            this.radBas01.Size = new System.Drawing.Size(120, 27);
            this.radBas01.TabIndex = 7;
            this.radBas01.TabStop = true;
            this.radBas01.Text = "30 cm/12in.";
            this.radBas01.UseVisualStyleBackColor = true;
            // 
            // radBas02
            // 
            this.radBas02.AutoSize = true;
            this.radBas02.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBas02.ForeColor = System.Drawing.Color.White;
            this.radBas02.Location = new System.Drawing.Point(9, 104);
            this.radBas02.Name = "radBas02";
            this.radBas02.Size = new System.Drawing.Size(120, 27);
            this.radBas02.TabIndex = 7;
            this.radBas02.TabStop = true;
            this.radBas02.Text = "35 cm/14in.";
            this.radBas02.UseVisualStyleBackColor = true;
            // 
            // chkExt00
            // 
            this.chkExt00.AutoSize = true;
            this.chkExt00.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkExt00.Location = new System.Drawing.Point(2, 28);
            this.chkExt00.Name = "chkExt00";
            this.chkExt00.Size = new System.Drawing.Size(125, 27);
            this.chkExt00.TabIndex = 7;
            this.chkExt00.Text = "Mushrooms";
            this.chkExt00.UseVisualStyleBackColor = true;
            // 
            // chkExt01
            // 
            this.chkExt01.AutoSize = true;
            this.chkExt01.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkExt01.Location = new System.Drawing.Point(2, 58);
            this.chkExt01.Name = "chkExt01";
            this.chkExt01.Size = new System.Drawing.Size(147, 27);
            this.chkExt01.TabIndex = 7;
            this.chkExt01.Text = "Green Peppers";
            this.chkExt01.UseVisualStyleBackColor = true;
            // 
            // chkExt02
            // 
            this.chkExt02.AutoSize = true;
            this.chkExt02.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkExt02.Location = new System.Drawing.Point(2, 85);
            this.chkExt02.Name = "chkExt02";
            this.chkExt02.Size = new System.Drawing.Size(112, 27);
            this.chkExt02.TabIndex = 7;
            this.chkExt02.Text = "Anchovies";
            this.chkExt02.UseVisualStyleBackColor = true;
            // 
            // chkExt03
            // 
            this.chkExt03.AutoSize = true;
            this.chkExt03.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkExt03.Location = new System.Drawing.Point(2, 114);
            this.chkExt03.Name = "chkExt03";
            this.chkExt03.Size = new System.Drawing.Size(87, 27);
            this.chkExt03.TabIndex = 7;
            this.chkExt03.Text = "Cheese";
            this.chkExt03.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(182, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.nudDrk03);
            this.panel2.Controls.Add(this.nudDrk02);
            this.panel2.Controls.Add(this.nudDrk01);
            this.panel2.Controls.Add(this.nudDrk00);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(20, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 174);
            this.panel2.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(7, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Drinks";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(162, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 32);
            this.label14.TabIndex = 0;
            this.label14.Text = "Qnty";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(19, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "Cola";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(19, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "Lemonade";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(19, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 25);
            this.label17.TabIndex = 1;
            this.label17.Text = "Orange";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(19, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Mineral Water";
            // 
            // nudDrk00
            // 
            this.nudDrk00.BackColor = System.Drawing.Color.White;
            this.nudDrk00.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudDrk00.ForeColor = System.Drawing.Color.Fuchsia;
            this.nudDrk00.Location = new System.Drawing.Point(171, 35);
            this.nudDrk00.Name = "nudDrk00";
            this.nudDrk00.Size = new System.Drawing.Size(54, 30);
            this.nudDrk00.TabIndex = 2;
            // 
            // nudDrk01
            // 
            this.nudDrk01.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudDrk01.ForeColor = System.Drawing.Color.Fuchsia;
            this.nudDrk01.Location = new System.Drawing.Point(171, 68);
            this.nudDrk01.Name = "nudDrk01";
            this.nudDrk01.Size = new System.Drawing.Size(54, 30);
            this.nudDrk01.TabIndex = 2;
            // 
            // nudDrk02
            // 
            this.nudDrk02.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudDrk02.ForeColor = System.Drawing.Color.Fuchsia;
            this.nudDrk02.Location = new System.Drawing.Point(171, 101);
            this.nudDrk02.Name = "nudDrk02";
            this.nudDrk02.Size = new System.Drawing.Size(54, 30);
            this.nudDrk02.TabIndex = 2;
            // 
            // nudDrk03
            // 
            this.nudDrk03.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudDrk03.ForeColor = System.Drawing.Color.Fuchsia;
            this.nudDrk03.Location = new System.Drawing.Point(171, 134);
            this.nudDrk03.Name = "nudDrk03";
            this.nudDrk03.Size = new System.Drawing.Size(54, 30);
            this.nudDrk03.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.OrangeRed;
            this.label19.Location = new System.Drawing.Point(276, 416);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 23);
            this.label19.TabIndex = 13;
            this.label19.Text = "Order Value";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.OrangeRed;
            this.label20.Location = new System.Drawing.Point(276, 451);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(139, 23);
            this.label20.TabIndex = 13;
            this.label20.Text = "Delivery Charge";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.Color.OrangeRed;
            this.label21.Location = new System.Drawing.Point(276, 486);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 23);
            this.label21.TabIndex = 13;
            this.label21.Text = "Order Total";
            // 
            // lblOrderValue
            // 
            this.lblOrderValue.AutoSize = true;
            this.lblOrderValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderValue.Location = new System.Drawing.Point(421, 404);
            this.lblOrderValue.Name = "lblOrderValue";
            this.lblOrderValue.Size = new System.Drawing.Size(100, 35);
            this.lblOrderValue.TabIndex = 14;
            this.lblOrderValue.Text = "label22";
            // 
            // lblDeliveryCharge
            // 
            this.lblDeliveryCharge.AutoSize = true;
            this.lblDeliveryCharge.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeliveryCharge.Location = new System.Drawing.Point(421, 441);
            this.lblDeliveryCharge.Name = "lblDeliveryCharge";
            this.lblDeliveryCharge.Size = new System.Drawing.Size(100, 35);
            this.lblDeliveryCharge.TabIndex = 14;
            this.lblDeliveryCharge.Text = "label22";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderTotal.Location = new System.Drawing.Point(421, 486);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(100, 35);
            this.lblOrderTotal.TabIndex = 14;
            this.lblOrderTotal.Text = "label22";
            // 
            // cmdPrint
            // 
            this.cmdPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdPrint.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmdPrint.Location = new System.Drawing.Point(39, 435);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(210, 50);
            this.cmdPrint.TabIndex = 15;
            this.cmdPrint.Text = "Print Delivery note";
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // cmdClear
            // 
            this.cmdClear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdClear.Location = new System.Drawing.Point(94, 491);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(92, 40);
            this.cmdClear.TabIndex = 16;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 774);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.cdmContinue);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "CODER BABA Delivery";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlExtras.ResumeLayout(false);
            this.pnlExtras.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            this.pnlTopping.ResumeLayout(false);
            this.pnlTopping.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrk00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrk01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrk02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrk03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Button cdmContinue;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAddress01;
        private System.Windows.Forms.TextBox txtAddress02;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlExtras;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Panel pnlTopping;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblDeliveryCharge;
        private System.Windows.Forms.Label lblOrderValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudDrk03;
        private System.Windows.Forms.NumericUpDown nudDrk02;
        private System.Windows.Forms.NumericUpDown nudDrk01;
        private System.Windows.Forms.NumericUpDown nudDrk00;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkExt03;
        private System.Windows.Forms.CheckBox chkExt02;
        private System.Windows.Forms.CheckBox chkExt01;
        private System.Windows.Forms.CheckBox chkExt00;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radBas02;
        private System.Windows.Forms.RadioButton radBas01;
        private System.Windows.Forms.RadioButton radBas00;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radTop02;
        private System.Windows.Forms.RadioButton radTop01;
        private System.Windows.Forms.RadioButton radTop00;
        private System.Drawing.Printing.PrintDocument prtContinuation;
        private System.Drawing.Printing.PrintDocument prtDeliveryNote;
    }
}

