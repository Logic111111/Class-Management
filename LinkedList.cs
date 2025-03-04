using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
     class LinkedList
    {
        
        public Node Head;

        public void Add(Color color)
        {
            Node newNode = new Node(color);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        public async Task BubbleSort(Panel panel)
        {
            if (Head == null) return;

            bool swapped;
            do
            {
                swapped = false;
                Node current = Head;

                while (current != null && current.Next != null)
                {
                    if (current.BlockColor.GetBrightness() > current.Next.BlockColor.GetBrightness())
                    {
                        SwapNodes(current, current.Next);
                        swapped = true;

                        // ✅ Update UI after each swap
                        UpdatePanelUI(panel);
                        await Task.Delay(500); // Slow down for animation
                    }
                    current = current.Next;
                }
            } while (swapped);
        }

        // ✅ Function to Update UI After Sorting
        private void UpdatePanelUI(Panel panel)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke((MethodInvoker)delegate
                {
                    UpdatePanelUI(panel);
                });
            }
            else
            {
                panel.Controls.Clear();
                Node temp = Head;
                int index = 0;

                while (temp != null)
                {
                    Label lbl = new Label
                    {
                        Width = 50,
                        Height = 50,
                        BackColor = temp.BlockColor,
                        Location = new Point(50 * index, 10),
                        AllowDrop = false
                    };

                    lbl.MouseDown += (s, e) => ((Label)s).DoDragDrop(s, DragDropEffects.Move);
                    panel.Controls.Add(lbl);
                    temp = temp.Next;
                    index++;
                }
            }
        }

        // ✅ Function to Swap Nodes
        private void SwapNodes(Node node1, Node node2)
        {
            var tempColor = node1.BlockColor;
            node1.BlockColor = node2.BlockColor;
            node2.BlockColor = tempColor;
        }





    }
}

