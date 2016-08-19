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
    /**  
     * <summary>  
     * This is the partial GenerateNameForm class for random name generation.  
     * </summary>  
     *   
     * @class GenerateNameForm  
     */
    public partial class GenerateNameForm : Form
    {
        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the constructor that initialize values.
        * </summary>
        * 
        * @constructor GenerateNameForm 
        * 
        */
        public GenerateNameForm()
        {
            InitializeComponent();
        }
        /**
         * <summary>
         * This is the privte method for generate names
         * </summary>
         * 
         * @method _generateNames
         * @returns {void} 
         * 
         */
        private void _generateNames ()
            {
            Random randomFirstName = new Random();
            Random randomLastName = new Random();

            int indexFirstNameListBox = randomFirstName.Next(0, FirstNameListBox.Items.Count) + 1;
            int indexLastNameListBox = randomLastName.Next(0, LastNameListBox.Items.Count) + 1;
            
           FirstNameListBox.SetSelected(indexFirstNameListBox, true);
           LastNameListBox.SetSelected(indexLastNameListBox, true);
            FirstNameTextBox.Text = FirstNameListBox.Text;
            LastNameTextBox.Text = LastNameListBox.Text;

        }
                /**
       * <summary>
       * This is the privte method for _Click event of GenerateButton
       * </summary>
       * 
       * @method GenerateButton_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            _generateNames();
        }
                        /**
       * <summary>
       * This is the privte method for Load event of GenerateNameForm
       * </summary>
       * 
       * @method GenerateNameForm_Load
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       */
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            _generateNames();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
        }
    }
}
