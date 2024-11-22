class Member
{
    string Name
    { get; set; }
    public bool IsCoal
    { get; set; }

    public Member(string Name, bool IsCoal)
    {
        this.Name = Name;
        this.IsCoal = IsCoal;
    }
}
class Committee
{
    string name { get; set; }
    Member[] members { get; set; }
    public int count { get; set; }
    public Committee(string name, Member[] members, int count)
    {
        this.name = name;
        this.members = members;
        this.count = count;
    }

    public int Count(bool belong)
    {
        int sum = 0;
        for (int i = 0; i < members.Length; i++)
        {
            if (members[i].IsCoal == belong) { sum++; }
        }
        return sum;
    }
}
class Program
{
    public static void Main()
    {

    }

    public static int Amount(Committee[] arr, Member m)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (m.IsCoal)
            {
                if (arr[i].Count(true) + 1 > arr[i].Count(false) && arr[i].count + 1 < 16)
                {
                    sum++;
                }
            }
            else if (arr[i].Count(true) > arr[i].Count(false) + 1 && arr[i].count + 1 < 16)
            {
                sum++;
            }
        }
        return sum;
    }
}