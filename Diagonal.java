import java.util.*;
public class Diagonal {
    public static void main(String args[]){
        Scanner sc=new Scanner(System.in);
        int row=sc.nextInt();
        int col=sc.nextInt();
        int arr[][]=new int[row][col];
        int sum=0;
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                arr[i][j]=sc.nextInt();
            }
        }
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                if(arr[i]==arr[j])
                {
                    sum+=arr[i][j];
                }
                //sum+=arr[i][j];
            }
            //System.out.println(sum);
            
        }
        System.out.println(sum);
            
    
}
    
}
