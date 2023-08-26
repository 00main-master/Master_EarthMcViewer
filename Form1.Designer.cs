namespace Master_EarthMcViewer
{
    partial class Form1
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
            TownInfoRequest = new Button();
            TownLabel = new Label();
            InputTownName = new TextBox();
            MapLink = new LinkLabel();
            ResidentInfoRequest = new Button();
            NationsInfoRequest = new Button();
            saveButton = new Button();
            saveFileDialog = new SaveFileDialog();
            SuspendLayout();
            // 
            // TownInfoRequest
            // 
            TownInfoRequest.Location = new Point(12, 41);
            TownInfoRequest.Name = "TownInfoRequest";
            TownInfoRequest.Size = new Size(130, 23);
            TownInfoRequest.TabIndex = 0;
            TownInfoRequest.Text = "Request town info";
            TownInfoRequest.UseVisualStyleBackColor = true;
            TownInfoRequest.Click += TownInfoRequest_Click;
            // 
            // TownLabel
            // 
            TownLabel.AutoSize = true;
            TownLabel.Location = new Point(12, 82);
            TownLabel.Name = "TownLabel";
            TownLabel.Size = new Size(0, 15);
            TownLabel.TabIndex = 1;
            // 
            // InputTownName
            // 
            InputTownName.Location = new Point(12, 12);
            InputTownName.Name = "InputTownName";
            InputTownName.Size = new Size(100, 23);
            InputTownName.TabIndex = 2;
            // 
            // MapLink
            // 
            MapLink.AutoSize = true;
            MapLink.Location = new Point(12, 67);
            MapLink.Name = "MapLink";
            MapLink.Size = new Size(0, 15);
            MapLink.TabIndex = 3;
            MapLink.TabStop = true;
            MapLink.LinkClicked += MapLink_LinkClicked;
            // 
            // ResidentInfoRequest
            // 
            ResidentInfoRequest.Location = new Point(148, 41);
            ResidentInfoRequest.Name = "ResidentInfoRequest";
            ResidentInfoRequest.Size = new Size(130, 23);
            ResidentInfoRequest.TabIndex = 4;
            ResidentInfoRequest.Text = "Request resident info";
            ResidentInfoRequest.UseVisualStyleBackColor = true;
            ResidentInfoRequest.Click += ResidentInfoRequest_Click;
            // 
            // NationsInfoRequest
            // 
            NationsInfoRequest.Location = new Point(284, 41);
            NationsInfoRequest.Name = "NationsInfoRequest";
            NationsInfoRequest.Size = new Size(130, 23);
            NationsInfoRequest.TabIndex = 5;
            NationsInfoRequest.Text = "Rquest nations info";
            NationsInfoRequest.UseVisualStyleBackColor = true;
            NationsInfoRequest.Click += NationsInfoRequest_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(708, 12);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(80, 80);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save info";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "info.txt";
            saveFileDialog.FileOk += saveFileDialog_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(saveButton);
            Controls.Add(NationsInfoRequest);
            Controls.Add(ResidentInfoRequest);
            Controls.Add(MapLink);
            Controls.Add(InputTownName);
            Controls.Add(TownLabel);
            Controls.Add(TownInfoRequest);
            Name = "Form1";
            Text = "Master_EarthMcViewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TownInfoRequest;
        private Label TownLabel;
        private TextBox InputTownName;
        private LinkLabel MapLink;
        private Button ResidentInfoRequest;
        private Button NationsInfoRequest;
        private Button saveButton;
        private SaveFileDialog saveFileDialog;
    }
}