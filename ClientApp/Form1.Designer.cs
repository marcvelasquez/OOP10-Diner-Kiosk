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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            placeOrderToolStripMenuItem1 = new ToolStripMenuItem();
            editOrderToolStripMenuItem = new ToolStripMenuItem();
            clearOrderToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            entreeToolStripMenuItem = new ToolStripMenuItem();
            drinksToolStripMenuItem = new ToolStripMenuItem();
            specialRequestToolStripMenuItem = new ToolStripMenuItem();
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 25;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.Animated = true;
            guna2ControlBox1.BackColor = Color.Transparent;
            guna2ControlBox1.BorderColor = Color.Transparent;
            guna2ControlBox1.CustomizableEdges = customizableEdges3;
            guna2ControlBox1.FillColor = Color.Transparent;
            guna2ControlBox1.ForeColor = SystemColors.Control;
            guna2ControlBox1.HoverState.BorderColor = Color.White;
            guna2ControlBox1.HoverState.FillColor = Color.White;
            guna2ControlBox1.IconColor = Color.Black;
            guna2ControlBox1.Location = new Point(744, 1);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox1.Size = new Size(56, 36);
            guna2ControlBox1.TabIndex = 1;
            // 
            // guna2ControlBox3
            // 
            guna2ControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox3.Animated = true;
            guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            customizableEdges1.BottomLeft = false;
            customizableEdges1.BottomRight = false;
            customizableEdges1.TopLeft = false;
            guna2ControlBox3.CustomizableEdges = customizableEdges1;
            guna2ControlBox3.FillColor = Color.Transparent;
            guna2ControlBox3.HoverState.BorderColor = Color.White;
            guna2ControlBox3.HoverState.FillColor = Color.White;
            guna2ControlBox3.IconColor = Color.Black;
            guna2ControlBox3.Location = new Point(691, 1);
            guna2ControlBox3.Name = "guna2ControlBox3";
            guna2ControlBox3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox3.Size = new Size(56, 36);
            guna2ControlBox3.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(239, 8);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(280, 36);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { placeOrderToolStripMenuItem1, editOrderToolStripMenuItem, clearOrderToolStripMenuItem1, exitToolStripMenuItem1 });
            fileToolStripMenuItem.Margin = new Padding(0, 0, 40, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 32);
            fileToolStripMenuItem.Text = "File";
            // 
            // placeOrderToolStripMenuItem1
            // 
            placeOrderToolStripMenuItem1.Name = "placeOrderToolStripMenuItem1";
            placeOrderToolStripMenuItem1.Size = new Size(208, 32);
            placeOrderToolStripMenuItem1.Text = "Place Order";
            // 
            // editOrderToolStripMenuItem
            // 
            editOrderToolStripMenuItem.Name = "editOrderToolStripMenuItem";
            editOrderToolStripMenuItem.Size = new Size(208, 32);
            editOrderToolStripMenuItem.Text = "Edit Order";
            // 
            // clearOrderToolStripMenuItem1
            // 
            clearOrderToolStripMenuItem1.Name = "clearOrderToolStripMenuItem1";
            clearOrderToolStripMenuItem1.Size = new Size(208, 32);
            clearOrderToolStripMenuItem1.Text = "Clear Order";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(208, 32);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Margin = new Padding(0, 0, 40, 0);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(63, 32);
            editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(70, 32);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(156, 32);
            aboutToolStripMenuItem.Text = "About";
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 65);
            panel1.TabIndex = 5;
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
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.AnimateShowHideButton = true;
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.Icon = null;
            materialFloatingActionButton1.Location = new Point(730, 382);
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(70, 70);
            materialFloatingActionButton1.TabIndex = 6;
            materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(materialFloatingActionButton1);
            Controls.Add(panel1);
            Controls.Add(guna2ControlBox3);
            Controls.Add(guna2ControlBox1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem placeOrderToolStripMenuItem1;
        private ToolStripMenuItem editOrderToolStripMenuItem;
        private ToolStripMenuItem clearOrderToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem entreeToolStripMenuItem;
        private ToolStripMenuItem drinksToolStripMenuItem;
        private ToolStripMenuItem specialRequestToolStripMenuItem;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
    }
}
