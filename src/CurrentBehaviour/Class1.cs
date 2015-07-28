namespace CurrentBehaviour
{
    public class Class1
    {
        object myLock = new object();

        public Class1()
        {
            lock (myLock)
            {

            }
        }
    }
}
