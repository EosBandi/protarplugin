using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using MissionPlanner.Controls.PreFlight;
using MissionPlanner.Controls;
using System.Linq;
using MissionPlanner;
using MissionPlanner.GCSViews;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static MAVLink;


namespace ProtarPlugin
{

    #region ControlClass

    partial class protarMotor : MyUserControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public protarMotor()
        {
            InitializeComponent();
        }


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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(protarMotor));
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gRPM = new AGaugeApp.AGauge();
            this.pbFuel = new BSE.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lTemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lThr = new System.Windows.Forms.Label();
            this.lSw = new System.Windows.Forms.Label();
            this.lStat = new System.Windows.Forms.Label();
            this.lError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            //
            // splitContainer3
            //
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            //
            // splitContainer3.Panel1
            //
            this.splitContainer3.Panel1.Controls.Add(this.gRPM);
            //
            // splitContainer3.Panel2
            //
            this.splitContainer3.Panel2.Controls.Add(this.lError);
            this.splitContainer3.Panel2.Controls.Add(this.lStat);
            this.splitContainer3.Panel2.Controls.Add(this.lSw);
            this.splitContainer3.Panel2.Controls.Add(this.lThr);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Panel2.Controls.Add(this.lTemp);
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Panel2.Controls.Add(this.pbFuel);
            this.splitContainer3.Size = new System.Drawing.Size(357, 150);
            this.splitContainer3.SplitterDistance = 148;
            this.splitContainer3.TabIndex = 0;
            //
            // gRPM
            //
            this.gRPM.BackColor = System.Drawing.Color.Transparent;
            //this.gRPM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gRPM.BackgroundImage")));
            this.gRPM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gRPM.BaseArcColor = System.Drawing.Color.Transparent;
            this.gRPM.BaseArcRadius = 70;
            this.gRPM.BaseArcStart = 135;
            this.gRPM.BaseArcSweep = 270;
            this.gRPM.BaseArcWidth = 2;
            this.gRPM.Cap_Idx = ((byte)(0));
            this.gRPM.CapColor = System.Drawing.Color.White;
            this.gRPM.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.gRPM.CapPosition = new System.Drawing.Point(45, 85);
            this.gRPM.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(45, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.gRPM.CapsText = new string[] {
        "RPM x1000",
        "",
        "",
        "",
        ""};
            this.gRPM.CapText = "RPM x1000";
            this.gRPM.Center = new System.Drawing.Point(75, 75);
            this.gRPM.Location = new System.Drawing.Point(0, 0);
            this.gRPM.Margin = new System.Windows.Forms.Padding(0);
            this.gRPM.MaxValue = 120F;
            this.gRPM.MinValue = 0F;
            this.gRPM.Name = "gRPM";
            this.gRPM.Need_Idx = ((byte)(3));
            this.gRPM.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.gRPM.NeedleColor2 = System.Drawing.Color.Brown;
            this.gRPM.NeedleEnabled = false;
            this.gRPM.NeedleRadius = 70;
            this.gRPM.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.gRPM.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.gRPM.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.gRPM.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.gRPM.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.gRPM.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.gRPM.NeedleType = 0;
            this.gRPM.NeedleWidth = 2;
            this.gRPM.Range_Idx = ((byte)(2));
            this.gRPM.RangeColor = System.Drawing.Color.Orange;
            this.gRPM.RangeEnabled = false;
            this.gRPM.RangeEndValue = 50F;
            this.gRPM.RangeInnerRadius = 1;
            this.gRPM.RangeOuterRadius = 70;
            this.gRPM.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.gRPM.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.gRPM.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.gRPM.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.gRPM.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.gRPM.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.gRPM.RangeStartValue = 35F;
            this.gRPM.ScaleLinesInterColor = System.Drawing.Color.White;
            this.gRPM.ScaleLinesInterInnerRadius = 52;
            this.gRPM.ScaleLinesInterOuterRadius = 60;
            this.gRPM.ScaleLinesInterWidth = 1;
            this.gRPM.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.gRPM.ScaleLinesMajorInnerRadius = 50;
            this.gRPM.ScaleLinesMajorOuterRadius = 60;
            this.gRPM.ScaleLinesMajorStepValue = 10F;
            this.gRPM.ScaleLinesMajorWidth = 2;
            this.gRPM.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.gRPM.ScaleLinesMinorInnerRadius = 55;
            this.gRPM.ScaleLinesMinorNumOf = 9;
            this.gRPM.ScaleLinesMinorOuterRadius = 60;
            this.gRPM.ScaleLinesMinorWidth = 1;
            this.gRPM.ScaleNumbersColor = System.Drawing.Color.White;
            this.gRPM.ScaleNumbersFormat = null;
            this.gRPM.ScaleNumbersRadius = 42;
            this.gRPM.ScaleNumbersRotation = 0;
            this.gRPM.ScaleNumbersStartScaleLine = 1;
            this.gRPM.ScaleNumbersStepScaleLines = 1;
            this.gRPM.Size = new System.Drawing.Size(150, 150);
            this.gRPM.TabIndex = 80;
            this.gRPM.Value = 0F;
            this.gRPM.Value0 = 0F;
            this.gRPM.Value1 = 0F;
            this.gRPM.Value2 = 0F;
            this.gRPM.Value3 = 0F;
            //
            // pbFuel
            //
            this.pbFuel.BackgroundColor = System.Drawing.Color.Silver;
            this.pbFuel.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbFuel.Location = new System.Drawing.Point(1, 3);
            this.pbFuel.Maximum = 12000;
            this.pbFuel.Minimum = 3000;
            this.pbFuel.Name = "pbFuel";
            this.pbFuel.Size = new System.Drawing.Size(199, 23);
            this.pbFuel.TabIndex = 0;
            this.pbFuel.Text = "FUEL";
            this.pbFuel.Value = 3000;
            this.pbFuel.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temp:";
            //
            // lTemp
            //
            this.lTemp.AutoSize = true;
            this.lTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTemp.Location = new System.Drawing.Point(55, 38);
            this.lTemp.Name = "lTemp";
            this.lTemp.Size = new System.Drawing.Size(34, 18);
            this.lTemp.TabIndex = 2;
            this.lTemp.Text = "0 C";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Throttle:";
            //
            // lThr
            //
            this.lThr.AutoSize = true;
            this.lThr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lThr.Location = new System.Drawing.Point(69, 60);
            this.lThr.Name = "lThr";
            this.lThr.Size = new System.Drawing.Size(34, 18);
            this.lThr.TabIndex = 4;
            this.lThr.Text = "0 C";
            //
            // lSw
            //
            this.lSw.AutoSize = true;
            this.lSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSw.Location = new System.Drawing.Point(3, 88);
            this.lSw.Name = "lSw";
            this.lSw.Size = new System.Drawing.Size(58, 18);
            this.lSw.TabIndex = 5;
            this.lSw.Text = "Switch";
            //
            // lStat
            //
            this.lStat.AutoSize = true;
            this.lStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStat.Location = new System.Drawing.Point(3, 106);
            this.lStat.Name = "lStat";
            this.lStat.Size = new System.Drawing.Size(56, 18);
            this.lStat.TabIndex = 6;
            this.lStat.Text = "Status";
            //
            // lError
            //
            this.lError.AutoSize = true;
            this.lError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lError.Location = new System.Drawing.Point(5, 124);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(84, 18);
            this.lError.TabIndex = 7;
            this.lError.Text = "Errorcode";
            //
            // protarMotor
            //
            this.Controls.Add(this.splitContainer3);
            this.Name = "protarMotor";
            this.Size = new System.Drawing.Size(357, 150);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.SplitContainer splitContainer3;


        #endregion

        private AGaugeApp.AGauge gRPM;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.Label lStat;
        private System.Windows.Forms.Label lSw;
        private System.Windows.Forms.Label lThr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lTemp;
        private System.Windows.Forms.Label label1;
        private BSE.Windows.Forms.ProgressBar pbFuel;
    }

    #endregion

    public class ProtarPlugin : MissionPlanner.Plugin.Plugin
    {

        private protarMotor mot;

        public override string Name
        {
            get { return "ProtarPlugin"; }
        }

        public override string Version
        {
            get { return "0.1"; }
        }

        public override string Author
        {
            get { return "Schaffer Andras"; }
        }

        //[DebuggerHidden]
        public override bool Init()
		//Init called when the plugin dll is loaded
        {
            loopratehz = 1;  //Loop runs every second (The value is in Hertz, so 2 means every 500ms, 0.1f means every 10 second...)

            return true;	 // If it is false then plugin will not load
        }

        public override bool Loaded()
		//Loaded called after the plugin dll successfully loaded
        {
            mot = new protarMotor();
            // force it to the top of the container to push down the tabcontrol
            mot.Dock = DockStyle.Top;
            mot.Visible = true;
            mot.TabIndex = 0;


            return true;     //If it is false plugin will not start (loop will not called)
        }

        public override bool Loop()
		//Loop is called in regular intervalls (set by loopratehz)
        {
            MainV2.instance.BeginInvoke((MethodInvoker)delegate
            {
                if (!FlightData.instance.tabControlactions.Parent.Controls.Contains(mot))
                    FlightData.instance.tabControlactions.Parent.Controls.Add(mot);
            });

            return true;	//Return value is not used
        }

        public override bool Exit()
		//Exit called when plugin is terminated (usually when Mission Planner is exiting)
        {
            return true;	//Return value is not used
        }
    }
}