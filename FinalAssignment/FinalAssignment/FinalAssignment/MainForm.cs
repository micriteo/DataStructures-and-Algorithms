using System.Diagnostics;
using System.Text;

namespace FinalAssignment
{
    public partial class MainForm : Form
    {
        private CustomBinaryTree<InputType> _binaryTree;
        private CustomLinkedList<InputType> _linkedList;
        private CustomArrayList<InputType> _arrayList;
        private string _labelExecutionTime = "Execution Time: ";

        public MainForm()
        {

            this._binaryTree = new CustomBinaryTree<InputType>();
            this._linkedList = new CustomLinkedList<InputType>();
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
                // Display buttons for the collection
                buttonBTInOrder.Visible = true;
                buttonBTPreOrder.Visible = true;
                buttonBTPostOrder.Visible = true;
                buttonGenerate.Enabled = false;
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
                // Hide buttons for the collection
                buttonBTInOrder.Visible = false;
                buttonBTPreOrder.Visible = false;
                buttonBTPostOrder.Visible = false;
                buttonGenerate.Enabled = true;
            }
            else if (comboBoxCollectionType.SelectedItem.ToString().Equals("ArrayList"))
            {
                jumpSearchCheck.Enabled = true;
                insertSortCheck.Enabled = true;
                quickSortCheck.Enabled = true;
                // Disabling algorithms which are not supported by the collecstion
                binarrySearchCheck.Enabled = false;
                // Removing any checked items from those which are supposed to be disabled
                binarrySearchCheck.Checked = false;
                // Hide buttons for the collection
                buttonBTInOrder.Visible = false;
                buttonBTPreOrder.Visible = false;
                buttonBTPostOrder.Visible = false;
                buttonGenerate.Enabled = true;
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            InputType input = new(textBoxInputText.Text);
            this._binaryTree.Add(input);
            this._arrayList.Add(input);
           //this._arrayList.QuickSort();
            this._linkedList.Add(input);
            textBoxInputText.Text = "";
        }

        private void buttonGenerate_Click_1(object sender, EventArgs e)
        {
            if(quickSortCheck.Checked) 
            {
                InputType[] sortedArray = this._arrayList.QuickSort();
                string outputString = string.Join(", ", sortedArray.Select(x => x.Value.ToString()));
                textBoxOutput.Text = outputString;
            }
            else if(insertSortCheck.Checked)
            {
                InputType[] sortedArray = this._arrayList.InsertSort();
                string outputString = string.Join(", ", sortedArray.Select(x => x.Value.ToString()));
                textBoxOutput.Text = outputString;
            }
            
        }

        private void buttonBTInOrder_Click(object sender, EventArgs e)
        {
            StringBuilder output = new("In Order Traversal:\n");

            var executionTime = Stopwatch.StartNew();
            this._binaryTree.InorderTraversal(this._binaryTree.Root, ref output);
            executionTime.Stop();

            textBoxOutput.Text = output.ToString();
            labelExecutionTime.Text = $"{this._labelExecutionTime}{executionTime.ElapsedMilliseconds}";
        }

        private void buttonBTPreOrder_Click(object sender, EventArgs e)
        {
            StringBuilder output = new("Pre Order Traversal:\n");

            this._binaryTree.PreorderTraversal(this._binaryTree.Root, ref output);

            textBoxOutput.Text = output.ToString();
        }

        private void buttonBTPostOrder_Click(object sender, EventArgs e)
        {
            StringBuilder output = new("Post Order Traversal:\n");

            this._binaryTree.PostorderTraversal(this._binaryTree.Root, ref output);

            textBoxOutput.Text = output.ToString();
        }
    }
}