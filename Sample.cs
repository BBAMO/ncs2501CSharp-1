using System.Xml.Serialization;

class Sample
{
    public void RandomSum()
    {
        int sum = 0;
        int[] nums = new int[10];

        Random rand = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next() % 100;
            Console.WriteLine("nums["+i+"]:" + nums[i]);
        }
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        Console.WriteLine(sum);
    }
}