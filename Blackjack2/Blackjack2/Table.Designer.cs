
namespace Blackjack2
{
    partial class Table
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
            this.button_hit = new System.Windows.Forms.Button();
            this.button_stay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.event_text = new System.Windows.Forms.RichTextBox();
            this.player_card_display = new System.Windows.Forms.RichTextBox();
            this.dealer_card_display = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dealer_points_display = new System.Windows.Forms.TextBox();
            this.player_points_display = new System.Windows.Forms.TextBox();
            this.Amount_Bet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.TextBox();
            this.button_bet = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_Bet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_hit
            // 
            this.button_hit.Location = new System.Drawing.Point(979, 575);
            this.button_hit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_hit.Name = "button_hit";
            this.button_hit.Size = new System.Drawing.Size(175, 53);
            this.button_hit.TabIndex = 1;
            this.button_hit.Text = "Hit";
            this.button_hit.UseVisualStyleBackColor = true;
            this.button_hit.Click += new System.EventHandler(this.button_hit_Click);
            // 
            // button_stay
            // 
            this.button_stay.Location = new System.Drawing.Point(981, 646);
            this.button_stay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_stay.Name = "button_stay";
            this.button_stay.Size = new System.Drawing.Size(175, 53);
            this.button_stay.TabIndex = 2;
            this.button_stay.Text = "Stay";
            this.button_stay.UseVisualStyleBackColor = true;
            this.button_stay.Click += new System.EventHandler(this.button_stay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(337, 903);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cash:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 905);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dealer Points:";
            // 
            // event_text
            // 
            this.event_text.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.event_text.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.event_text.Location = new System.Drawing.Point(981, 7);
            this.event_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.event_text.Name = "event_text";
            this.event_text.ReadOnly = true;
            this.event_text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.event_text.Size = new System.Drawing.Size(173, 471);
            this.event_text.TabIndex = 8;
            this.event_text.Text = "";
            // 
            // player_card_display
            // 
            this.player_card_display.BackColor = System.Drawing.Color.Aquamarine;
            this.player_card_display.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player_card_display.Location = new System.Drawing.Point(1, 487);
            this.player_card_display.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.player_card_display.Name = "player_card_display";
            this.player_card_display.Size = new System.Drawing.Size(971, 404);
            this.player_card_display.TabIndex = 9;
            this.player_card_display.Text = "";
            // 
            // dealer_card_display
            // 
            this.dealer_card_display.BackColor = System.Drawing.Color.Aquamarine;
            this.dealer_card_display.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dealer_card_display.Location = new System.Drawing.Point(1, 7);
            this.dealer_card_display.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dealer_card_display.Name = "dealer_card_display";
            this.dealer_card_display.Size = new System.Drawing.Size(971, 471);
            this.dealer_card_display.TabIndex = 10;
            this.dealer_card_display.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(874, 901);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Player Points:";
            // 
            // dealer_points_display
            // 
            this.dealer_points_display.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dealer_points_display.Location = new System.Drawing.Point(128, 903);
            this.dealer_points_display.Name = "dealer_points_display";
            this.dealer_points_display.Size = new System.Drawing.Size(125, 30);
            this.dealer_points_display.TabIndex = 13;
            // 
            // player_points_display
            // 
            this.player_points_display.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player_points_display.Location = new System.Drawing.Point(1013, 898);
            this.player_points_display.Name = "player_points_display";
            this.player_points_display.Size = new System.Drawing.Size(125, 30);
            this.player_points_display.TabIndex = 14;
            // 
            // Amount_Bet
            // 
            this.Amount_Bet.Location = new System.Drawing.Point(653, 900);
            this.Amount_Bet.Name = "Amount_Bet";
            this.Amount_Bet.Size = new System.Drawing.Size(150, 27);
            this.Amount_Bet.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(600, 901);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bet";
            // 
            // Balance
            // 
            this.Balance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Balance.Location = new System.Drawing.Point(405, 898);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(125, 30);
            this.Balance.TabIndex = 17;
            // 
            // button_bet
            // 
            this.button_bet.Location = new System.Drawing.Point(981, 719);
            this.button_bet.Name = "button_bet";
            this.button_bet.Size = new System.Drawing.Size(175, 53);
            this.button_bet.TabIndex = 18;
            this.button_bet.Text = "Place Bet";
            this.button_bet.UseVisualStyleBackColor = true;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(979, 501);
            this.button_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(175, 53);
            this.button_start.TabIndex = 20;
            this.button_start.Text = "Start Game";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_restart
            // 
            this.button_restart.Location = new System.Drawing.Point(981, 791);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(175, 53);
            this.button_restart.TabIndex = 21;
            this.button_restart.Text = "Restart";
            this.button_restart.UseVisualStyleBackColor = true;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1162, 985);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_bet);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Amount_Bet);
            this.Controls.Add(this.player_points_display);
            this.Controls.Add(this.dealer_points_display);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dealer_card_display);
            this.Controls.Add(this.player_card_display);
            this.Controls.Add(this.event_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_stay);
            this.Controls.Add(this.button_hit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)(this.Amount_Bet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_hit;
        private System.Windows.Forms.Button button_stay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox event_text;
        private System.Windows.Forms.RichTextBox player_card_display;
        private System.Windows.Forms.RichTextBox dealer_card_display;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dealer_points_display;
        private System.Windows.Forms.TextBox player_points_display;
        private System.Windows.Forms.NumericUpDown Amount_Bet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.Button button_bet;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_restart;
    }
}

