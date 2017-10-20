private void ReadArray(string[] strArray, string fileName)
        {
            try
            {
                int index = 0;      // Index variable.

                // Opening file.
                StreamReader inputFile = File.OpenText(fileName);

                // Reading values into the array.
                while (!inputFile.EndOfStream && index < strArray.Length)
                {
                    strArray[index] = inputFile.ReadLine();
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