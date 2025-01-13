class Sample
{
    void DataType()
    {
        bool b = true;

        short sh = -32768;
        int i = 2147483647;
        long l = 1234L;
        float f = 123.45F;
        double d1 = 123.45;
        double d2 = 123.45D;
        decimal d = 123.45M;

        char c = 'A';
        string s = "Hello";

        // == !=
        if (s[0] != 'e')
            b = true;
        else
            b = false;

        DateTime dt = new DateTime(2025, 1, 13, 10, 24, 00);

        // max, min
        int i2 = 0;

        //if (i2 > 2147483647) ;
        if (i2 > int.MaxValue) ;
    }
}