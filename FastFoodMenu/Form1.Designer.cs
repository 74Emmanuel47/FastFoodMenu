
namespace FastFoodMenu
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.indicator = new System.Windows.Forms.Panel();
            this.btnCustmors = new System.Windows.Forms.Button();
            this.btnDriverPayment = new System.Windows.Forms.Button();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnCollection = new System.Windows.Forms.Button();
            this.btnEatIn = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.firstCustomControl1 = new FastFoodMenu.FirstCustomControl();
            this.secondCustomControl1 = new FastFoodMenu.SecondCustomControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.indicator);
            this.panel1.Controls.Add(this.btnCustmors);
            this.panel1.Controls.Add(this.btnDriverPayment);
            this.panel1.Controls.Add(this.btnTakeAway);
            this.panel1.Controls.Add(this.btnDelivery);
            this.panel1.Controls.Add(this.btnCollection);
            this.panel1.Controls.Add(this.btnEatIn);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 732);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(9, 691);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "?";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.DarkRed;
            this.indicator.Location = new System.Drawing.Point(6, 100);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(10, 57);
            this.indicator.TabIndex = 6;
            // 
            // btnCustmors
            // 
            this.btnCustmors.FlatAppearance.BorderSize = 0;
            this.btnCustmors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustmors.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCustmors.ForeColor = System.Drawing.Color.White;
            this.btnCustmors.Location = new System.Drawing.Point(19, 538);
            this.btnCustmors.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustmors.Name = "btnCustmors";
            this.btnCustmors.Size = new System.Drawing.Size(226, 57);
            this.btnCustmors.TabIndex = 12;
            this.btnCustmors.Text = "Customers";
            this.btnCustmors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustmors.UseVisualStyleBackColor = true;
            this.btnCustmors.Click += new System.EventHandler(this.btnCustmors_Click);
            // 
            // btnDriverPayment
            // 
            this.btnDriverPayment.FlatAppearance.BorderSize = 0;
            this.btnDriverPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriverPayment.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDriverPayment.ForeColor = System.Drawing.Color.White;
            this.btnDriverPayment.Location = new System.Drawing.Point(19, 465);
            this.btnDriverPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnDriverPayment.Name = "btnDriverPayment";
            this.btnDriverPayment.Size = new System.Drawing.Size(226, 57);
            this.btnDriverPayment.TabIndex = 11;
            this.btnDriverPayment.Text = "Driver Payment";
            this.btnDriverPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDriverPayment.UseVisualStyleBackColor = true;
            this.btnDriverPayment.Click += new System.EventHandler(this.btnDriverPayment_Click);
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.FlatAppearance.BorderSize = 0;
            this.btnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAway.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnTakeAway.ForeColor = System.Drawing.Color.White;
            this.btnTakeAway.Location = new System.Drawing.Point(19, 392);
            this.btnTakeAway.Margin = new System.Windows.Forms.Padding(0);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(226, 57);
            this.btnTakeAway.TabIndex = 10;
            this.btnTakeAway.Text = "Take Away";
            this.btnTakeAway.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeAway.UseVisualStyleBackColor = true;
            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.FlatAppearance.BorderSize = 0;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Location = new System.Drawing.Point(19, 319);
            this.btnDelivery.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(226, 57);
            this.btnDelivery.TabIndex = 9;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnCollection
            // 
            this.btnCollection.FlatAppearance.BorderSize = 0;
            this.btnCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollection.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCollection.ForeColor = System.Drawing.Color.White;
            this.btnCollection.Location = new System.Drawing.Point(19, 246);
            this.btnCollection.Margin = new System.Windows.Forms.Padding(0);
            this.btnCollection.Name = "btnCollection";
            this.btnCollection.Size = new System.Drawing.Size(226, 57);
            this.btnCollection.TabIndex = 8;
            this.btnCollection.Text = "Collection";
            this.btnCollection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCollection.UseVisualStyleBackColor = true;
            this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
            // 
            // btnEatIn
            // 
            this.btnEatIn.FlatAppearance.BorderSize = 0;
            this.btnEatIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEatIn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEatIn.ForeColor = System.Drawing.Color.White;
            this.btnEatIn.Location = new System.Drawing.Point(19, 173);
            this.btnEatIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnEatIn.Name = "btnEatIn";
            this.btnEatIn.Size = new System.Drawing.Size(226, 57);
            this.btnEatIn.TabIndex = 7;
            this.btnEatIn.Text = "Eat-In";
            this.btnEatIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEatIn.UseVisualStyleBackColor = true;
            this.btnEatIn.Click += new System.EventHandler(this.btnEatIn_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(19, 100);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(226, 57);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(248, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 16);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(346, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 221);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Restaurants";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fast Foods";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(501, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "C# UI Designing By Emmanuel";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1249, 22);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 13;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1207, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 14;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstCustomControl1
            // 
            this.firstCustomControl1.Location = new System.Drawing.Point(248, 255);
            this.firstCustomControl1.Name = "firstCustomControl1";
            this.firstCustomControl1.Size = new System.Drawing.Size(1046, 477);
            this.firstCustomControl1.TabIndex = 19;
            // 
            // secondCustomControl1
            // 
            this.secondCustomControl1.BackColor = System.Drawing.SystemColors.Control;
            this.secondCustomControl1.Location = new System.Drawing.Point(248, 255);
            this.secondCustomControl1.Name = "secondCustomControl1";
            this.secondCustomControl1.Size = new System.Drawing.Size(1046, 477);
            this.secondCustomControl1.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(0, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 123);
            this.panel4.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 732);
            this.Controls.Add(this.firstCustomControl1);
            this.Controls.Add(this.secondCustomControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel indicator;
        private System.Windows.Forms.Button btnCustmors;
        private System.Windows.Forms.Button btnTakeAway;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnCollection;
        private System.Windows.Forms.Button btnEatIn;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDriverPayment;
        private SecondCustomControl secondCustomControl1;
        private FirstCustomControl firstCustomControl1;
        private System.Windows.Forms.Panel panel4;
    }
}

