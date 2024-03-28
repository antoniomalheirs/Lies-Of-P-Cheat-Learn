namespace LiesOfPCheatLearn;

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
        label1 = new Label();
        Infiteergos = new CheckBox();
        InfiniteStamina = new CheckBox();
        InfiniteVitalCells = new CheckBox();
        Frezzyposition = new CheckBox();
        label2 = new Label();
        Infinitehealth = new CheckBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new Point(44, 35);
        label1.Name = "label1";
        label1.Size = new Size(120, 19);
        label1.TabIndex = 1;
        label1.Text = "Funções do Trainer";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Infiteergos
        // 
        Infiteergos.AutoSize = true;
        Infiteergos.Location = new Point(63, 57);
        Infiteergos.Name = "Infiteergos";
        Infiteergos.Size = new Size(95, 19);
        Infiteergos.TabIndex = 2;
        Infiteergos.Text = "Infinite Ergos";
        Infiteergos.UseVisualStyleBackColor = true;
        Infiteergos.CheckedChanged += Infiteergos_CheckedChanged;
        // 
        // InfiniteStamina
        // 
        InfiniteStamina.AutoSize = true;
        InfiniteStamina.Location = new Point(63, 132);
        InfiniteStamina.Name = "InfiniteStamina";
        InfiniteStamina.Size = new Size(109, 19);
        InfiniteStamina.TabIndex = 3;
        InfiniteStamina.Text = "Infinite Stamina";
        InfiniteStamina.UseVisualStyleBackColor = true;
        InfiniteStamina.CheckedChanged += InfiniteStamina_CheckedChanged;
        // 
        // InfiniteVitalCells
        // 
        InfiniteVitalCells.AutoSize = true;
        InfiniteVitalCells.Location = new Point(63, 82);
        InfiniteVitalCells.Name = "InfiniteVitalCells";
        InfiniteVitalCells.Size = new Size(117, 19);
        InfiniteVitalCells.TabIndex = 4;
        InfiniteVitalCells.Text = "Infinite Vital Cells";
        InfiniteVitalCells.UseVisualStyleBackColor = true;
        InfiniteVitalCells.CheckedChanged += InfiniteVitalCells_CheckedChanged;
        // 
        // Frezzyposition
        // 
        Frezzyposition.AutoSize = true;
        Frezzyposition.Location = new Point(63, 157);
        Frezzyposition.Name = "Frezzyposition";
        Frezzyposition.Size = new Size(104, 19);
        Frezzyposition.TabIndex = 7;
        Frezzyposition.Text = "Frezzy Position";
        Frezzyposition.UseVisualStyleBackColor = true;
        Frezzyposition.CheckedChanged += Frezzyposition_CheckedChanged;
        // 
        // label2
        // 
        label2.Location = new Point(244, 35);
        label2.Name = "label2";
        label2.Size = new Size(139, 19);
        label2.TabIndex = 8;
        label2.Text = "Valores atuais do Trainer";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Infinitehealth
        // 
        Infinitehealth.AutoSize = true;
        Infinitehealth.Location = new Point(63, 107);
        Infinitehealth.Name = "Infinitehealth";
        Infinitehealth.Size = new Size(101, 19);
        Infinitehealth.TabIndex = 9;
        Infinitehealth.Text = "Infinite Health";
        Infinitehealth.UseVisualStyleBackColor = true;
        Infinitehealth.CheckedChanged += Infinitehealth_CheckedChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(538, 247);
        Controls.Add(Infinitehealth);
        Controls.Add(label2);
        Controls.Add(Frezzyposition);
        Controls.Add(InfiniteVitalCells);
        Controls.Add(InfiniteStamina);
        Controls.Add(Infiteergos);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
        private CheckBox Infiteergos;
        private CheckBox InfiniteStamina;
        private CheckBox InfiniteVitalCells;
        private CheckBox Frezzyposition;
    private Label label2;
    private CheckBox Infinitehealth;
}
