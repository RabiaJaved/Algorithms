/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        
        

        IList<IList<int>> result=new List<IList<int>>();
        
        if(root==null) return result;
        Queue<TreeNode> q= new Queue<TreeNode>();
        q.Enqueue(root);
        int curLevel;
        int level=0;
        
                while(q.Count!=0)
                {
                    curLevel=q.Count;
                    List<int> subList= new List<int>();
                    level++;
                    while(curLevel!=0)
                    {
                        TreeNode n=q.Dequeue();
                        subList.Add(n.val);
                        curLevel--;
                        if(n.left!=null) q.Enqueue(n.left);
                        if(n.right!=null)q.Enqueue(n.right);
                        
                    }
                    
                    if(level % 2 == 0)
                    {
                       subList.Reverse();
                       
                    }
                    result.Add(subList);
                }
        
        
        return result;
    }
}
        
        
