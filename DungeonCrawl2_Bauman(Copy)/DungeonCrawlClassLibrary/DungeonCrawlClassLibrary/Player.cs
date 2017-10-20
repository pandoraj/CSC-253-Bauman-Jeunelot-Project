using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DungeonCrawlClassLibrary
{
    public enum Race
    {
        Human, Merfolk, Selkie
    }
    public enum Class
    {
        Fighter, Wizard, Mercenary, Alchemist, Tamer, Hunter, Fisher
    }
    public class Player
    {
        //fields
        private string _name;
        private string _password;
        private Race _playerRace;
        private Class _playerClass;
        //public int healthPoints;
        //public int Experience;
        //public int level;

        //constructor
        public Player()
        {
            _name = "";
            _password = "";            
        }
        //Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //Password property
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        //playerClass Property
        public Class playerClass
        {
            get { return _playerClass; }
            set { _playerClass = value; }
        }
        //playerRace Property
        public Race playerRace
        {
            get { return _playerRace; }
            set { _playerRace = value; }
        }

        public bool SavePlayerFile()
        {
            try
            {
                StreamWriter outputFile;

                // Create a file with the player name and add each field to it.
                outputFile = File.CreateText(_name+".txt");
                outputFile.WriteLine(_password);
                outputFile.WriteLine(_name);
                outputFile.WriteLine(_playerClass.ToString());
                outputFile.WriteLine(_playerRace.ToString());
                // Close the file.
                outputFile.Close();
                // Return true if successfully saved

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public string CheckPlayerFile(string playerName, string password)
        {
            // If no file with the player name is found, this method returns the string no instead of the file name.
            string fileName = "no";
            try
            {
                StreamReader inputFile;

                // Open the file under the name the user entered.
                inputFile = File.OpenText(playerName + ".txt");

                // Check the password.
                string filePassword = inputFile.ReadLine();
                string tempName = inputFile.ReadLine();
                if (filePassword == password)
                {
                    //fileName = playerName + ".txt";
                    if (playerName == tempName)
                    {
                        fileName = playerName + ".txt";
                    }
                }
                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Error message for incorrect player name.
                
            }

            return fileName;
        }
        public bool CheckPassword()
        {
            // True if password meets requirements.
            bool goodPassword = false;
            int uppercase = 0;
            int lowercase = 0;
            int specialCharacter = 0;

            // Check that password has uppercase, lowercase, and special character.
            foreach (char ch in _password)
            {
                if (char.IsUpper(ch))
                {
                    uppercase++;
                }

                if (char.IsLower(ch))
                {
                    lowercase++;
                }

                if (!char.IsLetterOrDigit(ch) && !char.IsWhiteSpace(ch))
                {
                    specialCharacter++;
                }
            }

            // Set the test variable to true if the password meets the requirements and return it.
            if (uppercase >= 1 && lowercase >= 1 && specialCharacter >= 1)
            {
                goodPassword = true;
            }

            return goodPassword;
        }
    }
}
