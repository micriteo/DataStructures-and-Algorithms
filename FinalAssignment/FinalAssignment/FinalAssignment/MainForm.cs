using System;

namespace FinalAssignment
{
    public partial class MainForm : Form
    {
        private CustomBinaryTree<InputType> _binaryTree;
        private CustomLinkedList<InputType> _linkedList;
        private CustomArrayList<InputType> _arrayList;
        public MainForm()
        {
            this._arrayList = new CustomArrayList<InputType>();
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCollectionType.SelectedItem.ToString().Equals("BinaryTree"))
            {
                binarrySearchCheck.Enabled = true;
                // Disabling algorithms which are not supported by the collection
                insertSortCheck.Enabled = false;
                quickSortCheck.Enabled = false;
                jumpSearchCheck.Enabled = false;
                // Removing any checked items from those which are supposed to be disabled
                insertSortCheck.Checked = false;
                quickSortCheck.Checked = false;
                jumpSearchCheck.Checked = false;
            }
            else if (comboBoxCollectionType.SelectedItem.ToString().Equals("LinkedList"))
            {
                insertSortCheck.Enabled = true;
                quickSortCheck.Enabled = true;
                // jumpSearchCheck.Enabled = true;
                // Disabling algorithms which are not supported by the collection
                binarrySearchCheck.Enabled = false;
                // Removing any checked items from those which are supposed to be disabled
                binarrySearchCheck.Checked = false;
            }
            else if (comboBoxCollectionType.SelectedItem.ToString().Equals("ArrayList"))
            {
                jumpSearchCheck.Enabled = true;
                insertSortCheck.Enabled = true;
                quickSortCheck.Enabled = true;
                // Disabling algorithms which are not supported by the collection
                binarrySearchCheck.Enabled = false;
                // Removing any checked items from those which are supposed to be disabled
                binarrySearchCheck.Checked = false;
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            InputType input = new(textBoxInputText.Text);
            this._arrayList.Add(input);
            textBoxInputText.Text = "";
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            InputType[] sortedArray = this._arrayList.QuickSort();
            string outputString = string.Join(", ", sortedArray.Select(x => x.Value.ToString()));
            textBoxOutput.Text = outputString;
        }
    }
}