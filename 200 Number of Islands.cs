public class Solution {
    public int NumIslands(char[,] grid) {
        
        if(grid.GetLength(0)==0) return 0;
        
        int rows= grid.GetLength(0);
        int cols=grid.GetLength(1);
        //bool[,] visited= new bool[rows,cols];
        
        int count=0;
        
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<cols;j++)
            {
                if(grid[i,j]=='1')
                {
                    
                    DoDFS(grid,i,j);
                    count++;
                }
            }
        }
        return count;
    }//end grid
    
    public void DoDFS(char[,] grid,int i,int j)
    {
       if(i>=grid.GetLength(0)||i<0||j>=grid.GetLength(1)||j<0||grid[i,j]!='1') return ;
        
        grid[i,j]='x';
        
        
        DoDFS(grid,i+1,j);
        DoDFS(grid,i-1,j);
        DoDFS(grid,i,j+1);
        DoDFS(grid,i,j-1);
    }
}