namespace BDO_AUTOCLICK
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LBL_Res = new System.Windows.Forms.Label();
            this.TB_ResX = new System.Windows.Forms.TextBox();
            this.LBL_Separator = new System.Windows.Forms.Label();
            this.TB_ResY = new System.Windows.Forms.TextBox();
            this.BTN_Go = new System.Windows.Forms.Button();
            this.BTN_TestRefresh = new System.Windows.Forms.Button();
            this.BTN_TestBuy = new System.Windows.Forms.Button();
            this.BTN_StopAll = new System.Windows.Forms.Button();
            this.TMR_Start = new System.Windows.Forms.Timer(this.components);
            this.TMR_Refresh = new System.Windows.Forms.Timer(this.components);
            this.TMR_Buy = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LBL_Res
            // 
            this.LBL_Res.AutoSize = true;
            this.LBL_Res.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LBL_Res.Location = new System.Drawing.Point(12, 18);
            this.LBL_Res.Name = "LBL_Res";
            this.LBL_Res.Size = new System.Drawing.Size(114, 25);
            this.LBL_Res.TabIndex = 0;
            this.LBL_Res.Text = "Resolution: ";
            // 
            // TB_ResX
            // 
            this.TB_ResX.Location = new System.Drawing.Point(121, 24);
            this.TB_ResX.Name = "TB_ResX";
            this.TB_ResX.Size = new System.Drawing.Size(112, 20);
            this.TB_ResX.TabIndex = 1;
            this.TB_ResX.TextChanged += new System.EventHandler(this.TB_ResX_TextChanged);
            // 
            // LBL_Separator
            // 
            this.LBL_Separator.AutoSize = true;
            this.LBL_Separator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBL_Separator.Location = new System.Drawing.Point(239, 23);
            this.LBL_Separator.Name = "LBL_Separator";
            this.LBL_Separator.Size = new System.Drawing.Size(18, 20);
            this.LBL_Separator.TabIndex = 2;
            this.LBL_Separator.Text = "×";
            // 
            // TB_ResY
            // 
            this.TB_ResY.Location = new System.Drawing.Point(263, 24);
            this.TB_ResY.Name = "TB_ResY";
            this.TB_ResY.Size = new System.Drawing.Size(112, 20);
            this.TB_ResY.TabIndex = 1;
            this.TB_ResY.TextChanged += new System.EventHandler(this.TB_ResY_TextChanged);
            // 
            // BTN_Go
            // 
            this.BTN_Go.Location = new System.Drawing.Point(17, 98);
            this.BTN_Go.Name = "BTN_Go";
            this.BTN_Go.Size = new System.Drawing.Size(115, 42);
            this.BTN_Go.TabIndex = 3;
            this.BTN_Go.Text = "Start";
            this.BTN_Go.UseVisualStyleBackColor = true;
            this.BTN_Go.Click += new System.EventHandler(this.BTN_Go_Click);
            // 
            // BTN_TestRefresh
            // 
            this.BTN_TestRefresh.Location = new System.Drawing.Point(146, 98);
            this.BTN_TestRefresh.Name = "BTN_TestRefresh";
            this.BTN_TestRefresh.Size = new System.Drawing.Size(115, 42);
            this.BTN_TestRefresh.TabIndex = 3;
            this.BTN_TestRefresh.Text = "Test Refresh";
            this.BTN_TestRefresh.UseVisualStyleBackColor = true;
            this.BTN_TestRefresh.Click += new System.EventHandler(this.BTN_TestRefresh_Click);
            // 
            // BTN_TestBuy
            // 
            this.BTN_TestBuy.Location = new System.Drawing.Point(275, 98);
            this.BTN_TestBuy.Name = "BTN_TestBuy";
            this.BTN_TestBuy.Size = new System.Drawing.Size(115, 42);
            this.BTN_TestBuy.TabIndex = 3;
            this.BTN_TestBuy.Text = "Test Buy/Bid";
            this.BTN_TestBuy.UseVisualStyleBackColor = true;
            this.BTN_TestBuy.Click += new System.EventHandler(this.BTN_TestBuy_Click);
            // 
            // BTN_StopAll
            // 
            this.BTN_StopAll.Location = new System.Drawing.Point(146, 146);
            this.BTN_StopAll.Name = "BTN_StopAll";
            this.BTN_StopAll.Size = new System.Drawing.Size(115, 42);
            this.BTN_StopAll.TabIndex = 3;
            this.BTN_StopAll.Text = "STOP ALL";
            this.BTN_StopAll.UseVisualStyleBackColor = true;
            this.BTN_StopAll.Click += new System.EventHandler(this.BTN_StopAll_Click);
            // 
            // TMR_Start
            // 
            this.TMR_Start.Tick += new System.EventHandler(this.TMR_Start_Tick);
            // 
            // TMR_Refresh
            // 
            this.TMR_Refresh.Tick += new System.EventHandler(this.TMR_Refresh_Tick);
            // 
            // TMR_Buy
            // 
            this.TMR_Buy.Tick += new System.EventHandler(this.TMR_Buy_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(402, 191);
            this.Controls.Add(this.BTN_TestBuy);
            this.Controls.Add(this.BTN_StopAll);
            this.Controls.Add(this.BTN_TestRefresh);
            this.Controls.Add(this.BTN_Go);
            this.Controls.Add(this.LBL_Separator);
            this.Controls.Add(this.TB_ResY);
            this.Controls.Add(this.TB_ResX);
            this.Controls.Add(this.LBL_Res);
            this.Name = "Form1";
            this.Text = "HENTAIHAVEN.ORG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_START;
        private System.Windows.Forms.Button BTN_STOP;
        private System.Windows.Forms.Label LBL_Res;
        private System.Windows.Forms.TextBox TB_ResX;
        private System.Windows.Forms.Label LBL_Separator;
        private System.Windows.Forms.TextBox TB_ResY;
        private System.Windows.Forms.Button BTN_Go;
        private System.Windows.Forms.Button BTN_TestRefresh;
        private System.Windows.Forms.Button BTN_TestBuy;
        private System.Windows.Forms.Button BTN_StopAll;
        private System.Windows.Forms.Timer TMR_Start;
        private System.Windows.Forms.Timer TMR_Refresh;
        private System.Windows.Forms.Timer TMR_Buy;
    }
}

