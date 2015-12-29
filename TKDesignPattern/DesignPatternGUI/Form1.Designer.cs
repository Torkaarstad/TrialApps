namespace DesignPattern.GUI
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
            this.components = new System.ComponentModel.Container();
            this.btnAdapter = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnFactory = new System.Windows.Forms.Button();
            this.gbxPatterns = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVisitor1 = new System.Windows.Forms.Button();
            this.btnObserver = new System.Windows.Forms.Button();
            this.btnStrategy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAbstractFactory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProxy = new System.Windows.Forms.Button();
            this.btnComposite = new System.Windows.Forms.Button();
            this.btnComponent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInstanceCount = new System.Windows.Forms.TextBox();
            this.timerComponentCreation = new System.Windows.Forms.Timer(this.components);
            this.gbxPatterns.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdapter
            // 
            this.btnAdapter.Location = new System.Drawing.Point(6, 79);
            this.btnAdapter.Name = "btnAdapter";
            this.btnAdapter.Size = new System.Drawing.Size(75, 23);
            this.btnAdapter.TabIndex = 0;
            this.btnAdapter.Text = "Adapter";
            this.btnAdapter.UseVisualStyleBackColor = true;
            this.btnAdapter.Click += new System.EventHandler(this.btnAdapter_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 175);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(470, 181);
            this.txtResult.TabIndex = 1;
            // 
            // btnFactory
            // 
            this.btnFactory.Location = new System.Drawing.Point(17, 19);
            this.btnFactory.Name = "btnFactory";
            this.btnFactory.Size = new System.Drawing.Size(92, 23);
            this.btnFactory.TabIndex = 2;
            this.btnFactory.Text = "Factory";
            this.btnFactory.UseVisualStyleBackColor = true;
            this.btnFactory.Click += new System.EventHandler(this.btnFactory_Click);
            // 
            // gbxPatterns
            // 
            this.gbxPatterns.Controls.Add(this.groupBox3);
            this.gbxPatterns.Controls.Add(this.groupBox2);
            this.gbxPatterns.Controls.Add(this.groupBox1);
            this.gbxPatterns.Location = new System.Drawing.Point(9, 9);
            this.gbxPatterns.Name = "gbxPatterns";
            this.gbxPatterns.Size = new System.Drawing.Size(473, 160);
            this.gbxPatterns.TabIndex = 3;
            this.gbxPatterns.TabStop = false;
            this.gbxPatterns.Text = "Design Patterns";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVisitor1);
            this.groupBox3.Controls.Add(this.btnObserver);
            this.groupBox3.Controls.Add(this.btnStrategy);
            this.groupBox3.Location = new System.Drawing.Point(279, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 119);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Behavioral";
            // 
            // btnVisitor1
            // 
            this.btnVisitor1.Location = new System.Drawing.Point(6, 73);
            this.btnVisitor1.Name = "btnVisitor1";
            this.btnVisitor1.Size = new System.Drawing.Size(75, 23);
            this.btnVisitor1.TabIndex = 5;
            this.btnVisitor1.Text = "Visitor1";
            this.btnVisitor1.UseVisualStyleBackColor = true;
            this.btnVisitor1.Click += new System.EventHandler(this.btnVisitor1_Click);
            // 
            // btnObserver
            // 
            this.btnObserver.Location = new System.Drawing.Point(6, 44);
            this.btnObserver.Name = "btnObserver";
            this.btnObserver.Size = new System.Drawing.Size(75, 23);
            this.btnObserver.TabIndex = 4;
            this.btnObserver.Text = "Observer";
            this.btnObserver.UseVisualStyleBackColor = true;
            this.btnObserver.Click += new System.EventHandler(this.btnObserver_Click);
            // 
            // btnStrategy
            // 
            this.btnStrategy.Location = new System.Drawing.Point(10, 15);
            this.btnStrategy.Name = "btnStrategy";
            this.btnStrategy.Size = new System.Drawing.Size(75, 23);
            this.btnStrategy.TabIndex = 3;
            this.btnStrategy.Text = "Strategy";
            this.btnStrategy.UseVisualStyleBackColor = true;
            this.btnStrategy.Click += new System.EventHandler(this.btnStrategy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAbstractFactory);
            this.groupBox2.Controls.Add(this.btnFactory);
            this.groupBox2.Location = new System.Drawing.Point(136, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 119);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Creational";
            // 
            // btnAbstractFactory
            // 
            this.btnAbstractFactory.Location = new System.Drawing.Point(17, 48);
            this.btnAbstractFactory.Name = "btnAbstractFactory";
            this.btnAbstractFactory.Size = new System.Drawing.Size(92, 23);
            this.btnAbstractFactory.TabIndex = 9;
            this.btnAbstractFactory.Text = "Abstract Factory";
            this.btnAbstractFactory.UseVisualStyleBackColor = true;
            this.btnAbstractFactory.Click += new System.EventHandler(this.btnAbstractFactory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProxy);
            this.groupBox1.Controls.Add(this.btnComposite);
            this.groupBox1.Controls.Add(this.btnAdapter);
            this.groupBox1.Location = new System.Drawing.Point(6, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 120);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Structural";
            // 
            // btnProxy
            // 
            this.btnProxy.Location = new System.Drawing.Point(6, 21);
            this.btnProxy.Name = "btnProxy";
            this.btnProxy.Size = new System.Drawing.Size(75, 23);
            this.btnProxy.TabIndex = 5;
            this.btnProxy.Text = "Proxy";
            this.btnProxy.UseVisualStyleBackColor = true;
            this.btnProxy.Click += new System.EventHandler(this.btnProxy_Click);
            // 
            // btnComposite
            // 
            this.btnComposite.Location = new System.Drawing.Point(6, 50);
            this.btnComposite.Name = "btnComposite";
            this.btnComposite.Size = new System.Drawing.Size(75, 23);
            this.btnComposite.TabIndex = 4;
            this.btnComposite.Text = "Composite";
            this.btnComposite.UseVisualStyleBackColor = true;
            this.btnComposite.Click += new System.EventHandler(this.btnComposite_Click);
            // 
            // btnComponent
            // 
            this.btnComponent.Location = new System.Drawing.Point(536, 50);
            this.btnComponent.Name = "btnComponent";
            this.btnComponent.Size = new System.Drawing.Size(75, 23);
            this.btnComponent.TabIndex = 4;
            this.btnComponent.Text = "Component";
            this.btnComponent.UseVisualStyleBackColor = true;
            this.btnComponent.Click += new System.EventHandler(this.btnComponent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "InstanceCount:";
            // 
            // txtInstanceCount
            // 
            this.txtInstanceCount.Location = new System.Drawing.Point(615, 94);
            this.txtInstanceCount.Name = "txtInstanceCount";
            this.txtInstanceCount.Size = new System.Drawing.Size(100, 20);
            this.txtInstanceCount.TabIndex = 6;
            // 
            // timerComponentCreation
            // 
            this.timerComponentCreation.Tick += new System.EventHandler(this.timerComponentCreation_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 368);
            this.Controls.Add(this.txtInstanceCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComponent);
            this.Controls.Add(this.gbxPatterns);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxPatterns.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdapter;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnFactory;
        private System.Windows.Forms.GroupBox gbxPatterns;
        private System.Windows.Forms.Button btnStrategy;
        private System.Windows.Forms.Button btnComposite;
        private System.Windows.Forms.Button btnProxy;
        private System.Windows.Forms.Button btnAbstractFactory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnObserver;
        private System.Windows.Forms.Button btnVisitor1;
        private System.Windows.Forms.Button btnComponent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInstanceCount;
        private System.Windows.Forms.Timer timerComponentCreation;
    }
}

