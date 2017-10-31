namespace WCF.Host.V3
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceMajuscule = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller1
            // 
            this.serviceProcessInstaller1.Password = null;
            this.serviceProcessInstaller1.Username = null;
            this.serviceProcessInstaller1.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.serviceProcessInstaller1_AfterInstall);
            // 
            // serviceMajuscule
            // 
            this.serviceMajuscule.Description = "Service Majuscule Octobre 2017";
            this.serviceMajuscule.DisplayName = "Service Majuscule";
            this.serviceMajuscule.ServiceName = "ServiceMajuscule";
            this.serviceMajuscule.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            this.serviceMajuscule.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.serviceInstaller1_AfterInstall);
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller1,
            this.serviceMajuscule});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller1;
        private System.ServiceProcess.ServiceInstaller serviceMajuscule;
    }
}