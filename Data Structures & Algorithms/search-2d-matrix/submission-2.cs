public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        for(var i = 0; i < matrix.Length ;i++){
            int low = 0;
            int high = matrix[i].Length - 1;

            if(target >= matrix[i][low] && target <= matrix[i][high]){
                while(low <= high){
                    int mid = (low + high) / 2;
                    if(matrix[i][mid] == target)
                        return true;
                    else if(matrix[i][mid] < target)    
                        low = mid + 1;
                    else 
                        high = mid - 1;
                }
            }            
        }
        return false;
    }
}
