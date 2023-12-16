namespace Gestion_des_etudiants
{
    partial class Manager
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            vider = new Button();
            supprimer = new Button();
            modifer = new Button();
            ajouter = new Button();
            chercher = new Button();
            premier = new Button();
            precedent = new Button();
            suivant = new Button();
            dernier = new Button();
            afficher = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 57);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 93);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 129);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Prenom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 166);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Filiere";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(171, 90);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 23);
            textBox4.TabIndex = 7;
            // 
            // vider
            // 
            vider.Location = new Point(324, 31);
            vider.Name = "vider";
            vider.Size = new Size(75, 28);
            vider.TabIndex = 8;
            vider.Text = "Vider";
            vider.UseVisualStyleBackColor = true;
            vider.Click += vider_Click;
            // 
            // supprimer
            // 
            supprimer.Location = new Point(324, 133);
            supprimer.Name = "supprimer";
            supprimer.Size = new Size(75, 28);
            supprimer.TabIndex = 9;
            supprimer.Text = "Supprimer";
            supprimer.UseVisualStyleBackColor = true;
            supprimer.Click += supprimer_Click;
            // 
            // modifer
            // 
            modifer.Location = new Point(324, 100);
            modifer.Name = "modifer";
            modifer.Size = new Size(75, 27);
            modifer.TabIndex = 10;
            modifer.Text = "Modifier";
            modifer.UseVisualStyleBackColor = true;
            modifer.Click += modifer_Click;
            // 
            // ajouter
            // 
            ajouter.Location = new Point(324, 65);
            ajouter.Name = "ajouter";
            ajouter.Size = new Size(75, 29);
            ajouter.TabIndex = 11;
            ajouter.Text = "Ajouter";
            ajouter.UseVisualStyleBackColor = true;
            ajouter.Click += ajouter_Click;
            // 
            // chercher
            // 
            chercher.Location = new Point(324, 167);
            chercher.Name = "chercher";
            chercher.Size = new Size(75, 30);
            chercher.TabIndex = 12;
            chercher.Text = "Chercher";
            chercher.UseVisualStyleBackColor = true;
            chercher.Click += chercher_Click;
            // 
            // premier
            // 
            premier.Location = new Point(80, 211);
            premier.Name = "premier";
            premier.Size = new Size(75, 39);
            premier.TabIndex = 13;
            premier.Text = "Premier";
            premier.UseVisualStyleBackColor = true;
            premier.Click += premier_Click;
            // 
            // precedent
            // 
            precedent.Location = new Point(161, 211);
            precedent.Name = "precedent";
            precedent.Size = new Size(75, 39);
            precedent.TabIndex = 14;
            precedent.Text = "Precedent";
            precedent.UseVisualStyleBackColor = true;
            precedent.Click += precedent_Click_1;
            // 
            // suivant
            // 
            suivant.Location = new Point(242, 211);
            suivant.Name = "suivant";
            suivant.Size = new Size(75, 39);
            suivant.TabIndex = 15;
            suivant.Text = "Suivant";
            suivant.UseVisualStyleBackColor = true;
            suivant.Click += suivant_Click_1;
            // 
            // dernier
            // 
            dernier.Location = new Point(323, 211);
            dernier.Name = "dernier";
            dernier.Size = new Size(76, 39);
            dernier.TabIndex = 16;
            dernier.Text = "Dernier";
            dernier.UseVisualStyleBackColor = true;
            dernier.Click += dernier_Click_1;
            // 
            // afficher
            // 
            afficher.Location = new Point(114, 265);
            afficher.Name = "afficher";
            afficher.Size = new Size(233, 37);
            afficher.TabIndex = 17;
            afficher.Text = "Afficher";
            afficher.UseVisualStyleBackColor = true;
            afficher.Click += afficher_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 336);
            Controls.Add(afficher);
            Controls.Add(dernier);
            Controls.Add(suivant);
            Controls.Add(precedent);
            Controls.Add(premier);
            Controls.Add(chercher);
            Controls.Add(ajouter);
            Controls.Add(modifer);
            Controls.Add(supprimer);
            Controls.Add(vider);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Manager";
            Text = "Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button vider;
        private Button supprimer;
        private Button modifer;
        private Button ajouter;
        private Button chercher;
        private Button premier;
        private Button precedent;
        private Button suivant;
        private Button dernier;
        private Button afficher;
    }
}