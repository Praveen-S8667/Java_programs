import java.util.*;
public class Count_sent_vow {
    //count the number of words and vowels....
    public static void main(String args[])
    {
        Scanner sc=new Scanner(System.in);
        String str=sc.nextLine();
        String arr[]=str.split(" ");
        int sent=0,count=0,tot=0;
        for(int i=0;i<arr.length;i++)
        {
            sent++;
        }
        System.out.println(sent);
        for(int i=0;i<arr.length;i++)
        {
            count=0;
            for(int j=0;j<arr[i].length();j++)
            {
                //count=0;
                char ch=arr[i].charAt(j);
                //System.out.println(ch);

                if(ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u')
                {
                    count++;

                }
                
            }
            System.out.println(count);
            tot+=count;
        }
        System.out.println(tot);


        
    }
    
}
