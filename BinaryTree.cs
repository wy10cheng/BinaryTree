using System;
using System.Collections.Generic;


namespace BinaryTree
{
  class Node
  {
    public int value;
    public Node left;
    public Node right;
  }
  
  class Tree
  {
    public int level = 0;
    public List<List<int>> result;
    
    private int findHeight(Node root){
      
      int heightLeft = 0;
      int heightRight = 0;
      
      if (root.left != null) 
      {
        heightLeft = findHeight(root.left);
      }
      if (root.right != null) 
      {
        heightRight = findHeight(root.right);
      }
      
      if(heightLeft > heightRight){
        return heightLeft+1;
        
      }
      else
      {
        return heightRight+1;
        
      }
      
    }
    


    public List<int> findNodes(Node root, int depth, List<int> result)
    {
       if (depth == 0)
          result.Add(root.value);
       
       else
       {
         depth--;
         
         if (root.left != null)
          {
              findNodes(root.left, depth, result);
          }
         if (root.right != null)
          {
              findNodes(root.right, depth, result);
          }
       }
       
       return result;

    }
    
    public List<List<int>> GetResult (Node root)
    {
       int height = findHeight(root);
       
       List<List<int>> result = new List<List<int>>();
      
       for (int i=0; i< height; i++)
       {
         List<int> res = new List<int>();
         result.Add(findNodes(root, i, res))；
         
       }
       
       return result;
       
       
    }
    
    public static void Main(string[] args)
    {
      //Your code goes here
      Console.WriteLine(GetResult(3));

    }
    
    
  }
  
  
}