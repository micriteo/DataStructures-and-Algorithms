using System.Diagnostics;
using System.Text;

namespace FinalAssignment
{
    public partial class MainForm : Form
    {
        private readonly CustomBinaryTree<InputType> _binaryTree;
        private readonly CustomLinkedList<InputType> _linkedList;
        private readonly CustomArrayList<InputType> _arrayList;
        private InputType[] sortedArray;

        private const string LabelExecutionTime = "Execution Time: ";

        public MainForm()
        {
            this._binaryTree = new();
            this._linkedList = new();
            this._arrayList = new();


            InitializeComponent();
            this.UpdateExecutionTimeLabel(0);
            this.InitializeToolTips();
        }

        private void InitializeToolTips()
        {
            toolTipInputTextBox.SetToolTip(textBoxInputText, "Enter values to be added, separated by a space!");
        }

        private void UpdateExecutionTimeLabel(double executionTime)
        {
            float seconds = (float)executionTime / 1000;
            // :F2 means that the number will be rounded to 2 decimal places (seconds:F2)
            labelExecutionTime.Text = $"{MainForm.LabelExecutionTime}{seconds:F2} seconds";
        }

        private void comboBoxCollectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Defining default status of buttons
            binarrySearchCheck.Enabled = false;
            binarrySearchCheck.Checked = false;
            // Disabling algorithms 
            quickSortCheck.Enabled = false;
            mergeSortCheck.Enabled = false;
            jumpSearchCheck.Enabled = false;
            // Removing any checked items 
            quickSortCheck.Checked = false;
            mergeSortCheck.Checked = false;
            jumpSearchCheck.Checked = false;
            // Display buttons for the collection
            buttonBTInOrder.Visible = false;
            buttonBTPreOrder.Visible = false;
            buttonBTPostOrder.Visible = false;
            buttonGenerate.Enabled = false;
            // Other default values
            textBoxSearchText.Visible = false;
            labelSearchItem.Visible = false;

            if (comboBoxCollectionType.SelectedItem.ToString().Equals("BinarySearchTree"))
            {
                binarrySearchCheck.Enabled = true;
                binarrySearchCheck.Checked = true;
                // Display buttons for the collection
                buttonBTInOrder.Visible = true;
                buttonBTPreOrder.Visible = true;
                buttonBTPostOrder.Visible = true;
            }
            else if (comboBoxCollectionType.SelectedItem.ToString().Equals("LinkedList"))
            {
                quickSortCheck.Enabled = true;
                mergeSortCheck.Enabled = true;
                // jumpSearchCheck.Enabled = true;
                buttonGenerate.Enabled = true;
            }
            else if (comboBoxCollectionType.SelectedItem.ToString().Equals("ArrayList"))
            {
                jumpSearchCheck.Enabled = true;
                quickSortCheck.Enabled = true;
                mergeSortCheck.Enabled = true;
                buttonGenerate.Enabled = true;
                textBoxSearchText.Visible = true;
                labelSearchItem.Visible = true;
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string input = textBoxInputText.Text;

            // Split the input string into an array of strings
            string[] inputArray = input.Split(" ");
            // Loop through the array of strings and add each one to the collection
            foreach (string value in inputArray)
            {
                this.InsertInAllCollectionTypes(value);
            }

            textBoxInputText.Text = "";
        }

        // Binary Search Tree search buttons ====================================================
        private void buttonBTInOrder_Click(object sender, EventArgs e)
        {
            StringBuilder output = new("In Order Traversal: \n\n");

            var executionTime = Stopwatch.StartNew();
            this._binaryTree.InorderTraversal(this._binaryTree.Root, ref output);
            executionTime.Stop();

            richTextBoxOutput.Text = output.ToString();
            this.UpdateExecutionTimeLabel(executionTime.ElapsedMilliseconds);
        }

        private void buttonBTPreOrder_Click(object sender, EventArgs e)
        {
            StringBuilder output = new("Pre Order Traversal: \n\n");

            var executionTime = Stopwatch.StartNew();
            this._binaryTree.PreorderTraversal(this._binaryTree.Root, ref output);
            executionTime.Stop();

            richTextBoxOutput.Text = output.ToString();
            this.UpdateExecutionTimeLabel(executionTime.ElapsedMilliseconds);
        }

