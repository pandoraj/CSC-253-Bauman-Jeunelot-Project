namespace DungeonCrawl1
{
    partial class coralCastleForm
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
            this.roomLabel = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.weaponsButton = new System.Windows.Forms.Button();
            this.potionsButton = new System.Windows.Forms.Button();
            this.treasuresButton = new System.Windows.Forms.Button();
            this.mobsButton = new System.Windows.Forms.Button();
            this.itemsButton = new System.Windows.Forms.Button();
            this.roomsButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.nameInstructionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordInstructionLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.classInstructionLabel = new System.Windows.Forms.Label();
            this.classListBox = new System.Windows.Forms.ListBox();
            this.raceInstructionLabel = new System.Windows.Forms.Label();
            this.raceListBox = new System.Windows.Forms.ListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.passwordRequirementLabel = new System.Windows.Forms.Label();
            this.newPlayerRadioButton = new System.Windows.Forms.RadioButton();
            this.returningRadioButton = new System.Windows.Forms.RadioButton();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomLabel
            // 
            this.roomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomLabel.Location = new System.Drawing.Point(245, 180);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(269, 117);
            this.roomLabel.TabIndex = 1;
            this.roomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roomLabel.Visible = false;
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionLabel.Location = new System.Drawing.Point(242, 13);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(103, 13);
            this.directionLabel.TabIndex = 4;
            this.directionLabel.Text = "Which direction?";
            this.directionLabel.Visible = false;
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(493, 13);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(187, 13);
            this.displayLabel.TabIndex = 5;
            this.displayLabel.Text = "What would you like to display?";
            this.displayLabel.Visible = false;
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.Location = new System.Drawing.Point(538, 180);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(367, 121);
            this.displayListBox.TabIndex = 6;
            this.displayListBox.Visible = false;
            // 
            // weaponsButton
            // 
            this.weaponsButton.Location = new System.Drawing.Point(514, 40);
            this.weaponsButton.Name = "weaponsButton";
            this.weaponsButton.Size = new System.Drawing.Size(75, 23);
            this.weaponsButton.TabIndex = 7;
            this.weaponsButton.Text = "Weapons";
            this.weaponsButton.UseVisualStyleBackColor = true;
            this.weaponsButton.Visible = false;
            this.weaponsButton.Click += new System.EventHandler(this.weaponsButton_Click);
            // 
            // potionsButton
            // 
            this.potionsButton.Location = new System.Drawing.Point(514, 77);
            this.potionsButton.Name = "potionsButton";
            this.potionsButton.Size = new System.Drawing.Size(75, 23);
            this.potionsButton.TabIndex = 8;
            this.potionsButton.Text = "Potions";
            this.potionsButton.UseVisualStyleBackColor = true;
            this.potionsButton.Visible = false;
            this.potionsButton.Click += new System.EventHandler(this.potionsButton_Click);
            // 
            // treasuresButton
            // 
            this.treasuresButton.Location = new System.Drawing.Point(595, 111);
            this.treasuresButton.Name = "treasuresButton";
            this.treasuresButton.Size = new System.Drawing.Size(75, 23);
            this.treasuresButton.TabIndex = 9;
            this.treasuresButton.Text = "Treasures";
            this.treasuresButton.UseVisualStyleBackColor = true;
            this.treasuresButton.Visible = false;
            this.treasuresButton.Click += new System.EventHandler(this.treasuresButton_Click);
            // 
            // mobsButton
            // 
            this.mobsButton.Location = new System.Drawing.Point(514, 111);
            this.mobsButton.Name = "mobsButton";
            this.mobsButton.Size = new System.Drawing.Size(75, 23);
            this.mobsButton.TabIndex = 10;
            this.mobsButton.Text = "Mobs";
            this.mobsButton.UseVisualStyleBackColor = true;
            this.mobsButton.Visible = false;
            this.mobsButton.Click += new System.EventHandler(this.mobsButton_Click);
            // 
            // itemsButton
            // 
            this.itemsButton.Location = new System.Drawing.Point(595, 77);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(75, 23);
            this.itemsButton.TabIndex = 11;
            this.itemsButton.Text = "Items";
            this.itemsButton.UseVisualStyleBackColor = true;
            this.itemsButton.Visible = false;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // roomsButton
            // 
            this.roomsButton.Location = new System.Drawing.Point(595, 40);
            this.roomsButton.Name = "roomsButton";
            this.roomsButton.Size = new System.Drawing.Size(75, 23);
            this.roomsButton.TabIndex = 12;
            this.roomsButton.Text = "Rooms";
            this.roomsButton.UseVisualStyleBackColor = true;
            this.roomsButton.Visible = false;
            this.roomsButton.Click += new System.EventHandler(this.roomsButton_Click);
            // 
            // downButton
            // 
            this.downButton.Image = global::DungeonCrawl1.Properties.Resources.DOWN;
            this.downButton.Location = new System.Drawing.Point(245, 106);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 71);
            this.downButton.TabIndex = 3;
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Visible = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.Image = global::DungeonCrawl1.Properties.Resources.up_arrow2;
            this.upButton.Location = new System.Drawing.Point(245, 29);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 71);
            this.upButton.TabIndex = 2;
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Visible = false;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // nameInstructionLabel
            // 
            this.nameInstructionLabel.AutoSize = true;
            this.nameInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInstructionLabel.Location = new System.Drawing.Point(9, 57);
            this.nameInstructionLabel.Name = "nameInstructionLabel";
            this.nameInstructionLabel.Size = new System.Drawing.Size(43, 13);
            this.nameInstructionLabel.TabIndex = 13;
            this.nameInstructionLabel.Text = "Name:";
            this.nameInstructionLabel.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 73);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 14;
            this.nameTextBox.Visible = false;
            // 
            // passwordInstructionLabel
            // 
            this.passwordInstructionLabel.AutoSize = true;
            this.passwordInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInstructionLabel.Location = new System.Drawing.Point(9, 98);
            this.passwordInstructionLabel.Name = "passwordInstructionLabel";
            this.passwordInstructionLabel.Size = new System.Drawing.Size(65, 13);
            this.passwordInstructionLabel.TabIndex = 15;
            this.passwordInstructionLabel.Text = "Password:";
            this.passwordInstructionLabel.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 114);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 16;
            this.passwordTextBox.Visible = false;
            // 
            // classInstructionLabel
            // 
            this.classInstructionLabel.AutoSize = true;
            this.classInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classInstructionLabel.Location = new System.Drawing.Point(9, 137);
            this.classInstructionLabel.Name = "classInstructionLabel";
            this.classInstructionLabel.Size = new System.Drawing.Size(41, 13);
            this.classInstructionLabel.TabIndex = 17;
            this.classInstructionLabel.Text = "Class:";
            this.classInstructionLabel.Visible = false;
            // 
            // classListBox
            // 
            this.classListBox.FormattingEnabled = true;
            this.classListBox.Location = new System.Drawing.Point(12, 153);
            this.classListBox.Name = "classListBox";
            this.classListBox.Size = new System.Drawing.Size(120, 69);
            this.classListBox.TabIndex = 18;
            this.classListBox.Visible = false;
            // 
            // raceInstructionLabel
            // 
            this.raceInstructionLabel.AutoSize = true;
            this.raceInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceInstructionLabel.Location = new System.Drawing.Point(11, 228);
            this.raceInstructionLabel.Name = "raceInstructionLabel";
            this.raceInstructionLabel.Size = new System.Drawing.Size(41, 13);
            this.raceInstructionLabel.TabIndex = 19;
            this.raceInstructionLabel.Text = "Race:";
            this.raceInstructionLabel.Visible = false;
            // 
            // raceListBox
            // 
            this.raceListBox.FormattingEnabled = true;
            this.raceListBox.Location = new System.Drawing.Point(12, 244);
            this.raceListBox.Name = "raceListBox";
            this.raceListBox.Size = new System.Drawing.Size(120, 69);
            this.raceListBox.TabIndex = 20;
            this.raceListBox.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(37, 319);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 21;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Visible = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // passwordRequirementLabel
            // 
            this.passwordRequirementLabel.Location = new System.Drawing.Point(138, 77);
            this.passwordRequirementLabel.Name = "passwordRequirementLabel";
            this.passwordRequirementLabel.Size = new System.Drawing.Size(98, 78);
            this.passwordRequirementLabel.TabIndex = 22;
            this.passwordRequirementLabel.Text = "Password must contain at least 1 uppercase letter, 1 lowercase letter, and 1 spec" +
    "ial character.";
            this.passwordRequirementLabel.Visible = false;
            // 
            // newPlayerRadioButton
            // 
            this.newPlayerRadioButton.AutoSize = true;
            this.newPlayerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerRadioButton.Location = new System.Drawing.Point(14, 13);
            this.newPlayerRadioButton.Name = "newPlayerRadioButton";
            this.newPlayerRadioButton.Size = new System.Drawing.Size(89, 17);
            this.newPlayerRadioButton.TabIndex = 23;
            this.newPlayerRadioButton.TabStop = true;
            this.newPlayerRadioButton.Text = "New Player";
            this.newPlayerRadioButton.UseVisualStyleBackColor = true;
            this.newPlayerRadioButton.CheckedChanged += new System.EventHandler(this.newPlayerRadioButton_CheckedChanged);
            // 
            // returningRadioButton
            // 
            this.returningRadioButton.AutoSize = true;
            this.returningRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returningRadioButton.Location = new System.Drawing.Point(14, 29);
            this.returningRadioButton.Name = "returningRadioButton";
            this.returningRadioButton.Size = new System.Drawing.Size(119, 17);
            this.returningRadioButton.TabIndex = 24;
            this.returningRadioButton.TabStop = true;
            this.returningRadioButton.Text = "Returning Player";
            this.returningRadioButton.UseVisualStyleBackColor = true;
            this.returningRadioButton.CheckedChanged += new System.EventHandler(this.returningRadioButton_CheckedChanged);
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(28, 153);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(75, 37);
            this.loadFileButton.TabIndex = 25;
            this.loadFileButton.Text = "Load Character";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Visible = false;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // coralCastleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(917, 347);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.returningRadioButton);
            this.Controls.Add(this.newPlayerRadioButton);
            this.Controls.Add(this.passwordRequirementLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.raceListBox);
            this.Controls.Add(this.raceInstructionLabel);
            this.Controls.Add(this.classListBox);
            this.Controls.Add(this.classInstructionLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordInstructionLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameInstructionLabel);
            this.Controls.Add(this.roomsButton);
            this.Controls.Add(this.itemsButton);
            this.Controls.Add(this.mobsButton);
            this.Controls.Add(this.treasuresButton);
            this.Controls.Add(this.potionsButton);
            this.Controls.Add(this.weaponsButton);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.directionLabel);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.roomLabel);
            this.Name = "coralCastleForm";
            this.Text = "Coral Castle";
            this.Load += new System.EventHandler(this.coralCastleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.Button weaponsButton;
        private System.Windows.Forms.Button potionsButton;
        private System.Windows.Forms.Button treasuresButton;
        private System.Windows.Forms.Button mobsButton;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Button roomsButton;
        private System.Windows.Forms.Label nameInstructionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label passwordInstructionLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label classInstructionLabel;
        private System.Windows.Forms.ListBox classListBox;
        private System.Windows.Forms.Label raceInstructionLabel;
        private System.Windows.Forms.ListBox raceListBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label passwordRequirementLabel;
        private System.Windows.Forms.RadioButton newPlayerRadioButton;
        private System.Windows.Forms.RadioButton returningRadioButton;
        private System.Windows.Forms.Button loadFileButton;
    }
}

