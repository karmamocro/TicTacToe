namespace TicTacToe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Btn1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "X";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClose.Iconimage")));
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = false;
            this.btnClose.IconZoom = 90D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(530, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.btnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(35, 21);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Btn1
            // 
            this.Btn1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn1.BorderRadius = 0;
            this.Btn1.ButtonText = "";
            this.Btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn1.DisabledColor = System.Drawing.Color.Gray;
            this.Btn1.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn1.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn1.Iconimage")));
            this.Btn1.Iconimage_right = null;
            this.Btn1.Iconimage_right_Selected = null;
            this.Btn1.Iconimage_Selected = null;
            this.Btn1.IconMarginLeft = 0;
            this.Btn1.IconMarginRight = 0;
            this.Btn1.IconRightVisible = true;
            this.Btn1.IconRightZoom = 0D;
            this.Btn1.IconVisible = false;
            this.Btn1.IconZoom = 90D;
            this.Btn1.IsTab = false;
            this.Btn1.Location = new System.Drawing.Point(107, 144);
            this.Btn1.Name = "Btn1";
            this.Btn1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.Btn1.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn1.selected = false;
            this.Btn1.Size = new System.Drawing.Size(115, 89);
            this.Btn1.TabIndex = 1;
            this.Btn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn1.Textcolor = System.Drawing.Color.White;
            this.Btn1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Click += new System.EventHandler(this.BtnClick);
            // 
            // Btn2
            // 
            this.Btn2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn2.BorderRadius = 0;
            this.Btn2.ButtonText = "";
            this.Btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn2.DisabledColor = System.Drawing.Color.Gray;
            this.Btn2.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn2.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn2.Iconimage")));
            this.Btn2.Iconimage_right = null;
            this.Btn2.Iconimage_right_Selected = null;
            this.Btn2.Iconimage_Selected = null;
            this.Btn2.IconMarginLeft = 0;
            this.Btn2.IconMarginRight = 0;
            this.Btn2.IconRightVisible = true;
            this.Btn2.IconRightZoom = 0D;
            this.Btn2.IconVisible = false;
            this.Btn2.IconZoom = 90D;
            this.Btn2.IsTab = false;
            this.Btn2.Location = new System.Drawing.Point(248, 144);
            this.Btn2.Name = "Btn2";
            this.Btn2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.Btn2.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn2.selected = false;
            this.Btn2.Size = new System.Drawing.Size(115, 89);
            this.Btn2.TabIndex = 1;
            this.Btn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn2.Textcolor = System.Drawing.Color.White;
            this.Btn2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Click += new System.EventHandler(this.BtnClick);
            // 
            // Btn3
            // 
            this.Btn3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn3.BorderRadius = 0;
            this.Btn3.ButtonText = "";
            this.Btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn3.DisabledColor = System.Drawing.Color.Gray;
            this.Btn3.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn3.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn3.Iconimage")));
            this.Btn3.Iconimage_right = null;
            this.Btn3.Iconimage_right_Selected = null;
            this.Btn3.Iconimage_Selected = null;
            this.Btn3.IconMarginLeft = 0;
            this.Btn3.IconMarginRight = 0;
            this.Btn3.IconRightVisible = true;
            this.Btn3.IconRightZoom = 0D;
            this.Btn3.IconVisible = false;
            this.Btn3.IconZoom = 90D;
            this.Btn3.IsTab = false;
            this.Btn3.Location = new System.Drawing.Point(387, 144);
            this.Btn3.Name = "Btn3";
            this.Btn3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.Btn3.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn3.selected = false;
            this.Btn3.Size = new System.Drawing.Size(115, 89);
            this.Btn3.TabIndex = 1;
            this.Btn3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn3.Textcolor = System.Drawing.Color.White;
            this.Btn3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Click += new System.EventHandler(this.BtnClick);
            // 
            // Btn4
            // 
            this.Btn4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn4.BorderRadius = 0;
            this.Btn4.ButtonText = "";
            this.Btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn4.DisabledColor = System.Drawing.Color.Gray;
            this.Btn4.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn4.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn4.Iconimage")));
            this.Btn4.Iconimage_right = null;
            this.Btn4.Iconimage_right_Selected = null;
            this.Btn4.Iconimage_Selected = null;
            this.Btn4.IconMarginLeft = 0;
            this.Btn4.IconMarginRight = 0;
            this.Btn4.IconRightVisible = true;
            this.Btn4.IconRightZoom = 0D;
            this.Btn4.IconVisible = false;
            this.Btn4.IconZoom = 90D;
            this.Btn4.IsTab = false;
            this.Btn4.Location = new System.Drawing.Point(107, 255);
            this.Btn4.Name = "Btn4";
            this.Btn4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.Btn4.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn4.selected = false;
            this.Btn4.Size = new System.Drawing.Size(115, 89);
            this.Btn4.TabIndex = 1;
            this.Btn4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn4.Textcolor = System.Drawing.Color.White;
            this.Btn4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Click += new System.EventHandler(this.BtnClick);
            // 
            // Btn5
            // 
            this.Btn5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn5.BorderRadius = 0;
            this.Btn5.ButtonText = "";
            this.Btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn5.DisabledColor = System.Drawing.Color.Gray;
            this.Btn5.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn5.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn5.Iconimage")));
            this.Btn5.Iconimage_right = null;
            this.Btn5.Iconimage_right_Selected = null;
            this.Btn5.Iconimage_Selected = null;
            this.Btn5.IconMarginLeft = 0;
            this.Btn5.IconMarginRight = 0;
            this.Btn5.IconRightVisible = true;
            this.Btn5.IconRightZoom = 0D;
            this.Btn5.IconVisible = false;
            this.Btn5.IconZoom = 90D;
            this.Btn5.IsTab = false;
            this.Btn5.Location = new System.Drawing.Point(248, 255);
            this.Btn5.Name = "Btn5";
            this.Btn5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.Btn5.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn5.selected = false;
            this.Btn5.Size = new System.Drawing.Size(115, 89);
            this.Btn5.TabIndex = 1;
            this.Btn5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn5.Textcolor = System.Drawing.Color.White;
            this.Btn5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Click += new System.EventHandler(this.BtnClick);
            // 
            // Btn6
            // 
            this.Btn6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn6.BorderRadius = 0;
            this.Btn6.ButtonText = "";
            this.Btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn6.DisabledColor = System.Drawing.Color.Gray;
            this.Btn6.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn6.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn6.Iconimage")));
            this.Btn6.Iconimage_right = null;
            this.Btn6.Iconimage_right_Selected = null;
            this.Btn6.Iconimage_Selected = null;
            this.Btn6.IconMarginLeft = 0;
            this.Btn6.IconMarginRight = 0;
            this.Btn6.IconRightVisible = true;
            this.Btn6.IconRightZoom = 0D;
            this.Btn6.IconVisible = false;
            this.Btn6.IconZoom = 90D;
            this.Btn6.IsTab = false;
            this.Btn6.Location = new System.Drawing.Point(387, 255);
            this.Btn6.Name = "Btn6";
            this.Btn6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.Btn6.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn6.selected = false;
            this.Btn6.Size = new System.Drawing.Size(115, 89);
            this.Btn6.TabIndex = 1;
            this.Btn6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn6.Textcolor = System.Drawing.Color.White;
            this.Btn6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Click += new System.EventHandler(this.BtnClick);
            // 
            // Btn7
            // 
            this.Btn7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn7.BorderRadius = 0;
            this.Btn7.ButtonText = "";
            this.Btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn7.DisabledColor = System.Drawing.Color.Gray;
            this.Btn7.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn7.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn7.Iconimage")));
            this.Btn7.Iconimage_right = null;
            this.Btn7.Iconimage_right_Selected = null;
            this.Btn7.Iconimage_Selected = null;
            this.Btn7.IconMarginLeft = 0;
            this.Btn7.IconMarginRight = 0;
            this.Btn7.IconRightVisible = true;
            this.Btn7.IconRightZoom = 0D;
            this.Btn7.IconVisible = false;
            this.Btn7.IconZoom = 90D;
            this.Btn7.IsTab = false;
            this.Btn7.Location = new System.Drawing.Point(107, 367);
            this.Btn7.Name = "Btn7";
            this.Btn7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.Btn7.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn7.selected = false;
            this.Btn7.Size = new System.Drawing.Size(115, 89);
            this.Btn7.TabIndex = 1;
            this.Btn7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn7.Textcolor = System.Drawing.Color.White;
            this.Btn7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Click += new System.EventHandler(this.BtnClick);
            // 
            // Btn8
            // 
            this.Btn8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn8.BorderRadius = 0;
            this.Btn8.ButtonText = "";
            this.Btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn8.DisabledColor = System.Drawing.Color.Gray;
            this.Btn8.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn8.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn8.Iconimage")));
            this.Btn8.Iconimage_right = null;
            this.Btn8.Iconimage_right_Selected = null;
            this.Btn8.Iconimage_Selected = null;
            this.Btn8.IconMarginLeft = 0;
            this.Btn8.IconMarginRight = 0;
            this.Btn8.IconRightVisible = true;
            this.Btn8.IconRightZoom = 0D;
            this.Btn8.IconVisible = false;
            this.Btn8.IconZoom = 90D;
            this.Btn8.IsTab = false;
            this.Btn8.Location = new System.Drawing.Point(248, 367);
            this.Btn8.Name = "Btn8";
            this.Btn8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.Btn8.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn8.selected = false;
            this.Btn8.Size = new System.Drawing.Size(115, 89);
            this.Btn8.TabIndex = 1;
            this.Btn8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn8.Textcolor = System.Drawing.Color.White;
            this.Btn8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Click += new System.EventHandler(this.BtnClick);
            // 
            // Btn9
            // 
            this.Btn9.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn9.BorderRadius = 0;
            this.Btn9.ButtonText = "";
            this.Btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn9.DisabledColor = System.Drawing.Color.Gray;
            this.Btn9.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn9.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn9.Iconimage")));
            this.Btn9.Iconimage_right = null;
            this.Btn9.Iconimage_right_Selected = null;
            this.Btn9.Iconimage_Selected = null;
            this.Btn9.IconMarginLeft = 0;
            this.Btn9.IconMarginRight = 0;
            this.Btn9.IconRightVisible = true;
            this.Btn9.IconRightZoom = 0D;
            this.Btn9.IconVisible = false;
            this.Btn9.IconZoom = 90D;
            this.Btn9.IsTab = false;
            this.Btn9.Location = new System.Drawing.Point(387, 367);
            this.Btn9.Name = "Btn9";
            this.Btn9.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Btn9.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.Btn9.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn9.selected = false;
            this.Btn9.Size = new System.Drawing.Size(115, 89);
            this.Btn9.TabIndex = 1;
            this.Btn9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn9.Textcolor = System.Drawing.Color.White;
            this.Btn9.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Click += new System.EventHandler(this.BtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = " E";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(10)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(25);
            this.panel1.Size = new System.Drawing.Size(590, 71);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Huidige speler:";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(335, 84);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(38, 37);
            this.lblPlayer.TabIndex = 5;
            this.lblPlayer.Text = "X";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(121, 469);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(28, 37);
            this.lblWin.TabIndex = 6;
            this.lblWin.Text = "-";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Reset";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(209, 520);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(144)))), ((int)(((byte)(212)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(164, 51);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "Reset";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.ResetScore);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 583);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.Btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn9;
        private Bunifu.Framework.UI.BunifuFlatButton Btn6;
        private Bunifu.Framework.UI.BunifuFlatButton Btn3;
        private Bunifu.Framework.UI.BunifuFlatButton Btn8;
        private Bunifu.Framework.UI.BunifuFlatButton Btn5;
        private Bunifu.Framework.UI.BunifuFlatButton Btn2;
        private Bunifu.Framework.UI.BunifuFlatButton Btn7;
        private Bunifu.Framework.UI.BunifuFlatButton Btn4;
        private Bunifu.Framework.UI.BunifuFlatButton Btn1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}

