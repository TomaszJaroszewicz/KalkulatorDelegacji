using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorDelegacji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CostOfBusinessTrip costOfBusinessTrip = new CostOfBusinessTrip(); //class 
        double tripCost;                //cost of business trip 
        string currency;                //currency of cost
        
        DateTime beginBusinessTrip = new DateTime();
        DateTime endBusinessTrip = new DateTime();

        private void Form1_Load(object sender, EventArgs e)
        {
            tripCost = costOfBusinessTrip.inPoland;
            currency = "zł";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //przepisywanie do zmienych start i koniec wartosci wprowadzonych przez uzytkownika
            //begin
            DateTime dateTimeBuffor = new DateTime(); 
            try //read hours and minutes from textBox and set to variable  inserted by the user
            {
                dateTimeBuffor = Convert.ToDateTime(textBoxStart.Text);
            }
            catch
            {
                MessageBox.Show("Niewłaściwy format wprowadzanego czasu" +Environment.NewLine+ "Wprowadz w formacie:  hh:mm");
            }
            beginBusinessTrip = monthCalendarStart.SelectionStart;//set to variable beginBusinessTrip from the calender
            //bind these two variables into one variable DateTime 
            beginBusinessTrip = beginBusinessTrip.AddHours((double)dateTimeBuffor.Hour);
            beginBusinessTrip = beginBusinessTrip.AddMinutes((double)dateTimeBuffor.Minute);
            //end
            //begin
            try //read hours and minutes from textBox and set to variable  
            {
                dateTimeBuffor = Convert.ToDateTime(textBoxEnd.Text);
            }
            catch
            {
                MessageBox.Show("Niewłaściwy format wprowadzanego czasu" + Environment.NewLine + "Wprowadz w formacie:  hh:mm");
            }
            endBusinessTrip = monthCalendarEnd.SelectionStart;//set to variable beginBusinessTrip from the calender
            
            //bind these two variables in one variable DateTime type 
            endBusinessTrip = endBusinessTrip.AddHours((double)dateTimeBuffor.Hour);
            endBusinessTrip = endBusinessTrip.AddMinutes((double)dateTimeBuffor.Minute);
            //end

            TimeSpan timeSpan = new TimeSpan();
            timeSpan = endBusinessTrip - beginBusinessTrip;//calculating total time span of business trip
            if (timeSpan.Hours < 0)
            {
                MessageBox.Show("Niewłaściwie wprowadzone daty." + Environment.NewLine + "Rozpoczęcie delegacji późniejsze niż zakończenie!");
            }
            else
            {
                days.Text = timeSpan.Days.ToString() + " dni";//appear days in business trip
                hours.Text = timeSpan.Hours.ToString() + " godzin";//appear hours in busines trip
                double businessTrip = CalculateWithoutFeed(timeSpan, tripCost) - CostOfFeed(timeSpan, tripCost);//calculate total cost
                amount.Text = (businessTrip.ToString() + " " + currency); //display total cost
            }
        }



        //my own methods:
        //this method calculate amount money if business trip was without feeding 
        private double CalculateWithoutFeed(TimeSpan timeSpan, double tripCost)
        {
            double suma = 0;
            if(timeSpan.Days>=1)                    //if delegation last more than one day
            {
                suma = timeSpan.Days * tripCost;
                if (timeSpan.Hours <= 8)            //if delegation last more than one day and no more than 8 hours
                {
                    suma += tripCost * 0.5;
                }
                else                               //if delegation last more than one day and more than 8 hours
                {
                    suma += tripCost;
                }   
            }
            else
            {
                if (timeSpan.Hours < 8)
                    suma = 0;
                if (timeSpan.Hours >= 8 && timeSpan.Hours < 12)
                    suma = tripCost * 0.5;
                if (timeSpan.Hours >= 12)
                    suma = tripCost;
            }
            return suma;
        }

        //method- chack what meal was provided and calculating cost of these meals
        private double CostOfFeed(TimeSpan timeSpan, double tripCost)
        {
            double cost = 0;

            if (checkBoxSniadanie.Checked == true)
                cost += timeSpan.Days * costOfBusinessTrip.Breakfast * tripCost;
            if (checkBoxObiad.Checked == true)
                cost += timeSpan.Days * costOfBusinessTrip.Dinner * tripCost;
            if (checkBoxKolacja.Checked == true)
                cost += timeSpan.Days * costOfBusinessTrip.Supper * tripCost;

            return cost;
        }

        //choose MENU->EXIT
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //choose MENU->Country->Poland
        private void polandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tripCost = costOfBusinessTrip.inPoland;
            currency = "zł";
        }

        //choose MENU->Country->Italy
        private void italyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tripCost = costOfBusinessTrip.inItaly;
            currency = "euro";
        }

        //choose MENU->Country->Lithuana
        private void lithuanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tripCost = costOfBusinessTrip.inLithuena;
            currency = "euro";
        }
        

       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program oblicza koszty delegacji na podstawie ilości dni. " +
                "Jeśli w delegacji bliśmy np.2 dni to program przyjmuje 2 śniadania itd.","O programie",MessageBoxButtons.OKCancel);
        }
    }
    
}
