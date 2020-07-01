﻿using Autofac;
using Autofac.Builder;
using Autofac.Core;
using System;
using System.Reflection;
using System.Windows.Forms;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Concrete;
using WSG.CafeOtomation.Business.DependencyResolvers.Autofac;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework;
using WSG.CafeOtomation.WinForm.Controller;

namespace WSG.CafeOtomation.WinForm
{
    static class Program
    {
        public static IModule Container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Container = new AutofacBusinessModule();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var user = new User()
            {
                ID = 1,
                LastName = "Ozkara",
                FirstName = "Nedim",
                Status = true
                
            };
            Application.Run(new Controller.Menu(user));
            //Application.Run(new Login());
        }
    }
}