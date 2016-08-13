namespace t4tinytypes.sample.vs
{
    public class Loader
    {public void Load()
        {
            //Ensure we can create all the types:
            var tinyString = new TinyString("Hello");
            var tinyInt = new TinyInt(94);
            var tinyComparableInt = new TinyComparableInt(62);
            var tinyDouble = new TinyDouble(4.8);
            var tinyDecimal = new TinyDecimal(1.45m);
            var tinyChar = new TinyChar('m');
            var tinyBool = new TinyBool(true);
        }
    }
}
