using System.Xml.Linq;

namespace Dynamic_Queue
{
    public partial class Form1 : Form
    {
        private Queue<int> queue;
        public Form1()
        {
            InitializeComponent();
            queue = new Queue<int>();

        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int number))
            {
                queue.Enqueue(number);
                UpdateLabel();
                MessageBox.Show("Added element:  " + number);
                ShowElements();
            }
            else
            {
                MessageBox.Show("Invalid number .");
                return;
            }
        }



        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                int removedElement = queue.Dequeue();
                UpdateLabel();
                MessageBox.Show("Element removed: " + removedElement);
                ShowElements();
            }
            else
            {
                MessageBox.Show("Queue is empty");
                return;
            }
        }
        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                int frontElement = queue.Peek();
                MessageBox.Show("Element in front: " + frontElement);
            }
            else
            {
                MessageBox.Show("Queue is empty.");
                return;
            }
        }


        private void ShowElements()
        {
            if (queue.Count > 0)
            {
                string elementos = string.Join(", ", queue);
                MessageBox.Show("Elements in the queue: " + elementos);
            }
            else
            {
                MessageBox.Show("Queue is empty.");
                return;
            }

        }


        private void UpdateLabel()
        {
            lblCount.Text = "Elements in the queue: " + queue.Count;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                queue.Clear();
                UpdateLabel();
                MessageBox.Show("Elements in the queue removed.");
            }
            else
            {
                MessageBox.Show("Queue is empty");
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                int backElement = GetBackElement();
                MessageBox.Show("Element at the back: " + backElement);
            }
            else
            {
                MessageBox.Show("Queue is empty.");
                return;
            }
        }

        private int GetBackElement()
        {
            return queue.ToArray()[queue.Count - 1];
        }

    }
    
}
