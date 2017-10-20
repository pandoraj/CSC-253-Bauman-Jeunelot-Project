
/**
* 09/01/2017
* CSC 253
* Marc Bauman
* Pandora Jeunelot
* This program allows the player to move north and south through a dungeon and collect items and treasures. 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DungeonCrawlClassLibrary;

namespace DungeonCrawl1
{
    #region Enum and Struct
    //replace ALL structs and enums with classes   

    struct Room
    {
        public string name;
        public string description;
    }

    struct Weapon
    {
        public string name;
        public string description;
        public int damage;
        public int cost;
        public int weight;
        public string material;
        public string rarity;
    }

    struct Potion
    {
        public string name;
        public string description;
        public string target;
        public string effect;
        public int cost;
        public string rarity;
        public int duration;
    }

    struct Treasure
    {
        public string name;
        public string description;
        public int cost;
        public string rarity;
    }

    struct Item
    {
        public string name;
        public string description;
        public int cost;
        public string rarity;
        public string effect;
        public bool consumable;
    }

    struct Mob
    {
        public string name;
        public string description;
        public int damage;
        public int health;
        public int armor;
        public int speed;
        public string armorClass;
    }

    #endregion

    public partial class coralCastleForm : Form
    {
        public coralCastleForm()
        {
            InitializeComponent();
        }
        // Constants for array sizes.
        const int ROOMSIZE = 5;
        const int WEAPONSSIZE = 4;
        const int POTIONSSIZE = 2;
        const int TREASURESSIZE = 3;

        // Variable for room array position.
        int currentRoom = 0;

        // Arrays to hold lines from the text files.
        Room[] roomsArray = new Room[ROOMSIZE];
        Weapon[] weaponsArray = new Weapon[WEAPONSSIZE];
        Potion[] potionsArray = new Potion[POTIONSSIZE];
        Treasure[] treasuresArray = new Treasure[TREASURESSIZE];

        // Lists for items file and mobs file.
        List<Item> itemsList = new List<Item>();
        List<Mob> mobsList = new List<Mob>();
        #region Read Methods
        // Methods to read lines from a text file into each array.
        private void ReadRoomArray(Room[] roomArray, string fileName)
        {
            try
            {
                int index = 0;      // Index variable.

                // Opening file.
                StreamReader inputFile = File.OpenText(fileName);

                // Reading values into the array.
                while (!inputFile.EndOfStream && index < roomArray.Length)
                {
                    roomArray[index].name = inputFile.ReadLine();
                    roomArray[index].description = inputFile.ReadLine();
                    index++;
                }
                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadWeaponsArray(Weapon[] weaponArray, string fileName)
        {
            try
            {
                int index = 0;      // Index variable.

                // Opening file.
                StreamReader inputFile = File.OpenText(fileName);

                // Reading values into the array.
                while (!inputFile.EndOfStream && index < weaponArray.Length)
                {
                    weaponArray[index].name = inputFile.ReadLine();
                    weaponArray[index].description = inputFile.ReadLine();
                    weaponArray[index].damage = int.Parse(inputFile.ReadLine());
                    weaponArray[index].cost = int.Parse(inputFile.ReadLine());
                    weaponArray[index].weight = int.Parse(inputFile.ReadLine());
                    weaponArray[index].material = inputFile.ReadLine();
                    weaponArray[index].rarity = inputFile.ReadLine();
                    index++;
                }
                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadPotionsArray(Potion[] potionArray, string fileName)
        {
            try
            {
                int index = 0;      // Index variable.

                // Opening file.
                StreamReader inputFile = File.OpenText(fileName);

                // Reading values into the array.
                while (!inputFile.EndOfStream && index < potionArray.Length)
                {
                    potionArray[index].name = inputFile.ReadLine();
                    potionArray[index].description = inputFile.ReadLine();
                    potionArray[index].target = inputFile.ReadLine();
                    potionArray[index].effect = inputFile.ReadLine();
                    potionArray[index].cost = int.Parse(inputFile.ReadLine());
                    potionArray[index].rarity = inputFile.ReadLine();
                    potionArray[index].duration = int.Parse(inputFile.ReadLine());
                    index++;
                }
                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadTreasuresArray(Treasure[] treasureArray, string fileName)
        {
            try
            {
                int index = 0;      // Index variable.

                // Opening file.
                StreamReader inputFile = File.OpenText(fileName);

                // Reading values into the array.
                while (!inputFile.EndOfStream && index < treasureArray.Length)
                {
                    treasureArray[index].name = inputFile.ReadLine();
                    treasureArray[index].description = inputFile.ReadLine();
                    treasureArray[index].cost = int.Parse(inputFile.ReadLine());
                    treasureArray[index].rarity = inputFile.ReadLine();
                    index++;
                }
                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Error message.
                MessageBox.Show(ex.Message);
            }
        }



        // Method to read lines from a text file into a list.
        private void ReadItemList(List<Item> itemList, string fileName)
        {
            try
            {
                Item tempItem = new Item();
                // Open the text file.
                StreamReader inputFile = File.OpenText(fileName);
                // Add lines from text file into list.
                while (!inputFile.EndOfStream)
                {
                    tempItem.name = inputFile.ReadLine();
                    tempItem.description = inputFile.ReadLine();
                    tempItem.cost = int.Parse(inputFile.ReadLine());
                    tempItem.rarity = inputFile.ReadLine();
                    tempItem.effect = inputFile.ReadLine();
                    tempItem.consumable = bool.Parse(inputFile.ReadLine());

                    itemList.Add(tempItem);
                }
                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadMobList(List<Mob> mobList, string fileName)
        {
            try
            {
                Mob tempMob = new Mob();
                // Open the text file.
                StreamReader inputFile = File.OpenText(fileName);
                // Add lines from text file into list.
                while (!inputFile.EndOfStream)
                {
                    tempMob.name = inputFile.ReadLine();
                    tempMob.description = inputFile.ReadLine();
                    tempMob.damage = int.Parse(inputFile.ReadLine());
                    tempMob.health = int.Parse(inputFile.ReadLine());
                    tempMob.armor = int.Parse(inputFile.ReadLine());
                    tempMob.speed = int.Parse(inputFile.ReadLine());
                    tempMob.armorClass = inputFile.ReadLine();

                    mobList.Add(tempMob);
                }
                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Error message.
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Display Methods
        // Display items from each array in the list box.
        private void DisplayRoomArray(Room[] roomArray)
        {
            // Clear the list box.
            displayListBox.Items.Clear();
            // Add each array element.
            foreach (Room room in roomArray)
            {
                displayListBox.Items.Add(room.name);
            }
        }

        private void DisplayWeaponsArray(Weapon[] weaponArray)
        {
            // Clear the list box.
            displayListBox.Items.Clear();
            // Add each array element.
            foreach (Weapon weapon in weaponArray)
            {
                displayListBox.Items.Add(weapon.name);
                displayListBox.Items.Add(weapon.description);
                displayListBox.Items.Add(weapon.damage);
                displayListBox.Items.Add(weapon.cost);
                displayListBox.Items.Add(weapon.weight);
                displayListBox.Items.Add(weapon.material);
                displayListBox.Items.Add(weapon.rarity);
            }
        }

        private void DisplayPotionsArray(Potion[] potionArray)
        {
            // Clear the list box.
            displayListBox.Items.Clear();
            // Add each array element.
            foreach (Potion potion in potionArray)
            {
                displayListBox.Items.Add(potion.name);
                displayListBox.Items.Add(potion.description);
                displayListBox.Items.Add(potion.target);
                displayListBox.Items.Add(potion.effect);
                displayListBox.Items.Add(potion.cost);
                displayListBox.Items.Add(potion.rarity);
                displayListBox.Items.Add(potion.duration);
            }
        }

        private void DisplayTreasureArray(Treasure[] treasureArray)
        {
            // Clear the list box.
            displayListBox.Items.Clear();
            // Add each array element.
            foreach (Treasure treasure in treasureArray)
            {
                displayListBox.Items.Add(treasure.name);
                displayListBox.Items.Add(treasure.description);
                displayListBox.Items.Add(treasure.cost);
                displayListBox.Items.Add(treasure.rarity);
            }
        }

        // Display items from a list into the list box.
        private void DisplayItemList(List<Item> itemsList)
        {
            // Clear list box and display items from list.
            displayListBox.Items.Clear();
            // Add each list element.
            foreach (Item item in itemsList)
            {
                displayListBox.Items.Add(item.name);
                displayListBox.Items.Add(item.description);
                displayListBox.Items.Add(item.cost);
                displayListBox.Items.Add(item.rarity);
                displayListBox.Items.Add(item.effect);
                displayListBox.Items.Add(item.consumable);
            }
        }

        private void DisplayMobList(List<Mob> mobList)
        {
            // Clear list box and display items from list.
            displayListBox.Items.Clear();
            // Add each list element.
            foreach (Mob mob in mobList)
            {
                displayListBox.Items.Add(mob.name);
                displayListBox.Items.Add(mob.description);
                displayListBox.Items.Add(mob.damage);
                displayListBox.Items.Add(mob.health);
                displayListBox.Items.Add(mob.armor);
                displayListBox.Items.Add(mob.speed);
                displayListBox.Items.Add(mob.armorClass);
            }
        }

        // Checks the current room number in the array and displays the relevant text.
        private void DisplayRoom(int currentRoom)
        {
            roomLabel.Text = roomsArray[currentRoom].description;

        }


        #endregion

        #region Other Methods

        // Method to swap characters in indexes.
        private void Swap(ref Weapon a, ref Weapon b)
        {
            Weapon temp = a;
            a = b;
            b = temp;
        }

        


        private void ShowGameControls()
        {
            // Set game labels to visible.
            directionLabel.Visible = true;
            displayLabel.Visible = true;
            roomLabel.Visible = true;

            // Set game listboxes to visible.
            displayListBox.Visible = true;

            // Set game buttons to visible.
            upButton.Visible = true;
            weaponsButton.Visible = true;
            potionsButton.Visible = true;
            roomsButton.Visible = true;
            mobsButton.Visible = true;
            itemsButton.Visible = true;
            treasuresButton.Visible = true;

            // Set labels for new player options invisible.
            nameInstructionLabel.Visible = false;
            passwordInstructionLabel.Visible = false;
            classInstructionLabel.Visible = false;
            raceInstructionLabel.Visible = false;
            passwordRequirementLabel.Visible = false;

            // Set textboxes for new player options to invisible.
            nameTextBox.Visible = false;
            passwordTextBox.Visible = false;

            // Set listboxes for new player options to invisible.
            classListBox.Visible = false;
            raceListBox.Visible = false;

            // Set buttons for new player options to invisible.
            submitButton.Visible = false;

            // Hide load character button.
            loadFileButton.Visible = false;

            // Hide player options radio buttons.
            newPlayerRadioButton.Visible = false;
            returningRadioButton.Visible = false;

        }

        // Method to sort array alphabetically.
        private void ArraySort(Weapon[] weaponsArray)
        {
            int minIndex;                         // Subscript of smallest character.
            string arrayString;                   // Temporary variable to hold current string from the array.
            char firstLetter, minCharacter;       // Variable for first letter of the current string and the character that comes first in the alphabet.

            // Loop through the array, comparing the first characters of the strings.
            for (int startscan = 0; startscan < weaponsArray.Length - 1; startscan++)
            {
                minIndex = startscan;
                arrayString = weaponsArray[startscan].name;
                minCharacter = arrayString[0];

                for (int index = startscan + 1; index < weaponsArray.Length; index++)
                {
                    arrayString = weaponsArray[index].name;
                    firstLetter = arrayString[0];
                    if (firstLetter < minCharacter)
                    {
                        minCharacter = firstLetter;
                        minIndex = index;
                    }
                }
                // Swap the two strings.
                Swap(ref weaponsArray[minIndex], ref weaponsArray[startscan]);
            }
        }

        #endregion

       

        private void coralCastleForm_Load(object sender, EventArgs e)
        {
            // Create items list and mob list.
            ReadItemList(itemsList, "Items.txt");
            ReadMobList(mobsList, "Mobs.txt");

            // Create rooms array.
            ReadRoomArray(roomsArray, "Rooms.txt");

            // Display text for first room.
            roomLabel.Text = roomsArray[0].description;

            // Add classes to list box.
            // For next iteration, want to put in a loop instead?
            classListBox.Items.Add(Class.Alchemist);
            classListBox.Items.Add(Class.Fighter);
            classListBox.Items.Add(Class.Wizard);
            classListBox.Items.Add(Class.Mercenary);
            classListBox.Items.Add(Class.Tamer);
            classListBox.Items.Add(Class.Hunter);
            classListBox.Items.Add(Class.Fisher);

            // Add races to list box.
            raceListBox.Items.Add(Race.Human);
            raceListBox.Items.Add(Race.Merfolk);
            raceListBox.Items.Add(Race.Selkie);
        }
       

        #region Buttons
        private void weaponsButton_Click(object sender, EventArgs e)
        {
            // Read the weapons array from the file, sort it alphabetically, and display it.
            ReadWeaponsArray(weaponsArray, "Weapons.txt");
            ArraySort(weaponsArray);
            DisplayWeaponsArray(weaponsArray);
        }

        private void roomsButton_Click(object sender, EventArgs e)
        {
            // Display the rooms array in the list box.
            DisplayRoomArray(roomsArray);
        }

        private void potionsButton_Click(object sender, EventArgs e)
        {
            // Read and display the potions array.
            ReadPotionsArray(potionsArray, "Potions.txt");
            DisplayPotionsArray(potionsArray);
        }

        private void treasuresButton_Click(object sender, EventArgs e)
        {
            // Read the treasures array from the file and display it.
            ReadTreasuresArray(treasuresArray, "Treasures.txt");
            DisplayTreasureArray(treasuresArray);
        }


        private void itemsButton_Click(object sender, EventArgs e)
        {
            // Display items in the listBox.  
            DisplayItemList(itemsList);
        }



        private void mobsButton_Click(object sender, EventArgs e)
        {
            // Display mobs in the list box.
            DisplayMobList(mobsList);
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            // Add 1 to the current room subscript as long as it isn't at the end of the array.
            if (currentRoom < roomsArray.Length - 1)
            {
                currentRoom++;
                DisplayRoom(currentRoom);

                // Show down arrow.
                downButton.Visible = true;
            }
            else
            {
                // Error message.
                MessageBox.Show("This is the last room!");
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            // Subtract 1 from the current room subscript as long as it isn't at the beginning of the array.
            if (currentRoom != 0)
            {
                currentRoom--;
                DisplayRoom(currentRoom);
            }
            else
            {
                // Error message.
                MessageBox.Show("This is the first room!");
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the new player information from the form controls.
                Player newPlayer = new Player();
                newPlayer.Name = nameTextBox.Text;
                newPlayer.Password = passwordTextBox.Text;

                // Check if a name has been entered.
                if (newPlayer.Name != "")
                {
                    // Check that a password has been entered.
                    if (newPlayer.Password != "")
                    {
                        // Check password.
                        if (newPlayer.CheckPassword() == true)
                        {
                            // Check if class is selected.
                            if (classListBox.SelectedIndex != -1)
                            {
                                // Get the class from the listbox.
                                string classString = classListBox.SelectedItem.ToString();
                                newPlayer.playerClass = (Class)Enum.Parse(typeof(Class), classString);

                                // Check if race is selected.
                                if (raceListBox.SelectedIndex != -1)
                                {
                                    // Get the race from the list box.
                                    string raceString = raceListBox.SelectedItem.ToString();
                                    newPlayer.playerRace = (Race)Enum.Parse(typeof(Race), raceString);

                                    // Add player data to a text file.
                                    newPlayer.SavePlayerFile();

                                    // Set game controls to visible.
                                    ShowGameControls();
                                }
                                else
                                {
                                    MessageBox.Show("Please a select a race.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please select a class.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a password!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            // Get the returning player's name and password from the textboxes.
            Player returnPlayer = new Player();
            string playerName = nameTextBox.Text;
            string password = passwordTextBox.Text;
            StreamReader inputFile;

            // Check the player's name and password.
            string fileName = returnPlayer.CheckPlayerFile(playerName, password);

            // As long as the CheckPlayerFile method returns a file name and not no, open the file.
            if (fileName != "no")
            {
                // Open the file with the player name.
                inputFile = File.OpenText(fileName);

                // Assign values from the file to the player structure
                returnPlayer.Password = inputFile.ReadLine();
                returnPlayer.Name = inputFile.ReadLine();
                returnPlayer.playerClass = returnPlayer.playerClass = (Class)Enum.Parse(typeof(Class), inputFile.ReadLine());
                returnPlayer.playerRace = (Race)Enum.Parse(typeof(Race), inputFile.ReadLine());

                // Close the file.
                inputFile.Close();

                // Only set game controls to visible if a file is confirmed.
                ShowGameControls();
            }
            else
            {
                //Error message if unable to load a file
                MessageBox.Show("No file was found with that information");
            }
        }

        #endregion

        #region Radio Buttons

        private void newPlayerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set labels for new player options visible.
            nameInstructionLabel.Visible = true;
            passwordInstructionLabel.Visible = true;
            classInstructionLabel.Visible = true;
            raceInstructionLabel.Visible = true;
            passwordRequirementLabel.Visible = true;

            // Set textboxes for new player options to visible.
            nameTextBox.Visible = true;
            passwordTextBox.Visible = true;

            // Set listboxes for new player options to visible.
            classListBox.Visible = true;
            raceListBox.Visible = true;

            // Set buttons for new player options to visible.
            submitButton.Visible = true;

            // Hide load character button.
            loadFileButton.Visible = false;
        }

        private void returningRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Show load character button.
            loadFileButton.Visible = true;

            // Show labels for player options.
            nameInstructionLabel.Visible = true;
            passwordInstructionLabel.Visible = true;

            // Show textboxes for player options.
            nameTextBox.Visible = true;
            passwordTextBox.Visible = true;

            // Hide labels for new player options.
            classInstructionLabel.Visible = false;
            raceInstructionLabel.Visible = false;

            // Hide listboxes for new player options.
            classListBox.Visible = false;
            raceListBox.Visible = false;

            // Hide buttons for new player options.
            submitButton.Visible = false;
        }
    }
}

#endregion