namespace lonestarmovieexpenseAS3
{
    partial class Form1
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
            this.titletxt = new System.Windows.Forms.TextBox();
            this.slctmoviebox = new System.Windows.Forms.GroupBox();
            this.movielistbox = new System.Windows.Forms.ListBox();
            this.ratingbox = new System.Windows.Forms.GroupBox();
            this.ratingtxtbox = new System.Windows.Forms.TextBox();
            this.stimebox = new System.Windows.Forms.GroupBox();
            this.showtimelistbox = new System.Windows.Forms.ListBox();
            this.bluraybox = new System.Windows.Forms.GroupBox();
            this.bournelegacychk = new System.Windows.Forms.CheckBox();
            this.bournetrilogychk = new System.Windows.Forms.CheckBox();
            this.wonderwomenchk = new System.Windows.Forms.CheckBox();
            this.avengersIWchk = new System.Windows.Forms.CheckBox();
            this.warnbluraytxt = new System.Windows.Forms.TextBox();
            this.ticketbox = new System.Windows.Forms.GroupBox();
            this.ticketlistbox = new System.Windows.Forms.ListBox();
            this.childradiobtn = new System.Windows.Forms.RadioButton();
            this.adultradiobtn = new System.Windows.Forms.RadioButton();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.titlepurchasetxt = new System.Windows.Forms.TextBox();
            this.moviepurchasedetail = new System.Windows.Forms.TextBox();
            this.subtotaltxt = new System.Windows.Forms.TextBox();
            this.gsttxt = new System.Windows.Forms.TextBox();
            this.psttxt = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.subtotal = new System.Windows.Forms.Label();
            this.gst = new System.Windows.Forms.Label();
            this.pst = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.creditcard = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.creditcardtxt = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.slctmoviebox.SuspendLayout();
            this.ratingbox.SuspendLayout();
            this.stimebox.SuspendLayout();
            this.bluraybox.SuspendLayout();
            this.ticketbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titletxt
            // 
            this.titletxt.BackColor = System.Drawing.Color.Yellow;
            this.titletxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titletxt.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletxt.ForeColor = System.Drawing.Color.Green;
            this.titletxt.Location = new System.Drawing.Point(75, 21);
            this.titletxt.Name = "titletxt";
            this.titletxt.ReadOnly = true;
            this.titletxt.Size = new System.Drawing.Size(433, 22);
            this.titletxt.TabIndex = 1;
            this.titletxt.Text = " Sehaj and Ravneet Lonestar Movie Theatre ";
            this.titletxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // slctmoviebox
            // 
            this.slctmoviebox.Controls.Add(this.movielistbox);
            this.slctmoviebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slctmoviebox.Location = new System.Drawing.Point(12, 70);
            this.slctmoviebox.Name = "slctmoviebox";
            this.slctmoviebox.Size = new System.Drawing.Size(240, 84);
            this.slctmoviebox.TabIndex = 1;
            this.slctmoviebox.TabStop = false;
            this.slctmoviebox.Text = "select movie";
            // 
            // movielistbox
            // 
            this.movielistbox.AllowDrop = true;
            this.movielistbox.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movielistbox.FormattingEnabled = true;
            this.movielistbox.ItemHeight = 15;
            this.movielistbox.Location = new System.Drawing.Point(6, 20);
            this.movielistbox.Name = "movielistbox";
            this.movielistbox.Size = new System.Drawing.Size(228, 49);
            this.movielistbox.TabIndex = 0;
            this.movielistbox.Tag = "";
            this.movielistbox.SelectedIndexChanged += new System.EventHandler(this.movielistbox_SelectedIndexChanged);
            // 
            // ratingbox
            // 
            this.ratingbox.Controls.Add(this.ratingtxtbox);
            this.ratingbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingbox.Location = new System.Drawing.Point(258, 70);
            this.ratingbox.Name = "ratingbox";
            this.ratingbox.Size = new System.Drawing.Size(148, 84);
            this.ratingbox.TabIndex = 3;
            this.ratingbox.TabStop = false;
            this.ratingbox.Text = "Movie Rating";
            // 
            // ratingtxtbox
            // 
            this.ratingtxtbox.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingtxtbox.Location = new System.Drawing.Point(26, 31);
            this.ratingtxtbox.Name = "ratingtxtbox";
            this.ratingtxtbox.ReadOnly = true;
            this.ratingtxtbox.Size = new System.Drawing.Size(100, 22);
            this.ratingtxtbox.TabIndex = 0;
            this.ratingtxtbox.VisibleChanged += new System.EventHandler(this.movielistbox_SelectedIndexChanged);
            // 
            // stimebox
            // 
            this.stimebox.Controls.Add(this.showtimelistbox);
            this.stimebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stimebox.Location = new System.Drawing.Point(412, 70);
            this.stimebox.Name = "stimebox";
            this.stimebox.Size = new System.Drawing.Size(209, 104);
            this.stimebox.TabIndex = 4;
            this.stimebox.TabStop = false;
            this.stimebox.Text = "Showtimes";
            // 
            // showtimelistbox
            // 
            this.showtimelistbox.AllowDrop = true;
            this.showtimelistbox.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimelistbox.FormattingEnabled = true;
            this.showtimelistbox.ItemHeight = 15;
            this.showtimelistbox.Location = new System.Drawing.Point(13, 19);
            this.showtimelistbox.Name = "showtimelistbox";
            this.showtimelistbox.Size = new System.Drawing.Size(190, 64);
            this.showtimelistbox.TabIndex = 0;
            // 
            // bluraybox
            // 
            this.bluraybox.Controls.Add(this.bournelegacychk);
            this.bluraybox.Controls.Add(this.bournetrilogychk);
            this.bluraybox.Controls.Add(this.wonderwomenchk);
            this.bluraybox.Controls.Add(this.avengersIWchk);
            this.bluraybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluraybox.Location = new System.Drawing.Point(18, 169);
            this.bluraybox.Name = "bluraybox";
            this.bluraybox.Size = new System.Drawing.Size(388, 95);
            this.bluraybox.TabIndex = 5;
            this.bluraybox.TabStop = false;
            this.bluraybox.Text = "Blu  Ray Collection ($9.99, unless otherwise stated)";
            this.bluraybox.Visible = false;
            // 
            // bournelegacychk
            // 
            this.bournelegacychk.AutoSize = true;
            this.bournelegacychk.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bournelegacychk.Location = new System.Drawing.Point(240, 68);
            this.bournelegacychk.Name = "bournelegacychk";
            this.bournelegacychk.Size = new System.Drawing.Size(110, 19);
            this.bournelegacychk.TabIndex = 3;
            this.bournelegacychk.Text = "Bourne Legacy";
            this.bournelegacychk.UseVisualStyleBackColor = true;
            this.bournelegacychk.Visible = false;
            this.bournelegacychk.VisibleChanged += new System.EventHandler(this.movielistbox_SelectedIndexChanged);
            // 
            // bournetrilogychk
            // 
            this.bournetrilogychk.AutoSize = true;
            this.bournetrilogychk.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bournetrilogychk.Location = new System.Drawing.Point(7, 68);
            this.bournetrilogychk.Name = "bournetrilogychk";
            this.bournetrilogychk.Size = new System.Drawing.Size(166, 19);
            this.bournetrilogychk.TabIndex = 2;
            this.bournetrilogychk.Text = "Bourne Trilogy($21.99)";
            this.bournetrilogychk.UseVisualStyleBackColor = true;
            this.bournetrilogychk.Visible = false;
            this.bournetrilogychk.VisibleChanged += new System.EventHandler(this.movielistbox_SelectedIndexChanged);
            // 
            // wonderwomenchk
            // 
            this.wonderwomenchk.AutoSize = true;
            this.wonderwomenchk.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wonderwomenchk.Location = new System.Drawing.Point(7, 44);
            this.wonderwomenchk.Name = "wonderwomenchk";
            this.wonderwomenchk.Size = new System.Drawing.Size(113, 19);
            this.wonderwomenchk.TabIndex = 1;
            this.wonderwomenchk.Text = "wonder Women";
            this.wonderwomenchk.UseVisualStyleBackColor = true;
            this.wonderwomenchk.Visible = false;
            this.wonderwomenchk.VisibleChanged += new System.EventHandler(this.movielistbox_SelectedIndexChanged);
            // 
            // avengersIWchk
            // 
            this.avengersIWchk.AutoSize = true;
            this.avengersIWchk.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avengersIWchk.Location = new System.Drawing.Point(7, 20);
            this.avengersIWchk.Name = "avengersIWchk";
            this.avengersIWchk.Size = new System.Drawing.Size(148, 19);
            this.avengersIWchk.TabIndex = 0;
            this.avengersIWchk.Text = "Avengers:Infinity War";
            this.avengersIWchk.UseVisualStyleBackColor = true;
            this.avengersIWchk.Visible = false;
            this.avengersIWchk.VisibleChanged += new System.EventHandler(this.movielistbox_SelectedIndexChanged);
            // 
            // warnbluraytxt
            // 
            this.warnbluraytxt.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warnbluraytxt.Location = new System.Drawing.Point(424, 213);
            this.warnbluraytxt.Name = "warnbluraytxt";
            this.warnbluraytxt.ReadOnly = true;
            this.warnbluraytxt.Size = new System.Drawing.Size(177, 22);
            this.warnbluraytxt.TabIndex = 6;
            // 
            // ticketbox
            // 
            this.ticketbox.Controls.Add(this.ticketlistbox);
            this.ticketbox.Controls.Add(this.childradiobtn);
            this.ticketbox.Controls.Add(this.adultradiobtn);
            this.ticketbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketbox.Location = new System.Drawing.Point(18, 271);
            this.ticketbox.Name = "ticketbox";
            this.ticketbox.Size = new System.Drawing.Size(388, 83);
            this.ticketbox.TabIndex = 7;
            this.ticketbox.TabStop = false;
            this.ticketbox.Text = "Tickets";
            // 
            // ticketlistbox
            // 
            this.ticketlistbox.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketlistbox.FormattingEnabled = true;
            this.ticketlistbox.ItemHeight = 15;
            this.ticketlistbox.Location = new System.Drawing.Point(240, 20);
            this.ticketlistbox.Name = "ticketlistbox";
            this.ticketlistbox.Size = new System.Drawing.Size(120, 49);
            this.ticketlistbox.TabIndex = 2;
            // 
            // childradiobtn
            // 
            this.childradiobtn.AutoSize = true;
            this.childradiobtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childradiobtn.Location = new System.Drawing.Point(6, 52);
            this.childradiobtn.Name = "childradiobtn";
            this.childradiobtn.Size = new System.Drawing.Size(106, 20);
            this.childradiobtn.TabIndex = 1;
            this.childradiobtn.TabStop = true;
            this.childradiobtn.Text = "Child - $7.99";
            this.childradiobtn.UseVisualStyleBackColor = true;
            // 
            // adultradiobtn
            // 
            this.adultradiobtn.AutoSize = true;
            this.adultradiobtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultradiobtn.Location = new System.Drawing.Point(7, 20);
            this.adultradiobtn.Name = "adultradiobtn";
            this.adultradiobtn.Size = new System.Drawing.Size(113, 20);
            this.adultradiobtn.TabIndex = 0;
            this.adultradiobtn.TabStop = true;
            this.adultradiobtn.Text = "Adult - $11.99";
            this.adultradiobtn.UseVisualStyleBackColor = true;
            // 
            // confirmbtn
            // 
            this.confirmbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.Location = new System.Drawing.Point(412, 291);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(96, 49);
            this.confirmbtn.TabIndex = 8;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.Location = new System.Drawing.Point(526, 291);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(88, 49);
            this.resetbtn.TabIndex = 9;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // titlepurchasetxt
            // 
            this.titlepurchasetxt.BackColor = System.Drawing.Color.Yellow;
            this.titlepurchasetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titlepurchasetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlepurchasetxt.ForeColor = System.Drawing.Color.Green;
            this.titlepurchasetxt.Location = new System.Drawing.Point(151, 371);
            this.titlepurchasetxt.Name = "titlepurchasetxt";
            this.titlepurchasetxt.ReadOnly = true;
            this.titlepurchasetxt.Size = new System.Drawing.Size(291, 22);
            this.titlepurchasetxt.TabIndex = 10;
            this.titlepurchasetxt.Text = "Sehaj and Ravneet Purchase";
            this.titlepurchasetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // moviepurchasedetail
            // 
            this.moviepurchasedetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviepurchasedetail.Location = new System.Drawing.Point(18, 405);
            this.moviepurchasedetail.Multiline = true;
            this.moviepurchasedetail.Name = "moviepurchasedetail";
            this.moviepurchasedetail.ReadOnly = true;
            this.moviepurchasedetail.Size = new System.Drawing.Size(256, 93);
            this.moviepurchasedetail.TabIndex = 11;
            this.moviepurchasedetail.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // subtotaltxt
            // 
            this.subtotaltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotaltxt.Location = new System.Drawing.Point(448, 405);
            this.subtotaltxt.Name = "subtotaltxt";
            this.subtotaltxt.ReadOnly = true;
            this.subtotaltxt.Size = new System.Drawing.Size(153, 21);
            this.subtotaltxt.TabIndex = 12;
            // 
            // gsttxt
            // 
            this.gsttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gsttxt.Location = new System.Drawing.Point(448, 431);
            this.gsttxt.Name = "gsttxt";
            this.gsttxt.ReadOnly = true;
            this.gsttxt.Size = new System.Drawing.Size(153, 21);
            this.gsttxt.TabIndex = 13;
            // 
            // psttxt
            // 
            this.psttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psttxt.Location = new System.Drawing.Point(448, 457);
            this.psttxt.Name = "psttxt";
            this.psttxt.ReadOnly = true;
            this.psttxt.Size = new System.Drawing.Size(153, 21);
            this.psttxt.TabIndex = 14;
            // 
            // totaltxt
            // 
            this.totaltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltxt.Location = new System.Drawing.Point(448, 483);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.ReadOnly = true;
            this.totaltxt.Size = new System.Drawing.Size(153, 21);
            this.totaltxt.TabIndex = 15;
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(389, 408);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(59, 15);
            this.subtotal.TabIndex = 16;
            this.subtotal.Text = "Sub Total";
            // 
            // gst
            // 
            this.gst.AutoSize = true;
            this.gst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gst.Location = new System.Drawing.Point(413, 434);
            this.gst.Name = "gst";
            this.gst.Size = new System.Drawing.Size(31, 15);
            this.gst.TabIndex = 17;
            this.gst.Text = "GST";
            // 
            // pst
            // 
            this.pst.AutoSize = true;
            this.pst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pst.Location = new System.Drawing.Point(414, 460);
            this.pst.Name = "pst";
            this.pst.Size = new System.Drawing.Size(30, 15);
            this.pst.TabIndex = 18;
            this.pst.Text = "PST";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(408, 486);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(37, 15);
            this.total.TabIndex = 19;
            this.total.Text = "Total ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(61, 520);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 15);
            this.name.TabIndex = 20;
            this.name.Text = "Name";
            // 
            // creditcard
            // 
            this.creditcard.AutoSize = true;
            this.creditcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditcard.Location = new System.Drawing.Point(34, 556);
            this.creditcard.Name = "creditcard";
            this.creditcard.Size = new System.Drawing.Size(68, 15);
            this.creditcard.TabIndex = 21;
            this.creditcard.Text = "Credit Card";
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(108, 517);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(166, 21);
            this.nametxt.TabIndex = 22;
            // 
            // creditcardtxt
            // 
            this.creditcardtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditcardtxt.Location = new System.Drawing.Point(108, 553);
            this.creditcardtxt.Name = "creditcardtxt";
            this.creditcardtxt.Size = new System.Drawing.Size(166, 21);
            this.creditcardtxt.TabIndex = 23;
            this.creditcardtxt.UseSystemPasswordChar = true;
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(108, 598);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 33);
            this.submitbtn.TabIndex = 24;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(199, 598);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 33);
            this.clearbtn.TabIndex = 25;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 662);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.creditcardtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.creditcard);
            this.Controls.Add(this.name);
            this.Controls.Add(this.total);
            this.Controls.Add(this.pst);
            this.Controls.Add(this.gst);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.psttxt);
            this.Controls.Add(this.gsttxt);
            this.Controls.Add(this.subtotaltxt);
            this.Controls.Add(this.moviepurchasedetail);
            this.Controls.Add(this.titlepurchasetxt);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.ticketbox);
            this.Controls.Add(this.warnbluraytxt);
            this.Controls.Add(this.bluraybox);
            this.Controls.Add(this.stimebox);
            this.Controls.Add(this.ratingbox);
            this.Controls.Add(this.slctmoviebox);
            this.Controls.Add(this.titletxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.slctmoviebox.ResumeLayout(false);
            this.ratingbox.ResumeLayout(false);
            this.ratingbox.PerformLayout();
            this.stimebox.ResumeLayout(false);
            this.bluraybox.ResumeLayout(false);
            this.bluraybox.PerformLayout();
            this.ticketbox.ResumeLayout(false);
            this.ticketbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.GroupBox slctmoviebox;
        private System.Windows.Forms.ListBox movielistbox;
        private System.Windows.Forms.GroupBox ratingbox;
        private System.Windows.Forms.TextBox ratingtxtbox;
        private System.Windows.Forms.GroupBox stimebox;
        private System.Windows.Forms.ListBox showtimelistbox;
        private System.Windows.Forms.GroupBox bluraybox;
        private System.Windows.Forms.CheckBox bournelegacychk;
        private System.Windows.Forms.CheckBox bournetrilogychk;
        private System.Windows.Forms.CheckBox wonderwomenchk;
        private System.Windows.Forms.CheckBox avengersIWchk;
        private System.Windows.Forms.TextBox warnbluraytxt;
        private System.Windows.Forms.GroupBox ticketbox;
        private System.Windows.Forms.RadioButton childradiobtn;
        private System.Windows.Forms.RadioButton adultradiobtn;
        private System.Windows.Forms.ListBox ticketlistbox;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.TextBox titlepurchasetxt;
        private System.Windows.Forms.TextBox moviepurchasedetail;
        private System.Windows.Forms.TextBox subtotaltxt;
        private System.Windows.Forms.TextBox gsttxt;
        private System.Windows.Forms.TextBox psttxt;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label gst;
        private System.Windows.Forms.Label pst;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label creditcard;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox creditcardtxt;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button clearbtn;
    }
}

