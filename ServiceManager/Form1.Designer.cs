namespace ServiceManager
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
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.Query = new System.Windows.Forms.Button();
        this.Restart = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(211, 36);
        this.textBox1.Multiline = true;
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(197, 108);
        this.textBox1.TabIndex = 0;
        this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
        // 
        // Query
        // 
        this.Query.Location = new System.Drawing.Point(49, 36);
        this.Query.Name = "Query";
        this.Query.Size = new System.Drawing.Size(75, 23);
        this.Query.TabIndex = 1;
        this.Query.Text = "Query";
        this.Query.UseVisualStyleBackColor = true;
        this.Query.Click += new System.EventHandler(this.Query_Click);
        // 
        // Restart
        // 
        this.Restart.Location = new System.Drawing.Point(49, 121);
        this.Restart.Name = "Restart";
        this.Restart.Size = new System.Drawing.Size(75, 23);
        this.Restart.TabIndex = 2;
        this.Restart.Text = "Reset";
        this.Restart.UseVisualStyleBackColor = true;
        this.Restart.Click += new System.EventHandler(this.Restart_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoScroll = true;
        this.ClientSize = new System.Drawing.Size(442, 385);
        this.Controls.Add(this.Restart);
        this.Controls.Add(this.Query);
        this.Controls.Add(this.textBox1);
        this.Name = "Form1";
        this.Text = "Service Manager";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button Query;
    private System.Windows.Forms.Button Restart;
}
}

