import java.util.*;
public class Prime {

    public static void main(String args[])
    {
        int begin,end;
        Scanner sc=new Scanner(System.in);
        begin= sc.nextInt();
        end= sc.nextInt();
        for(int i=begin;i<end;i++)
        {
            int flag=0;
            for(int j=2;j<i;j++)
            {
                if(i%j==0)
                {
                    flag=1;
                    break;
                }
            }
            if(flag==0)
            {
                System.out.println(i);
            }
        }


    }
    
}
