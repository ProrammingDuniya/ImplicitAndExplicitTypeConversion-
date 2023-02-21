using ConversionMagic;

internal class Program
{
    private static void Main(string[] args)
    {
        Email email = new("programmingduniya1@gmail.com");

        string strEmail = email;

        Email newEmail = (Email) "programmingduniya1@gmail.com";
    }
}