public class Eliminate_number {
    public static void main(String args[]){
    String str="hi123hello";
    char arr[]=str.toCharArray();
    
    for(int i=0;i<str.length();i++)
    {
        //System.out.print(str.charAt(i));
        if((int)arr[i]>=49&&(int)arr[i]<=57)
        {
            System.out.print(arr[i]);
        }

    }
    }
}
    

