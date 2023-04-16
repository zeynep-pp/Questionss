namespace Question2FormsApplication
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
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelObjects = new System.Windows.Forms.Label();
            this.labelPlayer1Score = new System.Windows.Forms.Label();
            this.labelPlayer2Score = new System.Windows.Forms.Label();
            this.buttonTake = new System.Windows.Forms.Button();
            this.numericUpDownTake = new System.Windows.Forms.NumericUpDown();
            this.labelTurn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTake)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPlayer1.Location = new System.Drawing.Point(149, 268);
            this.labelPlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(99, 29);
            this.labelPlayer1.TabIndex = 0;
            this.labelPlayer1.Text = "Player1";
            this.labelPlayer1.Click += new System.EventHandler(this.labelPlayer1_Click);
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPlayer2.Location = new System.Drawing.Point(667, 268);
            this.labelPlayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(99, 29);
            this.labelPlayer2.TabIndex = 1;
            this.labelPlayer2.Text = "Player2";
            // 
            // labelObjects
            // 
            this.labelObjects.AutoSize = true;
            this.labelObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelObjects.Location = new System.Drawing.Point(4, 25);
            this.labelObjects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObjects.Name = "labelObjects";
            this.labelObjects.Size = new System.Drawing.Size(99, 29);
            this.labelObjects.TabIndex = 2;
            this.labelObjects.Text = "Objects";
            // 
            // labelPlayer1Score
            // 
            this.labelPlayer1Score.AutoSize = true;
            this.labelPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPlayer1Score.Location = new System.Drawing.Point(152, 319);
            this.labelPlayer1Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayer1Score.Name = "labelPlayer1Score";
            this.labelPlayer1Score.Size = new System.Drawing.Size(172, 29);
            this.labelPlayer1Score.TabIndex = 3;
            this.labelPlayer1Score.Text = "Player1 Score";
            // 
            // labelPlayer2Score
            // 
            this.labelPlayer2Score.AutoSize = true;
            this.labelPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPlayer2Score.Location = new System.Drawing.Point(667, 319);
            this.labelPlayer2Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayer2Score.Name = "labelPlayer2Score";
            this.labelPlayer2Score.Size = new System.Drawing.Size(172, 29);
            this.labelPlayer2Score.TabIndex = 4;
            this.labelPlayer2Score.Text = "Player2 Score";
            // 
            // buttonTake
            // 
            this.buttonTake.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTake.Location = new System.Drawing.Point(424, 463);
            this.buttonTake.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(156, 59);
            this.buttonTake.TabIndex = 5;
            this.buttonTake.Text = "Topla";
            this.buttonTake.UseVisualStyleBackColor = false;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // numericUpDownTake
            // 
            this.numericUpDownTake.BackColor = System.Drawing.Color.LightSeaGreen;
            this.numericUpDownTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownTake.Location = new System.Drawing.Point(440, 386);
            this.numericUpDownTake.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownTake.Name = "numericUpDownTake";
            this.numericUpDownTake.Size = new System.Drawing.Size(87, 36);
            this.numericUpDownTake.TabIndex = 6;
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTurn.Location = new System.Drawing.Point(440, 235);
            this.labelTurn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(81, 29);
            this.labelTurn.TabIndex = 7;
            this.labelTurn.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 634);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.numericUpDownTake);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.labelPlayer2Score);
            this.Controls.Add(this.labelPlayer1Score);
            this.Controls.Add(this.labelObjects);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelObjects;
        private System.Windows.Forms.Label labelPlayer1Score;
        private System.Windows.Forms.Label labelPlayer2Score;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.NumericUpDown numericUpDownTake;
        private System.Windows.Forms.Label labelTurn;
    }
}

