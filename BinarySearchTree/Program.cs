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
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.add(0);
            testTree.add(10);
            testTree.add(5);
            testTree.add(3);


        }
    }
    class BinarySearchTree 
    {

        public treeNode rootNode;

        public treeNode getRoot(){ return this.rootNode; }
        public void add(int dataAdd) {
            treeNode currentNode = this.getRoot();
            treeNode node = new treeNode();
            node.setData(dataAdd);
            if( this.rootNode == null) {
                this.rootNode = node;
            }else{
   
                bool added = false;
                while (!added){
                    
                    if (node.getData() < currentNode.getData())
                    {
                        if (currentNode.getleftNode() != null)
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
                        if (currentNode.getrightNode() != null)
                        {
                            currentNode = currentNode.getrightNode();
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
        public treeNode leftNode;
        public treeNode rightNode;
        public int data;
     
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