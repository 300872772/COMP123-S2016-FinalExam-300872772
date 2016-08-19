using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *App Name: Character Builder 
 *Author: Md Mamunur Rahman 
 * Student ID: 300872772  
 * 
 * Date last modified: August 09, 2016 
 * Description: This application demonstrates a Solution for character building 
 *  
 * Version: 0.0.1 - added all properties to splash form
 */
namespace COMP123_S2016_FinalExam
{
    public partial class SplashForm : Form
    {
    /**  
    * <summary>  
    * This is the partial SplashForm class for starting splash.  
    * </summary>  
    *   
    * @class SplashForm  
    */
        public SplashForm()
        {
            InitializeComponent();
        }

        //PRIVATE METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
       * <summary>
       * This is the privte method for _Tick event of SplashTimer
       * </summary>
       * 
       * @method SplashTimer_Tick
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashProgressBar.PerformStep();
            if (SplashProgressBar.Value >= SplashProgressBar.Maximum)
            {
                SplashTimer.Enabled = false;

                this.Hide();
                GenerateNameForm generateNameForm = new GenerateNameForm();
                generateNameForm.Show();


            }

        }
    }
}
