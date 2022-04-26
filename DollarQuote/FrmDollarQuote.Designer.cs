
namespace DollarQuote {
    partial class FrmDollarQuote {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.LabelBuyDollar = new System.Windows.Forms.Label();
            this.LabelSellDollar = new System.Windows.Forms.Label();
            this.LabelVariation = new System.Windows.Forms.Label();
            this.loadingScreen = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loadingScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "DÓLAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comprar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Variação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Venda:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(440, 450);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 42);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LabelBuyDollar
            // 
            this.LabelBuyDollar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelBuyDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBuyDollar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LabelBuyDollar.Location = new System.Drawing.Point(199, 135);
            this.LabelBuyDollar.Name = "LabelBuyDollar";
            this.LabelBuyDollar.Size = new System.Drawing.Size(325, 56);
            this.LabelBuyDollar.TabIndex = 5;
            this.LabelBuyDollar.Text = "0,0";
            this.LabelBuyDollar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSellDollar
            // 
            this.LabelSellDollar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelSellDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSellDollar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LabelSellDollar.Location = new System.Drawing.Point(199, 230);
            this.LabelSellDollar.Name = "LabelSellDollar";
            this.LabelSellDollar.Size = new System.Drawing.Size(325, 56);
            this.LabelSellDollar.TabIndex = 6;
            this.LabelSellDollar.Text = "0,0";
            this.LabelSellDollar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelVariation
            // 
            this.LabelVariation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelVariation.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVariation.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LabelVariation.Location = new System.Drawing.Point(199, 330);
            this.LabelVariation.Name = "LabelVariation";
            this.LabelVariation.Size = new System.Drawing.Size(325, 56);
            this.LabelVariation.TabIndex = 7;
            this.LabelVariation.Text = "0,0";
            this.LabelVariation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadingScreen
            // 
            this.loadingScreen.Image = global::DollarQuote.Properties.Resources.icon_loading_blue;
            this.loadingScreen.Location = new System.Drawing.Point(12, 135);
            this.loadingScreen.Name = "loadingScreen";
            this.loadingScreen.Size = new System.Drawing.Size(576, 260);
            this.loadingScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadingScreen.TabIndex = 8;
            this.loadingScreen.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDollarQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 504);
            this.Controls.Add(this.loadingScreen);
            this.Controls.Add(this.LabelVariation);
            this.Controls.Add(this.LabelSellDollar);
            this.Controls.Add(this.LabelBuyDollar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDollarQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Quote";
            this.Load += new System.EventHandler(this.FrmDollarQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadingScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label LabelBuyDollar;
        private System.Windows.Forms.Label LabelSellDollar;
        private System.Windows.Forms.Label LabelVariation;
        private System.Windows.Forms.PictureBox loadingScreen;
        private System.Windows.Forms.Timer timer1;
    }
}

