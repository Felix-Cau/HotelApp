namespace HotelApp.Views
{
    partial class FormCustomer
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
            labelCustomerInformation = new Label();
            labelFullName = new Label();
            labelAddress = new Label();
            labelPostalCode = new Label();
            labelCity = new Label();
            labelCountry = new Label();
            labelPhoneNumber = new Label();
            labelEmail = new Label();
            textBoxFullName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPostalCode = new TextBox();
            textBoxCountry = new TextBox();
            textBoxCity = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxEmail = new TextBox();
            buttonUpdateCustomer = new Button();
            buttonAddNewCustomer = new Button();
            buttonRemoveCustomer = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelCustomerInformation
            // 
            labelCustomerInformation.AutoSize = true;
            labelCustomerInformation.Font = new Font("Segoe UI", 11F);
            labelCustomerInformation.Location = new Point(12, 9);
            labelCustomerInformation.Name = "labelCustomerInformation";
            labelCustomerInformation.Size = new Size(154, 20);
            labelCustomerInformation.TabIndex = 0;
            labelCustomerInformation.Text = "Customer information";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(16, 40);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(59, 15);
            labelFullName.TabIndex = 1;
            labelFullName.Text = "Full name";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(16, 84);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(49, 15);
            labelAddress.TabIndex = 2;
            labelAddress.Text = "Address";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(16, 128);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(68, 15);
            labelPostalCode.TabIndex = 3;
            labelPostalCode.Text = "Postal code";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(122, 128);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(28, 15);
            labelCity.TabIndex = 4;
            labelCity.Text = "City";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(16, 172);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(50, 15);
            labelCountry.TabIndex = 5;
            labelCountry.Text = "Country";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(16, 216);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(86, 15);
            labelPhoneNumber.TabIndex = 6;
            labelPhoneNumber.Text = "Phone number";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(16, 260);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(41, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "E-mail";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(16, 58);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(258, 23);
            textBoxFullName.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(16, 102);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(258, 23);
            textBoxAddress.TabIndex = 9;
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Location = new Point(16, 146);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.Size = new Size(100, 23);
            textBoxPostalCode.TabIndex = 10;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(16, 190);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(258, 23);
            textBoxCountry.TabIndex = 11;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(122, 146);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(152, 23);
            textBoxCity.TabIndex = 12;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(16, 234);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(258, 23);
            textBoxPhoneNumber.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(16, 278);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(258, 23);
            textBoxEmail.TabIndex = 14;
            // 
            // buttonUpdateCustomer
            // 
            buttonUpdateCustomer.Location = new Point(47, 307);
            buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            buttonUpdateCustomer.Size = new Size(106, 23);
            buttonUpdateCustomer.TabIndex = 15;
            buttonUpdateCustomer.Text = "Update customer ";
            buttonUpdateCustomer.UseVisualStyleBackColor = true;
            buttonUpdateCustomer.Click += buttonUpdateCustomer_Click;
            // 
            // buttonAddNewCustomer
            // 
            buttonAddNewCustomer.Location = new Point(159, 307);
            buttonAddNewCustomer.Name = "buttonAddNewCustomer";
            buttonAddNewCustomer.Size = new Size(115, 23);
            buttonAddNewCustomer.TabIndex = 16;
            buttonAddNewCustomer.Text = "Add new customer";
            buttonAddNewCustomer.UseVisualStyleBackColor = true;
            buttonAddNewCustomer.Click += buttonAddNewCustomer_Click;
            // 
            // buttonRemoveCustomer
            // 
            buttonRemoveCustomer.Location = new Point(80, 336);
            buttonRemoveCustomer.Name = "buttonRemoveCustomer";
            buttonRemoveCustomer.Size = new Size(113, 23);
            buttonRemoveCustomer.TabIndex = 17;
            buttonRemoveCustomer.Text = "Remove customer";
            buttonRemoveCustomer.UseVisualStyleBackColor = true;
            buttonRemoveCustomer.Click += buttonRemoveCustomer_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(199, 336);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 18;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 376);
            Controls.Add(buttonCancel);
            Controls.Add(buttonRemoveCustomer);
            Controls.Add(buttonAddNewCustomer);
            Controls.Add(buttonUpdateCustomer);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxPostalCode);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxFullName);
            Controls.Add(labelEmail);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelCountry);
            Controls.Add(labelCity);
            Controls.Add(labelPostalCode);
            Controls.Add(labelAddress);
            Controls.Add(labelFullName);
            Controls.Add(labelCustomerInformation);
            Name = "FormCustomer";
            Text = "Customers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCustomerInformation;
        private Label labelFullName;
        private Label labelAddress;
        private Label labelPostalCode;
        private Label labelCity;
        private Label labelCountry;
        private Label labelPhoneNumber;
        private Label labelEmail;
        private TextBox textBoxFullName;
        private TextBox textBoxAddress;
        private TextBox textBoxPostalCode;
        private TextBox textBoxCountry;
        private TextBox textBoxCity;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxEmail;
        private Button buttonUpdateCustomer;
        private Button buttonAddNewCustomer;
        private Button buttonRemoveCustomer;
        private Button buttonCancel;
    }
}