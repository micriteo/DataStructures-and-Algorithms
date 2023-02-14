using System;
using System.Collections;

namespace DataStructures_LinkedList
{
    public class DoubleLinkedList <T> : IPrintable
    {
        private DoubleLinkedListNode<T> _headNode;

        public DoubleLinkedList()
        {
            this._headNode = null;
        }

        public void Add(T data)
        {
            if (this._headNode is null)
            {
                this._headNode = new DoubleLinkedListNode<T>(data);
            }
            else
            {
                DoubleLinkedListNode<T> currentNode = this._headNode;

                while (currentNode.NextNode is not null)
                {
                    currentNode = currentNode.NextNode;
                }

                currentNode.NextNode = new DoubleLinkedListNode<T>(data)
                {
                    PreviousNode = currentNode
                };
            }
        }

        public void Remove(int index)
        {
            checkIndex(index);

            DoubleLinkedListNode<T> currentNode = this._headNode;
            // DoubleLinkedListNode<T> currentNode = this._headNode.NextNode;

            // If the head node is the one to be removed
            if (index == 0)
            {
                // Cleaning the pointer of the next node to the previous node to null
                currentNode.NextNode.PreviousNode = null;
                this._headNode = currentNode.NextNode;
                return;
            }

            int currentIndex = 0;
            while (currentNode.NextNode is not null)
            {
                currentNode = currentNode.NextNode;
                currentIndex++;

                if (currentIndex == index)
                {
                    if (currentNode.PreviousNode is not null)
                    {
                        currentNode.PreviousNode.NextNode = currentNode.NextNode;
                    }
                    if (currentNode.NextNode is not null)
                    {
                        currentNode.NextNode.PreviousNode = currentNode.PreviousNode;
                    }
                    currentNode = null; // Is this needed?
                    break;
                }
            }
        }

        public T Get(int index)
        {
            checkIndex(index);

            DoubleLinkedListNode<T> currentNode = this._headNode;

            // If the element to be returned is the head node
            if (index == 0)
            {
                return currentNode.Value;
            }

            int currentIndex = 1;
            while (currentNode.NextNode is not null)
            {
                if (currentIndex == index)
                {
                    return currentNode.NextNode.Value;
                }

                currentNode = currentNode.NextNode;
            }

            // return currentNode.Value;
            throw new EntryPointNotFoundException();
        }

        public int Count
        {
            get
            {
                int count = 0;
                DoubleLinkedListNode<T> currentNode = this._headNode;

                if (currentNode is null)
                {
                    return count;
                }

                // The list has one element
                count++;
                while (currentNode.NextNode is not null)
                {
                    count++;
                    currentNode = currentNode.NextNode;
                }

                return count;
            }
        }

        public IEnumerable GetEnumerable()
        {
            DoubleLinkedListNode<T> currentNode = this._headNode;

            if (currentNode is null)
            {
                yield break;
            }
            else
            {
                yield return currentNode.Value;
            }

            while (currentNode.NextNode is not null)
            {
                currentNode = currentNode.NextNode;
                yield return currentNode.Value;
            }
        }

        private void checkIndex(int index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}