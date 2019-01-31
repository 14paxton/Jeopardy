﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy
{
    class ValidateData
    {
        public static bool AreFourChoices(List<Choice> Value)
        {
            try
            {
                if (Value.Count != 4)
                {
                    throw new CustomExceptions.WrongCountException();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return false;
            }

        }

        //MARK: Validate Game properties
        public static bool ValidateGameName(string gameName)
        {
            if (gameName.Length > 0 && gameName.Length < 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateGameTimeLimit(TimeSpan defaultTimeLimit)
        {
            TimeSpan[] validTimeLimits = new TimeSpan[] { new TimeSpan(0, 0, 30), new TimeSpan(0, 1, 0), new TimeSpan(0, 1, 30), new TimeSpan(0, 2, 0), new TimeSpan(0, 3, 0) };
            if (validTimeLimits.Contains(defaultTimeLimit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateNumCategories(int numCategories)
        {
            if(numCategories >= 3 && numCategories <= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateNumQuestionsPerCategory(int numQuestions)
        {
            if(numQuestions >= 3 && numQuestions <= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //MARK: Validate Category properties
        public static bool ValidateCategoryIndex(int index)
        {
            if(index >= 0 && index <= 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateCategoryTitle(string title)
        {
            if (title.Length > 0 && title.Length < 255)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateCategorySubtitle(string subtitle)
        {
            if (subtitle.Length > 0 && subtitle.Length < 255)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //MARK: Validate Question properties
        public static bool ValidateQuestionType(string type)
        {
            string[] validTypes = new string[] { "fb", "mc", "tf" }; //fill in the blank, multiple choice, true/false
            if (validTypes.Contains(type))
            {
                return true;
            }
            return false; 
        }

        public static bool ValidateQuestionText(string questionText)
        {
            if (questionText.Length > 0 && questionText.Length < 1000)
            {
                return true;
            }
            return false; 
        }

        public static bool ValidateQuestionAnswer(string answer)
        {
            if (answer.Length > 0 && answer.Length < 255)
            {
                return true;
            }
            return false; 
        }

        public static bool ValidateQuestionWeight(int weight)
        {
            List<int> validWeights = new List<int> ( new[] { 100, 200, 300, 400, 500, 600, 700, 800 } ); 
            if (validWeights.Contains(weight))
            {
                return true;
            }
            return false; 
        }

        //MARK: Validate Choice properties
        public static bool ValidateChoiceIndex(int index)
        {
            return true;
        }

        public static bool ValidateChoiceText(string choiceText)
        {
            if (choiceText.Length > 0 && choiceText.Length < 255)
            {
                return true;
            }
            return false; 
        }

        //MARK: Validate Team properties
        public static bool ValidateTeamName(string teamName)
        {
            if (teamName.Length > 0 && teamName.Length < 255)
            {
                return true;
            }
            return false; 
        }

        public static bool ValidateTeamScore(int teamScore)
        {
            if (teamScore > -100000 && teamScore < 1000000) //TODO
            {
                return true;
            }
            return false; 
        }

    }
}
