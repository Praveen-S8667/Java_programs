import java.util.*;
public class Rotate {
    public static void main(String args[]){
    Scanner sc=new Scanner(System.in);
    int rot=sc.nextInt();
    int n=sc.nextInt();
    int arr[]=new int[n];
    for(int i=0;i<n;i++)
    {
        arr[i]=sc.nextInt();
    }
    
    for(int i=0;i<rot;i++)
    {
        int last=arr[n-1];
        for(int j=n-1;j>0;j--)
        {
            arr[j]=arr[j-1];
        }
        arr[0]=last;
    }
    for(int i=0;i<n;i++)
    {
        System.out.print(arr[i]);
    } 
}
    
}
