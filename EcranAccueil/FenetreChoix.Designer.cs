﻿namespace EcranAccueil
{
    partial class FenetreChoix
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
            this.button_ajouter_client = new System.Windows.Forms.Button();
            this.button_rechercher_client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ajouter_client
            // 
            this.button_ajouter_client.Location = new System.Drawing.Point(59, 40);
            this.button_ajouter_client.Name = "button_ajouter_client";
            this.button_ajouter_client.Size = new System.Drawing.Size(120, 23);
            this.button_ajouter_client.TabIndex = 0;
            this.button_ajouter_client.Text = "Ajouter un client";
            this.button_ajouter_client.UseVisualStyleBackColor = true;
            // 
            // button_rechercher_client
            // 
            this.button_rechercher_client.Location = new System.Drawing.Point(59, 99);
            this.button_rechercher_client.Name = "button_rechercher_client";
            this.button_rechercher_client.Size = new System.Drawing.Size(120, 23);
            this.button_rechercher_client.TabIndex = 1;
            this.button_rechercher_client.Text = "Rechercher un client";
            this.button_rechercher_client.UseVisualStyleBackColor = true;
            // 
            // FenetreChoix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 173);
            this.Controls.Add(this.button_rechercher_client);
            this.Controls.Add(this.button_ajouter_client);
            this.Name = "FenetreChoix";
            this.Text = "FenetreChoix";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ajouter_client;
        private System.Windows.Forms.Button button_rechercher_client;
    }
}