namespace Ogretmentbl
{
    partial class ogretmenkayit
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
            this.ogrtmnkytbox = new System.Windows.Forms.GroupBox();
            this.ogrtmntctext = new System.Windows.Forms.TextBox();
            this.ogrtmntclbl = new System.Windows.Forms.Label();
            this.ogrtmnsoyadtext = new System.Windows.Forms.TextBox();
            this.ogrtmnadtext = new System.Windows.Forms.TextBox();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.ogrtmnsoyadlbl = new System.Windows.Forms.Label();
            this.ogrtmnadlbl = new System.Windows.Forms.Label();
            this.ogrtmnkytbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogrtmnkytbox
            // 
            this.ogrtmnkytbox.Controls.Add(this.ogrtmntctext);
            this.ogrtmnkytbox.Controls.Add(this.ogrtmntclbl);
            this.ogrtmnkytbox.Controls.Add(this.ogrtmnsoyadtext);
            this.ogrtmnkytbox.Controls.Add(this.ogrtmnadtext);
            this.ogrtmnkytbox.Controls.Add(this.kaydetbtn);
            this.ogrtmnkytbox.Controls.Add(this.ogrtmnsoyadlbl);
            this.ogrtmnkytbox.Controls.Add(this.ogrtmnadlbl);
            this.ogrtmnkytbox.Location = new System.Drawing.Point(0, 0);
            this.ogrtmnkytbox.Name = "ogrtmnkytbox";
            this.ogrtmnkytbox.Size = new System.Drawing.Size(302, 304);
            this.ogrtmnkytbox.TabIndex = 0;
            this.ogrtmnkytbox.TabStop = false;
            this.ogrtmnkytbox.Text = "Öğretmen Bilgileri";
            
            // 
            // ogrtmntctext
            // 
            this.ogrtmntctext.Location = new System.Drawing.Point(123, 154);
            this.ogrtmntctext.Name = "ogrtmntctext";
            this.ogrtmntctext.Size = new System.Drawing.Size(145, 22);
            this.ogrtmntctext.TabIndex = 6;
            // 
            // ogrtmntclbl
            // 
            this.ogrtmntclbl.AutoSize = true;
            this.ogrtmntclbl.Location = new System.Drawing.Point(55, 157);
            this.ogrtmntclbl.Name = "ogrtmntclbl";
            this.ogrtmntclbl.Size = new System.Drawing.Size(25, 16);
            this.ogrtmntclbl.TabIndex = 5;
            this.ogrtmntclbl.Text = "TC";
            // 
            // ogrtmnsoyadtext
            // 
            this.ogrtmnsoyadtext.Location = new System.Drawing.Point(123, 101);
            this.ogrtmnsoyadtext.Name = "ogrtmnsoyadtext";
            this.ogrtmnsoyadtext.Size = new System.Drawing.Size(145, 22);
            this.ogrtmnsoyadtext.TabIndex = 4;
            // 
            // ogrtmnadtext
            // 
            this.ogrtmnadtext.Location = new System.Drawing.Point(123, 53);
            this.ogrtmnadtext.Name = "ogrtmnadtext";
            this.ogrtmnadtext.Size = new System.Drawing.Size(145, 22);
            this.ogrtmnadtext.TabIndex = 3;
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(84, 219);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetbtn.TabIndex = 2;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // ogrtmnsoyadlbl
            // 
            this.ogrtmnsoyadlbl.AutoSize = true;
            this.ogrtmnsoyadlbl.Location = new System.Drawing.Point(46, 104);
            this.ogrtmnsoyadlbl.Name = "ogrtmnsoyadlbl";
            this.ogrtmnsoyadlbl.Size = new System.Drawing.Size(47, 16);
            this.ogrtmnsoyadlbl.TabIndex = 1;
            this.ogrtmnsoyadlbl.Text = "Soyad";
            // 
            // ogrtmnadlbl
            // 
            this.ogrtmnadlbl.AutoSize = true;
            this.ogrtmnadlbl.Location = new System.Drawing.Point(55, 56);
            this.ogrtmnadlbl.Name = "ogrtmnadlbl";
            this.ogrtmnadlbl.Size = new System.Drawing.Size(24, 16);
            this.ogrtmnadlbl.TabIndex = 0;
            this.ogrtmnadlbl.Text = "Ad";
            // 
            // ogretmenkayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 335);
            this.Controls.Add(this.ogrtmnkytbox);
            this.Name = "ogretmenkayit";
            this.Text = "Öğretmen Kayıt İşlemleri";
            this.ogrtmnkytbox.ResumeLayout(false);
            this.ogrtmnkytbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ogrtmnkytbox;
        private System.Windows.Forms.TextBox ogrtmntctext;
        private System.Windows.Forms.Label ogrtmntclbl;
        private System.Windows.Forms.TextBox ogrtmnsoyadtext;
        private System.Windows.Forms.TextBox ogrtmnadtext;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Label ogrtmnsoyadlbl;
        private System.Windows.Forms.Label ogrtmnadlbl;
    }
}

