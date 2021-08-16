namespace tictactoe
{
    partial class Userinput
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
            this.player1label = new System.Windows.Forms.Label();
            this.Player2label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.player1nametextbox = new System.Windows.Forms.TextBox();
            this.player2nametextbox = new System.Windows.Forms.TextBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1label
            // 
            this.player1label.AutoSize = true;
            this.player1label.Location = new System.Drawing.Point(12, 57);
            this.player1label.Name = "player1label";
            this.player1label.Size = new System.Drawing.Size(45, 13);
            this.player1label.TabIndex = 0;
            this.player1label.Text = "Player 1";
            this.player1label.Click += new System.EventHandler(this.player1label_Click);
            // 
            // Player2label
            // 
            this.Player2label.AutoSize = true;
            this.Player2label.Location = new System.Drawing.Point(12, 88);
            this.Player2label.Name = "Player2label";
            this.Player2label.Size = new System.Drawing.Size(45, 13);
            this.Player2label.TabIndex = 1;
            this.Player2label.Text = "Player 2";
            this.Player2label.Click += new System.EventHandler(this.Player2label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PLEASE ENTER YOUR NAMES";
            // 
            // player1nametextbox
            // 
            this.player1nametextbox.Location = new System.Drawing.Point(91, 57);
            this.player1nametextbox.Name = "player1nametextbox";
            this.player1nametextbox.Size = new System.Drawing.Size(135, 20);
            this.player1nametextbox.TabIndex = 3;
            this.player1nametextbox.TextChanged += new System.EventHandler(this.player1nametextbox_TextChanged);
            // 
            // player2nametextbox
            // 
            this.player2nametextbox.Location = new System.Drawing.Point(91, 85);
            this.player2nametextbox.Name = "player2nametextbox";
            this.player2nametextbox.Size = new System.Drawing.Size(135, 20);
            this.player2nametextbox.TabIndex = 4;
            this.player2nametextbox.TextChanged += new System.EventHandler(this.player2nametextbox_TextChanged);
            // 
            // submitbutton
            // 
            this.submitbutton.Location = new System.Drawing.Point(151, 120);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(75, 23);
            this.submitbutton.TabIndex = 5;
            this.submitbutton.Text = "submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // Userinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.player2nametextbox);
            this.Controls.Add(this.player1nametextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Player2label);
            this.Controls.Add(this.player1label);
            this.Name = "Userinput";
            this.Text = "Userinput";
            this.Load += new System.EventHandler(this.Userinput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1label;
        private System.Windows.Forms.Label Player2label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox player1nametextbox;
        private System.Windows.Forms.TextBox player2nametextbox;
        private System.Windows.Forms.Button submitbutton;
    }
}