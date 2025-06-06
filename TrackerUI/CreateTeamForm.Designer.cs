namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            headerLabel = new Label();
            selectTeamMemberDropdown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addMemberButton = new Button();
            groupBox1 = new GroupBox();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            cellPhoneValue = new TextBox();
            cellPhoneLabel = new Label();
            createMemberButton = new Button();
            teamMembersListBox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(24, 147);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(362, 35);
            teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.Location = new Point(24, 107);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(157, 37);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(24, 25);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(213, 50);
            headerLabel.TabIndex = 11;
            headerLabel.Text = "Create Team";
            // 
            // selectTeamMemberDropdown
            // 
            selectTeamMemberDropdown.FormattingEnabled = true;
            selectTeamMemberDropdown.Location = new Point(25, 252);
            selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            selectTeamMemberDropdown.Size = new Size(361, 38);
            selectTeamMemberDropdown.TabIndex = 16;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamMemberLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamMemberLabel.Location = new Point(25, 212);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(263, 37);
            selectTeamMemberLabel.TabIndex = 15;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.ForeColor = SystemColors.MenuHighlight;
            addMemberButton.Location = new Point(82, 296);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(182, 44);
            addMemberButton.TabIndex = 17;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(createMemberButton);
            groupBox1.Controls.Add(cellPhoneValue);
            groupBox1.Controls.Add(cellPhoneLabel);
            groupBox1.Controls.Add(emailValue);
            groupBox1.Controls.Add(emailLabel);
            groupBox1.Controls.Add(lastNameValue);
            groupBox1.Controls.Add(lastNameLabel);
            groupBox1.Controls.Add(firstNameValue);
            groupBox1.Controls.Add(firstNameLabel);
            groupBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(25, 370);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 376);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(189, 73);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(157, 43);
            firstNameValue.TabIndex = 20;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = SystemColors.MenuHighlight;
            firstNameLabel.Location = new Point(9, 70);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(144, 37);
            firstNameLabel.TabIndex = 19;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(189, 134);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(157, 43);
            lastNameValue.TabIndex = 22;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = SystemColors.MenuHighlight;
            lastNameLabel.Location = new Point(9, 131);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(142, 37);
            lastNameLabel.TabIndex = 21;
            lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(189, 196);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(157, 43);
            emailValue.TabIndex = 24;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = SystemColors.MenuHighlight;
            emailLabel.Location = new Point(9, 193);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(82, 37);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email";
            // 
            // cellPhoneValue
            // 
            cellPhoneValue.Location = new Point(189, 254);
            cellPhoneValue.Name = "cellPhoneValue";
            cellPhoneValue.Size = new Size(157, 43);
            cellPhoneValue.TabIndex = 26;
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cellPhoneLabel.ForeColor = SystemColors.MenuHighlight;
            cellPhoneLabel.Location = new Point(9, 251);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new Size(138, 37);
            cellPhoneLabel.TabIndex = 25;
            cellPhoneLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.ForeColor = SystemColors.MenuHighlight;
            createMemberButton.Location = new Point(57, 311);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(221, 44);
            createMemberButton.TabIndex = 19;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 30;
            teamMembersListBox.Location = new Point(484, 141);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(305, 602);
            teamMembersListBox.TabIndex = 19;
            teamMembersListBox.SelectedIndexChanged += tournamentPlayersListBox_SelectedIndexChanged;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedMemberButton.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedMemberButton.Location = new Point(808, 386);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(138, 100);
            deleteSelectedMemberButton.TabIndex = 21;
            deleteSelectedMemberButton.Text = "Delete Selected Member";
            deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.ForeColor = SystemColors.MenuHighlight;
            createTeamButton.Location = new Point(365, 790);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(203, 44);
            createTeamButton.TabIndex = 25;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(968, 956);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(groupBox1);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropdown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label headerLabel;
        private ComboBox selectTeamMemberDropdown;
        private Label selectTeamMemberLabel;
        private Button addMemberButton;
        private GroupBox groupBox1;
        private Button createMemberButton;
        private TextBox cellPhoneValue;
        private Label cellPhoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private ListBox teamMembersListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}