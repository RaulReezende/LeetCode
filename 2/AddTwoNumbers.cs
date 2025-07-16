namespace LeetCode._2;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class AddTwoNumbers
{

    public ListNode AddTwoNumbersM(ListNode l1, ListNode l2)
    {
        Console.WriteLine(Math.Floor(12.3) % 10);
        string s1 = string.Empty, s2 = string.Empty;
        ListNode current = l1;
        while (current != null)
        {
            s1 += current.val.ToString();

            current = current.next;
        }

        current = l2;
        while (current != null) 
        {
            s2 += current.val.ToString();
            current = current.next;
        }

        int s3 = Int32.Parse(s1) + Int32.Parse(s2);

        ListNode listNode = new(1);

        string s4 = s3.ToString().Reverse().ToString();
     
        Console.WriteLine(s1);

        return new ListNode();
    }
}
