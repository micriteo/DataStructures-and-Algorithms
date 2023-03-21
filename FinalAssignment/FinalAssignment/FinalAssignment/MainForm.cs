using System.Text;

namespace FinalAssignment
{
    public partial class MainForm : Form
    {
        private CustomBinaryTree<InputType> _binaryTree;
        private CustomLinkedList<InputType> _linkedList;
        private CustomArrayList<InputType> _arrayList;

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
                // Hide buttons for the collection
                buttonBTInOrder.Visible = false;
                buttonBTPreOrder.Visible = false;
                buttonBTPostOrder.Visible = false;
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            InputType input = new(textBoxInputText.Text);
            this._binaryTree.Add(input);
            this._arrayList.Add(input);
            this._linkedList.Add(input);
            textBoxInputText.Text = "";
        }

        private void buttonBTInOrder_Click(object sender, EventArgs e)
        {
            StringBuilder output = new("In Order Traversal:\n");

            _binaryTree.InorderTraversal(_binaryTree.Root, ref output);

            textBoxOutput.Text = output.ToString();
        }

        private void buttonBTPreOrder_Click(object sender, EventArgs e)
        {
            StringBuilder output = new("Pre Order Traversal:\n");

            _binaryTree.PreorderTraversal(_binaryTree.Root, ref output);

            textBoxOutput.Text = output.ToString();
        }

        private void buttonBTPostOrder_Click(object sender, EventArgs e)
        {
            StringBuilder output = new("Post Order Traversal:\n");

            _binaryTree.PostorderTraversal(_binaryTree.Root, ref output);

            textBoxOutput.Text = output.ToString();
        }
    }
}