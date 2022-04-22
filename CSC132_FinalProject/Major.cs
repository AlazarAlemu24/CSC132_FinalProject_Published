using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC132_FinalProject
{
    abstract class Major
    {
        /// <summary>
        //just made a change to push 
        /// </summary>
       // int total_credits;
        //int credits = 120;
        //infoirmation hiding using get and set 
        protected string Description_of_major;
        protected int Number_of_credits;
        protected int ClassesCompleted;

        //Changing the value of the hidden variables 
        public Major(string Desc_of_major, int Num_of_credits, int Classes_completed)
        {
            this.Description_of_major = Desc_of_major;
            this.Number_of_credits = Num_of_credits;
            this.ClassesCompleted = Classes_completed;
        }
        //creating a method that is going to be altered in the child class
        public abstract int Credit_calculator();
        public abstract string Info_for_Major();
    
    }
class Computer_science : Major
{
    public Computer_science(string Desc_of_major, int Num_of_credits, int Classes_completed) : base(Desc_of_major, Num_of_credits, Classes_completed)
    {

    }
        public override int Credit_calculator()
        {
            Number_of_credits = 120;
            int total_credits = Number_of_credits - ClassesCompleted;
            return total_credits;
        }
        public override string Info_for_Major()
        {
            Description_of_major = "description ";
            return Description_of_major;
        }

    }
    // this class is created by Abenezer Gizaw

    class Finance : Major
    {
        public Finance(string Desc_of_major, int Num_of_credits, int Classes_completed) : base(Desc_of_major, Num_of_credits, Classes_completed)
        {

        }
        // overriding credit calculator class 
        public override int Credit_calculator()
        {

            Number_of_credits = 120;
            int total_credits = Number_of_credits - ClassesCompleted;
            return total_credits;

        }
        public override string Info_for_Major()
        {
            Description_of_major = "A finance major is typically offered as a bachelor or Master of Arts degree or as a specialization within a business administration program.";
            return Description_of_major;
        }
    }
    class Accounting : Major
     {
        //David Groom wrote this class that inherits from the base class Major
            public Accounting(string Desc_of_major, int Num_of_credits, int Classes_completed) : base(Desc_of_major, Num_of_credits, Classes_completed)
        {
            //David Groom wrote this constructor to inherit variables from the base class Major
            
        }

        public override int Credit_calculator()
        {
            //David Groom wrote this method to calculate the total credits needed to graduate
            //David Groom. Accounting has 130 credits
               int total_credits = Number_of_Credits - Classescompleted;
            //David Groom. Classes already completed will be subtracted form the total number of credits needed to graduate
               return total_credits;

        }
        //David Groom created this method to return a unique string for this class to show on a form
        public override string Info_for_Major()
        {

            Description_of_Major = "The Accounting program at Cornerstone preparesyou to sit for the Uniform Certified Public Accountant (CPA) exam and begin the process to become licensed";
            //Getting this variable from the abstract class and giving a string variable
            return Description_of_Major;
            //David Groom made this to assign Description of Major to a string value and return said value, these values are coming from the abstract class which are unassigned
        }
        public string Description_of_Major
        {
            get
            {
                return Description_of_major;
            }
            set
            {
                value = Description_of_major;
            }
        }
        public int Number_of_Credits
        {
            get
            {
                return Number_of_credits;
            }
            set
            {
                value = Number_of_credits;
            }
        }
        public int Classescompleted
        {
            get
            {
                return ClassesCompleted;
            }
            set
            {
                value = ClassesCompleted;
            }
        }
        
    }   
   class Exercise_Science : Major
    {
      // Daniela wrote this class that inherits from the base class major
        public Exercise_Science(string Desc_of_major, int Num_of_credits, int Classes_completed) : base(Desc_of_major, Num_of_credits, Classes_completed)
      {
        // constructor to inherit variables from the base class Major
      }

        public override int Credit_calculator()
        {
            // Daniela Fernandez wrote this method to declare the total of credits you need for graduate
            Number_of_credits = 120;
            // Exercise science needs 120 credits in total
            int total_credits = Number_of_credits - ClassesCompleted;
            // classes already completed will be substracted from the total number of credits needed to graduate
            return total_credits;
        }
        // method to return a string for this class to show a form
        public override string Info_for_Major()
        {
            Description_of_major = "The exercise science program at Cornerstone is designed to inspire your intellect, deepen your character and prepare you to lead in your career with influence and wisdom. Concentrations are also available in cardiovascular rehabilitation, pre-occupational therapy and pre-physical therapy.";
            // this variable from the abstract class and giving a string variable
            return Description_of_major;
            // description of major to a string value and return said value, but these values are coming from the abstract class
        }
   }

    //Code by Redi8
    //What the code is doing: inheriting from the parent abstarct major and displaying results for Engineering  
    class Engineering : Major
    {
        public Engineering(String Desc_of_major, int Num_of_credits, int Classes_completed) : base(Desc_of_major, Num_of_credits, Classes_completed)
        {
        }
        //Calculating credits
        public override int Credit_calculator()
        {
            Number_of_credits = 150;
            int total_credits = Number_of_credits - ClassesCompleted;
            return total_credits;
        }
        //displaying information about the major
        public override string Info_for_Major()
        {
            Description_of_major = "The engineering major at Cornerstone University prepares you for fruitful work in a STEM career path. Engineering is a quickly growing industry in all aspects of business, from data science to design and innovation. Turn your calling into a life of meaning by integrating your faith and work.";
            return Description_of_major;
        }
    }

}
