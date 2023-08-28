using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class BinarySearchTree 
    {
        private treeNode rootNode = null;
        public void add(treeNode node) {
            if( rootNode == null) {
                rootNode = node;
            }
            else
            {
               treeNode currentNode = rootNode;
                bool added = false;
                while (!added){
                    
                    if (node.getData() < currentNode.getData())
                    {
                        if (currentNode.getleftNode() == null)
                        {
                            currentNode = currentNode.getleftNode();
                        }
                        else {
                            currentNode.setleftNode(node);
                            added = true;
                        }
                    }
                    else {
                        currentNode = currentNode.getrightNode();
                        if (currentNode.getrightNode() == null)
                        {
                            currentNode = currentNode.getleftNode();
                        }
                        else
                        {
                            currentNode.setrightNode(node);
                            added = true;
                        }
                    }

                }
                

            }
        }
    }
    class treeNode
    {
        private treeNode leftNode = null;
        private treeNode rightNode = null;
        private int data;
        public treeNode getleftNode() {
            return leftNode;
                }
        public void setleftNode(treeNode value) {
            leftNode = value;
        }
        public treeNode getrightNode()
        {
            return rightNode;
        }
        public void setrightNode(treeNode value)
        {
            rightNode = value;
        }
        public int getData()
        {
            return data;
        }
        public void setData(int value)
        {
            data = value;
        }
       
    }

}