        private void buttonBTPostOrder_Click(object sender, EventArgs e)
        {
            StringBuilder output = new("Post Order Traversal: \n\n");

            var executionTime = Stopwatch.StartNew();
            this._binaryTree.PostorderTraversal(this._binaryTree.Root, ref output);
            executionTime.Stop();

            richTextBoxOutput.Text = output.ToString();
            this.UpdateExecutionTimeLabel(executionTime.ElapsedMilliseconds);
        }
        // ======================================================================================

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (mergeSortCheck.Checked)
            {
                this.sortedArray = this._arrayList.MergeSort();
                string outputString = string.Join(", ", sortedArray.Select(x => x.Value.ToString()));
                richTextBoxOutput.Text = outputString;
            }
            else if (quickSortCheck.Checked)
            {
                InputType[] sortedArray = this._arrayList.QuickSort();
                string outputString = string.Join(", ", sortedArray.Select(x => x.Value.ToString()));
                richTextBoxOutput.Text = outputString;
            }
            else if (jumpSearchCheck.Checked)
            {
                try
                {
                    InputType inputType = new InputType(textBoxSearchText.Text);
                    int index = this._arrayList.JumpSearch(inputType);

                    if (index == -1)
                    {
                        richTextBoxOutput.Text = "Input not found.";
                    }
                    else
                    {
                        richTextBoxOutput.Text = $"Input '{textBoxSearchText.Text}' found at index {index}.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Select a type of searching algorithm");
            }
        }

        private void InsertInAllCollectionTypes(string input)
        {
            // Check if there is enough memory to continue (could not test function)
            if (!MemoryHandler.IsMemoryAvailable())
            {
                throw new InsufficientMemoryException("Aborting the rest of the values!");
            }

            try
            {
                InputType inputType = new(input);
                this._binaryTree.Add(inputType);
                this._arrayList.Add(inputType);
                this._linkedList.Add(inputType);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"Null values error: {ex.Message}");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this._binaryTree.Clear();
            this._arrayList.Clear();
            this._linkedList.Clear();
            richTextBoxOutput.Text = "";
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display warning message regarding big data submissions
            MessageBox.Show(
                "The application might crash upon submittion of a big collection of data!\n" +
                "If that happens, close the application and submit a smaller size file.",
                "Warning!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            // Ask for the file path
            FileDialog fileDialog = new OpenFileDialog()
            {
                Filter = "csv files (*.csv)|*.csv"
            };

            if (fileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                var executionTime = Stopwatch.StartNew();
                try
                {
                    string filePath = fileDialog.FileName;
                    string[] lines = File.ReadAllLines(filePath);

                    // Reading each line from the CSV file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            // Splitting the line by comma
                            string[] values = reader.ReadLine().Split(',');
                            foreach (string input in values)
                            {
                                if (!string.IsNullOrWhiteSpace(input))
                                {
                                    this.InsertInAllCollectionTypes(input);
                                }
                            }
                        }
                    }
                    MessageBox.Show("CSV file has been imported!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occured: {ex.Message}");
                }

                executionTime.Stop();
                this.UpdateExecutionTimeLabel(executionTime.ElapsedMilliseconds);
            }
            else
            {
                MessageBox.Show("No CSV file has been selected!");
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This is the Final Assignment for Data Structures and Algorithms at NHL Stenden University of Applied Scieces",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void textBoxSearchText_TextChanged(object sender, EventArgs e)
        {
            jumpSearchCheck.PerformClick();
        }

        private void buttonDisplayRaw_Click(object sender, EventArgs e)
        {
            StringBuilder defaultHeading = new("Unsorted ");

            if (comboBoxCollectionType.SelectedItem == null)
            {
                MessageBox.Show("Please select a collection type!");
                return;
            }

            if (comboBoxCollectionType.SelectedItem.ToString().Equals("BinarySearchTree"))
            {
                defaultHeading.Append("Binary Search Tree \n(is sorted so will display same as InOrderTraversal):\n");
                defaultHeading.Append(this._binaryTree.GetCollectionValues());
            }
            else if (comboBoxCollectionType.SelectedItem.ToString().Equals("LinkedList"))
            {
                defaultHeading.Append("LinkedList:\n");
                defaultHeading.Append(this._linkedList.GetCollectionValues());
            }
            else if (comboBoxCollectionType.SelectedItem.ToString().Equals("ArrayList"))
            {
                defaultHeading.Append("ArrayList:\n");
                defaultHeading.Append(this._arrayList.GetCollectionValues());
            }

            richTextBoxOutput.Text = defaultHeading.ToString();
        }
    }
}