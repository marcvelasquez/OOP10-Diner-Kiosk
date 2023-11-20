namespace ClientApp
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
            entreeToolStripMenuItem = new ToolStripMenuItem();
            drinksToolStripMenuItem = new ToolStripMenuItem();
            specialRequestToolStripMenuItem = new ToolStripMenuItem();
            lstBxEntree = new ListBox();
            groupBox2 = new GroupBox();
            radCoffee = new RadioButton();
            radTea = new RadioButton();
            radLemon = new RadioButton();
            radSoda = new RadioButton();
            radJuice = new RadioButton();
            radMilk = new RadioButton();
            cmboSpecial = new ComboBox();
            ckBxWater = new CheckBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            placeOrderToolStripMenuItem = new ToolStripMenuItem();
            clearOrderToolStripMenuItem = new ToolStripMenuItem();
            displayOrderToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            entreeToolStripMenuItem1 = new ToolStripMenuItem();
            drinkToolStripMenuItem = new ToolStripMenuItem();
            specialRequestToolStripMenuItem1 = new ToolStripMenuItem();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // entreeToolStripMenuItem
            // 
            entreeToolStripMenuItem.Name = "entreeToolStripMenuItem";
            entreeToolStripMenuItem.Size = new Size(247, 32);
            entreeToolStripMenuItem.Text = "Entree";
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new Size(247, 32);
            drinksToolStripMenuItem.Text = "Drinks";
            // 
            // specialRequestToolStripMenuItem
            // 
            specialRequestToolStripMenuItem.Name = "specialRequestToolStripMenuItem";
            specialRequestToolStripMenuItem.Size = new Size(247, 32);
            specialRequestToolStripMenuItem.Text = "Special Request";
            // 
            // lstBxEntree
            // 
            lstBxEntree.FormattingEnabled = true;
            lstBxEntree.ItemHeight = 20;
            lstBxEntree.Location = new Point(58, 113);
            lstBxEntree.Name = "lstBxEntree";
            lstBxEntree.SelectionMode = SelectionMode.MultiExtended;
            lstBxEntree.Size = new Size(150, 104);
            lstBxEntree.Sorted = true;
            lstBxEntree.TabIndex = 6;
            lstBxEntree.SelectedIndexChanged += lstBxEntree_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radCoffee);
            groupBox2.Controls.Add(radTea);
            groupBox2.Controls.Add(radLemon);
            groupBox2.Controls.Add(radSoda);
            groupBox2.Controls.Add(radJuice);
            groupBox2.Controls.Add(radMilk);
            groupBox2.Location = new Point(244, 113);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(135, 215);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox1";
            // 
            // radCoffee
            // 
            radCoffee.AutoSize = true;
            radCoffee.Location = new Point(6, 175);
            radCoffee.Name = "radCoffee";
            radCoffee.Size = new Size(74, 24);
            radCoffee.TabIndex = 5;
            radCoffee.TabStop = true;
            radCoffee.Text = "Coffee";
            radCoffee.UseVisualStyleBackColor = true;
            radCoffee.CheckedChanged += radCoffee_CheckedChanged;
            // 
            // radTea
            // 
            radTea.AutoSize = true;
            radTea.Location = new Point(6, 145);
            radTea.Name = "radTea";
            radTea.Size = new Size(53, 24);
            radTea.TabIndex = 4;
            radTea.TabStop = true;
            radTea.Text = "Tea";
            radTea.UseVisualStyleBackColor = true;
            radTea.CheckedChanged += radTea_CheckedChanged;
            // 
            // radLemon
            // 
            radLemon.AutoSize = true;
            radLemon.Location = new Point(6, 115);
            radLemon.Name = "radLemon";
            radLemon.Size = new Size(100, 24);
            radLemon.TabIndex = 3;
            radLemon.TabStop = true;
            radLemon.Text = "Lemonade";
            radLemon.UseVisualStyleBackColor = true;
            radLemon.CheckedChanged += radLemon_CheckedChanged;
            // 
            // radSoda
            // 
            radSoda.AutoSize = true;
            radSoda.Location = new Point(6, 85);
            radSoda.Name = "radSoda";
            radSoda.Size = new Size(64, 24);
            radSoda.TabIndex = 2;
            radSoda.TabStop = true;
            radSoda.Text = "Soda";
            radSoda.UseVisualStyleBackColor = true;
            radSoda.CheckedChanged += radSoda_CheckedChanged;
            // 
            // radJuice
            // 
            radJuice.AutoSize = true;
            radJuice.Location = new Point(6, 56);
            radJuice.Name = "radJuice";
            radJuice.Size = new Size(62, 24);
            radJuice.TabIndex = 1;
            radJuice.TabStop = true;
            radJuice.Text = "Juice";
            radJuice.UseVisualStyleBackColor = true;
            radJuice.CheckedChanged += radJuice_CheckedChanged;
            // 
            // radMilk
            // 
            radMilk.AutoSize = true;
            radMilk.Location = new Point(6, 26);
            radMilk.Name = "radMilk";
            radMilk.Size = new Size(58, 24);
            radMilk.TabIndex = 0;
            radMilk.TabStop = true;
            radMilk.Text = "Milk";
            radMilk.UseVisualStyleBackColor = true;
            radMilk.CheckedChanged += radMilk_CheckedChanged;
            // 
            // cmboSpecial
            // 
            cmboSpecial.FormattingEnabled = true;
            cmboSpecial.Items.AddRange(new object[] { "Whole Wheat", "Pumpernickel", "Seedless Rye", "Pita", "Sour Dough" });
            cmboSpecial.Location = new Point(58, 223);
            cmboSpecial.Name = "cmboSpecial";
            cmboSpecial.Size = new Size(151, 28);
            cmboSpecial.TabIndex = 8;
            cmboSpecial.SelectedIndexChanged += cmboSpecial_SelectedIndexChanged;
            cmboSpecial.KeyPress += cmboSpecial_KeyPress;
            // 
            // ckBxWater
            // 
            ckBxWater.AutoSize = true;
            ckBxWater.Location = new Point(103, 267);
            ckBxWater.Name = "ckBxWater";
            ckBxWater.Size = new Size(70, 24);
            ckBxWater.TabIndex = 9;
            ckBxWater.Text = "Water";
            ckBxWater.UseVisualStyleBackColor = true;
            ckBxWater.CheckedChanged += ckBxWater_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(434, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { placeOrderToolStripMenuItem, clearOrderToolStripMenuItem, displayOrderToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // placeOrderToolStripMenuItem
            // 
            placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            placeOrderToolStripMenuItem.Size = new Size(183, 26);
            placeOrderToolStripMenuItem.Text = "Place Order";
            placeOrderToolStripMenuItem.Click += placeOrderToolStripMenuItem_Click;
            // 
            // clearOrderToolStripMenuItem
            // 
            clearOrderToolStripMenuItem.Name = "clearOrderToolStripMenuItem";
            clearOrderToolStripMenuItem.Size = new Size(183, 26);
            clearOrderToolStripMenuItem.Text = "Clear Order";
            clearOrderToolStripMenuItem.Click += clearOrderToolStripMenuItem_Click;
            // 
            // displayOrderToolStripMenuItem
            // 
            displayOrderToolStripMenuItem.Name = "displayOrderToolStripMenuItem";
            displayOrderToolStripMenuItem.Size = new Size(183, 26);
            displayOrderToolStripMenuItem.Text = "Display Order";
            displayOrderToolStripMenuItem.Click += displayOrderToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(183, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { entreeToolStripMenuItem1, drinkToolStripMenuItem, specialRequestToolStripMenuItem1 });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // entreeToolStripMenuItem1
            // 
            entreeToolStripMenuItem1.Name = "entreeToolStripMenuItem1";
            entreeToolStripMenuItem1.Size = new Size(224, 26);
            entreeToolStripMenuItem1.Text = "Entree";
            // 
            // drinkToolStripMenuItem
            // 
            drinkToolStripMenuItem.Name = "drinkToolStripMenuItem";
            drinkToolStripMenuItem.Size = new Size(224, 26);
            drinkToolStripMenuItem.Text = "Drink";
            // 
            // specialRequestToolStripMenuItem1
            // 
            specialRequestToolStripMenuItem1.Name = "specialRequestToolStripMenuItem1";
            specialRequestToolStripMenuItem1.Size = new Size(224, 26);
            specialRequestToolStripMenuItem1.Text = "Special Request";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(434, 450);
            Controls.Add(ckBxWater);
            Controls.Add(cmboSpecial);
            Controls.Add(groupBox2);
            Controls.Add(lstBxEntree);
            Controls.Add(menuStrip1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem entreeToolStripMenuItem;
        private ToolStripMenuItem drinksToolStripMenuItem;
        private ToolStripMenuItem specialRequestToolStripMenuItem;
        private GroupBox groupBox2;
        private RadioButton radCoffee;
        private RadioButton radTea;
        private RadioButton radLemon;
        private RadioButton radSoda;
        private RadioButton radJuice;
        private RadioButton radMilk;
        private ListBox lstBxEntree;
        private CheckBox ckBxWater;
        private ComboBox cmboSpecial;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem placeOrderToolStripMenuItem;
        private ToolStripMenuItem clearOrderToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem displayOrderToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem entreeToolStripMenuItem1;
        private ToolStripMenuItem drinkToolStripMenuItem;
        private ToolStripMenuItem specialRequestToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
